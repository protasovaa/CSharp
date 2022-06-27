using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketModel
{
    public class Astronaut : PersonModel
    {
        public bool IsIll { get; internal set; }

        public int DiseaseIndex { get; internal set; }

        public Astronaut(Action<string> Notification, float defaultX, float defaultY)
            : base(Notification, defaultX, defaultY)
        {

        }

        public bool WaitHeal { get; internal set; }

        public void RandomSick(Random random)
        {   
            
            if (random.Next(0, 10) < 3)
            {
                DiseaseIndex = random.Next(0, Disease.AllDisease.Length);
                IsIll = true;
                WaitHeal = false;
            }
        }

        protected override void CheckEvents()
        {
            if (!IsLocked)
            {
                ToX = defaultX;
                ToY = defaultY;
            }
        }
    }
}
