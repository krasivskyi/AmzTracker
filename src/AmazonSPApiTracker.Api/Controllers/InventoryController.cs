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

        public InventoryController(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
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