using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.Data
{
    public class CustomerBiometric : EntityBase
    {
        public int CustomerBiometricID { get; set; }
        public int GenderID { get; set; }
        public int HairColorID { get; set; }
        public int EyeColorID { get; set; }
        public int RaceID { get; set; }
        public int EthnicityID { get; set; }
        public double Weight { get; set; }
        public string Height { get; set; }
        public DateTime DateEffective { get; set; }
        public DateTime DateEnd { get; set; }
        public DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Gender Gender { get; set; }
        public virtual HairColor HairColor { get; set; }
        public virtual EyeColor EyeColor { get; set; }
        public virtual Race Race { get; set; }
        public virtual Ethnicity Ethnicity { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
