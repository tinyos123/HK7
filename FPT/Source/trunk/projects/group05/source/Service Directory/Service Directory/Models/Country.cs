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
    
    public partial class Country
    {
        public Country()
        {
            this.Counties = new HashSet<County>();
            this.TrustRegions = new HashSet<TrustRegion>();
        }
    
        public int CountryID { get; set; }
        public string CountryName { get; set; }
    
        public virtual ICollection<County> Counties { get; set; }
        public virtual ICollection<TrustRegion> TrustRegions { get; set; }
    }
}