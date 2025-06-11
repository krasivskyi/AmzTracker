using AmazonSPApiTracker.Application.Interfaces.Repositories;
using AmazonSPApiTracker.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AmazonSPApiTracker.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryRepository _inventoryRepository;
        private readonly ISkuRepository _skuRepository;

        public InventoryController(IInventoryRepository inventoryRepository, ISkuRepository skuRepository)
        {
            _inventoryRepository = inventoryRepository;
            _skuRepository = skuRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateInventory([FromBody] Inventory inventory)
        {
            if (inventory == null)
            {
                return BadRequest();
            }

            var skuExists = await _skuRepository.GetByIdAsync(inventory.SkuId);
            if (skuExists == null)
            {
                return BadRequest($"Sku '{inventory.SkuId}' does not exist. Please create it first via the Sku controller.");
            }
            
            inventory.Sku = null; // Prevent EF from trying to re-create the Sku

            await _inventoryRepository.AddOrUpdateAsync(inventory);
            return CreatedAtAction(nameof(GetInventory), new { sku = inventory.SkuId }, inventory);
        }

        [HttpGet("{sku}")]
        public async Task<IActionResult> GetInventory(string sku)
        {
            var inventory = await _inventoryRepository.GetBySkuIdAsync(sku);
            if (inventory == null) return NotFound();
            return Ok(inventory);
        }
    }
} 