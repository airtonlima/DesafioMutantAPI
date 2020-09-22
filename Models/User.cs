
namespace DesafioMutant.API.Models
{
    public class User
    {
        public User()
        {

        }
        public User(int id, string username, string email)
        {
            this.Id = id;
            this.Username = username;
            this.Email = email;
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}
