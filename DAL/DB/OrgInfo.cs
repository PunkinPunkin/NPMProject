using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.DB
{
    public class OrgInfo
    {
        [Key]
        public int OrgId { get; set; }

        [Required]
        [MaxLength(20)]
        public string OrgName { get; set; }

        [MaxLength(100)]
        public string OrgAddress { get; set; }

    }
}
