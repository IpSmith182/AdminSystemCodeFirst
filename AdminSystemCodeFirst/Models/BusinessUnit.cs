using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminSystemCodeFirst.Models
{
    using System;
    using System.Collections.Generic;

    public partial class BusinessUnit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BusinessUnit()
        {
            this.Staffs = new HashSet<Staff>();
        }

        public int businessUnitId { get; set; }
        public string businessUnitCode { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string officeAddress1 { get; set; }
        public string officeAddresss2 { get; set; }
        public string officeAddress3 { get; set; }
        public string officePostCode { get; set; }
        public string officeContact { get; set; }
        public string officePhone { get; set; }
        public string officeEmail { get; set; }
        public Nullable<bool> Active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Staff> Staffs { get; set; }
    }
}