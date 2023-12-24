namespace ProniaP140.Entities
{

    public class PlantCategory
    {
        public int Id { get; set; }
        public int PlantId { get; set; }
        public Plant Plant { get; set; } = null!;
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public override string ToString()
        {
            return Category.Name;
        }

    }
}
