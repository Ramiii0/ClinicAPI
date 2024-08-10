using ClinicAPI.Models;

namespace ClinicAPI.Dtos
{
    public class VisitDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CC { get; set; }
        public string HPI { get; set; }
        public string Examination { get; set; } = string.Empty;
        public string PR { get; set; } = string.Empty;
       
        public string? ServiceFollow {  get; set; } 
        public DateTime VisitDate { get; set; } = DateTime.Now;
        public int PatientId { get; set; }
        public List<InvestigationDto> Investigation { get; set; }
        public  List<TreatmentDto> Treatment { get; set; }
       public  List<RadiologyDto> Radiology { get; set; }
    }
}
