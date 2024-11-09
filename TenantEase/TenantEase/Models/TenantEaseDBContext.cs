using Microsoft.EntityFrameworkCore;

namespace TenantEase.Models
{
    public class TenantEaseDBContext : DbContext
    {
        public TenantEaseDBContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
