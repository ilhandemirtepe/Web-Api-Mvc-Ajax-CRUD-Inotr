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
    
    public partial class Isler
    {
        public Isler()
        {
            this.DestekBildirimler = new HashSet<DestekBildirimler>();
        }
    
        public int ID { get; set; }
        public Nullable<int> MusteriID { get; set; }
        public Nullable<int> SatinAlmaSiparisID { get; set; }
        public Nullable<int> SatisSiparisID { get; set; }
        public Nullable<int> UrunHizmetID { get; set; }
        public Nullable<int> Adet { get; set; }
        public string Acıklama { get; set; }
        public string Icerik { get; set; }
        public string Resim { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public Nullable<int> Durum { get; set; }
    
        public virtual ICollection<DestekBildirimler> DestekBildirimler { get; set; }
        public virtual Musteri Musteri { get; set; }
        public virtual SatinAlmaSiparis SatinAlmaSiparis { get; set; }
        public virtual SatisSiparis SatisSiparis { get; set; }
        public virtual UrunHizmet UrunHizmet { get; set; }
    }
}