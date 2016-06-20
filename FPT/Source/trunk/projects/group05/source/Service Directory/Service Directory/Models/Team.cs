//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Service_Directory.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Team
    {
        public int TeamID { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public Nullable<int> ContactID { get; set; }
        public string TeamName { get; set; }
        public string TeamAddressLine1 { get; set; }
        public string TeamAddressLine2 { get; set; }
        public string TeamAddressLine3 { get; set; }
        public string TeamCountry { get; set; }
        public Nullable<int> TeamPostcode { get; set; }
        public string TeamShortDescription { get; set; }
        public string TeamFullDescription { get; set; }
        public string TeamCounty { get; set; }
        public string TeamFax { get; set; }
        public string TeamEmail { get; set; }
        public string TeamWebAddress { get; set; }
        public string TeamNationCountry { get; set; }
        public string TeamTownVillageCity { get; set; }
        public Nullable<decimal> TeamPremiseNumber { get; set; }
    
        public virtual Contact Contact { get; set; }
        public virtual Department Department { get; set; }
    }
}