namespace ClinicAPI.Dtos
{
    public class CreateInvestigationDto
    {
        public List<string>? Invests { get; set; }
        public int PatientId { get; set; }
        public int VisitId { get; set; }
         
    }
}
