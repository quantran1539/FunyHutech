//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL_QuanLySinhVien
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblBRBusinessRule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblBRBusinessRule()
        {
            this.tblBRLogicalOperatorGroups = new HashSet<tblBRLogicalOperatorGroup>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string RuleConditionText { get; set; }
        public string RuleActionText { get; set; }
        public string RuleElseActionText { get; set; }
        public int Entity_ID { get; set; }
        public byte MemberType_ID { get; set; }
        public int Status_ID { get; set; }
        public Nullable<int> Priority { get; set; }
        public Nullable<int> NotificationGroupID { get; set; }
        public Nullable<int> NotificationUserID { get; set; }
        public System.DateTime EnterDTM { get; set; }
        public int EnterUserID { get; set; }
        public System.DateTime LastChgDTM { get; set; }
        public int LastChgUserID { get; set; }
        public byte[] LastChgTS { get; set; }
        public System.Guid MUID { get; set; }
    
        public virtual tblEntity tblEntity { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBRLogicalOperatorGroup> tblBRLogicalOperatorGroups { get; set; }
    }
}
