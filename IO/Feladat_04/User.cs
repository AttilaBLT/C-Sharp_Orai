namespace Feladat_04;
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }

    public User()
    {
    }

    public User(string email, string password)
    {
        Email = email;
        Password = password;
    }

    public override string ToString()
    {
        return $"{Email} -> {Password}";
    }
}