using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.Data.Mapping
{
    public class CustomerGroupMap : EntityTypeConfiguration<CustomerGroup>
    {
        public CustomerGroupMap()
        {
            this.ToTable("CustomerGroup");

            this.HasKey(t => t.CustomerGroupID);
            this.Property(t => t.CustomerGroupID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.GroupName).IsRequired().HasMaxLength(50);
            this.Property(t => t.UpdatedBy).IsOptional().HasMaxLength(50);
            this.Property(t => t.CustomerGroupID).HasColumnName("CustomerGroupID");
            this.Property(t => t.GroupName).HasColumnName("GroupName");
            this.Property(t => t.GroupTypeID).HasColumnName("GroupTypeID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateEnd).HasColumnName("DateEnd");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
        }
    }
}

