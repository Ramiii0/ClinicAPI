using ClinicAPI.Dtos;
using ClinicAPI.Models;
using System.Linq;

namespace ClinicAPI.Mappers
{
    public static class VisitMapper
    {
        public static VisitModel ToCreateVisit(this CreateVisitDto model)
        {
            return new VisitModel
            {
                Title = model.Title,
                CC = model.CC,
                Examination = model.Examination,
                HPI = model.HPI,
              
                PR = model.PR,
                PatientId = model.PatientId,
            };
        }

        public static VisitDto FilterVisit(this VisitModel model)
        {
            return new VisitDto
            {
                Id = model.Id,
                CC = model.CC,
                Examination = model.Examination,
                HPI = model.HPI,
                PatientId = model.PatientId,
                PR = model.PR,
               
                Title = model.Title,
                VisitDate = model.VisitDate,
                Radiology=model.Radiologies.Select(x=>x.FilterRadiology()).Where(x => x.PatientId == model.PatientId).ToList(),
                Investigation = model.Investigation.Select(d=>d.FilterInvestigation()).Where(x=>x.PatientId == model.PatientId).ToList(),
                Treatment = model.Treatments.Select(q => q.FilterTreatment()).Where(x => x.PatientId == model.PatientId).ToList(),
                
            };
        }
      

     
  
    }
}
