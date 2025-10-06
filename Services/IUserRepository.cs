namespace AuthApp.Services
{
    public interface IUserRepository
    {
        bool ValidateCredentials(string username, string password);
    }
}
