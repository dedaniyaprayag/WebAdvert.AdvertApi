using AdvertApi.Services;
using Microsoft.Extensions.HealthChecks;
using System.Threading;
using System.Threading.Tasks;

namespace AdvertApi.HealthChecks
{
    public class StorageHealthChceks : IHealthCheck
    {
        private readonly IAdvertStorageService _storageService;

        public StorageHealthChceks(IAdvertStorageService storageService)
        {
            _storageService = storageService;
        }

        public async ValueTask<IHealthCheckResult> CheckAsync(CancellationToken cancellationToken = default)
        {
            var isStorageOk = await _storageService.CheckHealthAsync();
            return HealthCheckResult.FromStatus(isStorageOk ? CheckStatus.Healthy : CheckStatus.Unhealthy, "");
        }     
    }
}
