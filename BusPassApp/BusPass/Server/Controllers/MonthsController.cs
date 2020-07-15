using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusPass.Shared.Entities;


namespace BusPass.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonthsController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public MonthsController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Month month)
        {
            context.Add(month);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
