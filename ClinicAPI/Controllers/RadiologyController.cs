using ClinicAPI.Data;
using ClinicAPI.Dtos;
using ClinicAPI.Mappers;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace ClinicAPI.Controllers
{
    [ApiController]
    [Route("api/radio")]
    [EnableCors("AllowAllOrigins")]
    public class RadiologyController : Controller
    {
        private readonly ApplicationDbContext _db;
        public RadiologyController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpPost]
        public async Task<IActionResult> CreateRadiolofy([FromForm] CreateRadiologyDto radiologyDto)
        {

            if (await _db.Patients.FirstOrDefaultAsync(x => x.Id == radiologyDto.PatientId) == null)
            {
                return BadRequest("Patient Doesnt exist");

            }
            if (await _db.Visits.FirstOrDefaultAsync(x => x.Id == radiologyDto.VisitId) == null)
            {
                return BadRequest("Visit Doesnt exist");
            }
           
           
            var radiology = radiologyDto.ToCreateRadiology();
           
            var path = await SaveImage.HandleImage(radiologyDto.Photo,"/Radio");
            if (path != null)
            {
                radiology.Photo = path;
            }
            await _db.Radiology.AddAsync(radiology);
          await  _db.SaveChangesAsync();
            return Ok(201);
        }
        [HttpGet("TypeCategory")]
        public async Task<IActionResult> GetTypeCategory()
        {
           var categgory= await _db.Radiology.FindAsync(1);
            if (categgory == null)
            {
                return NotFound();
            }
            
            return Ok(categgory.TypeCategory);


        }
        public class AddTypeCategory
        {
            public string? Name { get; set; }
        }
    }
}
