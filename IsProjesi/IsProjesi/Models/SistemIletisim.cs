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
    
    public partial class SistemIletisim
    {
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Modul { get; set; }
        public string SmsIcerik { get; set; }
        public string EpostIcerik { get; set; }
        public string Tip { get; set; }
        public string Zaman { get; set; }
        public string EpostaKonusu { get; set; }
        public string SmsBaslik { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public string ModulAdi { get; set; }
        public string FonksiyonDurumu { get; set; }
        public string Konu { get; set; }
    }
}
