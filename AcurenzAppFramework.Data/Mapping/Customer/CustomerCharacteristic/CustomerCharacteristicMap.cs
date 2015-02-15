using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.Data.Mapping
{
    public class CustomerCharacteristicsMap : EntityTypeConfiguration<CustomerCharacteristics>
    {
        public CustomerCharacteristicsMap()
        {
            this.ToTable("CustomerCharacteristics");

            HasRequired(t => t.CustomerCharactersticType).WithMany(t => t.CustomerCharacteristics).HasForeignKey(t => t.CustomerCharacteristicsTypeID);
            HasRequired(t => t.Customer).WithMany(t => t.CustomerCharacteristics).Map(t => t.MapKey("CustomerNumber")).WillCascadeOnDelete();


            this.HasKey(t => t.CustomerCharacteristicsID);
            this.Property(t => t.CustomerCharacteristicsID)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.DateEffective).HasColumnName("DateEffective")
                .IsRequired();

            this.Property(t => t.DateEnd).HasColumnName("DateEnd")
                .IsOptional();

            this.Property(t => t.DateCreated)
                .IsOptional().HasColumnName("DateCreated");

            this.Property(t => t.CustomerCharacteristicsID).HasColumnName("CustomerCharacteristicsID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
        }
    }
}
