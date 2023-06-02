using System.ComponentModel.DataAnnotations;

namespace UsersTenants.Api.Data.Models
{
    /// <summary>
    /// Relationship class that shows the role of a user in a tenant
    /// </summary>
    public class UserTenantRole
    {

        #region Properties

        /// <summary>
        /// FK Id of user participating in the tenant
        /// </summary>
        [Key]
        [StringLength(36)]
        public string IdUser { get; set; }

        /// <summary>
        /// User participating in the tenant
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// FK Id of the tenant owner
        /// </summary>
        [Key]
        [StringLength(36)]
        public string IdTenant { get; set; }

        /// <summary>
        /// Tenant owner
        /// </summary>
        public Tenant Tenant { get; set; }

        /// <summary>
        /// FK Id role profile for user and tenant owner
        /// </summary>
        [Key]
        [StringLength(36)]
        public string IdRole { get; set; }

        /// <summary>
        /// Role profile for user and tenant owner
        /// </summary>
        public Role Role { get; set; }

        /// <summary>
        /// Creation date of the element
        /// </summary>
        public DateTime CreationDate { get; set; }

        #endregion

    }
}
