using ClinicAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicAPI.Dtos
{
    public class CreateTreatmentDto
    {
      
        public string Category { get; set; }
        public string? SubCategory { get; set; }
        public string? Dose { get; set; }
        public string? Frequency { get; set; }
        public string? Drug { get; set; }
        public string? Root { get; set; }
        public string? Time { get; set; }
        public string? Duration { get; set; }
        public int PatientId { get; set; }
        public int VisitId { get; set; }
     
    }
}
