using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.src.VirtualWallet.CashesIn.Application.DTO
{
    public class CashesInDTO : IEnumerable
    {
        public readonly IEnumerable<CashInDTO> _cashesIn;

        public CashesInDTO(IEnumerable<CashInDTO> cashesIn)
        {
            _cashesIn = cashesIn;
        }

        public IEnumerator GetEnumerator()
        {
            return _cashesIn.GetEnumerator();
        }
    }
}
