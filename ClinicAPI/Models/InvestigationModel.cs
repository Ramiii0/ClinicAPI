using System.ComponentModel.DataAnnotations;

namespace ClinicAPI.Models
{
    public class InvestigationModel
    {
        [Key]
        public int Id { get; set; }
        public int HB { get; set; }
        public int PLATELETS { get; set; }
        public int UREA { get; set; }
        public int Creatinine { get; set; }
        public int RBS { get; set; }
        public int FBS { get; set; }
        public int HbA1c { get; set; }
        public int PSA { get; set; }
        public int GUE_PUS { get; set; }
        public int GUERBC { get; set; }
        public int Uric_Acid { get; set; }
        public int CRP { get; set; }
        public int ESR { get; set; }
        public int FERRITIN { get; set; }
        public int D_DIMER { get; set; }
        public int WBC { get; set; }
        public int PatientId { get; set; }
        public PatientModel Patient { get; set; }
        
        public int VisitId { get; set; }    
        public VisitModel Visit { get; set; }
    }
}


