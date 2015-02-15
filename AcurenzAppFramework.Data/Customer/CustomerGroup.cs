using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.Data
{
    public class CustomerGroup : EntityBase
    {
        public int CustomerGroupID { get; set; }
        public string GroupName { get; set; }
        public string GroupTypeID { get; set; }
        public string DateCreated { get; set; }
        public bool DateEnd { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime DateUpdated { get; set; }

        public virtual ICollection<CustomerAffiliation> CustomerAffiliations { get; set; }
    }
}
