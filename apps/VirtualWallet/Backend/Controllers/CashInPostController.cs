using Company.src.VirtualWallet.CashesIn.Application.Create;
using Company.src.VirtualWallet.CashesIn.Application.DTO;
using Company.src.VirtualWallet.CashesIn.Application.SearchAll;
using Company.src.VirtualWallet.CashesIn.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Company.Apps.VirtualWallet.Backend.Controllers
{
    [ApiController]
    [Route("cashin")]
    public class CashInPostController : ControllerBase
    {

        private readonly ILogger<CashesInGetController> _logger;
        private readonly ICashInCreator _service;

        public CashInPostController(ILogger<CashesInGetController> logger, ICashInCreator service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost]
        public ObjectResult Create(string name)
        {
            _service.Create(Guid.NewGuid(), name);
            //_service.Create(Guid.Parse("8A32FED9-7C1F-4C2B-83D9-21DBB8E4A3C7"), name);
            return Ok(new Dictionary<string, string>
            {
                {"message", "CashIn successffuly created"}
            });
        }
    }
}
