using System.ComponentModel.DataAnnotations;

namespace UsersTenants.Api.Data.Models
{
  /// <summary>
  /// Main entity that represents an account/organization of one or several users, and subscribes to Sebastian's business services
  /// </summary>
  public class Tenant
  {

    #region Constructors

    /// <summary>
    /// Constructor
    /// </summary>
    public Tenant()
    {
      UserTenantRoles = new HashSet<UserTenantRole>();
    }

    #endregion

    #region Properties

    /// <summary>
    /// Primary key of the element
    /// </summary>
    [Key]
    [StringLength(36)]
    public string Id { get; set; }

    /// <summary>
    /// Tenant title
    /// </summary>
    [StringLength(200)]
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Creation date of the element
    /// </summary>
    public DateTime CreationDate { get; set; } = DateTime.Now;

    /// <summary>
    /// FK Id of user creator
    /// </summary>
    [StringLength(36)]
    public string IdCreator { get; set; }

    /// <summary>
    /// User creator
    /// </summary>
    public User Creator { get; set; }

    /// <summary>
    /// Postal address
    /// </summary>
    [StringLength(400)]
    public string? Address { get; set; }

    /// <summary>
    /// Telephone contact
    /// </summary>
    [StringLength(100)]
    public string? Phone { get; set; }

    /// <summary>
    /// Collection of roles in different user tenants
    /// </summary>
    public ICollection<UserTenantRole> UserTenantRoles { get; set; }

    #endregion
  }
}
