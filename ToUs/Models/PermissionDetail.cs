//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToUs.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PermissionDetail
    {
        public int Id { get; set; }
        public Nullable<int> PermissionId { get; set; }
        public string ActionName { get; set; }
        public string ActionCode { get; set; }
        public Nullable<bool> CheckAction { get; set; }
    
        public virtual Permission Permission { get; set; }
    }
}