using ClinicAPI.Models;

namespace ClinicAPI.Dtos
{
    public class CreateRadiologyDto
    {
  
        public IFormFile? Photo { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
        public int PatientId { get; set; }
        public int VisitId { get; set; }
        

    }
}
