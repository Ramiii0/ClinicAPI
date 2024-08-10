using ClinicAPI.Data;
using ClinicAPI.Dtos;
using ClinicAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClinicAPI.Controllers
{
    [ApiController]
    [Route("api/drugs")]
    [EnableCors("AllowAllOrigins")]
    public class DrugsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public DrugsController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet("allcategory")]
        public async Task<IActionResult> GetAllDrugCategory()
        {
            var categories = await _db.DrugCategories.ToListAsync();
            if (categories == null)
            {
                return NotFound();
            }
            return Ok(categories);
        }
        [HttpGet("category")]
        public async Task<IActionResult> GetOneDrugCategory(int id)
        {
            var categories = await _db.DrugCategories.Include(x=>x.Drugs).FirstOrDefaultAsync(x=>x.Id ==id);
            if (categories == null)
            {
                return NotFound();
            }
            return Ok(categories);
        }
        [HttpPost("category")]
        public async Task<IActionResult> CreateCategory([FromBody]CreateDrugCategotyDto DrugCategotyDto)
        {
            var category = FilterCategory(DrugCategotyDto);
            _db.DrugCategories.AddAsync(category);
            _db.SaveChanges();
            return Ok("Added Successfully");

        }
        [HttpPost("add")]
        
        public async Task<IActionResult> CreateDrug([FromBody] CreateDrugDto createDrug)
        {
            var drug = FilterDrugs(createDrug);
            _db.Drugs.AddAsync(drug);
            _db.SaveChanges();
            return Ok("Added Successfully");

        }
        [HttpDelete("category/id")]
        public async Task<IActionResult> DeleteDrugCategory(int? id)
        {
            var category = await _db.DrugCategories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            _db.Remove(category);
            _db.SaveChanges();
            return Ok(204);
        }
        [HttpDelete("id")]
        public async Task<IActionResult> DeleteDrug(int? id)
        {
            var deug = await _db.DrugCategories.FindAsync(id);
            if (deug == null)
            {
                return NotFound();
            }
            _db.Remove(deug);
            _db.SaveChanges();
            return Ok(204);
        }
        private DrugCategoryModel FilterCategory(CreateDrugCategotyDto obj)
        {
            return new DrugCategoryModel
            {
                CategoryName = obj.CategoryName,
            };
        }
        private DrugsModel FilterDrugs(CreateDrugDto obj)
        {
            return new DrugsModel
            {
                DrugName = obj.DrugName,
                DrugCategoryId = obj.DrugCategoryId,
            };
        }

    }
}
