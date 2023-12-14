using System;
using System.Text.Json.Serialization;
using UserCRUD.Models.Users;

namespace UserCRUD.Models.Feedbacks
{
    public class Feedback
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public string Answer { get; set; }

        public Guid UserId { get; set; }
        [JsonIgnore]
        public User User { get; set; }
    }
}
