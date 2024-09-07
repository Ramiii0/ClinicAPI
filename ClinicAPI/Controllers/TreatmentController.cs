using ClinicAPI.Data;
using ClinicAPI.Dtos;
using ClinicAPI.Mappers;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize]
        
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
        [HttpPut("id")]
        [Authorize]
        public async Task<IActionResult> UpdateTreatment([FromBody] CreateTreatmentDto dto, int id)
        {
            var treatmentsModel=await _db.Treatments.FindAsync( id);
            if (treatmentsModel == null)
            {
                return NotFound();
            }
            if (dto.Drug != null)
               { treatmentsModel.Drug = dto.Drug; }
            if (dto.Root != null)
                { treatmentsModel.Root = dto.Root; }
            if (dto.Category != null)
               { treatmentsModel.Category = dto.Category; }
            if (dto.SubCategory != null)
                { treatmentsModel.SubCategory = dto.SubCategory; }
            if (dto.Frequency != null)
               { treatmentsModel.Frequency = dto.Frequency; }
            if (dto.Dose != null)
               { treatmentsModel.Dose = dto.Dose; }
            if (dto.Duration != null)
              { treatmentsModel.Duration = dto.Duration; }
            await _db.SaveChangesAsync();
            return Ok("updated successfuly");

        }
        [HttpDelete("id")]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            var treat = await _db.Treatments.FindAsync(id);
            if (treat == null)
            {
                return NotFound();
            }
            _db.Treatments.Remove(treat);
          await  _db.SaveChangesAsync();
            return NoContent();
        }


    }
}
