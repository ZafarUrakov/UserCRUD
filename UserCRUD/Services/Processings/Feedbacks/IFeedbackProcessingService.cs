using System;
using System.Linq;
using System.Threading.Tasks;
using UserCRUD.Models.Feedbacks;

namespace UserCRUD.Services.Processings.Feedbacks
{
    public interface IFeedbackProcessingService
    {
        ValueTask<Feedback> AddFeedbackAsync(string answer, Guid userId);
        IQueryable<Feedback> RetrieveAllFeedbacks();
    }
}
