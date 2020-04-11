namespace EF_Studii_de_caz
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public class EF6RecipesContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public EF6RecipesContext() : base("name=EF6RecipesContext")
        { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .Map(m =>
            {
                m.Properties(p => new { p.SKU, p.Description, p.Price });
                m.ToTable("Product", "ef_studii_de_caz");
            })
            .Map(m =>
            {
                m.Properties(p => new { p.SKU, p.ImageURL });
                m.ToTable("ProductWebInfo", "ef_studii_de_caz");
            });
        }
    }
}
