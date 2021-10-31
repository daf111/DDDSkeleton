using Company.src.Shared.Domain;
using Company.src.Shared.Domain.ValueObject;
using Company.src.VirtualWallet.CashesIn.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.src.VirtualWallet.CashesIn.Domain
{
    public class CashIn : Entity
    {
        public CashInName Name { get; private set; }

        protected CashIn()
        {
        }

        public CashIn(Guid id, string name) : this()
        {
            Id = new IdentityValueObject(id);
            Name = new CashInName(name);
        }

        public static CashIn Create(Guid id, string name)
        {
            return new CashIn(id, name);
        }
    }
}
