using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcurenzAppFramework.Data
{
    public class CustomerIdentification : EntityBase,IAuditableEntity
    {
        public int CustomerIdentificationID { get; set; }
        public int CustomerIdentificationTypeID { get; set; }
        public string IdentificationValue { get; set; }
        public DateTime DateOfIssue { get; set; }
        public string StateOfIssue { get; set; }
        public string CountryOfIssue { get; set; }
        public bool IsVerified { get; set; }
        public DateTime DateEffective { get; set; }
        public DateTime DateEnd { get; set; }
        public DateTime DateCancelled { get; set; }
        public DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }

        public virtual CustomerIdentificationType CustomerIdentificationType { get; set; }
        public virtual Customer Customer { get; set; }
    }
}