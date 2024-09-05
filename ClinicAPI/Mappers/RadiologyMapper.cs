using ClinicAPI.Dtos;
using ClinicAPI.Models;
using static ClinicAPI.Controllers.RadiologyController;

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
            string photo = model.Photo;
            byte[] numArray = null;
            if (photo != null && File.Exists(photo)) { numArray = File.ReadAllBytes(photo); }
                
            return new RadiologyDto()
            {
                Id = model.Id,
                Photo = model.Photo,
                Type = model.Type,
                ImageData = numArray,
                Description = model.Description,
                VisitId = model.VisitId,
                PatientId = model.PatientId
            };
        }
        public static RadioTypeCategory ToCreateRadiologyCAtegory(this AddTypeCategory model)
        {
            return new RadioTypeCategory() { Name = model.Name };
        }
    }
}
