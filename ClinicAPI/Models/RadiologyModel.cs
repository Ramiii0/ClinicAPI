namespace ClinicAPI.Models
{
    public class RadiologyModel
    {
        public int Id { get; set; }
        public string? Photo {  get; set; }
        public string? Type { get; set; }
        public List<string>? TypeCategory { get; set; }
        public string? Description { get; set; }
        public int PatientId { get; set; }
        public DateTime DateCreated { get; set; }
        public RadiologyModel()
        {
            DateCreated = DateTime.Now; // Default value for DateCreated
        }
        public PatientModel? Patient { get; set; }
        public int VisitId { get; set; }
        public VisitModel? Visit { get; set; }



    }
}
