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
    
    public partial class Help
    {
        public int Help_ID { get; set; }
        public Nullable<int> Help_Type_ID { get; set; }
        public Nullable<int> Admin_ID { get; set; }
        public string Help_Name { get; set; }
        public string Help_Description { get; set; }
        public byte[] Material { get; set; }
        public string FileName { get; set; }
    
        public virtual System_Administrator System_Administrator { get; set; }
        public virtual Help_Type Help_Type { get; set; }
    }
}
