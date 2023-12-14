using System.Linq;
using System.Threading.Tasks;
using System;
using UserCRUD.Models.Calculations;
using UserCRUD.Models.Feedbacks;

namespace UserCRUD.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Feedback> InsertFeedbackAsync(Feedback feedback);
        IQueryable<Feedback> SelectAllFeedbacks();
        ValueTask<Feedback> SelectFeedbackByIdAsync(Guid feedbackId);
        ValueTask<Feedback> UpdateFeedbackAsync(Feedback feedback);
        ValueTask<Feedback> DeleteFeedbackAsync(Feedback feedback);
    }
}
