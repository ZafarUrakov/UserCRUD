using System;
using System.Linq;
using System.Threading.Tasks;
using UserCRUD.Models.Users;
using UserCRUD.Models.Users.Exceptions;
using UserCRUD.Services.Foundations.Users;

namespace UserCRUD.Services.Processings.Users
{
    public class UserProcessingService : IUserProcessingService
    {
        private readonly IUserService userService;

        public UserProcessingService(IUserService userService)
        {
            this.userService = userService;
        }

        public User RetrieveUserByName(string userName)
        {
           var maybeUser = this.userService.RetrieveAllUsers()
                .FirstOrDefault(u => u.FirstName == userName);

            if(maybeUser is null)
                throw new UserNotFoundByNameException(userName);
            else
                return maybeUser;
        }

        public async ValueTask<User> AddUserAsync(User user) =>
            await this.userService.AddUserAsync(user);

        public async ValueTask<User> ModifyUserAsync(User user) =>
            await this.userService.ModifyUserAsync(user);

        public IQueryable<User> RetrieveAllUsers() =>
            this.userService.RetrieveAllUsers();

        public async ValueTask<User> RemoveUserAsync(Guid userId) =>
            await this.userService.RemoveUserAsync(userId);

        public async ValueTask<User> RetrieveUserByIdAsync(Guid userId) =>
            await this.userService.RetrieveUserByIdAsync(userId);
    }
}
