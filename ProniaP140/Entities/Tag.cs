namespace ProniaP140.Entities
{
    public class Tag
    {

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<PlantTag> PlantTags { get; set; }
    }
}
