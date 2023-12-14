using System;
using System.Linq;
using System.Threading.Tasks;
using UserCRUD.Brokers.Storages;
using UserCRUD.Models.Feedbacks;

namespace FeedbackCRUD.Services.Foundations.Feedbacks
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IStorageBroker storageBroker;

        public FeedbackService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public async ValueTask<Feedback> AddFeedbackAsync(Feedback feedback) =>
            await this.storageBroker.InsertFeedbackAsync(feedback);

        public IQueryable<Feedback> RetrieveAllFeedbacks() =>
            this.storageBroker.SelectAllFeedbacks();
    }
}
