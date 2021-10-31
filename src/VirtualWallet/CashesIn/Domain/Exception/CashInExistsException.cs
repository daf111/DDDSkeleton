using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.src.VirtualWallet.CashesIn.Domain.Exception
{
    public class CashInExistsException : SystemException
    {
        public CashInExistsException(string message) : base(message)
        {
        }
    }
}
