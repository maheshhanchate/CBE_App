using System.Linq;
using CBEApp.EntityFramework;
using CBEApp.MultiTenancy;

namespace CBEApp.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly CBEAppDbContext _context;

        public DefaultTenantCreator(CBEAppDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
