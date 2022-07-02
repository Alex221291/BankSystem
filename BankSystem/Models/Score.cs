namespace BankSystem.Models;

public class Score
{
    public Guid Id { get; set; }
    
    public string Number { get; set; }
    public DateTime DateStart { get; set; }
    public DateTime DataFinish { get; set; }
    public double Balance { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }
}