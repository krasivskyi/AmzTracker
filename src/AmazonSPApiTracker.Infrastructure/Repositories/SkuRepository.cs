using AmazonSPApiTracker.Application.Interfaces.Repositories;
using AmazonSPApiTracker.Domain.Entities;
using AmazonSPApiTracker.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmazonSPApiTracker.Infrastructure.Repositories
{
    public class SkuRepository : ISkuRepository
    {
        private readonly ApplicationDbContext _context;

        public SkuRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Sku?> GetByIdAsync(string id)
        {
            return await _context.Skus.FindAsync(id);
        }

        public async Task<IReadOnlyList<Sku>> GetAllAsync()
        {
            return await _context.Skus.ToListAsync();
        }

        public async Task AddAsync(Sku entity)
        {
            await _context.Skus.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Sku entity)
        {
            _context.Skus.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _context.Skus.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
} 