﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class inotr_sistemEntities : DbContext
    {
        public inotr_sistemEntities()
            : base("name=inotr_sistemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BankaHesapBilgisi> BankaHesapBilgisi { get; set; }
        public DbSet<DestekBildirimler> DestekBildirimler { get; set; }
        public DbSet<DestekKategori> DestekKategori { get; set; }
        public DbSet<DestekMesajlari> DestekMesajlari { get; set; }
        public DbSet<Evrak> Evrak { get; set; }
        public DbSet<EvrakTur> EvrakTur { get; set; }
        public DbSet<Firma> Firma { get; set; }
        public DbSet<GelirFatura> GelirFatura { get; set; }
        public DbSet<GelirFatura_Detay> GelirFatura_Detay { get; set; }
        public DbSet<GelirOdeme> GelirOdeme { get; set; }
        public DbSet<GenelTasarimAyarlari> GenelTasarimAyarlari { get; set; }
        public DbSet<GiderFatura> GiderFatura { get; set; }
        public DbSet<GiderFatura_Detay> GiderFatura_Detay { get; set; }
        public DbSet<GiderOdeme> GiderOdeme { get; set; }
        public DbSet<il> il { get; set; }
        public DbSet<ilce> ilce { get; set; }
        public DbSet<Isler> Isler { get; set; }
        public DbSet<Kasa> Kasa { get; set; }
        public DbSet<KasaHareketleri> KasaHareketleri { get; set; }
        public DbSet<Kdv> Kdv { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<MiktarTur> MiktarTur { get; set; }
        public DbSet<Musteri> Musteri { get; set; }
        public DbSet<MusteriAdaylari> MusteriAdaylari { get; set; }
        public DbSet<Not> Not { get; set; }
        public DbSet<PosBilgisi> PosBilgisi { get; set; }
        public DbSet<SatinAlmaBankaHesapBilgisi> SatinAlmaBankaHesapBilgisi { get; set; }
        public DbSet<SatinAlmaSiparis> SatinAlmaSiparis { get; set; }
        public DbSet<SatinAlmaSiparis_Detay> SatinAlmaSiparis_Detay { get; set; }
        public DbSet<SatinAlmaTeklif> SatinAlmaTeklif { get; set; }
        public DbSet<SatinAlmaTeklif_Detay> SatinAlmaTeklif_Detay { get; set; }
        public DbSet<SatisSiparis> SatisSiparis { get; set; }
        public DbSet<SatisSiparis_Detay> SatisSiparis_Detay { get; set; }
        public DbSet<SatisTalep> SatisTalep { get; set; }
        public DbSet<SatisTeklif> SatisTeklif { get; set; }
        public DbSet<SatisTeklif_Detay> SatisTeklif_Detay { get; set; }
        public DbSet<Sistem> Sistem { get; set; }
        public DbSet<SistemIletisim> SistemIletisim { get; set; }
        public DbSet<StokHareketleri> StokHareketleri { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<Tedarikci> Tedarikci { get; set; }
        public DbSet<UrunHizmet> UrunHizmet { get; set; }
        public DbSet<UrunHizmetKategori> UrunHizmetKategori { get; set; }
        public DbSet<FirmaFaturaBilgi> FirmaFaturaBilgi { get; set; }
        public DbSet<KullaniciYetki> KullaniciYetki { get; set; }
        public DbSet<ParaBirimi> ParaBirimi { get; set; }
        public DbSet<TedarikciTur> TedarikciTur { get; set; }
        public DbSet<Yetki> Yetki { get; set; }
    }
}
