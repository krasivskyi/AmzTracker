using AmazonSPApiTracker.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmazonSPApiTracker.Application.Interfaces.Repositories
{
    public interface ISkuRepository
    {
        Task<Sku> GetByIdAsync(string id);
        Task<IReadOnlyList<Sku>> GetAllAsync();
        Task AddAsync(Sku entity);
        Task UpdateAsync(Sku entity);
        Task DeleteAsync(string id);
    }
} 