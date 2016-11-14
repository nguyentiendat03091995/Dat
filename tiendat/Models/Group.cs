//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tiendat.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Group
    {
        public Group()
        {
            this.Accounts = new HashSet<Account>();
            this.Permissions = new HashSet<Permission>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
