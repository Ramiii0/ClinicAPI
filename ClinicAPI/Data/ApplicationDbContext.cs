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

            modelBuilder.Entity<PatientModel>().HasData( new PatientModel
       { Id=1,
       FirstName= "Mohammed",
      LastName= "Raid",
      Gender= "Male",
      Age=22,
      Residence= "Baghdad",
      Phone=123,
      Weight=70,
      Height= 180,
      Medical= "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer in elementum massa. Aliquam  r",
      Surgical= "Lorem ipsum   , consectetur adipiscing elit. Integer in elementum massa. Aliquam elementum risus vitae   . Sed eu  tellus, eget lacinia",
      Social="wfvbeuibwjebdjiwvbwjklvf",
            });
            modelBuilder.Entity<VisitModel>().HasData(new VisitModel 
            { Id = 1,  
            CC= "C.C details...",
            Title = "Visit 1",
            HPI= "HPI details",
            Examination= "exam details",
            PR= "PR details",
            
             PatientId = 1,






            });
           
            
          

        }
    }
}
