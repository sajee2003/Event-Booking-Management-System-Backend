using EventBookingManagementSystem_Backend.DB.Entities;
using EventBookingManagementSystem_Backend.DTOs.CommonModules;
using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.Services.Implementations;
using EventBookingManagementSystem_Backend.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace EventBookingManagementSystem_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetController : ControllerBase
    {
        private readonly IAssetService assetService;

        public AssetController(IAssetService assetService)
        {
            this.assetService = assetService;
        }
     
    
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var items = await assetService.GetAllAsset();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var item = await assetService.GetByIdAsync(id);
            if (item == null) return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsset([FromBody] AssetRequest assetDto)
        {
            if (assetDto == null)
            {
                return BadRequest("Asset data is null.");
            }

            var newAsset = await assetService.CreateAssetAsync(assetDto);

            return Ok( newAsset);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, AssetDTO asset)
        {
            var updated = await assetService.UpdateAsync(id,asset);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await assetService.DeleteAsset(id);
            if (result == null) return NotFound();
            return Ok(result);
        }
    }

 }
