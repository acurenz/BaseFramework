using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.Data
{
    public class CustomerAffiliation : EntityBase,IAuditableEntity
    {
        public int CustomerAffiliationID { get; set; }
        public int CustomerAffiliationTypeID { get; set; }
        public int CustomerGroupID { get; set; }
        public bool IsHeadOfGroup { get; set; }
        public DateTime DateEffective { get; set; }
        public DateTime DateEnd { get; set; }
        public DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }

        public virtual CustomerAffiliationType CustomerAffiliationType { get; set; }
        public virtual CustomerGroup CustomerGroup { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
