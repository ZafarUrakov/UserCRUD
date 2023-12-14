using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserCRUD.Models.Calculations;
using UserCRUD.Services.Orchestrations;

namespace UserCRUD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculationController : Controller
    {
        private readonly ICalculationOrchestrationService calculationOrchestrationService;

        public CalculationController(ICalculationOrchestrationService calculationOrchestrationService)
        {
            this.calculationOrchestrationService = calculationOrchestrationService;
        }

        [HttpPost]
        public async ValueTask<ActionResult<string>> GetFeedback(
            string userName, Calculation calculation)
        {
            var feedback = await this.calculationOrchestrationService
                .ManageAllFunctions(userName, calculation);

            return Ok(feedback);
        }
    }
}
