using Microsoft.EntityFrameworkCore;
using School.Helper;
using School.Students.Domain;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace School.Shared
{
    public class SchoolContext : DbContext
    { 
        public virtual DbSet<Student> Student { get; set; }
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }
        public override int SaveChanges()
        {
            MakeAudit();
            return base.SaveChanges();
        }
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            MakeAudit();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            MakeAudit();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            MakeAudit();
            return base.SaveChangesAsync(cancellationToken);
        }
        private void MakeAudit()
        {
            var modifiedEntries = ChangeTracker.Entries().Where(
                x => x.Entity is AuditEntity
                && (
                    x.State == EntityState.Added
                    || x.State == EntityState.Modified
                )
            );

            foreach (var entry in modifiedEntries)
            {
                var entity = entry.Entity as AuditEntity;

                if(entity != null)
                {
                    var date = DateTime.UtcNow;
                    //var userId = _currentUser.Get.UserId

                    if(entry.State == EntityState.Added)
                    {
                        entity.CreatedAt = date;
                        //entity.CreatedBy = userId;
                    }
                    else if(entity is ISoftDeleted && ((ISoftDeleted)entity).IsDeleted)
                    {
                        entity.DeletedAt = date;
                        //entity.DeletedBy = userId;
                    }
                    Entry(entity).Property(x => x.CreatedAt).IsModified = false;
                    //Entry(entity).Property(x => x.CreatedBy).IsModified = false;

                    entity.UpdatedAt = date;
                    //entity.UpdatedBy = userId;
                }
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            AddMyFilters(ref modelBuilder);
        }

        private void AddMyFilters(ref ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasQueryFilter(p => !p.IsDeleted);
        }
    }
}
