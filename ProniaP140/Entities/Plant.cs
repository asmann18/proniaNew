namespace ProniaP140.Entities
{
    public class Plant
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string SKU { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public ICollection<PlantTag> PlantTags { get; set; }
        public ICollection<PlantCategory> PlantCategories { get; set; }
        public ICollection<PlantInformation> PlantInformations{ get; set; }
        public ICollection<PlantImage> PlantImages{ get; set; }


    }
}
