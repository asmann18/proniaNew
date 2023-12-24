using Microsoft.EntityFrameworkCore;
using ProniaP140.Entities;

namespace ProniaP140.DAL;

public class ProniaDbContext:DbContext
{
    public ProniaDbContext(DbContextOptions<ProniaDbContext> opt):base(opt)
    {
        
    }
    public DbSet<Plant> Plants { get; set; }
    public DbSet<Category> Categories  { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Information> Informations { get; set; }
    public DbSet<PlantImage> PlantImages{ get; set; }
    public DbSet<PlantCategory> PlantCategories { get; set; }
    public DbSet<PlantTag> PlantTags { get; set; }
    public DbSet<PlantInformation> PlantInformations { get; set; }
    public DbSet<Slider> Sliders { get; set; }
}
