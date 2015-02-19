using AcurenzAppFramework.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.DataAccess
{
    public class DriverLicenseStoreInitializer : DropCreateDatabaseAlways<DriverLicenseStoreContext>
    {
        protected override void Seed(DriverLicenseStoreContext context)
        {
            //IList<CustomerAddressType> defaultCustomerAddressTypes = new List<CustomerAddressType>();

            //defaultCustomerAddressTypes.Add(new CustomerAddressType() { DisplayCode = "Residence", Description = "Residence", Active = true, LookupCode = "Residence", DateUpdated = DateTime.Now, UpdatedBy = "Aravind" });
            //defaultCustomerAddressTypes.Add(new CustomerAddressType() { DisplayCode = "Office", Description = "Office", Active = true, LookupCode = "Office", DateUpdated = DateTime.Now, UpdatedBy = "Aravind" });

            //foreach (var addressType in defaultCustomerAddressTypes)
            //{
            //    context.Set<CustomerAddressType>().Add(addressType);
            //}
            //context.SaveChanges();

           // base.Seed(context);
        }
    }
}
