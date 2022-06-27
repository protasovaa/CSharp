using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketModel
{
    public class IntValidator : IStringValidator
    {
        public string ErrorMessage { get; private set; }

        public bool IsValid(string str)
        {
            int res;
            bool isDouble = Int32.TryParse(str, out res);

            if (!isDouble)
                ErrorMessage = "Введено не целое число";

            return isDouble;
        }
    }
}
