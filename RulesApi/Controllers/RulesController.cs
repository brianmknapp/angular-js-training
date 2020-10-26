using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using RulesApi.Models;

namespace RulesApi.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class RulesController : ControllerBase
    {
        private IList<Rule> _context;
        public RulesController()
        {
            
            _context = new List<Rule>
            {
                new Rule{Id = 1, RuleName = "Must be 5 characters"},
                new Rule{Id = 2, RuleName = "Must not be used elsewhere"},
                new Rule{Id = 3, RuleName = "Must be cool"}
            };
        }

        // GET: api/Rules
        [HttpGet]
        public IEnumerable<Rule> GetRule()
        {
            return _context;
        }

        // GET: api/Rules/5
        [HttpGet("{id}")]
        public IActionResult GetRule(long id)
        {
            var rule = _context.FirstOrDefault(x => x.Id == id);
            if (rule is null)
            {
                return NotFound();
            }

            return new OkObjectResult(rule);
        }

        // PUT: api/Rules/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public IActionResult PutRule(long id, Rule rule)
        {
            if (id != rule.Id)
            {
                return BadRequest();
            }

            _context.First(x => x.Id == id).RuleName = rule.RuleName;

            return NoContent();
        }

        // POST: api/Rules
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public IActionResult PostRule(Rule rule)
        {
            _context.Add(rule);
            
            return CreatedAtAction(nameof(GetRule), "Rules", _context);
        }

        // DELETE: api/Rules/5
        [HttpDelete("{id}")]
        public IActionResult DeleteRule(long id)
        {
            var rule = _context.FirstOrDefault(x => x.Id == id);
            if (rule == null)
            {
                return NotFound();
            }

            _context.ToList().Remove(rule);

            return new OkResult();
        }

        private bool RuleExists(long id)
        {
            return _context.Any(e => e.Id == id);
        }
    }
}
