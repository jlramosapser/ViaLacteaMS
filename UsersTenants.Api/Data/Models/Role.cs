using System.ComponentModel.DataAnnotations;

namespace UsersTenants.Api.Data.Models
{
  /// <summary>
  /// Main entity that represents a role profile of user in a tenant
  /// </summary>
  public class Role
  {

    #region Constructors

    public Role()
    {
      UserTenantRoles = new HashSet<UserTenantRole>();
    }

    #endregion

    #region Properties

    /// <summary>
    /// Primary key of an element
    /// </summary>
    [Key]
    [StringLength(36)]
    public string Id { get; set; }

    /// <summary>
    /// Role unique name
    /// </summary>
    [StringLength(100)]
    public string Name { get; set; }

    /// <summary>
    /// Role description
    /// </summary>
    [StringLength(500)]
    public string? Description { get; set; }

    /// <summary>
    /// Collection of roles in different user tenants
    /// </summary>
    public ICollection<UserTenantRole> UserTenantRoles { get; set; }

    /// <summary>
    /// Creation date of the element
    /// </summary>
    public DateTime CreationDate { get; set; } = DateTime.Now;

    /// <summary>
    /// FK Id of user creator of the element
    /// </summary>
    [StringLength(36)]
    public string IdCreator { get; set; }

    /// <summary>
    /// User creator of the element
    /// </summary>
    public User Creator { get; set; }


    #endregion
  }
}
