using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finals3.Model
{
   
        [Route("api/[controller]")]
        [ApiController]
        public class ExpensesController : ControllerBase
        {
            private ExpensesDatabase _database = new ExpensesDatabase();

            private readonly ILogger<ExpensesController> _logger;

            public ExpensesController(Microsoft.Extensions.Logging.ILogger<ExpensesController> logger)
            {
                _logger = logger;
            }

            public IEnumerable<Expense> Get()
            {
                return _database.Items;
            }

            [HttpGet("{UserId}")]
            public async Task<IActionResult> Get(int UserId)
            {
                var item = await _database.Items.FindAsync(UserId);
                if (item == null)
                    return NotFound(new { error = "id is not found" });
                else
                    return Ok(item);
            }

            [HttpPost]
            public async Task<IActionResult> Post(Expense expense)
            {
                _database.Items.Add(expense);
                await _database.SaveChangesAsync();
                return Ok(expense);
            }

            //[HttpGet]
            //public IEnumerable<Expense> Get()
            //{
            //    var rng = new Random();
            //    return Enumerable.Range(1, 5).Select(index => new Expense
            //    {
            //        Date = DateTime.Now.AddDays(index),
            //       Amount = rng.Next(0, 200),

            //    })
            //    .ToArray();
            //}
        }
    
}
