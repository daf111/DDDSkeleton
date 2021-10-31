using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.src.Shared.Domain.Exception
{
    public class ArgumentDomainException : ArgumentException
    {
        public ArgumentDomainException(string message) : base(message)
        {
        }
    }
}
