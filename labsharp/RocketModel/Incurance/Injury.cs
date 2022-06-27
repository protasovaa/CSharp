using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketModel
{
    class Injury : Insurance
    {
        public Injury(Action<string> Notification, float defaultX, float defaultY, List<Astronaut> astronauts, object astronautsLocker)
            : base(Notification, defaultX, defaultY, astronauts, astronautsLocker)
        {
            for (int i = 0; i < Disease.AllDisease.Length; i++)
                if (Disease.AllDisease[i].Contains("Есть травмы"))
                    HealDiseaseIndexes.Add(i);
        }
    }
}
