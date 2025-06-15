using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WebWhatsAppClone.DataBase.Entities;

namespace WebWhatsAppClone.DataBase
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<FileCategory> FileCategories { get; set; }
    }
}
