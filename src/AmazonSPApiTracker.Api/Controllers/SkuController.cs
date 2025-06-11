using AmazonSPApiTracker.Application.Interfaces.Repositories;
using AmazonSPApiTracker.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AmazonSPApiTracker.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SkuController : ControllerBase
    {
        private readonly ISkuRepository _skuRepository;

        public SkuController(ISkuRepository skuRepository)
        {
            _skuRepository = skuRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSku([FromBody] Sku sku)
        {
            if (sku == null)
            {
                return BadRequest();
            }

            var existingSku = await _skuRepository.GetByIdAsync(sku.Id);
            if (existingSku != null)
            {
                return Conflict($"Sku with Id '{sku.Id}' already exists.");
            }

            await _skuRepository.AddAsync(sku);
            return CreatedAtAction(nameof(GetSkuById), new { id = sku.Id }, sku);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSkuById(string id)
        {
            var sku = await _skuRepository.GetByIdAsync(id);
            if (sku == null)
            {
                return NotFound();
            }
            return Ok(sku);
        }
    }
} 