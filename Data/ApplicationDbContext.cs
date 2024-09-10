using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WashCar.Models;

namespace WashCar.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WashCar.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<WashCar.Models.Funcionario> Funcionario { get; set; } = default!;
        public DbSet<WashCar.Models.Carro> Carro { get; set; } = default!;
        public DbSet<WashCar.Models.Lavagem> Lavagem { get; set; } = default!;
        public DbSet<WashCar.Models.Recibo> Recibo { get; set; } = default!;
    }
}
