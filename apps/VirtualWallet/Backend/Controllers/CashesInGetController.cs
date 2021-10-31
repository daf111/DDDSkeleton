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
    public class CashesInGetController : ControllerBase
    {

        private readonly ILogger<CashesInGetController> _logger;
        private readonly ICashInSearcher _service;

        public CashesInGetController(ILogger<CashesInGetController> logger, ICashInSearcher service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public CashesInDTO Get()
        {
            return _service.Search();
        }
    }
}
