using Company.src.Shared.Domain.ValueObject;
using Company.src.VirtualWallet.CashesIn.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.src.VirtualWallet.CashesIn.Infraestructure
{
    public class EFCashInRepository : ICashInRepository
    {
        public List<CashIn> GetAll()
        {
            var context = new CashInContext("Server=.\\SQLExpress;Database=VirtualWallet;Trusted_Connection=true;");
            return context.CashesIn.ToList();
        }
        public CashIn Find(IdentityValueObject id)
        {
            var context = new CashInContext("Server=.\\SQLExpress;Database=VirtualWallet;Trusted_Connection=true;");
            return context.CashesIn.Find(id);
        }
        public void Create(CashIn cashIn)
        {
            var context = new CashInContext("Server=.\\SQLExpress;Database=VirtualWallet;Trusted_Connection=true;");
            context.CashesIn.Add(cashIn);
            context.SaveChanges();
        }
    }
}
