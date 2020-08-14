using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class NpmPSubject
    {
        public int SubjectId { get; set; }
        public int PaintingId { get; set; }
        public int? OriginalPaintingId { get; set; }
        public int? SubjectTypeId { get; set; }
        public int? SubjectId1 { get; set; }
        public int? SubjectId2 { get; set; }
        public string SubjectType { get; set; }
        public string Subject1 { get; set; }
        public string Subject2 { get; set; }
        public string Description { get; set; }
        public int? Sequence { get; set; }
        public string Creator { get; set; }
        public string CreatedIp { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastModifier { get; set; }
        public string LastModifiedIp { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual NpmPainting Painting { get; set; }
    }
}
