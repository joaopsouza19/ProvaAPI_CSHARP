using ServicoApi.Models;

namespace ServicoApi.Services
{
    public interface IUserService
    {
        bool ValidateUser(string email, string password);
        void CreateUser(User user);
        // Outros métodos de serviço, se houver
    }
}
