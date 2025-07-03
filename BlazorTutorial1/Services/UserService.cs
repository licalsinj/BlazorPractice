using BlazorTutorial1.Models;
using BlazorTutorial1.IServices;

namespace BlazorTutorial1.Services
{
    // New Service File under Model
    public class UserService : IServices.IUserService
    {
        private List<User> userList = new List<User>();
        public List<User> GetUsers()
        {
            return userList;
        }
        public void AddUser(User user)
        {
            userList.Add(user);
        }
        public User GetUserById(Guid id)
        {
            User? returnUser = userList.Where(u => u.UserId == id).FirstOrDefault();
            if (returnUser != null)
            {
                return returnUser;
            }
            return new User
            {
                UserId = Guid.Empty,
                FirstName = "",
                LastName = "",
                Email = "",
                IsBold = false,
                IsItal = false,
                IsStrk = false,
                IsUnln = false,
            };
        }
    }
}