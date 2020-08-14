using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class OrgInfos
    {
        public int OrgId { get; set; }
        public string OrgName { get; set; }
        public string OrgAddress { get; set; }
        public string OrgPhone { get; set; }
    }
}
