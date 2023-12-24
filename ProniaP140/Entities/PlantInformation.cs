
namespace ProniaP140.Entities
{
    public class PlantInformation
    {
        public int Id { get; set; }
        public int PlantId { get; set; }
        public Plant Plant { get; set; } = null!;
        public int InformationId { get; set; }
        public Information Information { get; set; } = null!;
    }
}
