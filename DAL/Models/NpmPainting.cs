using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class NpmPainting
    {
        public NpmPainting()
        {
            NpmItemWorksRelation = new HashSet<NpmItemWorksRelation>();
            NpmPCollection = new HashSet<NpmPCollection>();
            NpmPSubject = new HashSet<NpmPSubject>();
            NpmPTitle = new HashSet<NpmPTitle>();
        }

        public int PaintingId { get; set; }
        public int? OriginalPaintingId { get; set; }
        public string Palace { get; set; }
        public string Catalog { get; set; }
        public string ItemNo { get; set; }
        public string ItemAddedNo { get; set; }
        public string Type { get; set; }
        public int? SeriesId { get; set; }
        public int? OldSeriesId { get; set; }
        public int? OldSeriesTypeId { get; set; }
        public string SeriesType { get; set; }
        public string SeriesJian { get; set; }
        public string SeriesKai { get; set; }
        public string SeriesFu { get; set; }
        public string Transcription { get; set; }
        public string CreatationTime { get; set; }
        public string CheckFinish { get; set; }
        public string DataOpen { get; set; }
        public string Checker { get; set; }
        public DateTime? CheckDate { get; set; }
        public string Quantity { get; set; }
        public string Creator { get; set; }
        public string CreatedIp { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastModifier { get; set; }
        public string LastModifiedIp { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual ICollection<NpmItemWorksRelation> NpmItemWorksRelation { get; set; }
        public virtual ICollection<NpmPCollection> NpmPCollection { get; set; }
        public virtual ICollection<NpmPSubject> NpmPSubject { get; set; }
        public virtual ICollection<NpmPTitle> NpmPTitle { get; set; }
    }
}
