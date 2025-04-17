namespace Hakaton.Services
{
    public interface IJwtService
    {
        public string GenerateToken(Guid userId);
    }
}
