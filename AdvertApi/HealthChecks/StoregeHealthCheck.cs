using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AdvertApi.Services;

namespace AdvertApi.HealthChecks
{
    public class StoregeHealthCheck : IHealthCheck
    {
        private readonly IAdvertStorageService _storageService;

        public StoregeHealthCheck(IAdvertStorageService storageService)
        {
            _storageService = storageService;
        }

        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            var isStorageOk = await _storageService.CheckHealthAsync();
            return isStorageOk ? HealthCheckResult.Healthy() : HealthCheckResult.Unhealthy();
        }
    }
}
