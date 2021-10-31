using Company.src.Shared.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.src.VirtualWallet.CashesIn.Domain
{
    public interface ICashInRepository
    {
        public List<CashIn> GetAll();
        public CashIn Find(IdentityValueObject id);
        public void Create(CashIn cashIn);
    }
}
