//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RFOUser
    {
        public RFOUser()
        {
            this.ContactAddresses = new HashSet<ContactAddress>();
            this.RFOUser1 = new HashSet<RFOUser>();
            this.Agreements = new HashSet<Agreement>();
        }
    
        public int UserId { get; set; }
        public Nullable<int> ManagerId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ExtranetUser { get; set; }
        public string EmailAddress { get; set; }
        public Nullable<int> UserTypeId { get; set; }
        public string Status { get; set; }
        public Nullable<int> TargetNumberOfRegistrations { get; set; }
    
        public virtual ICollection<ContactAddress> ContactAddresses { get; set; }
        public virtual ICollection<RFOUser> RFOUser1 { get; set; }
        public virtual RFOUser RFOUser2 { get; set; }
        public virtual UserType UserType { get; set; }
        public virtual ICollection<Agreement> Agreements { get; set; }
    }
}