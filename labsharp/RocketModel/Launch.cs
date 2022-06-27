using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RocketModel
{

    public class Launch : Model
    {
        private readonly List<Astronaut> astronauts;
        private readonly object sportsmansLocker;

        List<Astronaut> participatingAstronauts;

        string Name { get; }

        int maxParticipatingAstronautsNumber;

        public Launch(Action<string> Notification, List<Astronaut> astronauts, object astronautsLocker,
            float x, float y, string name, int maxParticipatingSportmansNumber = 3)
            : base(Notification)
        {
            this.astronauts = astronauts;
            this.sportsmansLocker = astronautsLocker;
            X = x;
            Y = y;

            participatingAstronauts = new List<Astronaut>();

            Name = name;

            this.maxParticipatingAstronautsNumber = maxParticipatingSportmansNumber;
        }

        bool StartLaunch()
        {
            participatingAstronauts.Clear();

            lock (sportsmansLocker)
            {
                int participatingAstronautsNumber = 0;

                for (int i = 0; i < astronauts.Count && participatingAstronautsNumber < maxParticipatingAstronautsNumber; i++)
                {
                    if (!astronauts[i].IsLocked)
                    {
                        astronauts[i].ToX = X;
                        astronauts[i].ToY = Y;

                        astronauts[i].IsLocked = true;
                        participatingAstronauts.Add(astronauts[i]);

                        participatingAstronautsNumber++;
                    }
                }
            }

            return participatingAstronauts.Count != 0;
        }

        void WaitAllAstronauts()
        {
            bool allSportmansCame = false; ;

            while (!allSportmansCame)
            {
                Task.Delay(100).Wait();

                lock (sportsmansLocker)
                {
                    allSportmansCame = participatingAstronauts.FirstOrDefault(item =>
                    !item.IsCome()) == null;
                }
            }
        }

        void DoLaunch()
        {
            Notification($"В запуске {Name} примут участие {participatingAstronauts.Count} астронавтов");
            WaitAllAstronauts();

            Notification($"Запуск {Name} начинается");
            Notification($"Запуск {Name} благополучно прошел");
            Task.Delay(10 * 1000).Wait();
        }

        void PrintAstronaut(int place, Astronaut astronaut)
        {
            Notification($"{place} вышел в открытый космос {astronaut.LastName} {astronaut.FirstName}");
        }

        int getNextAstronaut(Random random, int participatingAstronautsNumber, List<int> space)
        {
            int result;

            do
            {
                result = random.Next(0, participatingAstronautsNumber);
            }
            while (space.Contains(result));

            return result;
        }

        List<int> DetermineSpace()
        {
            List<int> space = new List<int>();

            if (participatingAstronauts.Count == 0)
                return space;

            Notification($"Космонавт {Name} выходит в открытый космос");

            Random random = new Random();

            int firstSportsman = getNextAstronaut(random, participatingAstronauts.Count, space);
            space.Add(firstSportsman);

            PrintAstronaut(1, participatingAstronauts[firstSportsman]);

            if (participatingAstronauts.Count == 1)
                return space;

            int secondSportsman = getNextAstronaut(random, participatingAstronauts.Count, space);
            space.Add(secondSportsman);

            PrintAstronaut(2, participatingAstronauts[secondSportsman]);

            if (participatingAstronauts.Count == 2)
                return space;

            
            int thirdSportsman = getNextAstronaut(random, participatingAstronauts.Count, space);
            space.Add(thirdSportsman);

            PrintAstronaut(3, participatingAstronauts[thirdSportsman]);

            return space;
        }

        void WaitHeal(List<Astronaut> sickAstronauts)
        {
            bool allHeal = true;

            do
            {
                Task.Delay(100).Wait();

                allHeal = sickAstronauts.Count(astronaut => astronaut.IsIll) == 0;

            } while (!allHeal);
        }

        void PrintSickAstronauts(List<Astronaut> sickAstronauts)
        {
            string message = "";

            foreach (var item in sickAstronauts)
            {
                message += $"{item.LastName} {item.FirstName}: {Disease.AllDisease[item.DiseaseIndex]}\r\n";
            }

            Notification(message);
        }

        List<Astronaut> DetermineSickAstronauts(List<int> space)
        {
            List<Astronaut> sickAstronauts = new List<Astronaut>();

            Random random = new Random();

            for (int i = 0; i < participatingAstronauts.Count; i++)
                if (!space.Contains(i))
                {
                    participatingAstronauts[i].RandomSick(random);

                    if (participatingAstronauts[i].IsIll)
                        sickAstronauts.Add(participatingAstronauts[i]);
                    else
                        participatingAstronauts[i].IsLocked = false;
                }

            return sickAstronauts;
        }

        public void EndLaunch()
        {
            Notification($"Запуск {Name} закончилсь");

            List<int> space = DetermineSpace();

            Notification($"В космосе были {Name}");

            Task.Delay(5000).Wait();

            Notification($"Космонавты {Name} запуска вернулись домой");


            foreach (var item in space)
            {
                participatingAstronauts[item].IsLocked = false;
            }


            Random random = new Random();

            List<Astronaut> sickSportsmans = DetermineSickAstronauts(space);

            if (sickSportsmans.Count != 0)
            {
                Notification($"Во время полета {Name}космонавты получили травмы\n");

                PrintSickAstronauts(sickSportsmans);
                Notification($"Пока все космонавты не получат компенсацию, запуск {Name} не начнётся");
                WaitHeal(sickSportsmans);

                Notification($"Запуск {Name}: Все космонавты получили компенсацию!");
            }
        }

        public override void Start()
        {
            while (!IsCanceled)
            {
                Notification($"Скоро будет запуск {Name}");

                Task.Delay(3 * 1000).Wait();

                if (!StartLaunch())
                {
                    Notification($"Космонавты не пришли на участие в запуске {Name}, запуск отменяется");
                }
                else
                {
                    DoLaunch();

                    EndLaunch();   
                }

                Task.Delay(5 * 1000).Wait();
            }
        }
    }
}
