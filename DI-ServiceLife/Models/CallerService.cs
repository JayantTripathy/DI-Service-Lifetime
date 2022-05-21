using DI_ServiceLife.Interfaces;

namespace DI_ServiceLife.Models
{
    // We Implement 3 DI Interfaces here
    public class CallerService : ITransientService, IScopedService, ISingletonService
    {
        Guid currentGUId;
        public CallerService()
        {
            currentGUId = Guid.NewGuid();
        }
        public Guid GetCurrentGUID()
        {
            return currentGUId;
        }
    }
}
