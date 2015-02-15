using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.Data.Mapping
{
    public class CustomerExtendedValuesMap : EntityTypeConfiguration<CustomerExtendedValues>
    {
        public CustomerExtendedValuesMap()
        {
            this.ToTable("CustomerExtendedValues");

            this.HasKey(t => t.CustomerExtendedValuesID);
            this.Property(t => t.CustomerExtendedValuesID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.HasRequired(t => t.Customer).WithOptional().Map(t => t.MapKey("CustomerNumber")).WillCascadeOnDelete();
            this.Property(t => t.DateEnd).IsOptional().HasColumnName("DateEnd");
            this.Property(t => t.DateEffective).IsRequired().HasColumnName("DateEffective");
            this.Property(t => t.Key).IsRequired().HasColumnName("Key");
            this.Property(t => t.Value).IsOptional().HasColumnName("Value");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
        }
    }
}

