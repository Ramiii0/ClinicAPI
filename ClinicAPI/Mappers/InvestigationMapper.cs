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
                HbA1c = model.HbA1c,
                PLATELETS = model.PLATELETS,
                PSA = model.PSA,
                UREA = model.UREA,
                Creatinine = model.Creatinine,
                RBS = model.RBS,
                FBS = model.FBS,
                GUERBC = model.GUERBC,
                GUE_PUS = model.GUE_PUS,
                ESR = model.ESR,
                FERRITIN = model.FERRITIN,
                D_DIMER = model.D_DIMER,
                HB = model.HB,
                Uric_Acid = model.Uric_Acid,
                CRP = model.CRP,
                WBC = model.WBC,
                VisitId = model.VisitId,
                PatientId = model.PatientId,

            };
        }
        public static InvestigationDto FilterInvestigation(this InvestigationModel model)
        {
            return new InvestigationDto
            {
                Id = model.Id,
                HB = model.HB,
                PLATELETS = model.PLATELETS,
                UREA = model.UREA,
                Creatinine = model.Creatinine,
                RBS = model.RBS,
                FBS = model.FBS,
                HbA1c = model.HbA1c,
                PSA = model.PSA,
                GUERBC = model.GUERBC,
                WBC = model.WBC,
                GUE_PUS = model.GUE_PUS,
                Uric_Acid = model.Uric_Acid,
                CRP = model.CRP,
                ESR = model.ESR,
                FERRITIN = model.FERRITIN,
                D_DIMER = model.D_DIMER,
                PatientId = model.PatientId,
                VisitId = model.VisitId,

            };
        }

    }
}
