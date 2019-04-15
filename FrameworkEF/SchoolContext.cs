using System.Data.Entity;

namespace FrameworkEF
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name=SchoolDBConnectionString")
        {
            //Database.SetInitializer<SchoolContext>(new CreateDatabaseIfNotExists<SchoolContext>());
            //Database.SetInitializer<SchoolContext>(new DropCreateDatabaseIfModelChanges<SchoolContext>());
            //Database.SetInitializer<SchoolContext>(new DropCreateDatabaseAlways<SchoolContext>());
        }

        //public DbSet<Student> Students { get; set; }
        //public DbSet<Address> Address { get; set; }

        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Classes> Classes { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Student>().HasOptional(S => S.Address).WithRequired(s => s.Student);
           
            // modelBuilder.Entity<Teachers>().HasMany(x => x.Class).WithRequired(x => x.Teacher);

           // modelBuilder.Entity<Student>().HasMany(s => s.Classes).WithMany(c => c.Students)
            //    .Map(cs =>
            //{
            //    cs.MapLeftKey("StudentRefId");
            //    cs.MapRightKey("CourseRefId");
            //    cs.ToTable("StudentCourse");
            //});
        }

    }
}

