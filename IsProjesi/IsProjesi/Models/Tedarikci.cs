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
    
    public partial class Tedarikci
    {
        public Tedarikci()
        {
            this.Evrak = new HashSet<Evrak>();
            this.GiderFatura = new HashSet<GiderFatura>();
            this.Not = new HashSet<Not>();
            this.SatinAlmaBankaHesapBilgisi = new HashSet<SatinAlmaBankaHesapBilgisi>();
            this.SatinAlmaTeklif = new HashSet<SatinAlmaTeklif>();
        }
    
        public int ID { get; set; }
        public Nullable<int> ilID { get; set; }
        public Nullable<int> ilceID { get; set; }
        public Nullable<int> TedarikTurID { get; set; }
        public string FirmaAdi { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string Yetkili { get; set; }
        public string CepTel { get; set; }
        public string Adres { get; set; }
        public string VergiNumarası { get; set; }
        public string VergiDairesi { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public string FaturaUnvan { get; set; }
        public Nullable<int> Durumu { get; set; }
    
        public virtual ICollection<Evrak> Evrak { get; set; }
        public virtual ICollection<GiderFatura> GiderFatura { get; set; }
        public virtual il il { get; set; }
        public virtual ilce ilce { get; set; }
        public virtual ICollection<Not> Not { get; set; }
        public virtual ICollection<SatinAlmaBankaHesapBilgisi> SatinAlmaBankaHesapBilgisi { get; set; }
        public virtual ICollection<SatinAlmaTeklif> SatinAlmaTeklif { get; set; }
        public virtual TedarikciTur TedarikciTur { get; set; }
    }
}
