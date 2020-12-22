using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminSystemCodeFirst.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Staff
    {
        public int staffId { get; set; }
        public int businessUnitId { get; set; }
        public string staffCode { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public System.DateTime dob { get; set; }
        public System.DateTime startDate { get; set; }
        public string profile { get; set; }
        public string emailAddress { get; set; }
        public string PhotoUrl { get; set; }
        public bool Active { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; }
    }
}