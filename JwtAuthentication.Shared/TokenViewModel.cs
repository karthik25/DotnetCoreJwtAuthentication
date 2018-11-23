namespace JwtAuthentication.Shared
{
    public class TokenViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class TokenResponse
    {
        public string Token { get; set; }
    }
}
