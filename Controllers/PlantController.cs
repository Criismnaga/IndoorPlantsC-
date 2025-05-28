using IndoorPlantsC_.Context;
using IndoorPlantsC_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IndoorPlantsC_.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlantController : ControllerBase
    {
        private readonly AppDbContext _context;
        public PlantController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Plant>> GetAll()
        {
            var plants = _context.Plants.Include(p => p.Users).AsNoTracking().ToList();
            if (!plants.Any())
            {
                return NotFound("Nenhuma planta foi encontrada");
            }
            return plants;
        }

        [HttpGet("{id:int}")]
        public ActionResult<Plant> GetById(int id)
        {
            var plant = _context.Plants.Include(p => p.Users).FirstOrDefault(p => p.PlantId == id);
            if (plant is null)
            {
                return NotFound("Não foi possível encontrar planta");
            }
            return plant;
        }


        [HttpPost]
        public ActionResult Post(Plant plant)
        {
            if (plant is null)
            {
                return BadRequest();
            }
            _context.Plants.Add(plant);
            _context.SaveChanges();
            return new CreatedAtRouteResult("RetrivePlant", new { id = plant.PlantId }, plant);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Plant plant)
        {
            if (id != plant.PlantId)
            {
                return BadRequest();
            }
            _context.Entry(plant).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(plant);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var plant = _context.Plants.FirstOrDefault(p => p.PlantId == id);
            if (plant is null)
            {
                return NotFound("Planta não encontrada");
            }
            _context.Plants.Remove(plant);
            _context.SaveChanges();
            return Ok(plant);
        }
    }
}