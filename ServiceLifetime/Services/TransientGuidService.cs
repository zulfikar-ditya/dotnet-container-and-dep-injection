namespace ServiceLifetime.Services
{
    public class TransientGuidService : TransientGuidServiceInterface
    {
        private readonly Guid ID;

        public TransientGuidService()
        {
            ID = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return ID.ToString();
        }
    }
}
