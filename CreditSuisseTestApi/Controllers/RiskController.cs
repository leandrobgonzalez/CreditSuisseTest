using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CreditSuisseTestService;
using CreditSuisseTestDomain.Entities;

namespace CreditSuisseTestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RiskController : ControllerBase
    {
        [HttpPost]
        [Route("Execute")]
        public IActionResult Execute([FromBody] Portfolio portfolio)
        {
            RiskService risk = new RiskService();
            var response = risk.CheckRisk(portfolio);
            return Ok(response);
        }
    }
}
