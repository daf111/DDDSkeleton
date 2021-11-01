using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.src.VirtualWallet.CashesIn.Domain;
using Company.src.VirtualWallet.CashesIn.Application.Create;
using Xunit;
using Company.src.Shared.Domain.ValueObject;
using Company.src.VirtualWallet.CashesIn.Domain.Exception;

namespace Company.test.src.VirtualWallet.CashesIn.Application.Create
{
    public class CashInCreatorShould
    {
        protected readonly Mock<ICashInRepository> _repository;
        protected readonly ICashInCreator _service;

        public CashInCreatorShould()
        {
            _repository = new Mock<ICashInRepository>();
            _service = new CashInCreator(_repository.Object);
        }

        [Fact]
        public void it_should_create_a_non_existing_cashin()
        {
            CashIn cashIn = new CashIn(Guid.NewGuid(), "Test");
            ShouldSearch(cashIn.Id, null);

            _service.Create(cashIn.Id.Value, cashIn.Name.Value);            
            ShouldCreate(cashIn);
        }

        [Fact]
        public void it_should_not_create_an_existing_cashin()
        {
            CashIn cashIn = new CashIn(Guid.NewGuid(), "Test");
            ShouldSearch(cashIn.Id, cashIn);

            Assert.Throws<CashInExistsException>(() => _service.Create(cashIn.Id.Value, cashIn.Name.Value));            
        }

        private void ShouldSearch(IdentityValueObject id, CashIn? cashIn)
        {
            _repository.Setup(x => x.Find(id)).Returns(cashIn);
        }
        
        private void ShouldCreate(CashIn cashIn)
        {
            _repository.Verify(x => x.Create(cashIn), Times.Once());
        }
    }
}
