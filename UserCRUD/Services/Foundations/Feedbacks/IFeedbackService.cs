using System.Linq;
using System.Threading.Tasks;
using System;
using UserCRUD.Models.Feedbacks;

namespace FeedbackCRUD.Services.Foundations.Feedbacks
{
    public interface IFeedbackService
    {
        ValueTask<Feedback> AddFeedbackAsync(Feedback feedback);
        IQueryable<Feedback> RetrieveAllFeedbacks();
    }
}
