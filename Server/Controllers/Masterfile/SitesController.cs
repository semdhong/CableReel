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
using Site = BlazorCableReel.Shared.Models.Site;

namespace BlazorCableReel.Server.Controllers.Masterfile
{
    [ApiController]
    [Route("[controller]")]
    public class SitesController : ControllerBase
    {
        private readonly Cablereel_DevContext db;
        private readonly ILogger<SitesController> logger;

        public SitesController(ILogger<SitesController> logger, Cablereel_DevContext _db)
        {
            this.logger = logger;
            this.db = _db;
        }



        [HttpGet]
        public async Task<ActionResult<List<Site>>> Get()
        {
            return await db.Sites.Select(x => new Site
            {
                Id = x.Id,
                SiteId = x.SiteId,
                Active = x.Active,
                Brgy = x.Brgy,
                Homing = x.Homing,
                Poid = x.Poid,
                SiteClose = x.SiteClose,
                SiteName = x.SiteName,
            }).ToListAsync();
        }

        [HttpGet("{id}", Name = "GetSite")]
        public async Task<ActionResult<Site>> Get(int id)
        {
            return await db.Sites.Select(x => new Site
            {
                Id = x.Id,
                SiteId = x.SiteId,
                Active = x.Active,
                Brgy = x.Brgy,
                Homing = x.Homing,
                Poid = x.Poid,
                SiteClose = x.SiteClose,
                SiteName = x.SiteName,
            }).FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Site _site)
        {
            var newsite = new Models.Site()
            {
                SiteId = _site.SiteId,
                Active = true,
                Brgy = _site.Brgy,
                Homing = _site.Homing,
                Poid = _site.Poid,
                SiteClose = false,
                SiteName = _site.SiteName,

            };
            db.Sites.Add(newsite);
            await db.SaveChangesAsync();
            return new CreatedAtRouteResult("GetSite", new { id = _site.Id }, newsite);

        }

        [HttpPut]
        public async Task<ActionResult> Put(Site _site)
        {
            var newsite = new Models.Site()
            {
                Id = _site.Id,
                SiteId = _site.SiteId,
                Active = true,
                Brgy = _site.Brgy,
                Homing = _site.Homing,
                Poid = _site.Poid,
                SiteClose = false,
                SiteName = _site.SiteName,

            };
            db.Entry(newsite).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var site = new BlazorCableReel.Server.Models.Site { Id = id };
            db.Remove(site);
            await db.SaveChangesAsync();
            return NoContent();
        }



    }
}
