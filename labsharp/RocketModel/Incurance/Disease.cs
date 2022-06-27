using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketModel
{
    // класс хранящий информацию о всех возможных болезнях
    public static class Disease
    {
        // я решил, что у меня будут врачи: кардиолог, невролог, травматолог
        // я не стал искать настоящие названия болезней, поэтому сделал так:
        static string[] _allDisease = new string[]
        {
            "Смерть экипажа",
            "Есть травмы",
            "Все живы",
        };

        public static string[] AllDisease { get => _allDisease; }
    }
}
