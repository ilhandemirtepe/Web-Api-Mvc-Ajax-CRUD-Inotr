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
    
    public partial class Yetki
    {
        public Yetki()
        {
            this.Musteri = new HashSet<Musteri>();
            this.KullaniciYetki = new HashSet<KullaniciYetki>();
        }
    
        public int ID { get; set; }
        public string Adi { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    
        public virtual ICollection<Musteri> Musteri { get; set; }
        public virtual ICollection<KullaniciYetki> KullaniciYetki { get; set; }
    }
}
