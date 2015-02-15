using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcurenzAppFramework.Data
{
    public class Customer : EntityBase,IAuditableEntity
    {
        public int CustomerID { get; set; }
        public long CustomerNumber { get; set; }
        public int CustomerTypeID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string OrganizationName { get; set; }
        public DateTime DOB { get; set; }
        public bool Active { get; set; }
        public DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }

        public virtual CustomerType CustomerType { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
        public virtual ICollection<CustomerIdentification> CustomerIdentifications { get; set; }
        public virtual ICollection<CustomerBiometric> CustomerBiometrics { get; set; }
        public virtual ICollection<CustomerCharacteristics> CustomerCharacteristics { get; set; }
        public virtual ICollection<CustomerAffiliation> CustomerAffiliations { get; set; }

        
    }
}