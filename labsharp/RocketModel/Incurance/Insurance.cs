using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketModel
{
    public abstract class Insurance : PersonModel, IIncurance
    {
        private readonly List<Astronaut> astronauts;
        private readonly object astronautsLocker;
        
        Astronaut sickAstronaut;

        public Insurance(Action<string> Notification, float defaultX, float defaultY, List<Astronaut> astronauts, object astronautsLocker)
            : base(Notification, defaultX, defaultY)
        {
            HealDiseaseIndexes = new List<int>();

            this.astronauts = astronauts;
            this.astronautsLocker = astronautsLocker;
        }

        public List<int> HealDiseaseIndexes { get; }

        void Heal()
        {
            if (IsCome())
            {
                Notification($"Страховая компания {LastName} выплачивает " +
                        $"{sickAstronaut.LastName} {sickAstronaut.FirstName}");

                Task.Delay(3 * 1000).Wait();

                sickAstronaut.IsIll = false;
                sickAstronaut.IsLocked = false;

                DoSomething = null;
                IsLocked = false;

                //return to 
                ToX = defaultX;
                ToY = defaultY;
            }
        }

        protected override void CheckEvents()
        {
            if (IsLocked)
                return;

            lock(astronautsLocker)
            {
                sickAstronaut = astronauts.FirstOrDefault(sportsman => sportsman.IsIll &&
                    HealDiseaseIndexes.Contains(sportsman.DiseaseIndex)
                    && !sportsman.WaitHeal);

                if (sickAstronaut != null)
                {
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
