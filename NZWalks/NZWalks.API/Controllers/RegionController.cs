using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;
using NZWalks.API.Models.DTO;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly NZWalksDbContext dbContext;

        public RegionController(NZWalksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            //Get data from database - Domain Models
            var regionsDomain = dbContext.Regions.ToList();

            //Map Domain Models to DTOs
            var regionsDto = new List<RegionDto>();

            foreach (var region in regionsDomain)
            {
                regionsDto.Add(new RegionDto()
                {
                    Id = region.Id,
                    Code = region.Code,
                    Name = region.Name,
                    RegionImageUrl = region.RegionImageUrl,
                });
            }
            
            //Return DTOs to client
            return Ok(regionsDto);
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            //var region = dbContext.Regions.Find(id);
            //Only Id can be passed to Find

            var regionDomain = dbContext.Regions.SingleOrDefault(r => r.Id == id); //any property can be used in SingleOrDefault

            if(regionDomain == null)
            {
                return NotFound();
            }

            //Convert to region DTO
            var regionDto = new RegionDto()
            {
                Id = regionDomain.Id,
                Code = regionDomain.Code,
                Name = regionDomain.Name,
                RegionImageUrl = regionDomain.RegionImageUrl,
            };

            return Ok(regionDto);
        }

        [HttpPost]
        public IActionResult Create([FromBody] AddRegionRequestDto addRegionRequestDto) 
        {
            //Convert DTO to Domain Model
            var regionDomainModel = new Region
            {
                Code = addRegionRequestDto.Code,
                Name = addRegionRequestDto.Name,
                RegionImageUrl = addRegionRequestDto.RegionImageUrl,
            };

            //Use Domain Model to create Region
            dbContext.Regions.Add(regionDomainModel);
            dbContext.SaveChanges();

            //convert Domain model back to DTO
            var regionDto = new RegionDto
            {
                Id = regionDomainModel.Id,
                Code = regionDomainModel.Code,
                Name = regionDomainModel.Name,
                RegionImageUrl = regionDomainModel.RegionImageUrl,
            };

            return CreatedAtAction(nameof(GetById), new {id = regionDto.Id}, regionDto);
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> DeleteRegion([FromRoute] Guid id)
        {
            var regionDomain = await dbContext.Regions.FindAsync(id);
            if (regionDomain == null)
            {
                return NotFound();
            }

            dbContext.Regions.Remove(regionDomain);
            await dbContext.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> PutRegion([FromRoute] Guid id, [FromBody] AddRegionRequestDto regionDto)
        {
            var regionDomain = await dbContext.Regions.FindAsync(id);
            if (regionDomain == null)
            {
                return NotFound();
            }

            regionDomain.Code = regionDto.Code;
            regionDomain.Name = regionDto.Name;
            regionDomain.RegionImageUrl = regionDto.RegionImageUrl;

            try
            {
                await dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!RegionExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        private bool RegionExists(Guid id)
        {
            return dbContext.Regions.Any(e => e.Id == id);
        }
    }
}
