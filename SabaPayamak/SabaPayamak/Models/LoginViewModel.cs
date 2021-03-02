namespace SabaPayamak.Models
{
    public class LoginViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string VirtualNumber { get; set; }
        public int TokenValidDay { get; set; } = 1;
    }
}
