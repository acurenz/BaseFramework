using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.Data.Mapping
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            this.ToTable("Customer");

            HasRequired(t => t.CustomerType).WithMany(t => t.Customers).HasForeignKey(t => t.CustomerTypeID);

            this.HasKey(t => t.CustomerID);
            this.Property(t => t.CustomerID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.CustomerNumber).HasColumnName("CustomerNumber").IsRequired();
            this.Property(t => t.DateCreated).IsRequired().HasColumnName("DateCreated");
            this.Property(t => t.FirstName).HasColumnName("FirstName").IsRequired().HasMaxLength(50);
            this.Property(t => t.LastName).HasColumnName("LastName").IsRequired().HasMaxLength(50);
            this.Property(t => t.MiddleName).HasColumnName("MiddleName").IsOptional().HasMaxLength(50);
            this.Property(t => t.OrganizationName).HasColumnName("OrganizationName").IsOptional().HasMaxLength(150);
            this.Property(t => t.DOB).IsRequired().HasColumnName("DOB");
            this.Property(t => t.Active).IsRequired().HasColumnName("Active");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
        }
    }
}
