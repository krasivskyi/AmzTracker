using AmazonSPApiTracker.Application.Interfaces.Repositories;
using AmazonSPApiTracker.Domain.Entities;
using AmazonSPApiTracker.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AmazonSPApiTracker.Infrastructure.Repositories
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly ApplicationDbContext _context;

        public InventoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Inventory?> GetBySkuIdAsync(string skuId)
        {
            return await _context.Inventories.FirstOrDefaultAsync(i => i.SkuId == skuId);
        }

        public async Task AddOrUpdateAsync(Inventory entity)
        {
            var existing = await _context.Inventories.FindAsync(entity.SkuId);
            if (existing == null)
            {
                _context.Inventories.Add(entity);
            }
            else
            {
                _context.Entry(existing).CurrentValues.SetValues(entity);
            }
            await _context.SaveChangesAsync();
        }
    }
} 