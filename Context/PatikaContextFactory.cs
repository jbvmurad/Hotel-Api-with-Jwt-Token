using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PatikaTask.Context
{
    public class PatikaContextFactory : IDesignTimeDbContextFactory<PatikaContext>
    {
        public PatikaContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PatikaContext>();

            optionsBuilder.UseSqlServer("Server=DESKTOP-2UJR7J7\\SQLEXPRESS ; Database=Patika; Integrated Security=true; TrustServerCertificate=true");

            return new PatikaContext(optionsBuilder.Options);
        }
    }
}
