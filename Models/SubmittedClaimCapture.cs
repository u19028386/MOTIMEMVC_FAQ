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
    
    public partial class SubmittedClaimCapture
    {
        public int SubmittedClaim_ID { get; set; }
        public int Claim_ID { get; set; }
        public System.DateTime Submission_Date { get; set; }
        public int Status_ID { get; set; }
    
        public virtual Claim_Capture Claim_Capture { get; set; }
        public virtual ClaimCaptureStatu ClaimCaptureStatu { get; set; }
    }
}