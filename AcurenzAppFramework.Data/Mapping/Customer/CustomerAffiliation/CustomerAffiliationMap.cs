using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.Data.Mapping
{
    public class CustomerAffiliationMap : EntityTypeConfiguration<CustomerAffiliation>
    {
        public CustomerAffiliationMap()
        {
            this.ToTable("CustomerAffiliation");

            HasRequired(t => t.CustomerAffiliationType).WithMany(t => t.CustomerAffiliations).HasForeignKey(t => t.CustomerAffiliationTypeID);
            HasRequired(t => t.CustomerGroup).WithMany(t => t.CustomerAffiliations).HasForeignKey(t => t.CustomerGroupID);
            HasRequired(t => t.Customer).WithMany(t => t.CustomerAffiliations).Map(t => t.MapKey("CustomerNumber")).WillCascadeOnDelete();

            this.HasKey(t => t.CustomerAffiliationID);
            this.Property(t => t.CustomerAffiliationID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);         
            this.Property(t => t.DateEffective).HasColumnName("DateEffective").IsRequired();
            this.Property(t => t.DateEnd).HasColumnName("DateEnd").IsOptional();
            this.Property(t => t.IsHeadOfGroup).HasColumnName("IsHeadOfGroup").IsRequired();
            this.Property(t => t.DateCreated).IsOptional().HasColumnName("DateCreated");
            this.Property(t => t.CustomerAffiliationID).HasColumnName("CustomerAffiliationID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
        }
    }
}
