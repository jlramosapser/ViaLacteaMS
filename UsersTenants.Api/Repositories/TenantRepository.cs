using Microsoft.EntityFrameworkCore;
using System.Security.Principal;
using UsersTenants.Api.Data;
using UsersTenants.Api.Data.Models;
using UsersTenants.Repositories.Interfaces;

namespace UsersTenants.Repositories
{
    public class TenantRepository : ITenantRepository
  {
    protected UsersTenantsContext _context;

    public TenantRepository(UsersTenantsContext context)
    {
      _context = context;
    }

    public List<Tenant> GetList(bool isSuperadmin)
    {
      try
      {
        List<Tenant> tenants = new List<Tenant>();
        tenants = _context.Tenants.ToList();
        return tenants;
      }
      catch (Exception)
      {
        throw;
      }
    }

    public async Task<Tenant?> GetItem(string idTenant)
    {
      try
      {
        Tenant? tenant = await _context.Tenants.FirstOrDefaultAsync(t => t.Id.Equals(idTenant));
        return tenant;
      }
      catch (Exception)
      {
        throw;
      }
    }

  }
}
