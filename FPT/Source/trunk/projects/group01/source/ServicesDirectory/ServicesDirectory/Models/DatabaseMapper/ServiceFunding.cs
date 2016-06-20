//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicesDirectory.Models.DatabaseMapper
{
    using System;
    using System.Collections.Generic;
    
    public partial class ServiceFunding
    {
        public int ServiceFundingId { get; set; }
        public Nullable<int> FundingSourceId { get; set; }
        public int FundingContactId { get; set; }
        public decimal FundingAmount { get; set; }
        public Nullable<System.DateTime> FundingStart { get; set; }
        public Nullable<System.DateTime> FundingEnd { get; set; }
        public Nullable<decimal> FundingNeeds { get; set; }
        public Nullable<bool> IsFundingContinuationNeeded { get; set; }
        public Nullable<decimal> FundingContinuationAmount { get; set; }
        public string FundingContinuationDetail { get; set; }
        public string FundraisingForText { get; set; }
        public string FundraisingWhy { get; set; }
        public Nullable<decimal> FundraisingNeeds { get; set; }
        public Nullable<System.DateTime> FundraisingRequiredBy { get; set; }
        public Nullable<bool> IsFundRaisingComplete { get; set; }
        public Nullable<System.DateTime> FundraisingCompletedDate { get; set; }
        public Nullable<bool> FundraisingDonorAnynymous { get; set; }
        public Nullable<decimal> FundraisingDonorAmount { get; set; }
        public Nullable<System.DateTime> FundDonationDate { get; set; }
        public Nullable<bool> IsFundraisingDonationIncremental { get; set; }
        public int ServiceId { get; set; }
    
        public virtual Contact Contact { get; set; }
        public virtual FundingSource FundingSource { get; set; }
        public virtual Service Service { get; set; }
    }
}