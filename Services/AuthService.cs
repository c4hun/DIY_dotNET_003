namespace AuthApp.Services
{
    public class AuthService
    {
        private readonly IUserRepository _repository;

        public AuthService(IUserRepository repository)
        {
            _repository = repository;
        }

        public bool Login(string username, string password)
        {
            return _repository.ValidateCredentials(username, password);
        }
    }
}
