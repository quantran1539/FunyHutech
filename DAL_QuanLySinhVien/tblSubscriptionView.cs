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
    
    public partial class tblSubscriptionView
    {
        public int ID { get; set; }
        public Nullable<int> Entity_ID { get; set; }
        public int Model_ID { get; set; }
        public Nullable<int> DerivedHierarchy_ID { get; set; }
        public int ViewFormat_ID { get; set; }
        public Nullable<int> ModelVersion_ID { get; set; }
        public Nullable<int> ModelVersionFlag_ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Levels { get; set; }
        public System.Guid MUID { get; set; }
        public string Description { get; set; }
        public bool IncludeSoftDeletedMembers { get; set; }
        public System.DateTime EnterDTM { get; set; }
        public Nullable<int> EnterUserID { get; set; }
        public int EnterVersionID { get; set; }
        public System.DateTime LastChgDTM { get; set; }
        public Nullable<int> LastChgUserID { get; set; }
        public int LastChgVersionID { get; set; }
        public byte[] LastChgTS { get; set; }
    
        public virtual tblDerivedHierarchy tblDerivedHierarchy { get; set; }
        public virtual tblEntity tblEntity { get; set; }
        public virtual tblModel tblModel { get; set; }
        public virtual tblModelVersion tblModelVersion { get; set; }
    }
}
