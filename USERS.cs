//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PAWproject
{
    using System;
    using System.Collections.Generic;
    
    public partial class USERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USERS()
        {
            this.RECOVERY = new HashSet<RECOVERY>();
        }
    
        public int ID { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Nullable<System.DateTime> lastlogin { get; set; }
        public Nullable<int> idrole { get; set; }
        public Nullable<int> logincount { get; set; }
        public string username { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECOVERY> RECOVERY { get; set; }
        public virtual ROLE ROLE { get; set; }
    }
}