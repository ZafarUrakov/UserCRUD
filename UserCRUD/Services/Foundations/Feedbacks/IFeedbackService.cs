using System.Linq;
using System.Threading.Tasks;
using System;
using UserCRUD.Models.Feedbacks;

namespace FeedbackCRUD.Services.Foundations.Feedbacks
{
    public interface IFeedbackService
    {
        ValueTask<Feedback> AddFeedbackAsync(Feedback feedback);
        ValueTask<Feedback> RetrieveFeedbackByIdAsync(Guid feedbackId);
        IQueryable<Feedback> RetrieveAllFeedbacks();
        ValueTask<Feedback> ModifyFeedbackAsync(Feedback feedback);
        ValueTask<Feedback> RemoveFeedbackAsync(Guid feedbackId);
    }
}
