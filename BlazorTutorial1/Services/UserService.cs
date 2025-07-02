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
    }
}