namespace SingleResponsibility
{
  internal class User
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Street { get; set; }
    public string? City { get; set; }
    public string? UserName { get; set; }
    public string? Password { get; set; }

    public static void Login()
    {
      Console.WriteLine("Login successful");
    }
    public static void Logout()
    {
      Console.WriteLine("Logout successful");
    }
    public static void ChangeAddress()
    {
      Console.WriteLine("Logout successful");
    }
  }
}