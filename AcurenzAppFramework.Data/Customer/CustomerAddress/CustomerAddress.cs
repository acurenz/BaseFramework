using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.Data
{
    public class CustomerAddress : EntityBase,IAuditableEntity
    {
        public long CustomerAddressID { get; set; }
        public int CustomerAddressTypeID { get; set; }
        public string ContactName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string County { get; set; }
        public string CountryCode { get; set; }
        public bool IsVerified { get; set; }
        public bool AcceptDelivery { get; set; }
        public DateTime DateEffective { get; set; }
        public DateTime? DateEnd { get; set; }
        public DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public long CustomerNumber { get; set; }

        public virtual CustomerAddressType CustomerAddressType { get; set; }
        public virtual Customer Customer { get; set; }

    }
}