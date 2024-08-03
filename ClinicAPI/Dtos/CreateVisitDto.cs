namespace ClinicAPI.Dtos
{
    public class CreateVisitDto
    {
         public string Title { get; set; }
        public string CC { get; set; }
        public string HPI { get; set; }
        public string Examination { get; set; } = string.Empty;
        public string PR { get; set; } = string.Empty;
        public string Radio { get; set; } = string.Empty;
        public int PatientId { get; set; }
        
    }
}
