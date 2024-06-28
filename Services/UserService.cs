using System.Linq;
using ServicoApi.Models;
using ServicoApi.Data;

namespace ServicoApi.Services
{
    public class UserService : IUserService
    {
        private readonly ServicoContext _context;

        public UserService(ServicoContext context)
        {
            _context = context;
        }

        public bool ValidateUser(string email, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            return user != null;
        }

        public void CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}