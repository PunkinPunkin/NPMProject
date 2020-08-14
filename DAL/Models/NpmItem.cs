using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class NpmItem
    {
        public NpmItem()
        {
            NpmItemWorksRelation = new HashSet<NpmItemWorksRelation>();
        }

        public int ItemId { get; set; }
        public string Palace { get; set; }
        public string Catalog { get; set; }
        public string ItemNo { get; set; }
        public string ItemAddedNo { get; set; }
        public int? OriginalItemId { get; set; }
        public string ItemNoStart { get; set; }
        public string ItemNoEnd { get; set; }
        public string SouthRegisterNo { get; set; }
        public string Nationality { get; set; }
        public string LiteratureNo { get; set; }
        public string DepartmentNo { get; set; }
        public string OriginalSource { get; set; }
        public string Source { get; set; }
        public string RegisterType { get; set; }
        public string OriginalCollectUnit { get; set; }
        public string OriginalCollector { get; set; }
        public string OriginalTitleName { get; set; }
        public string TitleName { get; set; }
        public string Department { get; set; }
        public string Era { get; set; }
        public string AcceptedDate { get; set; }
        public string TransferDate { get; set; }
        public string OriginalNo { get; set; }
        public string SubOriginalNo { get; set; }
        public string UtensilsChkRptName { get; set; }
        public string OriginalRegNo { get; set; }
        public string TotalRegisterNo1 { get; set; }
        public string TotalRegisterNo2 { get; set; }
        public string TotalRegisterNo3 { get; set; }
        public string TotalRegisterNo4 { get; set; }
        public string OriginalRegGroupNo { get; set; }
        public string TotalRegisterNoStart { get; set; }
        public string TotalRegisterNoEnd { get; set; }
        public int? Quantity { get; set; }
        public string OriginalPrice { get; set; }
        public int? Ntcurrency { get; set; }
        public string ForeignCurrencyType { get; set; }
        public int? ForeignCurrency { get; set; }
        public string OriginalTwPost { get; set; }
        public string TaiwanBox1 { get; set; }
        public string TaiwanBox2 { get; set; }
        public string TaiwanBox3 { get; set; }
        public string OriginalShPost { get; set; }
        public string ShanghaiBox1 { get; set; }
        public string ShanghaiBox2 { get; set; }
        public string Material { get; set; }
        public string Shape { get; set; }
        public string TempClass { get; set; }
        public string VerifiedClass { get; set; }
        public string VerifiedDate { get; set; }
        public string RegisterDimension { get; set; }
        public string RegisterWeight { get; set; }
        public string Style { get; set; }
        public string Style2 { get; set; }
        public string Author { get; set; }
        public string OriginalPosition { get; set; }
        public string CurrentPosition { get; set; }
        public string OriginalStatus { get; set; }
        public string CurrentStatus { get; set; }
        public string ExhibitDimension { get; set; }
        public string Dynasty { get; set; }
        public int? LimitedMonths { get; set; }
        public int? VisitLimitedMonths { get; set; }
        public string CurrentBox { get; set; }
        public string UtensilsCurrentBox1 { get; set; }
        public string UtensilsCurrentBox2 { get; set; }
        public string UtensilsCurrentBox3 { get; set; }
        public string CurrentCloset1 { get; set; }
        public string CurrentCloset2 { get; set; }
        public string CurrentCloset3 { get; set; }
        public string PositionDescription { get; set; }
        public string TempBox { get; set; }
        public string AccessoryName { get; set; }
        public string AccessoryQuantity { get; set; }
        public string StoreRoomName { get; set; }
        public string StoreRoomNo { get; set; }
        public string CollectionUnicode { get; set; }
        public string Memo { get; set; }
        public string RegisterMemo { get; set; }
        public string CheckFinish { get; set; }
        public string Checker { get; set; }
        public DateTime? CheckDate { get; set; }
        public string PaintingCheckFinish { get; set; }
        public string PaintingChecker { get; set; }
        public DateTime? PaintingCheckDate { get; set; }
        public string TijianStatus { get; set; }
        public string PreviousExhibitDate { get; set; }
        public string PreviousVisitDate { get; set; }
        public string CancelFlag { get; set; }
        public string CancelDate { get; set; }
        public string CancelDocumentNo { get; set; }
        public string CancelReason { get; set; }
        public string CollectType { get; set; }
        public string OriginalEnglishTitle { get; set; }
        public string OriginalForeignTitle { get; set; }
        public string DocWordNo { get; set; }
        public string RegisterStaff { get; set; }
        public string Insurance { get; set; }
        public string Times { get; set; }
        public string Creator { get; set; }
        public string CreatedIp { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastModifier { get; set; }
        public string LastModifiedIp { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual ICollection<NpmItemWorksRelation> NpmItemWorksRelation { get; set; }
    }
}
