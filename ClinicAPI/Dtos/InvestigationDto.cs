using ClinicAPI.Models;

namespace ClinicAPI.Dtos
{
    public class InvestigationDto
    {
        public int Id { get; set; }

        public List<string>? Invests { get; set; }
        public int PatientId { get; set; }
        

        public int VisitId { get; set; }
       
    }
}
