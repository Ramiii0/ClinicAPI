using System.Text.Json.Serialization;

namespace ClinicAPI.Models
{
    public class PatientModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Age { get; set; }
        public string? Gender { get; set; }
        public string? Residence { get; set; }
        public int? Phone {  get; set; }    
        public int? Weight { get; set; }
         public int Height { get; set; }
        public string? Medical { get; set; }
        public string? Surgical { get; set; }
        public string?  Social { get; set; }
        public string? Photo { get; set; }
       
        public List<VisitModel> Visits { get; set; }
       
        public List<TreatmentsModel> Treatments { get; set; }
        public List<InvestigationModel> Investigations { get; set; }
        public List<RadiologyModel> Radiologies { get; set; }







    }
}
