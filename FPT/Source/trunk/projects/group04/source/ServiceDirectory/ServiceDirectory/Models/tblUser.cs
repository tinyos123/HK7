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
    
    public partial class tblUser
    {
        public tblUser()
        {
            this.tblSupportingMaterials = new HashSet<tblSupportingMaterial>();
        }
    
        public int UserID { get; set; }
        public string Account { get; set; }
        public string UserPassword { get; set; }
        public Nullable<int> RoleID { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
    
        public virtual tblRole tblRole { get; set; }
        public virtual ICollection<tblSupportingMaterial> tblSupportingMaterials { get; set; }
    }
}