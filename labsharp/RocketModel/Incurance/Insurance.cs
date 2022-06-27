using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketModel
{
    // в этом классе опредлется общее для всех докторов - идти лечит
    public abstract class Insurance : PersonModel, IIncurance
    {
        // список космонавтов, которые просматриваем и локер для него
        private readonly List<Astronaut> astronauts;
        private readonly object astronautsLocker;

        // ссылка на пострадавших
        Astronaut sickAstronaut;

        public Insurance(Action<string> Notification, float defaultX, float defaultY, List<Astronaut> astronauts, object astronautsLocker)
            : base(Notification, defaultX, defaultY)
        {
            HealDiseaseIndexes = new List<int>();

            this.astronauts = astronauts;
            this.astronautsLocker = astronautsLocker;
        }

        // нужный список аварий
        public List<int> HealDiseaseIndexes { get; }

        // выплата
        // проверят дошёл до цели
        void Heal()
        {
            if (IsCome())
            {
                Notification($"Страховая компания {LastName} выплачивает " +
                        $"{sickAstronaut.LastName} {sickAstronaut.FirstName}");

                Task.Delay(3 * 1000).Wait();

                sickAstronaut.IsIll = false;
                sickAstronaut.IsLocked = false;

                //страховая ничего не делает
                DoSomething = null;
                IsLocked = false;

                //return to 
                ToX = defaultX;
                ToY = defaultY;
            }
        }

        // провекрка
        protected override void CheckEvents()
        {
            if (IsLocked)
                return;

            lock(astronautsLocker)
            {
                // если была авария и индекс аварии такой же
                sickAstronaut = astronauts.FirstOrDefault(sportsman => sportsman.IsIll &&
                    HealDiseaseIndexes.Contains(sportsman.DiseaseIndex)
                    && !sportsman.WaitHeal);

                if (sickAstronaut != null)
                {
                    // сразу пометим, что он ждёт выплату, чтобы другие страховые компании не участововали 
                    sickAstronaut.WaitHeal = true;
                    ToX = sickAstronaut.X;
                    ToY = sickAstronaut.Y;

                    IsLocked = true;
                    DoSomething = Heal;

                    Notification($"Страховая компания {LastName} выплатила " +
                        $"{sickAstronaut.LastName} {sickAstronaut.FirstName}");
                }
            }
        }
    }
}
