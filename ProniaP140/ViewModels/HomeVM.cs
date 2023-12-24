using ProniaP140.Entities;

namespace ProniaP140.ViewModels
{
    public class HomeVM
    {
        public int Test;
        public IEnumerable<Slider> Sliders { get; set; } = null!;
        public ICollection<Plant> Plants { get; set; } = null!;
        public ICollection<Plant> NewPlants { get; set; } = null!;
    }
}
