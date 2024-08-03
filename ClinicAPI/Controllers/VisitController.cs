using ClinicAPI.Data;
using ClinicAPI.Dtos;
using ClinicAPI.Mappers;
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
                return BadRequest("Patient Doesnt exist");

            }
           
            var visit = visitDto.ToCreateVisit();
          await  _db.Visits.AddAsync(visit);
          await  _db.SaveChangesAsync();
            return Ok(visit);

        }
       /* [HttpPut("id")]
        public IActionResult AddInvestigationToVisit(int id)
        {
            var visit
        }*/
    }
}
