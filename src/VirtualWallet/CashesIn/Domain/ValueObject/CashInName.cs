using Company.src.Shared.Domain.Exception;
using Company.src.Shared.Domain.ValueObject;
using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.src.VirtualWallet.CashesIn.Domain.ValueObject
{
    public class CashInName : StringValueObject
    {
        public CashInName(string value) : base(value)
        {
            if (value == null || value == string.Empty)
            {
                throw new ArgumentDomainException("Name cannot be empty");
            }
        }

        public static Result<CashInName> Create(string value)
        {
            return Result.Success(new CashInName(value));
        }
    }
}
