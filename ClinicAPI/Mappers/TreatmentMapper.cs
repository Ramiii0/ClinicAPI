using ClinicAPI.Dtos;
using ClinicAPI.Models;


namespace ClinicAPI.Mappers
{
    public static class TreatmentMapper
    {
        public static TreatmentsModel ToCreateTreatmentDto(this CreateTreatmentDto model)
        {
            return new TreatmentsModel
            {
                Category = model.Category,
                Dose = model.Dose,
                Duration = model.Duration,
                Frequency = model.Frequency,
                Time = model.Time,
                PatientId = model.PatientId,    
                Drug=model.Drug,
                VisitId = model.VisitId,
                Root=model.Root,
                SubCategory=model.SubCategory,


            };
        }
        public static TreatmentDto FilterTreatment(this TreatmentsModel model)
        {
            return new TreatmentDto
            {
                Id = model.Id,
                Category = model.Category,
                SubCategory = model.SubCategory,
                Dose = model.Dose,
                Duration = model.Duration,
                Frequency = model.Frequency,
                Root = model.Root,
                Time = model.Time,
                Drug = model.Drug,
                PatientId = model.PatientId,
                VisitId = model.VisitId,
            };
        }
    }
}
