using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using UserCRUD.Models.Calculations;
using UserCRUD.Models.Feedbacks;

namespace UserCRUD.Models.Users
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        [JsonIgnore]
        public List<Calculation> Calculations { get; set; }
        [JsonIgnore]
        public List<Feedback> Feedbacks { get; set; }
    }
}
