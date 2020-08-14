using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class NpmItemWorksRelation
    {
        public int RelationId { get; set; }
        public int PaintingId { get; set; }
        public int ItemId { get; set; }
        public string Creator { get; set; }
        public string CreatedIp { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastModifier { get; set; }
        public string LastModifiedIp { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual NpmItem Item { get; set; }
        public virtual NpmPainting Painting { get; set; }
    }
}
