using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.Data.Mapping
{
    public class CustomerAddressMap : EntityTypeConfiguration<CustomerAddress>
    {
        public CustomerAddressMap()
        {
            this.ToTable("CustomerAddress");

            HasRequired(t => t.CustomerAddressType).WithMany(t => t.CustomerAddresses).HasForeignKey(t => t.CustomerAddressTypeID);
            HasRequired(t => t.Customer).WithMany(t => t.CustomerAddresses).Map(t => t.MapKey("CustomerNumber")).WillCascadeOnDelete();
            //HasRequired(t => t.Customer).WithMany().HasForeignKey(t => t.CustomerNumber).WillCascadeOnDelete();

            this.HasKey(t => t.CustomerAddressID);
            this.Property(t => t.CustomerAddressID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.ContactName).HasColumnName("ContactName").IsRequired();
            this.Property(t => t.Address1).HasColumnName("Address1").IsRequired().HasMaxLength(50);
            this.Property(t => t.Address2).HasColumnName("Address2").IsOptional().HasMaxLength(50);
            this.Property(t => t.City).HasColumnName("City").IsRequired().HasMaxLength(30);
            this.Property(t => t.State).HasColumnName("State").IsRequired().HasMaxLength(30);
            this.Property(t => t.ZipCode).HasColumnName("ZipCode").IsRequired().HasMaxLength(30);
            this.Property(t => t.DateEffective).HasColumnName("DateEffective").IsRequired();
            this.Property(t => t.DateEnd).HasColumnName("DateEnd").IsOptional();
            this.Property(t => t.AcceptDelivery).IsRequired().HasColumnName("AcceptDelivery");
            this.Property(t => t.DateCreated).IsOptional().HasColumnName("DateCreated");
            this.Property(t => t.CustomerAddressID).HasColumnName("CustomerAddressID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Ignore(t => t.CustomerNumber);
        }
    }
}
