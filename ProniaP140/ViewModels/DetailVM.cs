using ProniaP140.Entities;

namespace ProniaP140.ViewModels
{
    public class DetailVM
    {
        public Plant  Plant{ get; set; }
        public List<Plant> RelatedPlants { get; set; }
    }
}
