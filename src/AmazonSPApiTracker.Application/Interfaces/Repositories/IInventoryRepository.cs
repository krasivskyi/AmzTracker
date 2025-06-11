using AmazonSPApiTracker.Domain.Entities;
using System.Threading.Tasks;

namespace AmazonSPApiTracker.Application.Interfaces.Repositories
{
    public interface IInventoryRepository
    {
        Task<Inventory?> GetBySkuIdAsync(string skuId);
        Task AddOrUpdateAsync(Inventory entity);
    }
} 