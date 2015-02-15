using AcurenzAppFramework.Data;
using AcurenzAppFramework.Data.Mapping;
using Repository.Providers.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.DataAccess
{
    public class DriverLicenseStoreContext : DbContextBase
    {
         public DriverLicenseStoreContext()
            : base("Name=DriverLicenseStoreContext")
        {
            Database.SetInitializer<DriverLicenseStoreContext>(new DropCreateDatabaseIfModelChanges<DriverLicenseStoreContext>());
            Configuration.ProxyCreationEnabled = false;
        }

         public new IDbSet<T> Set<T>() where T : class
         {
             return base.Set<T>();
         }

         public DbSet<LicenseType> LicenseTypes { get; set; }
         public DbSet<CustomerAddress> CustomerAddresses { get; set; }
         public DbSet<CustomerAddressType> CustomerAddressTypes { get; set; }
         public DbSet<CustomerAffiliation> CustomerAffiliations { get; set; }
         public DbSet<CustomerAffiliationType> CustomerAffiliationTypes { get; set; }
         public DbSet<CustomerBiometric> CustomerBiometrics { get; set; }
         public DbSet<Ethnicity> Ethnicities { get; set; }
         public DbSet<EyeColor> EyeColors { get; set; }
         public DbSet<Gender> Genders { get; set; }
         public DbSet<HairColor> HairColors { get; set; }
         public DbSet<Race> Races { get; set; }
         public DbSet<CustomerCharacteristics> CustomerCharacteristics { get; set; }
         public DbSet<CustomerCharacteristicType> CustomerCharacteristicTypes { get; set; }
         public DbSet<CustomerIdentification> CustomerIdentifications { get; set; }
         public DbSet<CustomerIdentificationType> CustomerIdentificationTypes { get; set; }
         public DbSet<Customer> Customers { get; set; }
         public DbSet<CustomerExtendedValues> CustomerExtendedValues { get; set; }
         public DbSet<CustomerGroup> CustomerGroups { get; set; }
         public DbSet<CustomerType> CustomerTypes { get; set; }

         protected override void OnModelCreating(DbModelBuilder modelBuilder)
         {
             modelBuilder.Configurations.Add(new LicenseTypeMap());
             modelBuilder.Configurations.Add(new PersonIdentificationMap());
             modelBuilder.Configurations.Add(new CustomerAddressMap());
             modelBuilder.Configurations.Add(new CustomerAddressTypeMap());
             modelBuilder.Configurations.Add(new CustomerAffiliationMap());
             modelBuilder.Configurations.Add(new CustomerAffiliationTypeMap());
             modelBuilder.Configurations.Add(new CustomerBiometricMap());
             modelBuilder.Configurations.Add(new EthnicityMap());
             modelBuilder.Configurations.Add(new EyeColorMap());
             modelBuilder.Configurations.Add(new GenderMap());
             modelBuilder.Configurations.Add(new HairColorMap());
             modelBuilder.Configurations.Add(new RaceMap());
             modelBuilder.Configurations.Add(new CustomerCharacteristicsMap());
             modelBuilder.Configurations.Add(new CustomerCharacteristicTypeMap());
             modelBuilder.Configurations.Add(new CustomerIdentificationMap());
             modelBuilder.Configurations.Add(new CustomerIdentificationTypeMap());
             modelBuilder.Configurations.Add(new CustomerMap());
             modelBuilder.Configurations.Add(new CustomerExtendedValuesMap());
             modelBuilder.Configurations.Add(new CustomerGroupMap());
             modelBuilder.Configurations.Add(new CustomerTypeMap());
         }
    }
}
