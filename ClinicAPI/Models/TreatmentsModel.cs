using System.ComponentModel.DataAnnotations.Schema;


namespace ClinicAPI.Models
{
    public class TreatmentsModel
    {
        public int Id {  get; set; }
   
        public string Category { get; set; }
        public string? SubCategory { get; set; }
        public string? Drug { get; set; }
        public string? Dose { get; set; }
        public string? Frequency { get; set; }
        public string? Root { get; set; }
        public string? Time { get; set; }
        public string? Duration { get; set; }
        public int PatientId { get; set; }
        [ForeignKey("PatientId")]
        public PatientModel? Patient { get; set; }
        public int VisitId { get; set; }
        [ForeignKey("VisitId")]

        public VisitModel? Visit { get; set; }
    }

}
