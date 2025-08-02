namespace PatikaTask.DTOs.AuthDTOs
{
    public class LoginResponse
    {
        public string Token { get; set; }
        public DateTime ExpiresAt { get; set; }
        public string Message { get; set; }
    }
}
