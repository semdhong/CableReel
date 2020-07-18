using BlazorCableReel.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BlazorCableReel.Shared.Models;
using BlazorCableReel.Server.Data;
using BlazorCableReel.Server.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using Scope = BlazorCableReel.Shared.Models.Scope;

namespace BlazorCableReel.Server.Controllers.Masterfile
{
    [ApiController]
    [Route("[controller]")]
    public class ScopeController : ControllerBase
    {
        private readonly Cablereel_DevContext db;
        private readonly ILogger<ScopeController> logger;

        public ScopeController(ILogger<ScopeController> logger, Cablereel_DevContext _db)
        {
            this.logger = logger;
            this.db = _db;
        }



        [HttpGet]
        public async Task<ActionResult<List<Scope>>> Get()
        {
            return await db.Scopes.Select(x => new Scope
            {
                Id = x.Id,
                 ScopeName=x.ScopeName,
                 
            }).ToListAsync();
        }

        [HttpGet("{id}", Name = "GetScope")]
        public async Task<ActionResult<Scope>> Get(int id)
        {
            return await db.Scopes.Select(x => new Scope
            {
                Id = x.Id,
                ScopeName = x.ScopeName,
            }).FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Scope _scope)
        {
            var newscope= new Models.Scope()
            {

                Id = _scope.Id,
                ScopeName = _scope.ScopeName,
            };
            db.Scopes.Add(newscope);
            await db.SaveChangesAsync();
            return new CreatedAtRouteResult("GetScope", new { id = _scope.Id }, newscope);

        }

        [HttpPut]
        public async Task<ActionResult> Put(Scope _scope)
        {
            var newscope = new Models.Scope()
            {
                Id = _scope.Id,
                 ScopeName = _scope.ScopeName,
               

            };
            db.Entry(newscope).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var scope = new BlazorCableReel.Server.Models.Scope { Id = id };
            db.Remove(scope);
            await db.SaveChangesAsync();
            return NoContent();
        }



    }
}
