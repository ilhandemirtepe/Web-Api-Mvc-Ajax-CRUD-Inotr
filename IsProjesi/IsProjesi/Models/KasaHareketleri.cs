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
    
    public partial class KasaHareketleri
    {
        public int ID { get; set; }
        public Nullable<int> KasaID { get; set; }
        public Nullable<int> GiderOdemeID { get; set; }
        public Nullable<int> GelirOdemeID { get; set; }
        public Nullable<decimal> Tutar { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public string Tip { get; set; }
        public string Durum { get; set; }
        public string Aciklama { get; set; }
    
        public virtual GelirOdeme GelirOdeme { get; set; }
        public virtual GiderOdeme GiderOdeme { get; set; }
        public virtual Kasa Kasa { get; set; }
    }
}
