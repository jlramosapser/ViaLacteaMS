using Microsoft.EntityFrameworkCore;
using System.Security.Principal;
using UsersTenants.Api.Data.Models;

namespace UsersTenants.Api.Data
{
    public class UsersTenantsContext : DbContext
  {
    public UsersTenantsContext(DbContextOptions<UsersTenantsContext> options) : base(options)
    {
    }

    public virtual DbSet<Tenant> Tenants { get; set; }
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Role> Roles { get; set; }
    public virtual DbSet<UserTenantRole> UserTenantRoles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<Tenant>(entity =>
      {
        entity.ToTable("Tenants");
        entity.HasOne(t => t.Creator)
          .WithMany(u => u.CreatedTenants)
          .HasForeignKey(a => a.IdCreator)
          .OnDelete(DeleteBehavior.Restrict)
          .HasConstraintName("FK_Tenant_Creator");
      });

      modelBuilder.Entity<User>(entity => {
        entity.ToTable("Users");
      });

      modelBuilder.Entity<Role>(entity =>
      {
        entity.ToTable("Roles");
        entity.HasOne(r => r.Creator)
          .WithMany(u => u.CreatedRoles)
          .HasForeignKey(r => r.IdCreator)
          .OnDelete(DeleteBehavior.Restrict)
          .HasConstraintName("FK_Role_Creator");
      });

      modelBuilder.Entity<UserTenantRole>(entity =>
      {
        entity.ToTable("UserTenantRoles");

        entity.HasKey(utr => new { utr.IdUser, utr.IdTenant, utr.IdRole });

        entity.HasOne(utr => utr.User)
          .WithMany(u => u.UserTenantRoles)
          .HasForeignKey(utr => utr.IdUser)
          .OnDelete(DeleteBehavior.Cascade)
          .HasConstraintName("FK_UserTenantRole_User");

        entity.HasOne(utr => utr.Tenant)
          .WithMany(t => t.UserTenantRoles)
          .HasForeignKey(utr => utr.IdTenant)
          .OnDelete(DeleteBehavior.Cascade)
          .HasConstraintName("FK_UserTenantRole_Tenant");

        entity.HasOne(utr => utr.Role)
          .WithMany(r => r.UserTenantRoles)
          .HasForeignKey(utr => utr.IdRole)
          .OnDelete(DeleteBehavior.Cascade)
          .HasConstraintName("FK_UserTenantRole_Role");

      });
    }
  }
}
