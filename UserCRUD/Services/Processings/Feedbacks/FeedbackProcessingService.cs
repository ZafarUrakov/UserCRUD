using System;
using System.Linq;
using System.Threading.Tasks;
using FeedbackCRUD.Services.Foundations.Feedbacks;
using UserCRUD.Brokers.Storages;
using UserCRUD.Models.Feedbacks;
using UserCRUD.Models.Users;

namespace UserCRUD.Services.Processings.Feedbacks
{
    public class FeedbackProcessingService : IFeedbackProcessingService
    {
        private readonly IFeedbackService feedbackService;

        public FeedbackProcessingService(IFeedbackService feedbackService)
        {
            this.feedbackService = feedbackService;
        }

        public async ValueTask<Feedback> AddFeedbackAsync(string answer, Guid userId)
        {
            var feedback = new Feedback
            {
                Id = Guid.NewGuid(),
                Answer = answer,
                UserId = userId
            };

            return await this.feedbackService.AddFeedbackAsync(feedback);
        }

        public IQueryable<Feedback> RetrieveAllFeedbacks() =>
            this.feedbackService.RetrieveAllFeedbacks();
    }
}
