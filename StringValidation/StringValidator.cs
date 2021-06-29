using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidation
{
    public class StringValidator
    {
        IValidation ivalidation;

        public StringValidator(IValidation data)
        {
            this.ivalidation = data;
        }
        public void CheckEmptyString(string userEnteredString)
        {
            bool emptyStringResult = ivalidation.Validate(userEnteredString);
            Console.WriteLine("The entered string to check if it is empty is : " + emptyStringResult);
        }
        public void CheckLengthOfString(string userEnteredString)
        {
            bool lengthOfStringResult = ivalidation.Validate(userEnteredString);
            Console.WriteLine("The entered string to check the length is : " + lengthOfStringResult);
        }
        public void CheckStartsWithString(string userEnteredString)
        {
            bool startsWithStringResult = ivalidation.Validate(userEnteredString);
            Console.WriteLine("The entered string to check starts with is : " + startsWithStringResult);
        }
    }
}
