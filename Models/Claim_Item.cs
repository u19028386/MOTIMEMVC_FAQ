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
    
    public partial class Claim_Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Claim_Item()
        {
            this.Project_Allocation = new HashSet<Project_Allocation>();
        }
    
        public int Claim_Item_ID { get; set; }
        public Nullable<int> Claim_Type_ID { get; set; }
        public string Claim_Item_Name { get; set; }
    
        public virtual Claim_Type Claim_Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project_Allocation> Project_Allocation { get; set; }
    }
}
