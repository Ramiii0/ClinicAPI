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
    [Route("api/investigation")]
    [EnableCors("AllowAllOrigins")]
    public class InvestigationController : Controller
    {
        private readonly ApplicationDbContext _db;
        public InvestigationController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpPost]
        [Authorize(Roles = "Analyzer,Doctor")]
        public async Task<IActionResult> CreateInvestigation([FromBody] CreateInvestigationDto investigationDto)
        {
            if( await _db.Patients.FirstOrDefaultAsync(x=>x.Id== investigationDto.PatientId)== null)
            {
                return BadRequest("Patient Doesnt exist");
               
            }
            if (await _db.Visits.FirstOrDefaultAsync(x => x.Id == investigationDto.VisitId) == null)
            {
                return BadRequest("Visit Doesnt exist");
            }
            var investigation = investigationDto.ToCreateInvestigation();
          await  _db.Investigations.AddAsync(investigation);
          await  _db.SaveChangesAsync();
            return Ok(201);
        }
    }
}
