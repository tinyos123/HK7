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
    using System.ComponentModel.DataAnnotations;
    
    public partial class tblProgramme
    {
        public tblProgramme()
        {
            this.tblServices = new HashSet<tblService>();
            this.tblOrganisations = new HashSet<tblOrganisation>();
        }
    
        public int ProgrammeID { get; set; }
        [Required(ErrorMessage="Please input the programme name")]
        public string ProgrammeName { get; set; }
        public Nullable<int> ContactID { get; set; }
        public string ProgrammeDescription { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual tblContact tblContact { get; set; }
        public virtual ICollection<tblService> tblServices { get; set; }
        public virtual ICollection<tblOrganisation> tblOrganisations { get; set; }
    }
}