using BlazorTutorial1.Models;

namespace BlazorTutorial1.IServices
{
	public interface IUserService
	{
		// Add your Service's methods here 
		List<User> GetUsers();
		void AddUser(User user);

		User? GetUserById(Guid id);

	}
}