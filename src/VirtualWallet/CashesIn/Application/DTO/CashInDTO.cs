using Company.src.VirtualWallet.CashesIn.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.src.VirtualWallet.CashesIn.Application.DTO
{
    public class CashInDTO
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public CashInDTO(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public static CashInDTO FromAggregate(CashIn cashIn)
        {
            return new CashInDTO(cashIn.Id, cashIn.Name.Value);
        }
    }
}
