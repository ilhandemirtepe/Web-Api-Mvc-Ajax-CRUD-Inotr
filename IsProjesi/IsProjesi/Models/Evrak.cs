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
    
    public partial class Evrak
    {
        public int ID { get; set; }
        public Nullable<int> TedarikciID { get; set; }
        public Nullable<int> EvrakTurID { get; set; }
        public Nullable<int> MusteriID { get; set; }
        public string Adi { get; set; }
        public string Yolu { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    
        public virtual EvrakTur EvrakTur { get; set; }
        public virtual Musteri Musteri { get; set; }
        public virtual Tedarikci Tedarikci { get; set; }
    }
}
