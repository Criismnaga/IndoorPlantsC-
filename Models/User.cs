namespace IndoorPlantsC_.Models;

public class User
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public DateTime BirthdayDate { get; set; }
    public string ResidenceType { get; set; }
    public double AvailableTime { get; set; }
    public int ExperiencELevel { get; set; }
}