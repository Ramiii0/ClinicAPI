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
    [Route("api/visit")]
    [EnableCors("AllowAllOrigins")]
    public class VisitController : Controller
    {
        private readonly ApplicationDbContext _db;
        public VisitController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet("id")]
        public IActionResult GetVisit(int id)
        {
            var visit = _db.Visits.Where(x=>x.PatientId == id).ToList();
            if (visit == null)
            {
                return NotFound();
            }
            return Ok(visit);
           
        }
        [HttpPost]
        public async Task<IActionResult> CreateVisit([FromBody] CreateVisitDto visitDto)
        {
            if (await _db.Patients.FirstOrDefaultAsync(x => x.Id == visitDto.PatientId) == null)
            {
                return NotFound("Patient Doesnt exist");

            }
           
            var visit = visitDto.ToCreateVisit();
          await  _db.Visits.AddAsync(visit);
          await  _db.SaveChangesAsync();
            return Ok(visit);

        }
        [HttpPut("id")]
        [Authorize]
        public async Task<IActionResult> UpdateVisit([FromBody] UpdateVisitDto visitDto, int id)
        {
            var visit = await _db.Visits.FindAsync(id);
            if (visit == null)
            {
                return NotFound();
            }

            if (visitDto.HPI != null)
            { visit.HPI = visitDto.HPI; }
            if (visitDto.CC != null)
            { visit.CC = visitDto.CC; }
            if (visitDto.PR != null)
            { visit.PR = visitDto.PR; }
            if (visitDto.ServiceFollow != null)
            { visit.ServiceFollow = visitDto.ServiceFollow; }
            if (visitDto.Title != null)
            { visit.Title = visitDto.Title; }
            if (visitDto.Examination != null)
            { visit.Examination = visitDto.Examination; }
          await  _db.SaveChangesAsync();
            return Ok("updated");
        
        }
        [HttpDelete("id")]
        [Authorize(Roles = "Doctor")]
        public async Task<IActionResult> Delete(int id)
        {
            var visit = await _db.Visits.FindAsync(id);
            if (visit == null)
            {
                return NotFound();

            }
            _db.Remove(visit);
          await  _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
