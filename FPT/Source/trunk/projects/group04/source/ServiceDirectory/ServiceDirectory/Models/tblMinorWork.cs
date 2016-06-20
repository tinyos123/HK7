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
    
    public partial class tblMinorWork
    {
        public int MinorWorkID { get; set; }
        public Nullable<int> PremisesID { get; set; }
        public string ShortDecription { get; set; }
        public string NoteAction { get; set; }
        public Nullable<decimal> EstimatesCost { get; set; }
        public Nullable<decimal> ActualCost { get; set; }
        public Nullable<int> DirectorateID { get; set; }
        public Nullable<int> ContactID { get; set; }
        public Nullable<int> AuthorisedID { get; set; }
        public string Statu { get; set; }
        public Nullable<System.DateTime> ReceiveDate { get; set; }
        public Nullable<System.DateTime> AuthorisedDate { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> AnticipatedCompletion { get; set; }
        public Nullable<System.DateTime> CompletionDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsProject { get; set; }
    
        public virtual tblContact tblContact { get; set; }
        public virtual tblContact tblContact1 { get; set; }
        public virtual tblDirectorate tblDirectorate { get; set; }
        public virtual tblPremis tblPremis { get; set; }
    }
}