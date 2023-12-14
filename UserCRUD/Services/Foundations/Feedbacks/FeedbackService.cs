using System;
using System.Linq;
using System.Threading.Tasks;
using UserCRUD.Brokers.Storages;
using UserCRUD.Models.Feedbacks;

namespace FeedbackCRUD.Services.Foundations.Feedbacks
{
    public class FeedbackService
    {
        private readonly IStorageBroker storageBroker;

        public FeedbackService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public async ValueTask<Feedback> AddFeedbackAsync(Feedback feedback) =>
            await this.storageBroker.InsertFeedbackAsync(feedback);

        public async ValueTask<Feedback> ModifyFeedbackAsync(Feedback feedback) =>
            await this.storageBroker.UpdateFeedbackAsync(feedback);

        public IQueryable<Feedback> RetrieveAllFeedbacks() =>
            this.storageBroker.SelectAllFeedbacks();

        public async ValueTask<Feedback> RemoveFeedbackAsync(Guid feedbackId)
        {
            var feedback = await this.storageBroker.SelectFeedbackByIdAsync(feedbackId);

            return await this.storageBroker.DeleteFeedbackAsync(feedback);
        }

        public async ValueTask<Feedback> RetrieveFeedbackByIdAsync(Guid feedbackId) =>
            await this.storageBroker.SelectFeedbackByIdAsync(feedbackId);
    }
}
