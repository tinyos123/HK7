//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceDirectory.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblSupportingMaterial
    {
        public int SupportID { get; set; }
        public string URL { get; set; }
        public Nullable<int> OrgID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string ShortDescription { get; set; }
        public string TypeFile { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual tblOrganisation tblOrganisation { get; set; }
        public virtual tblUser tblUser { get; set; }
    }
}