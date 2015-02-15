using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.Data.Mapping
{
    public class CustomerIdentificationMap : EntityTypeConfiguration<CustomerIdentification>
    {
        public CustomerIdentificationMap()
        {
            this.ToTable("CustomerIdentification");

            HasRequired(t => t.CustomerIdentificationType).WithMany(t => t.CustomerIdentifications).HasForeignKey(t => t.CustomerIdentificationTypeID);
            HasRequired(t => t.Customer).WithMany(t => t.CustomerIdentifications).Map(t => t.MapKey("CustomerNumber")).WillCascadeOnDelete();

            this.HasKey(t => t.CustomerIdentificationID);
            this.Property(t => t.CustomerIdentificationID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.IdentificationValue).HasColumnName("IdentificationValue").IsRequired().HasMaxLength(50);
            this.Property(t => t.DateOfIssue).HasColumnName("DateOfIssue").IsRequired();
            this.Property(t => t.StateOfIssue).HasColumnName("StateOfIssue").HasMaxLength(20);
            this.Property(t => t.CountryOfIssue).HasColumnName("CountryOfIssue").IsRequired().HasMaxLength(20);
            this.Property(t => t.DateEffective).HasColumnName("DateEffective").IsRequired();
            this.Property(t => t.DateEnd).HasColumnName("DateEnd").IsRequired();
            this.Property(t => t.DateCancelled).IsOptional().HasColumnName("DateCancelled");
            this.Property(t => t.DateCreated).IsOptional().HasColumnName("DateCreated");
            this.Property(t => t.CustomerIdentificationID).HasColumnName("CustomerIdentificationID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
        }
    }
}
