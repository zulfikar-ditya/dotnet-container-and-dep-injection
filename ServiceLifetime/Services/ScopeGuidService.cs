namespace ServiceLifetime.Services
{
    public class ScopeGuidService: ScopeGuidServiceInterface
    {
        private readonly Guid ID;

        public ScopeGuidService()
        {
            ID = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return ID.ToString();
        }
    }
}
