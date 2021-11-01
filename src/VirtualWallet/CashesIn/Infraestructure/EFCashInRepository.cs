using Company.src.Shared.Domain.ValueObject;
using Company.src.VirtualWallet.CashesIn.Domain;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.src.VirtualWallet.CashesIn.Infraestructure
{
    public class EFCashInRepository : ICashInRepository
    {
        private readonly CashInContext _context;

        public EFCashInRepository(IConfiguration config)
        {
            _context = new CashInContext(config["ConnectionStrings:VirtualWalletDatabase"]);
        }
        public List<CashIn> GetAll()
        {
            return _context.CashesIn.ToList();
        }
        public CashIn Find(IdentityValueObject id)
        {
            return _context.CashesIn.Find(id);
        }
        public void Create(CashIn cashIn)
        {
            _context.CashesIn.Add(cashIn);
            _context.SaveChanges();
        }
    }
}
