
using System.ComponentModel.DataAnnotations;

namespace UsersTenants.Api.Data.Models
{
    /// <summary>
    /// Main actor of the system, which performs business actions
    /// </summary>
    public class User
    {
        #region Constructors

        public User()
        {
            UserTenantRoles = new HashSet<UserTenantRole>();
            CreatedTenants = new HashSet<Tenant>();
            CreatedRoles = new HashSet<Role>();
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
        /// User's birthday
        /// </summary>
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// User's firstname
        /// </summary>
        [StringLength(100)]
        public string? FirstName { get; set; }

        /// <summary>
        /// User's lastname
        /// </summary>
        [StringLength(100)]
        public string? LastName { get; set; }

        /// <summary>
        /// User's nickname
        /// </summary>
        [StringLength(100)]
        public string? NickName { get; set; }

        /// <summary>
        /// User's telephone number
        /// </summary>
        [StringLength(100)]
        public string? Phone { get; set; }

        /// <summary>
        /// User's email
        /// </summary>
        [StringLength(200)]
        public string? Email { get; set; }

        /// <summary>
        /// User registration date in the system
        /// </summary>
        public DateTime? RegistrationDate { get; set; }

        /// <summary>
        /// Indicates if the user has accepted the legal terms proposed by the system
        /// </summary>
        public bool LegalTermsAccepted { get; set; }

        /// <summary>
        /// Indicates if the user is enabled or disabled
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Collection of roles in different user tenants
        /// </summary>
        public ICollection<UserTenantRole> UserTenantRoles { get; set; }

        /// <summary>
        /// Collection of created tenants by this user
        /// </summary>
        public ICollection<Tenant> CreatedTenants { get; set; }

        /// <summary>
        /// Collection of created roles by this user
        /// </summary>
        public ICollection<Role> CreatedRoles { get; set; }

        #endregion

    }
}
