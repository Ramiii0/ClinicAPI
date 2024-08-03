namespace ClinicAPI.Dtos
{
    public class RadiologyDto
    {
        public int Id { get; set; }
        public string? Photo { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
        public int PatientId { get; set; }
        public int VisitId { get; set; }
    }
}
