using Company.src.Shared.Domain.ValueObject;
using Company.src.VirtualWallet.CashesIn.Application.DTO;
using Company.src.VirtualWallet.CashesIn.Domain;
using Company.src.VirtualWallet.CashesIn.Domain.Exception;
using Company.src.VirtualWallet.CashesIn.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.src.VirtualWallet.CashesIn.Application.Create
{
    public class CashInCreator : ICashInCreator
    {
        private readonly ICashInRepository _repository;

        public CashInCreator(ICashInRepository repository)
        {
            _repository = repository;
        }

        public void Create(Guid id, string name)
        {
            CashIn cashIn = CashIn.Create(id, name);
            ensureCashInNotExists(cashIn);
            _repository.Create(cashIn);
        }

        private void ensureCashInNotExists(CashIn cashIn)
        {
            CashIn _cashIn = _repository.Find(cashIn.Id);
            if (_cashIn != null)
            {
                throw new CashInExistsException("CashIn with Id " + cashIn.Id.Value + " already exists");
            }
        }
    }
}
