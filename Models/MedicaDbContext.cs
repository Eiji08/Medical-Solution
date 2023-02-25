using Microsoft.EntityFrameworkCore;
namespace Medical_Solution.Models
{
    public class MedicaDbContext : DbContext
    {
        public MedicaDbContext(DbContextOptions<MedicaDbContext> options)
        : base(options)
        {
        }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Ocupacion> Ocupacion { get; set; }
        public DbSet<Medico> Medico { get; set; }
        public DbSet<Forma_de_Pago> Forma_De_Pagos { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Cita> Cita { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Medical_Solution;Trusted_Connection=True;");
        }

    }
}
    
