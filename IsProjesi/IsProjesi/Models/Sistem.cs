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
    
    public partial class Sistem
    {
        public int ID { get; set; }
        public string AlanAdi { get; set; }
        public string IpAdresi { get; set; }
        public string EpostaAdresi { get; set; }
        public string EPostaSifre { get; set; }
        public string EPostaGidenSunucuAdresi { get; set; }
        public Nullable<int> EPostaPortNumarasi { get; set; }
        public string SmsKullaniciAdi { get; set; }
        public string SmsSifre { get; set; }
        public string SmsNumarasi { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    }
}
