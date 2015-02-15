using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.Data
{
    public interface IAuditableEntity
    {
        DateTime DateUpdated { get; set; }
        string UpdatedBy { get; set; }
        DateTime DateCreated { get; set; }
        string CreatedBy { get; set; }
    }
}
