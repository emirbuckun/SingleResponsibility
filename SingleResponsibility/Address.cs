namespace SingleResponsibility
{
  internal class Address // This class can be created for Single Res. Principle
  {
    public string? Street { get; set; }
    public string? City { get; set; }
    public static void ChangeAddress()
    {
      Console.WriteLine("Logout successful");
    }
  }
}