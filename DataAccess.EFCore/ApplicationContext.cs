using Domain.Entities;
using Microsoft.EntityFrameworkCore;
//using Domain.Entities;

namespace DataAccess.EFCore
{
    public class ApplicationContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options">Options that are provided in the configuration</param>
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base (options)
        { 
        }

        // We register the models/entities to the Db context
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
