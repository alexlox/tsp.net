namespace EF_Studii_de_caz
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HierarchyModel : DbContext
    {
        public HierarchyModel()
            : base("name=HierarchyModel")
        {
        }

        public DbSet<Business> Businesses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
