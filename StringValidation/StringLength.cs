using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidation
{
    public class StringLength : IValidation
    {
        public bool Validate(string data)
        {
            int length = data.Length;

            if (length > 8)
            {
                return false;
            }
            return true;
        }
    }
}
