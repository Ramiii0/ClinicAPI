using ClinicAPI.Data;
using ClinicAPI.Dtos;
using ClinicAPI.Mappers;
using ClinicAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClinicAPI.Controllers
{
    [ApiController]
    [Route("api/patient")]
    [EnableCors("AllowAllOrigins")]
    public class PatientController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PatientController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        
        
        
        public async Task<IActionResult> GetAll()
        {
            var patients = await _db.Patients.OrderByDescending(i => i.DateCreated).ToListAsync();
            return Ok(patients);
        }
        [HttpGet("id")]
       


        public async Task<IActionResult> GetOne(int id)
        {
            var patient = await _db.Patients.Include(x => x.Visits).ThenInclude(s => s.Treatments)
                .Include(m=>m.Visits).ThenInclude(p=>p.Investigation)
                 .Include(m => m.Visits).ThenInclude(p => p.Radiologies)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (patient == null)
            {
                return NotFound();
            }
            var dto = patient.FilterPatient();


            return Ok(dto);



        }
        [HttpPost]
       
        public async Task<IActionResult> Create([FromForm]  CreatePatientDto patientDto)
        {
            var patient = patientDto.ToCreatePatientDto();
            var CreateImage = new SaveImage();
           
            var Path= await  CreateImage.HandleImage(patientDto.Photo,"Images/Patients");
            if (Path != null)
            {
                patient.Photo = Path;
            }
           await _db.Patients.AddAsync(patient);
           await _db.SaveChangesAsync();
            return StatusCode(201);
        }
        [HttpPut("id")]
        public async Task<IActionResult> Update(int id, [FromBody] CreatePatientDto  model)
        {
            var patient = await _db.Patients.FindAsync(id);
            if (patient == null)
            {
                return NotFound();
            }
            patient.FirstName = model.FirstName;
            patient.LastName = model.LastName;
            patient.Age = model.Age;
            patient.Gender = model.Gender;
            
            patient.Medical = model.Medical;
          
            patient.Weight = model.Weight;
            patient.Height = model.Height;
            patient.Social = model.Social;
            patient.Surgical = model.Surgical; 
            patient.Residence = model.Residence;

           await _db.SaveChangesAsync();
            return Ok(patient);



        }
        [HttpDelete("id")]
      
        public async Task<IActionResult> Delete(int id)
        {
            var patient= await _db.Patients.FindAsync(id);
            if (patient == null)
            {
                return NotFound();
            }
            _db.Patients.Remove(patient);
           await _db.SaveChangesAsync();
            return NoContent ();
        }
        [HttpGet("search")]
        public async Task<IActionResult> FindPatient([FromQuery] string name)
        {
            var filterpatient = new List<PatientDto>();
            if (string.IsNullOrEmpty(name))
            {
                return BadRequest("Name parameter is required");
            }

            var patients = await _db.Patients.Include(x => x.Visits).ThenInclude(s => s.Treatments)
                .Include(m => m.Visits).ThenInclude(p => p.Investigation)
                 .Include(m => m.Visits).ThenInclude(p => p.Radiologies)
            .Where(p => p.FirstName.Contains(name) || p.LastName.Contains(name))
            .ToListAsync();

            if (patients == null || patients.Count ==0)
            {
                return NotFound("No patients found");
            }
            foreach (var item in patients)
            {
               var filter = item.FilterPatient();
                filterpatient.Add(filter);

            }

            return Ok(filterpatient);
        }
        
    }
   
    
}
