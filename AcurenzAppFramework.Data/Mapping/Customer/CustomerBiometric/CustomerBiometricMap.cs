using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.Data.Mapping
{
    public class CustomerBiometricMap : EntityTypeConfiguration<CustomerBiometric>
    {
        public CustomerBiometricMap()
        {
            this.ToTable("CustomerBiometric");

            HasRequired(t => t.Ethnicity).WithMany(t => t.CustomerBiometrics).HasForeignKey(t => t.EthnicityID);
            HasRequired(t => t.Gender).WithMany(t => t.CustomerBiometrics).HasForeignKey(t => t.GenderID);
            HasRequired(t => t.Race).WithMany(t => t.CustomerBiometrics).HasForeignKey(t => t.RaceID);
            HasRequired(t => t.HairColor).WithMany(t => t.CustomerBiometrics).HasForeignKey(t => t.HairColorID);
            HasRequired(t => t.EyeColor).WithMany(t => t.CustomerBiometrics).HasForeignKey(t => t.EyeColorID);
            HasRequired(t => t.Customer).WithMany(t => t.CustomerBiometrics).Map(t => t.MapKey("CustomerNumber")).WillCascadeOnDelete();

            this.HasKey(t => t.CustomerBiometricID);
            this.Property(t => t.CustomerBiometricID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.DateEffective).HasColumnName("DateEffective").IsRequired();
            this.Property(t => t.DateEnd).HasColumnName("DateEnd").IsOptional();
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.Height).HasColumnName("Height");
            this.Property(t => t.CustomerBiometricID).HasColumnName("CustomerBiometricID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
        }
    }
}
