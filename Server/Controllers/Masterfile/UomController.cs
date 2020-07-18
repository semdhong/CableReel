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
using Uom = BlazorCableReel.Shared.Models.Uom;

namespace BlazorCableReel.Server.Controllers.Masterfile
{
    [ApiController]
    [Route("[controller]")]
    public class UomController : ControllerBase
    {
        private readonly Cablereel_DevContext db;
        private readonly ILogger<UomController> logger;

        public UomController(ILogger<UomController> logger, Cablereel_DevContext _db)
        {
            this.logger = logger;
            this.db = _db;
        }



        [HttpGet]
        public async Task<ActionResult<List<Uom>>> Get()
        {
            return await db.Uoms.Select(x => new Uom
            {
                Id = x.Id,
                 UomName=x.UomName,
                 
            }).ToListAsync();
        }

        [HttpGet("{id}", Name = "GetUom")]
        public async Task<ActionResult<Uom>> Get(int id)
        {
            return await db.Uoms.Select(x => new Uom
            {
                Id = x.Id,
                UomName = x.UomName,
            }).FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Uom _Uom)
        {
            var newUom= new Models.Uom()
            {

                Id = _Uom.Id,
                UomName = _Uom.UomName,
            };
            db.Uoms.Add(newUom);
            await db.SaveChangesAsync();
            return new CreatedAtRouteResult("GetUom", new { id = _Uom.Id }, newUom);

        }

        [HttpPut]
        public async Task<ActionResult> Put(Uom _Uom)
        {
            var newUom = new Models.Uom()
            {
                Id = _Uom.Id,
                 UomName = _Uom.UomName,
               

            };
            db.Entry(newUom).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var Uom = new BlazorCableReel.Server.Models.Uom { Id = id };
            db.Remove(Uom);
            await db.SaveChangesAsync();
            return NoContent();
        }



    }
}
