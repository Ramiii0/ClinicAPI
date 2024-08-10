using ClinicAPI.Dtos;
using ClinicAPI.Models;

namespace ClinicAPI.Mappers
{
    public static class PatientMapper
    {
        public static PatientModel ToCreatePatientDto(this CreatePatientDto model)
        {
            return new PatientModel
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Gender = model.Gender,
                Height = model.Height,
                Weight = model.Weight,
                Residence = model.Residence,
                Phone = model.Phone,
                
                Medical = model.Medical,
                Social = model.Social,
                Age = model.Age,    
                Surgical = model.Surgical, 
           /*     Photo = model.Photo,*/


            };
        }
        
        public static PatientDto FilterPatient(this PatientModel model)
        {
            return new PatientDto
            {
                Id= model.Id,

                FirstName = model.FirstName,
                LastName = model.LastName,
                Gender = model.Gender,
                Height = model.Height,
                Weight = model.Weight,
                Residence = model.Residence,
                Phone = model.Phone,
                Medical = model.Medical,
                Social = model.Social,
                Age = model.Age,
                
                Surgical = model.Surgical,
                Photo = model.Photo,
                Visits = model.Visits.Select(v => v.FilterVisit()).ToList(),



            };
        }


    }
}
