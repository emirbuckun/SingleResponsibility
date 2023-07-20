namespace SingleResponsibility
{
  internal class LoginService // This class can be created for Single Res. Principle
  {
    // private Connection _connection { get; set; } // Connection functions may needed, new class should be added
    public void Login()
    {
      // Params initialized
      // _connection.GetConnection(params);
      Console.WriteLine("Login successful");
    }
    public void Login(User user)
    {
      if (user is null) throw new ArgumentNullException(nameof(user));

      Login(user.Name, user.Password);
      Console.WriteLine("Login successful");
    }
    public void Login(Guest guest)
    {
      if (guest is null) throw new ArgumentNullException(nameof(guest));
      Login(guest.Name, guest.Password);
      Console.WriteLine("Login successful");
    }
    public void Logout()
    {
      Console.WriteLine("Logout successful");
    }
    private void CreateConnection()
    {
      Console.WriteLine("CreateConnection()");
    }
    private void Login(string? name, string? password)
    {
      Console.WriteLine($"{name} successfully logged in!");
    }
  }
}