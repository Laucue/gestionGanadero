using Microsoft.EntityFrameworkCore;
using Model;

namespace Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    // Constructor sin parámetros para las clases Log
    public DataContext() : base()
    {
    }

    // Configuración de inyección de dependencias entre capas Data y Logic
    // Entidades del sistema ganadero
    public DbSet<AnimalsEntity> Animals { get; set; }
    public DbSet<PastureTypesEntity> Species { get; set; }
    public DbSet<BreedsEntity> Breeds { get; set; }
    public DbSet<LocationsEntity> Locations { get; set; }
    public DbSet<HealthRecordsEntity> HealthRecords { get; set; }
    public DbSet<VaccinesEntity> Vaccines { get; set; }
    public DbSet<BreedingRecordsEntity> ReproductionRecords { get; set; }
    public DbSet<SalesEntity> Sales { get; set; }
    public DbSet<FeedingPlansEntity> FeedingPlans { get; set; }
    public DbSet<DietsEntity> Diets { get; set; }
    public DbSet<DietItemsEntity> DietItems { get; set; }
    public DbSet<FeedingSchedulesEntity> FeedingSchedules { get; set; }
    public DbSet<UsersEntity> Users { get; set; }
    public DbSet<RolesEntity> Roles { get; set; }
    public DbSet<ActivityLogEntity> AuditLogs { get; set; }
    // Nuevas entidades añadidas para completar los 17 dominios
    public DbSet<BuyersEntity> Buyers { get; set; }
    public DbSet<TreatmentsEntity> Treatments { get; set; }
    public DbSet<DiseasesEntity> Diseases { get; set; }
    public DbSet<MedicalCheckupsEntity> MedicalCheckups { get; set; }
    public DbSet<BirthsEntity> Births { get; set; }
    public DbSet<SaleDetailsEntity> SaleDetails { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configuraciones de relaciones
        modelBuilder.Entity<AnimalsEntity>()
            .HasOne(a => a.Species)
            .WithMany(s => s.Animals)
            .HasForeignKey(a => a.IdSpecies);

        modelBuilder.Entity<AnimalsEntity>()
            .HasOne(a => a.Breed)
            .WithMany(b => b.Animals)
            .HasForeignKey(a => a.IdBreed);

        modelBuilder.Entity<AnimalsEntity>()
            .HasOne(a => a.Location)
            .WithMany(l => l.Animals)
            .HasForeignKey(a => a.IdLocation);

        // Configurar relaciones padre-hijo
        modelBuilder.Entity<AnimalsEntity>()
            .HasOne(a => a.Father)
            .WithMany(a => a.FatherChildren)
            .HasForeignKey(a => a.IdFather)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<AnimalsEntity>()
            .HasOne(a => a.Mother)
            .WithMany(a => a.MotherChildren)
            .HasForeignKey(a => a.IdMother)
            .OnDelete(DeleteBehavior.Restrict);

        // Configurar otras relaciones
        modelBuilder.Entity<HealthRecordsEntity>()
            .HasOne(h => h.Animal)
            .WithMany(a => a.HealthRecords)
            .HasForeignKey(h => h.IdAnimal);

        modelBuilder.Entity<HealthRecordsEntity>()
            .HasOne(h => h.Vaccine)
            .WithMany(v => v.HealthRecords)
            .HasForeignKey(h => h.IdVaccine);

        modelBuilder.Entity<BreedingRecordsEntity>()
            .HasOne(r => r.Animal)
            .WithMany(a => a.ReproductionRecords)
            .HasForeignKey(r => r.IdAnimal);

        modelBuilder.Entity<BreedingRecordsEntity>()
            .HasOne(r => r.Partner)
            .WithMany()
            .HasForeignKey(r => r.IdPartner);

        modelBuilder.Entity<SalesEntity>()
            .HasOne(s => s.Animal)
            .WithMany(a => a.Sales)
            .HasForeignKey(s => s.IdAnimal);

        modelBuilder.Entity<FeedingSchedulesEntity>()
            .HasOne(f => f.Animal)
            .WithMany(a => a.FeedingSchedules)
            .HasForeignKey(f => f.IdAnimal);

        modelBuilder.Entity<FeedingSchedulesEntity>()
            .HasOne(f => f.Species)
            .WithMany()
            .HasForeignKey(f => f.IdSpecies);

        modelBuilder.Entity<FeedingSchedulesEntity>()
            .HasOne(f => f.Diet)
            .WithMany(d => d.FeedingSchedules)
            .HasForeignKey(f => f.IdDiet);

        modelBuilder.Entity<DietsEntity>()
            .HasOne(d => d.FeedingPlan)
            .WithMany(f => f.Diets)
            .HasForeignKey(d => d.IdPlan);

        modelBuilder.Entity<DietItemsEntity>()
            .HasOne(di => di.Diet)
            .WithMany(d => d.DietItems)
            .HasForeignKey(di => di.IdDiet);

        modelBuilder.Entity<UsersEntity>()
            .HasOne(u => u.Role)
            .WithMany(r => r.Users)
            .HasForeignKey(u => u.IdRole);

        modelBuilder.Entity<ActivityLogEntity>()
            .HasOne(a => a.User)
            .WithMany(u => u.AuditLogs)
            .HasForeignKey(a => a.IdUser);

        // Configuración de nombres de tablas
        modelBuilder.Entity<AnimalsEntity>().ToTable("Animals");
        modelBuilder.Entity<PastureTypesEntity>().ToTable("Species");
        modelBuilder.Entity<BreedsEntity>().ToTable("Breeds");
        modelBuilder.Entity<LocationsEntity>().ToTable("Locations");
        modelBuilder.Entity<HealthRecordsEntity>().ToTable("HealthRecords");
        modelBuilder.Entity<VaccinesEntity>().ToTable("Vaccines");
        modelBuilder.Entity<BreedingRecordsEntity>().ToTable("ReproductionRecords");
        modelBuilder.Entity<SalesEntity>().ToTable("Sales");
        modelBuilder.Entity<FeedingPlansEntity>().ToTable("FeedingPlans");
        modelBuilder.Entity<DietsEntity>().ToTable("Diets");
        modelBuilder.Entity<DietItemsEntity>().ToTable("DietItems");
        modelBuilder.Entity<FeedingSchedulesEntity>().ToTable("FeedingSchedules");
        modelBuilder.Entity<UsersEntity>().ToTable("Users");
        modelBuilder.Entity<RolesEntity>().ToTable("Roles");
        modelBuilder.Entity<ActivityLogEntity>().ToTable("AuditLogs");
        // Mappings para nuevas tablas (placeholders)
        modelBuilder.Entity<BuyersEntity>().ToTable("Buyers");
        modelBuilder.Entity<TreatmentsEntity>().ToTable("Treatments");
        modelBuilder.Entity<DiseasesEntity>().ToTable("Diseases");
        modelBuilder.Entity<MedicalCheckupsEntity>().ToTable("MedicalCheckups");
        modelBuilder.Entity<BirthsEntity>().ToTable("Births");
        modelBuilder.Entity<SaleDetailsEntity>().ToTable("SaleDetails");
    }

    // 🔹 Configuración adicional para permitir conexión sin inyección de dependencias
    //    (solo se ejecuta si el contexto no viene configurado desde fuera)
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql(
                "server=127.0.0.1;user=root;password=1234;port=3306;database=ganaderia_db",
                new MySqlServerVersion(new Version(8, 0, 34))
            );
        }
    }
}
