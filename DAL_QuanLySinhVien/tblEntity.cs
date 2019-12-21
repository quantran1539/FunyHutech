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
    
    public partial class tblEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEntity()
        {
            this.tblAttributes = new HashSet<tblAttribute>();
            this.tblAttributes1 = new HashSet<tblAttribute>();
            this.tblAttributeGroups = new HashSet<tblAttributeGroup>();
            this.tblBRBusinessRules = new HashSet<tblBRBusinessRule>();
            this.tblEvents = new HashSet<tblEvent>();
            this.tblHierarchies = new HashSet<tblHierarchy>();
            this.tblIndexes = new HashSet<tblIndex>();
            this.tblSecurityRoleAccessMembers = new HashSet<tblSecurityRoleAccessMember>();
            this.tblStgBatches = new HashSet<tblStgBatch>();
            this.tblSubscriptionViews = new HashSet<tblSubscriptionView>();
            this.tblSyncRelationships = new HashSet<tblSyncRelationship>();
            this.tblSyncRelationships1 = new HashSet<tblSyncRelationship>();
        }
    
        public int ID { get; set; }
        public System.Guid MUID { get; set; }
        public int Model_ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string EntityTable { get; set; }
        public string HierarchyTable { get; set; }
        public string HierarchyParentTable { get; set; }
        public string CollectionTable { get; set; }
        public string CollectionMemberTable { get; set; }
        public bool IsBase { get; set; }
        public System.DateTime EnterDTM { get; set; }
        public int EnterUserID { get; set; }
        public int EnterVersionID { get; set; }
        public System.DateTime LastChgDTM { get; set; }
        public int LastChgUserID { get; set; }
        public int LastChgVersionID { get; set; }
        public byte[] LastChgTS { get; set; }
        public string StagingBase { get; set; }
        public string StagingLeafName { get; set; }
        public string StagingConsolidatedName { get; set; }
        public string StagingRelationshipName { get; set; }
        public byte DataCompression { get; set; }
        public byte TransactionLogType { get; set; }
        public bool RequireApproval { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAttribute> tblAttributes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAttribute> tblAttributes1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAttributeGroup> tblAttributeGroups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBRBusinessRule> tblBRBusinessRules { get; set; }
        public virtual tblCodeGenInfo tblCodeGenInfo { get; set; }
        public virtual tblModel tblModel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEvent> tblEvents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHierarchy> tblHierarchies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblIndex> tblIndexes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSecurityRoleAccessMember> tblSecurityRoleAccessMembers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblStgBatch> tblStgBatches { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSubscriptionView> tblSubscriptionViews { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSyncRelationship> tblSyncRelationships { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSyncRelationship> tblSyncRelationships1 { get; set; }
    }
}
