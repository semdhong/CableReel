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
using Stage = BlazorCableReel.Shared.Models.Stage;

namespace BlazorCableReel.Server.Controllers.Masterfile
{
    [ApiController]
    [Route("[controller]")]
    public class StageController : ControllerBase
    {
        private readonly Cablereel_DevContext db;
        private readonly ILogger<StageController> logger;

        public StageController(ILogger<StageController> logger, Cablereel_DevContext _db)
        {
            this.logger = logger;
            this.db = _db;
        }



        [HttpGet]
        public async Task<ActionResult<List<Stage>>> Get()
        {
            return await db.Stages.Select(x => new Stage
            {
                Id = x.Id,
                 Stagename  = x.Stagename,
                
            }).ToListAsync();
        }

        [HttpGet("{id}", Name = "GetStage")]
        public async Task<ActionResult<Stage>> Get(int id)
        {
            return await db.Stages.Select(x => new Stage
            {
                Id = x.Id,
            
                Stagename = x.Stagename,

            }).FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Stage _stage)
        {
            var newsite = new Models.Stage()
            {
                Id = _stage.Id,

                Stagename = _stage.Stagename,

            };
            db.Stages.Add(newsite);
            await db.SaveChangesAsync();
            return new CreatedAtRouteResult("GetStage", new { id = _stage.Id }, newsite);

        }

        [HttpPut]
        public async Task<ActionResult> Put(Stage _stage)
        {
            var newsite = new Models.Stage()
            {
                Id = _stage.Id,
                Stagename= _stage.Stagename
            };
            db.Entry(newsite).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var site = new BlazorCableReel.Server.Models.Stage { Id = id };
            db.Remove(site);
            await db.SaveChangesAsync();
            return NoContent();
        }



    }
}
