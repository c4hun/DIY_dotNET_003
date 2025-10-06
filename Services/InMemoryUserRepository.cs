using System.Collections.Generic;

namespace AuthApp.Services
{
    public class InMemoryUserRepository : IUserRepository
    {
        private readonly Dictionary<string, string> _users = new()
        {
            { "admin", "password" }
        };

        public bool ValidateCredentials(string username, string password)
        {
            return _users.TryGetValue(username, out var storedPassword)
                   && storedPassword == password;
        }
    }
}
