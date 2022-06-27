using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketModel
{
    public static class Disease
    {
        static string[] _allDisease = new string[]
        {
            "Смерть экипажа",
            "Есть травмы",
            "Все живы",
        };

        public static string[] AllDisease { get => _allDisease; }
    }
}
