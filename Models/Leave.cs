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
    
    public partial class Leave
    {
        public int Leave_ID { get; set; }
        public Nullable<int> Employee_ID { get; set; }
        public Nullable<int> Leave_Type_ID { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Leave_Type Leave_Type { get; set; }
    }
}
