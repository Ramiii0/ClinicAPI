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
        [Authorize]
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
        [HttpPost("addinvestigation")]
        [Authorize]
        public IActionResult AddInvestigation([FromQuery] string name)
        { var type = new InvestigationType()
        {
            Category=name

        };
            _db.InvestigationTypes.Add(type);
            _db.SaveChanges();
            return Ok(201);

        }
        [HttpDelete("id")]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            var invest= _db.Investigations.FirstOrDefault(x=>x.Id==id);
            if (invest==null) { return NotFound(); }
            _db.Remove(invest);
            _db.SaveChangesAsync();
            return Ok();
        }
        [HttpPut("id")]
        [Authorize]
        public async Task<IActionResult> Update(int id, [FromBody] updateinvests model)
        {
            var getinvest= await _db.Investigations.FirstOrDefaultAsync(x=>x.Id==id);
            if (getinvest == null)
            {
                return NotFound();
            }
            if (model.oldValue != null && model.newValue != null) 
            {
                int index = getinvest.Invests.IndexOf(model.oldValue);
                if (index != -1)
                    getinvest.Invests[index] = model.newValue;
            }
            await _db.SaveChangesAsync();
            return Ok("updated successfullly");

        }
        public class updateinvests
        {
            public string oldValue { get; set; }

            public string newValue { get; set; }
        }

    }
}
