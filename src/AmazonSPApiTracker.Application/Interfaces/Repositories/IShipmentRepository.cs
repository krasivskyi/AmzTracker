using AmazonSPApiTracker.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmazonSPApiTracker.Application.Interfaces.Repositories
{
    public interface IShipmentRepository
    {
        Task<Shipment> GetByIdAsync(string shipmentId);
        Task<IReadOnlyList<Shipment>> GetBySkuAsync(string skuId);
        Task AddAsync(Shipment entity);
        Task UpdateAsync(Shipment entity);
    }
} 