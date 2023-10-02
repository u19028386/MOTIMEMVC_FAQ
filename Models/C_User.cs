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
    
    public partial class C_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_User()
        {
            this.Alerts = new HashSet<Alert>();
            this.Audit_Log = new HashSet<Audit_Log>();
            this.Employees = new HashSet<Employee>();
            this.System_Administrator = new HashSet<System_Administrator>();
            this.User_User_Role = new HashSet<User_User_Role>();
        }
    
        public int C_User_ID { get; set; }
        public Nullable<int> Title_ID { get; set; }
        public Nullable<int> Password_ID { get; set; }
        public Nullable<int> User_Role_ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email_Address { get; set; }
        public string Token { get; set; }
        public string ResetPasswordToken { get; set; }
        public Nullable<System.DateTime> ResetPasswordExpiry { get; set; }
        public byte[] ProfilePicture { get; set; }
        public string FileName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string RefreshToken { get; set; }
        public Nullable<System.DateTime> RefreshTokenExpiryTime { get; set; }
    
        public virtual C_Password C_Password { get; set; }
        public virtual Title Title { get; set; }
        public virtual User_Role User_Role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alert> Alerts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Audit_Log> Audit_Log { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<System_Administrator> System_Administrator { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_User_Role> User_User_Role { get; set; }
    }
}