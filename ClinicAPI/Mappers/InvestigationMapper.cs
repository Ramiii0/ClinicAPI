using ClinicAPI.Dtos;
using ClinicAPI.Models;

namespace ClinicAPI.Mappers
{
    public static class InvestigationMapper
    {
        public static InvestigationModel ToCreateInvestigation(this CreateInvestigationDto model)
        {
            return new InvestigationModel
            {
                Invests = model.Invests,
                VisitId = model.VisitId,
                PatientId = model.PatientId

            };
        }
        public static InvestigationDto FilterInvestigation(this InvestigationModel model)
        {
            return new InvestigationDto
            {
                Id = model.Id,
                Invests = model.Invests,
                PatientId = model.PatientId,
                VisitId = model.VisitId

            };
        }

    }
}
