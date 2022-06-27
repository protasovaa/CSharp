using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketModel
{
    public class NotNegativeIntValidator : IStringValidator
    {
        IntValidator intValid = new IntValidator();

        public string ErrorMessage { get; private set; }

        public bool IsValid(string str)
        {
            bool isInt = intValid.IsValid(str);

            if (!isInt)
            {
                ErrorMessage = intValid.ErrorMessage;
                return false;
            }

            bool isValid = Int32.Parse(str) >= 0;

            if (!isValid)
                ErrorMessage = "Число меньше 0";

            return isValid;
        }
    }
}
