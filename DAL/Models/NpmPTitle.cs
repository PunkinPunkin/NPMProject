using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class NpmPTitle
    {
        public int TitleId { get; set; }
        public int PaintingId { get; set; }
        public int? OriginalPaintingId { get; set; }
        public int? TitleTypeId { get; set; }
        public string TitleType { get; set; }
        public string Title { get; set; }
        public string Creator { get; set; }
        public string CreatedIp { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastModifier { get; set; }
        public string LastModifiedIp { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual NpmPainting Painting { get; set; }
    }
}
