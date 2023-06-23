using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FinanceTaskOne.Configurations;

namespace FinanceTaskOne.Context
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> Context) : base(Context)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
        }
        public DbSet<FinanceTaskOne.Models.RegisterModel>? User { get; set; }

        public DbSet<FinanceTaskOne.Models.LoginModel>? LoginModel { get; set; }

        public DbSet<FinanceTaskOne.Models.Products>? MasterTbl_Products { get; set; }

        public DbSet<FinanceTaskOne.Models.Category>? MasterTbl_Category { get; set; }
    }
}
