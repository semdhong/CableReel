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
using Client = BlazorCableReel.Shared.Models.Client;

namespace BlazorCableReel.Server.Controllers.Masterfile
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly Cablereel_DevContext db;
        private readonly ILogger<ClientController> logger;

        public ClientController(ILogger<ClientController> logger, Cablereel_DevContext _db)
        {
            this.logger = logger;
            this.db = _db;
        }



        [HttpGet]
        public async Task<ActionResult<List<Clients>>> Get()
        {
            return await db.Clients.Select(x => new Clients
            {
                Id = x.Id,
                BusinessName=x.BusinessName,
                 Shortname =x.Shortname
            }).ToListAsync();
        }

        [HttpGet("{id}", Name = "GetClient")]
        public async Task<ActionResult<Clients>> Get(int id)
        {
            return await db.Clients.Select(x => new Clients
            {
                Id = x.Id,
                BusinessName = x.BusinessName,
                Shortname = x.Shortname
            }).FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Clients _client)
        {
            var newclient= new Models.Clients()
            {
               
                BusinessName = _client.BusinessName,
                Shortname = _client.Shortname
            };
            db.Clients.Add(newclient);
            await db.SaveChangesAsync();
            return new CreatedAtRouteResult("GetClient", new { id = _client.Id }, newclient);

        }

        [HttpPut]
        public async Task<ActionResult> Put(Clients _client)
        {
            var newclient = new Models.Clients()
            {
                Id = _client.Id,
                BusinessName = _client.BusinessName,
                Shortname = _client.Shortname

            };
            db.Entry(newclient).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var client = new BlazorCableReel.Server.Models.Clients { Id = id };
            db.Remove(client);
            await db.SaveChangesAsync();
            return NoContent();
        }



    }
}
