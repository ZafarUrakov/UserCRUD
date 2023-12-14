using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserCRUD.Models.Feedbacks;
using UserCRUD.Services.Processings.Feedbacks;

namespace UserCRUD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeedbackController : Controller
    {
        private readonly IFeedbackProcessingService feedbackProcessingService;

        public FeedbackController(IFeedbackProcessingService feedbackProcessingService)
        {
            this.feedbackProcessingService = feedbackProcessingService;
        }

        [HttpGet]
        public ActionResult<IQueryable<Feedback>> GetFeedbacks()
        {
            var feedbacks = this.feedbackProcessingService.RetrieveAllFeedbacks();

            return Ok(feedbacks);
        }
    }
}
