using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidation
{
    public interface IValidation
    {
        bool Validate(string data);
    }
}
