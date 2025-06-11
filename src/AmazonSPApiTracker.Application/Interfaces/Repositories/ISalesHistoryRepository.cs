using AmazonSPApiTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmazonSPApiTracker.Application.Interfaces.Repositories
{
    public interface ISalesHistoryRepository
    {
        Task<IReadOnlyList<SalesHistory>> GetBySkuIdAsync(string skuId, DateTime startDate, DateTime endDate);
        Task AddBatchAsync(IEnumerable<SalesHistory> entities);
    }
} 