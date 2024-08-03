using ClinicAPI.Data;
using ClinicAPI.Dtos;
using ClinicAPI.Mappers;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClinicAPI.Controllers
{
    [ApiController]
    [Route("api/treatment")]
    [EnableCors("AllowAllOrigins")]
    public class TreatmentController : Controller
    {
        private readonly ApplicationDbContext _db;
        public TreatmentController(ApplicationDbContext db)
        {
            _db = db;
        }
       
        [HttpPost]
        public async Task<IActionResult> CreateTreatment([FromBody] CreateTreatmentDto dto)
        {
            if (await _db.Patients.FirstOrDefaultAsync(x => x.Id == dto.PatientId) == null)
            {
                return BadRequest("Patient Doesnt exist");

            }
            if (await _db.Visits.FirstOrDefaultAsync(x => x.Id == dto.VisitId) == null)
            {
                return BadRequest("Visit Doesnt exist");
            }
            var treatment = dto.ToCreateTreatmentDto();
         await   _db.Treatments.AddAsync(treatment);
          await  _db.SaveChangesAsync();
            return Ok(201);

        }
    }
}
