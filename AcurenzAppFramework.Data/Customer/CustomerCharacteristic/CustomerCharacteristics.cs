using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.Data
{
    public class CustomerCharacteristics : EntityBase,IAuditableEntity
    {
        public int CustomerCharacteristicsID { get; set; }
        public int CustomerCharacteristicsTypeID { get; set; }
        public DateTime DateEffective { get; set; }
        public DateTime DateEnd { get; set; }
        public DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }

        public virtual CustomerCharacteristicType CustomerCharactersticType { get; set; }
        public virtual Customer Customer { get; set; }
    }
}