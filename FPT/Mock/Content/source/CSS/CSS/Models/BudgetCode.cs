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
    
    public partial class BudgetCode
    {
        public BudgetCode()
        {
            this.FundingMethods = new HashSet<FundingMethod>();
        }
    
        public string BudgetCode1 { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Verified { get; set; }
    
        public virtual ICollection<FundingMethod> FundingMethods { get; set; }
    }
}