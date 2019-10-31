using FutureAgro.DataAccess.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FutureAgro.DataAccess.Data
{
    public class FutureAgroIdentityDbContext : IdentityDbContext<IdentityUser>
    {
        public FutureAgroIdentityDbContext(DbContextOptions<FutureAgroIdentityDbContext> options)
            : base(options)
        {
        }

        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<Planta> Plantas { get; set; }

        /*B-ContextoDbSets*/

/*Code injected by: Crecimiento_ContextoDbSets*/
public DbSet<Crecimiento> Crecimientos { get; set; }
/*Code injected by: Crecimiento_ContextoDbSets*/


/*Code injected by: ControlAmbienteBase_ContextoDbSets*/
public DbSet<Medida> Medidas { get; set; }
/*Code injected by: ControlAmbienteBase_ContextoDbSets*/

        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
