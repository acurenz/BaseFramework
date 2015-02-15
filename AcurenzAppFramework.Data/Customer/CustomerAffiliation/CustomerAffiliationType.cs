using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.Data
{
    public class CustomerAffiliationType : EntityBase
    {
        public int CustomerAffiliationTypeID { get; set; }
        public string DisplayCode { get; set; }
        public string LookupCode { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime DateUpdated { get; set; }

        public virtual ICollection<CustomerAffiliation> CustomerAffiliations { get; set; }

    }
}
