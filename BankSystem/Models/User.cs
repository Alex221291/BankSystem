namespace BankSystem.Models;

public class User
{
    public Guid Id { get; set; }
    
    public string FirstName { get; set; }
    public string SurName { get; set; }
    public string LastName { get; set; }
    public DateTime Birthday { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string PhoneNumber { get; set; }

    public List<Score> Scores { get; set; }
}