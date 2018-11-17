using FreeSchool.Domain.Entities;
using FreeSchool.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
namespace FreeSchool.Infra.Data.Context
{
    public class FreeSchoolContext : DbContext
    {

        public FreeSchoolContext()
            : base("FreeSchool")
        {

        }

        public DbSet<Activity> Activity { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Curse> Curse { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<FrequencyJob> FrequencyJob { get; set; }
        public DbSet<ItemActivity> ItemActivity { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<JobRole> JobRole { get; set; }
        public DbSet<Module> Module { get; set; }
        public DbSet<ModulePerCurse> ModulePerCurse { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<PersonPerCurse> PersonPerCurse { get; set; }
        public DbSet<Responsible> Responsible { get; set; }
        public DbSet<School> School { get; set; }
        public DbSet<StatusStudent> StatusStudent { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Task> Task { get; set; }
        public DbSet<TypeAddress> TypeAddress { get; set; }
        public DbSet<TypeContact> TypeContact { get; set; }
        public DbSet<TypeDocument> TypeDocument { get; set; }
        public DbSet<TypeResponsible> TypeResponsible { get; set; }
        public DbSet<TypeStudent> TypeStudent { get; set; }
        public DbSet<TypeApprobationNote> TypeApprobationNote { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Worker> Worker { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add<Contact>(new ContactConfig());

            modelBuilder.Properties<string>().Configure(x => x.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(x => x.HasMaxLength(250));
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (DbEntityEntry entry in ChangeTracker.Entries().Where(x => x.Entity.GetType().GetProperty("UpdateDate") != null))
                if (entry.State == EntityState.Added || entry.State == EntityState.Modified)
                    entry.Property("UpdateDate").CurrentValue = DateTime.Now;

            foreach (DbEntityEntry entry in ChangeTracker.Entries().Where(x => x.Entity.GetType().GetProperty("DeleteDate") != null))
                if (entry.State == EntityState.Deleted)
                {
                    entry.Property("DeleteDate").CurrentValue = DateTime.Now;
                    entry.Property("IsDeleted").CurrentValue = true;
                }

            foreach (DbEntityEntry entry in ChangeTracker.Entries().Where(x => x.Entity.GetType().GetProperty("CreateDate") != null))
            {
                if (entry.State == EntityState.Added)
                    entry.Property("CreateDate").CurrentValue = DateTime.Now;

                if (entry.State == EntityState.Modified)
                    entry.Property("CreateDate").IsModified = false;
            }
            

            return base.SaveChanges();
        }
    }
}
