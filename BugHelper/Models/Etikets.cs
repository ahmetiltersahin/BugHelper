//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BugHelper.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Etikets
    {
        public int Id { get; set; }
        public string Etiketler { get; set; }
        public Nullable<int> Soru_Id { get; set; }
    
        public virtual SorularModels SorularModels { get; set; }
    }
}
