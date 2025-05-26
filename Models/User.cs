using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IndoorPlantsC_.Models;

public class User
{
    [Key]
    public int UserId { get; set; }
    [StringLength(80)]
    public string Name { get; set; }
    [StringLength(80)]
    public string LastName { get; set; }
    [StringLength(80)]
    public DateTime BirthdayDate { get; set; }
    [StringLength(80)]
    public string ResidenceType { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    public double AvailableTime { get; set; }
    public int ExperiencELevel { get; set; }
    public ICollection<Plant> Plants { get; set; }

    public User()
    {
        Plants = new Collection<Plant>();
    }
}