using AmazonSPApiTracker.Application.Interfaces.Repositories;
using AmazonSPApiTracker.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace AmazonSPApiTracker.Infrastructure.Mocks
{
    public class MockInventoryRepository : IInventoryRepository
    {
        public Task AddOrUpdateAsync(Inventory entity)
        {
            // This is a mock, so we don't need to do anything here.
            return Task.CompletedTask;
        }

        public Task<Inventory> GetBySkuIdAsync(string skuId)
        {
            return Task.FromResult(new Inventory
            {
                SkuId = skuId,
                Fulfillable = 123,
                Inbound = 45,
                Reserved = 6,
                Researching = 7,
                LastUpdated = DateTime.UtcNow
            });
        }
    }
} 