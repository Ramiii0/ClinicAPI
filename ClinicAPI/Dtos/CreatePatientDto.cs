using ClinicAPI.Models;

namespace ClinicAPI.Dtos
{
    public class CreatePatientDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Age { get; set; }
        public string? Gender { get; set; }
        public string? Residence { get; set; }
        public int? Phone { get; set; }
        public IFormFile? Photo { get; set; }
        public int? Weight { get; set; }
        public int Height { get; set; } 
        public string? Medical { get; set; }
        public string? Surgical { get; set; }
        public string? Social { get; set; }
      
        
    }
}
