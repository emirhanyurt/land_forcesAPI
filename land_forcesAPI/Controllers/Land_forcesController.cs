using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace land_forcesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Land_forcesController : ControllerBase
    {
        private static List<landforcesEP> soldiers = new List<landforcesEP>
            {
                
            };
        private readonly Context _context;

        public Land_forcesController(Context  context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<landforcesEP>> Get(int id)
        {
            var soldier = await _context.landforcesEPs.FindAsync(id);
             if(soldier == null)
            {
                return BadRequest("Personel Bulunamadı.");
            }
            return Ok(soldier);
        }
        [HttpGet("(Action)")]
        public async Task<ActionResult<landforcesEP>> Getgrade(string Military_grade)
        {
            var soldier = await _context.landforcesEPs.Where(x=>x.Military_grade == Military_grade).ToListAsync();
            if (soldier == null)
            {
                return BadRequest("Personel Bulunamadı.");
            }
            return Ok(soldier);
        }
        [HttpGet]
        public async Task<ActionResult<List<landforcesEP>>> Get()
        {

            return Ok(await _context.landforcesEPs.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<List<landforcesEP>>> Addsoldier(landforcesEP force)
        {
          _context.landforcesEPs.Add(force);
            await _context.SaveChangesAsync();
            return Ok(await _context.landforcesEPs.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<landforcesEP>>> Updatesoldier(landforcesEP request)
        {
            var soldierDB = await _context.landforcesEPs.FindAsync(request.Id);
            if (soldierDB == null)
            {
                return BadRequest("Personel Bulunamadı.");
            }
            soldierDB.FirstName = request.FirstName;
            soldierDB.LastName= request.LastName;
            soldierDB.Military_grade = request.Military_grade;
            soldierDB.Garrison = request.Garrison;
            soldierDB.Pleace = request.Pleace;
            await _context.SaveChangesAsync();
            return Ok(await _context.landforcesEPs.ToListAsync());
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<landforcesEP>> Delete(int id)
        {
            var dbsoldier = await _context.landforcesEPs.FindAsync(id);
            if (dbsoldier == null)
            {
                return BadRequest("Personel Bulunamadı.");
            }
            _context.landforcesEPs.Remove(dbsoldier);
            await _context.SaveChangesAsync();
            return Ok(await _context.landforcesEPs.ToListAsync());
        }
    }
}
