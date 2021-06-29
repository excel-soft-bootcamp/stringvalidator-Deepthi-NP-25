using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidation
{
    public class EmptyString : IValidation
    {
        public bool Validate(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return false;
            }
            return true;
        }
    }
}
