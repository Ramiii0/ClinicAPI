using System.ComponentModel.DataAnnotations;

namespace ClinicAPI.Models
{
    public class InvestigationModel
    {
        [Key]
        public int Id { get; set; }
        public List<string>? Invests { get; set; }

        public int PatientId { get; set; }
        public DateTime DateCreated { get; set; }
        public InvestigationModel()
        {
            DateCreated = DateTime.Now; // Default value for DateCreated
        }
        public PatientModel Patient { get; set; }
        
        public int VisitId { get; set; }    
        public VisitModel Visit { get; set; }
    }
}


