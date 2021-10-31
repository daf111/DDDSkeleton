using Company.src.VirtualWallet.CashesIn.Application.DTO;
using Company.src.VirtualWallet.CashesIn.Domain;
using Company.src.VirtualWallet.CashesIn.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.src.VirtualWallet.CashesIn.Application.SearchAll
{
    public class CashInSearcher : ICashInSearcher
    {
        private readonly ICashInRepository _repository;

        public CashInSearcher(ICashInRepository repository)
        {
            _repository = repository;
        }

        public CashesInDTO Search()
        {
            return new CashesInDTO(
                (_repository.GetAll()).Select(CashInDTO.FromAggregate));
        }

    }
}
