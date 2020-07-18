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
using Material = BlazorCableReel.Shared.Models.Material;

namespace BlazorCableReel.Server.Controllers.Masterfile
{
    [ApiController]
    [Route("[controller]")]
    public class MaterialsController : ControllerBase
    {
        private readonly Cablereel_DevContext db;
        private readonly ILogger<MaterialsController> logger;

        public MaterialsController(ILogger<MaterialsController> logger, Cablereel_DevContext _db)
        {
            this.logger = logger;
            this.db = _db;
        }



        [HttpGet]
        public async Task<ActionResult<List<Material>>> Get()
        {
            return await db.Materials.Select(x => new Material
            {
                Id = x.Id,
                Code=x.Code,
                 Description=x.Description
                
            }).ToListAsync();
        }

        [HttpGet("{id}", Name = "GetMaterial")]
        public async Task<ActionResult<Material>> Get(int id)
        {
            return await db.Materials.Select(x => new Material
            {
                Id = x.Id,
                Code = x.Code,
                Description = x.Description
            }).FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Material _Material)
        {
            var newsite = new Models.Material()
            {
                Id = _Material.Id,
                Code = _Material.Code,
                Description = _Material.Description

            };
            db.Materials.Add(newsite);
            await db.SaveChangesAsync();
            return new CreatedAtRouteResult("GetMaterial", new { id = _Material.Id }, newsite);

        }

        [HttpPut]
        public async Task<ActionResult> Put(Material _Material)
        {
            var newsite = new Models.Material()
            {
                Id = _Material.Id,
                Code = _Material.Code,
                Description = _Material.Description

            };
            db.Entry(newsite).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var site = new BlazorCableReel.Server.Models.Material { Id = id };
            db.Remove(site);
            await db.SaveChangesAsync();
            return NoContent();
        }



    }
}
