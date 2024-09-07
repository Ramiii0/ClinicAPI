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
           
            var path = await SaveImage.HandleImage(radiologyDto.Photo,"Radio");
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
           var categgory= await _db.RadioTypeCategory.ToListAsync();
            if (categgory == null)
            {
                return NotFound();
            }
            
            return Ok(categgory);


        }
        [HttpPost("addcategorytype")]
        
        public async Task<IActionResult> AddTypeCAtegory([FromBody] AddTypeCategory dto)
        {
            var create = dto.ToCreateRadiologyCAtegory();
            _db.RadioTypeCategory.AddAsync(create);
            await _db.SaveChangesAsync();
            return Ok("Added successfully");
        }
        [HttpDelete("id")]
        
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _db.Radiology.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            _db.Remove(category);
            await _db.SaveChangesAsync();
            return Ok(204);
        }
        [HttpPut("id")]
       
        public async Task<IActionResult> Update(int id, [FromBody] CreateRadiologyDto model)
        {
            var radio = await _db.Radiology.FindAsync(id);
            if (radio == null)
            {
                return NotFound();
            }
            if (model.Type != null)
               { radio.Type = model.Type; }
            if (model.Description != null)
            { radio.Description = model.Description; }
             await _db.SaveChangesAsync();
            return Ok("updated successfuly");

        }


    }
    public class AddTypeCategory
    {
        public string? Name { get; set; }
    }
}
