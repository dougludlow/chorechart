using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChoreChart.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChoreChart.Api.Controllers
{
    [Route("api/[controller]")]
    public class ChoresController : Controller
    {
        private ChoreChartContext _context;

        public ChoresController(ChoreChartContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Chore> Get()
        {
            return _context.Chores.ToList();
        }

        // POST api/values
        [HttpPost]
        public async Task Post([FromBody]Chore chore)
        {
            _context.Chores.Add(chore);
            await _context.SaveChangesAsync();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task Delete(long id)
        {
            var chore = await _context.Chores.FindAsync(id);
            _context.Chores.Remove(chore);
            await _context.SaveChangesAsync();
        }
    }
}
