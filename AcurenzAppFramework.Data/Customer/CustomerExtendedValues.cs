using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.Data
{
    public class CustomerExtendedValues : EntityBase
    {
        public int CustomerExtendedValuesID { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public DateTime DateEffective { get; set; }
        public DateTime DateEnd { get; set; }
        public DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        
        public virtual Customer Customer { get; set; }
    }
}
