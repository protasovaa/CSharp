using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketModel
{
    public class WordValidator : IStringValidator
    {
        public string ErrorMessage { get; private set; }

        public bool IsValid(string word)
        {
            if (word == "")
            {
                ErrorMessage = "Ввод пустой";
                return false;
            }


            foreach (char c in word)
                if (!Char.IsLetter(c))
                {
                    ErrorMessage = "Введены не только буквы";
                    return false;
                }

            return true;
        }
    }
}
