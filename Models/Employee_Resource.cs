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
    
    public partial class Employee_Resource
    {
        public int Employee_Resource_ID { get; set; }
        public Nullable<int> Resource_ID { get; set; }
        public Nullable<int> Employee_ID { get; set; }
        public Nullable<int> Resource_Level_ID { get; set; }
    
        public virtual C_Resource C_Resource { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Resource_Level Resource_Level { get; set; }
    }
}
