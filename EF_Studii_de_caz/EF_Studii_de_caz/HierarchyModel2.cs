namespace EF_Studii_de_caz
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HierarchyModel2 : DbContext
    {
        public HierarchyModel2()
            : base("name=HierarchyModel2")
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>()
                .Map<FullTimeEmployee>(m => m.Requires("EmployeeType")
                .HasValue(1))
                .Map<HourlyEmployee>(m => m.Requires("EmployeeType")
                .HasValue(2));
        }
    }
}
