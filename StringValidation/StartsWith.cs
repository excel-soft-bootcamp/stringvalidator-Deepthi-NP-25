using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidation
{
    public class StartsWith : IValidation
    {
        public bool Validate(string data)
        {
            if (data.StartsWith("ex"))
            {
                return false;
            }
            return true;
        }
    }
}

        