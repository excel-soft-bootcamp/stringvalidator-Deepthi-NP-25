using System;

namespace StringValidation
{
    class Program
    {
        public static void Main()
        {

            EmptyString emptyString = new EmptyString();
            StringValidator stringValidator1 = new StringValidator(emptyString);
            stringValidator1.CheckEmptyString(" ");

            StringLength stringLength = new StringLength();
            StringValidator stringValidator2 = new StringValidator(stringLength);
            stringValidator2.CheckLengthOfString("deepthi");

            StartsWith startsWith = new StartsWith();
            StringValidator stringValidator3 = new StringValidator(startsWith);
            stringValidator3.CheckStartsWithString("extra");
        }
    }
}
