//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IsProjesi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kdv
    {
        public Kdv()
        {
            this.UrunHizmet = new HashSet<UrunHizmet>();
        }
    
        public int ID { get; set; }
        public string KdvYuzdesi { get; set; }
    
        public virtual ICollection<UrunHizmet> UrunHizmet { get; set; }
    }
}
