using Company.src.VirtualWallet.CashesIn.Application.DTO;
using Company.src.VirtualWallet.CashesIn.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.src.VirtualWallet.CashesIn.Application.SearchAll
{
    public interface ICashInSearcher
    {
        public CashesInDTO Search();
    }
}
