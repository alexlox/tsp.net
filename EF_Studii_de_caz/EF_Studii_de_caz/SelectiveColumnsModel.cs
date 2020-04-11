namespace EF_Studii_de_caz
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SelectiveColumnsModel : DbContext
    {
        public SelectiveColumnsModel()
            : base("name=SelectiveColumnsModel")
        {
        }

        public DbSet<Photograph> Photographs { get; set; }
        public DbSet<PhotographFullImage> PhotographFullImages { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Photograph>()
                .HasRequired(p => p.PhotographFullImage)
                .WithRequiredPrincipal(p => p.Photograph);
            modelBuilder.Entity<Photograph>()
                .ToTable("Photograph", "ef_studii_de_caz");
            modelBuilder.Entity<PhotographFullImage>()
                .ToTable("Photograph", "ef_studii_de_caz");
        }
    }
}
