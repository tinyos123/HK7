﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebsiteQuanLyBanHang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class SalesMan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalesMan()
        {
            this.Customers = new HashSet<Customer>();
            this.Payments = new HashSet<Payment>();
            this.PurchaseOrders = new HashSet<PurchaseOrder>();
            this.ReturnGoods = new HashSet<ReturnGood>();
            this.Users = new HashSet<User>();
        }


        [Key]
        [Required]
        [Display(Name = "Mã")]
        [StringLength(6, ErrorMessage = "Định dạng [NV0001]")]
        public string SalesManID { get; set; }
        [Required]
        [Display(Name = "Tên")]
        [StringLength(50, ErrorMessage = "Tên không quá 50 kí tự")]
        public string SalesManName { get; set; }
        [Display(Name = "Địa chỉ")]
        [StringLength(50, ErrorMessage = "Tên không quá 50 kí tự")]
        public string Address { get; set; }
        [Display(Name = "Hạn mức")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        public decimal OverAmt { get; set; }
        [Display(Name = "Trạng thái")]
        [StringLength(2, ErrorMessage = "2 kí tự")]
        public string Status { get; set; }
        [Display(Name = "Mô tả")]
        [StringLength(50, ErrorMessage = "Tên không quá 200 kí tự")]
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReturnGood> ReturnGoods { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}