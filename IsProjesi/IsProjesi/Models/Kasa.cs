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
    
    public partial class Kasa
    {
        public Kasa()
        {
            this.KasaHareketleri = new HashSet<KasaHareketleri>();
        }
    
        public int ID { get; set; }
        public Nullable<double> Deger { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    
        public virtual ICollection<KasaHareketleri> KasaHareketleri { get; set; }
    }
}