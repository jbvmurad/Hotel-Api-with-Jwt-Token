namespace PatikaTask.Services
{
    public interface IJwtService
    {
        string GenerateToken(string email);
        bool ValidateCredentials(string email, string password);
    }
}
