namespace IndoorPlantsC_.Models;

public class Plant
{
    public int PlantId { get; set; }
    public string CientificName { get; set; }
    public string PopularName { get; set; }
    public string Family { get; set; }
    public bool Ispoisonous { get; set; }
    public int WateringFrequency { get; set; }

}