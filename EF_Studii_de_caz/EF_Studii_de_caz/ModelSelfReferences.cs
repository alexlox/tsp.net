using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace EF_Studii_de_caz
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelSelfReferences : DbContext
    {
        public ModelSelfReferences()
            : base("name=ModelSelfReferences")
        {
        }

        public virtual DbSet<SelfReference> SelfReferences { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SelfReference>()
                .HasMany(m => m.References)
                .WithOptional(m => m.ParentSelfReference);
        }
    }
}
