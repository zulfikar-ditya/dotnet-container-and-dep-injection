using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace ServiceLifetime.Services
{
    public class SingletonGuidService : SingletonGuidServiceInterface
    {
        private readonly Guid ID;

        public SingletonGuidService() {
            ID = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return ID.ToString();
        }
    }
}
