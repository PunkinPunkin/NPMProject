using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class NpmPCollection
    {
        public int CollectionId { get; set; }
        public int PaintingId { get; set; }
        public int? OriginalPaintingId { get; set; }
        public int? CollectionTypeId { get; set; }
        public string CollectionType { get; set; }
        public string Creator { get; set; }
        public string CreatedIp { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastModifier { get; set; }
        public string LastModifiedIp { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual NpmPainting Painting { get; set; }
    }
}
