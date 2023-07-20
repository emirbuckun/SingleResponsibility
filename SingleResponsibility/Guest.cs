namespace SingleResponsibility
{
  internal class Guest
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Password { get; set; }

    // Login - logout operation may needed
    // It's not correct for single responsibility principle
  }
}