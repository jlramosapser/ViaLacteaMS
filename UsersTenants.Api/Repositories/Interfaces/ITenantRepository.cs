using UsersTenants.Api.Data.Models;

namespace UsersTenants.Repositories.Interfaces
{
    public interface ITenantRepository
  {
    /// <summary>
    /// Retrieves the total list of tenants. ONLY if it is the superadmin role it will also return the System tenant
    /// </summary>
    /// <param name="isSuperadmin">Indicates if it is a superadmin user</param>
    /// <returns>Tenants list</returns>
    List<Tenant> GetList(bool isSuperadmin);

    /// <summary>
    /// Retrieve a tenant by its id
    /// </summary>
    /// <param name="idTenant">Unique id of tenant</param>
    /// <returns>Tenant entity</returns>
    Task<Tenant?> GetItem(string idTenant);

  }
}
