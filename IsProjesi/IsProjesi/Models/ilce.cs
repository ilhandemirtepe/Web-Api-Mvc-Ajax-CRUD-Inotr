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
    
    public partial class ilce
    {
        public ilce()
        {
            this.Firma = new HashSet<Firma>();
            this.Musteri = new HashSet<Musteri>();
            this.MusteriAdaylari = new HashSet<MusteriAdaylari>();
            this.Tedarikci = new HashSet<Tedarikci>();
        }
    
        public int ID { get; set; }
        public Nullable<int> ilID { get; set; }
        public string IlceAdi { get; set; }
    
        public virtual ICollection<Firma> Firma { get; set; }
        public virtual il il { get; set; }
        public virtual ICollection<Musteri> Musteri { get; set; }
        public virtual ICollection<MusteriAdaylari> MusteriAdaylari { get; set; }
        public virtual ICollection<Tedarikci> Tedarikci { get; set; }
    }
}
