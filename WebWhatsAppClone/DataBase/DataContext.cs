using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WebWhatsAppClone.DataBase.Base;
using File = WebWhatsAppClone.DataBase.Entities.File;
using WebWhatsAppClone.DataBase.Entities;

namespace WebWhatsAppClone.DataBase
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<FileCategory> FileCategories { get; set; }
        public DbSet<FileFormat> FileFormats { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Continent> Continents { get; set; }
        public DbSet<Region> Regions { get; set; }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entity_entries = ChangeTracker.Entries<AuditableEntity<Guid, DateTimeOffset>>();

            foreach (var entity_entry in entity_entries)
            {
                switch (entity_entry.State)
                {
                    case EntityState.Added:
                        entity_entry.Entity.created_at = DateTimeOffset.UtcNow;
                        break;

                    case EntityState.Modified:
                        entity_entry.Entity.is_updated = true;  
                        entity_entry.Entity.updated_at = DateTimeOffset.UtcNow;
                        break;

                    case EntityState.Deleted:
                        entity_entry.State = EntityState.Modified;
                        entity_entry.Entity.is_deleted = true;
                        entity_entry.Entity.deleted_at = DateTimeOffset.UtcNow;
                        break;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
