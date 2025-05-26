using System.ComponentModel.DataAnnotations;

namespace IndoorPlantsC_.Models;

public class Plant
{
    [Key]
    public int PlantId { get; set; }
    [StringLength(80)]
    public string CientificName { get; set; }
    [StringLength(80)]
    public string PopularName { get; set; }
    [StringLength(80)]
    public string Family { get; set; }
    public bool IsPoisonous { get; set; }
    public int WateringFrequency { get; set; }

}