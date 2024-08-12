using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp_FA_BSD_Training.Data;

public class BlazorApp_FA_BSD_TrainingContext : IdentityDbContext<IdentityUser>
{
    public BlazorApp_FA_BSD_TrainingContext(DbContextOptions<BlazorApp_FA_BSD_TrainingContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
