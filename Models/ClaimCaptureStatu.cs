//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MOTIMEMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClaimCaptureStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClaimCaptureStatu()
        {
            this.Claim_Capture = new HashSet<Claim_Capture>();
            this.SubmittedClaimCaptures = new HashSet<SubmittedClaimCapture>();
        }
    
        public int claimStatusId { get; set; }
        public string Status_Name { get; set; }
        public string Status_Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim_Capture> Claim_Capture { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubmittedClaimCapture> SubmittedClaimCaptures { get; set; }
    }
}
