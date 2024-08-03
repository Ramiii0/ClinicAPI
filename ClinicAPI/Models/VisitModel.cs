using ClinicAPI.Dtos;
using ClinicAPI.Migrations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicAPI.Models
{
    public class VisitModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CC { get; set; }
        public string HPI { get; set; }
        public string Examination { get; set; } = string.Empty;
        public string PR { get; set; } = string.Empty;
       
        public DateTime VisitDate { get; set; } = DateTime.Now;
        public int PatientId { get; set; }
        public PatientModel? Patient { get; set; }
        public List<RadiologyModel> Radiologies { get; set; }

        public List<TreatmentsModel> Treatments { get; set; }
       public List<InvestigationModel> Investigation { get; set; }
     
    }
}
