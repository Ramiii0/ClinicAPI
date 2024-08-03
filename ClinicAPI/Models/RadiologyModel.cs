namespace ClinicAPI.Models
{
    public class RadiologyModel
    {
        public int Id { get; set; }
        public string? Photo {  get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
        public int PatientId { get; set; }
        public PatientModel? Patient { get; set; }
        public int VisitId { get; set; }
        public VisitModel? Visit { get; set; }



    }
}
