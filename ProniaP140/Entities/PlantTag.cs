namespace ProniaP140.Entities
{
    public class PlantTag
    {
        public int Id { get; set; }
        public int PlantId { get; set; }
        public Plant Plant { get; set; } = null!;
        public int TagId { get; set; }
        public Tag Tag { get; set; } = null!;
        public override string ToString()
        {
            return Tag.Name;
        }
    }
}
