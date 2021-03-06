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
    
    public partial class SatisTeklif
    {
        public SatisTeklif()
        {
            this.SatisSiparis = new HashSet<SatisSiparis>();
            this.SatisTeklif_Detay = new HashSet<SatisTeklif_Detay>();
        }
    
        public int ID { get; set; }
        public Nullable<int> SatisTalepID { get; set; }
        public Nullable<int> MusteriAdayID { get; set; }
        public Nullable<int> MusteriID { get; set; }
        public Nullable<double> KdvToplam { get; set; }
        public Nullable<double> ToplamTutar { get; set; }
        public Nullable<double> ToplamIndirim { get; set; }
        public Nullable<int> Vade { get; set; }
        public string OdemeTuru { get; set; }
        public string TeklifDetay { get; set; }
        public string GenelToplam { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    
        public virtual Musteri Musteri { get; set; }
        public virtual MusteriAdaylari MusteriAdaylari { get; set; }
        public virtual ICollection<SatisSiparis> SatisSiparis { get; set; }
        public virtual SatisTalep SatisTalep { get; set; }
        public virtual ICollection<SatisTeklif_Detay> SatisTeklif_Detay { get; set; }
    }
}
