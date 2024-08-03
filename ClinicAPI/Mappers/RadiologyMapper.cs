using ClinicAPI.Dtos;
using ClinicAPI.Models;

namespace ClinicAPI.Mappers
{
    public static class RadiologyMapper
    {
        public static RadiologyModel ToCreateRadiology(this CreateRadiologyDto model)
        {
            return new RadiologyModel
            {
               
                Type = model.Type,
                Description = model.Description,
                VisitId = model.VisitId,
                PatientId = model.PatientId,
            };
        }
        public static RadiologyDto FilterRadiology(this RadiologyModel model)
        {
            return new RadiologyDto
            {
                Id = model.Id,
                Photo = model.Photo,
                Type = model.Type,
                Description = model.Description,
                VisitId = model.VisitId,
                PatientId = model.PatientId,
            };
        }
    }
}
