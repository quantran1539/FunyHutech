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
    
    public partial class tblExternalSystem
    {
        public int ID { get; set; }
        public System.Guid MUID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte Status_ID { get; set; }
        public System.DateTime EnterDTM { get; set; }
        public Nullable<int> EnterUserID { get; set; }
        public System.DateTime LastChgDTM { get; set; }
        public Nullable<int> LastChgUserID { get; set; }
    }
}
