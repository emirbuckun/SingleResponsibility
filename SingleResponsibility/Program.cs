using SingleResponsibility;

internal class Program
{
  private static void Main(string[] args)
  {
    LoginService loginService = new();

    User user = new();
    loginService.Login(user);

    Guest guest = new();
    loginService.Login(guest);
  }
}