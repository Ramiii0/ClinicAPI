using ClinicAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicAPI.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<PatientModel> Patients { get; set; }
        public DbSet<VisitModel> Visits { get; set; }
        public DbSet<TreatmentsModel> Treatments { get; set; }
        public DbSet<InvestigationModel> Investigations { get; set; }
        public DbSet<RadiologyModel> Radiology { get; set; }
        public DbSet<DrugsModel> Drugs { get; set; }
        public DbSet<DrugCategoryModel> DrugCategories { get; set; }
        public DbSet<InvestigationType> InvestigationTypes { get; set; }
        public DbSet<RadioTypeCategory> RadioTypeCategory { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RadiologyModel>()
              .HasOne(i => i.Patient)
              .WithMany(p => p.Radiologies)
              .HasForeignKey(i => i.PatientId)
              .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<RadiologyModel>()
             .HasOne(i => i.Visit)
             .WithMany(p => p.Radiologies)
             .HasForeignKey(i => i.VisitId)
             .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<InvestigationModel>()
               .HasOne(i => i.Patient)
               .WithMany(p => p.Investigations)
               .HasForeignKey(i => i.PatientId)
               .OnDelete(DeleteBehavior.ClientSetNull);

            /*  modelBuilder.Entity<PatientModel>().Navigation(x => x.Visits).AutoInclude();
              modelBuilder.Entity<VisitModel>().Navigation(c => c.Treatments).AutoInclude();*/

       
           
            
          

        }
    }
}
