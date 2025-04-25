using EventBookingManagementSystem_Backend.DTOs.RequestModels;
using EventBookingManagementSystem_Backend.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventBookingManagementSystem_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Package_ItemController : ControllerBase
    {
        private readonly IPackage_ItemService _package_ItemService;

        public Package_ItemController(IPackage_ItemService package_ItemService)
        {
            _package_ItemService = package_ItemService;
        }

        //get all package item
        [HttpGet("get-all-package-item")]

        public async Task<IActionResult> GetAllPackageItems()
        {
            try
            {
                var data = await _package_ItemService.GetAllPackageItems();
                return data == null ? NotFound() : Ok(data);

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //get package item by packageId
        [HttpGet("get-package-item-by-packageId/{packageId}")]

        public async Task<IActionResult> GetPackageItemsByPackageId(Guid packageId)
        {
            try
            {
                var data = await _package_ItemService.GetPackageItemsByPackageId(packageId);
                return data == null ? NotFound() : Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // get package item by itemId

        [HttpGet("get-package-item-by-itemId/{itemId}")]

        public async Task<IActionResult> GetPackageItemsByItemId(Guid itemId)
        {
            try
            {
                var data = await _package_ItemService.GetPackageItemsByItemId(itemId);
                return data == null ? NotFound() : Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // get package item by assetId

        [HttpGet("get-package-item-by-assetId/{assetId}")]

        public async Task<IActionResult> GetPackageItemsByAssetId(Guid assetId)
        {
            try
            {
                var data = await _package_ItemService.GetPackageItemsByAssetId(assetId);
                return data == null ? NotFound() : Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // add package item

        [HttpPost("add-package-item")]

        public async Task<IActionResult> AddPackageItem(Package_ItemRequest package_Item)
        {
            try
            {
                var data = await _package_ItemService.AddPackageItem(package_Item);
                return data == null ? NotFound() : Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //update package item

        [HttpPut("update-package-item")]

        public async Task<IActionResult> UpdatePackageItem(Guid Id,Package_ItemRequest package_Item)
        {
            try
            {
                var data = await _package_ItemService.UpdatePackageItem(Id,package_Item);
                return data == null ? NotFound() : Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        //delete package item

        [HttpDelete("delete-package-item/{id}")]

        public async Task<IActionResult> DeletePackageItem(Guid id)
        {
            try
            {
                var data = await _package_ItemService.DeletePackageItem(id);
                return data == false ? NotFound() : Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
