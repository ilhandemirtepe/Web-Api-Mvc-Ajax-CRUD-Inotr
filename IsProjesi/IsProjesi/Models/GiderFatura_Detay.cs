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
    
    public partial class GiderFatura_Detay
    {
        public int ID { get; set; }
        public Nullable<int> GiderFaturaID { get; set; }
        public string Adi { get; set; }
        public Nullable<decimal> Tutar { get; set; }
        public Nullable<int> Adet { get; set; }
        public Nullable<double> KdvOrani { get; set; }
        public Nullable<decimal> ToplamTutar { get; set; }
    
        public virtual GiderFatura GiderFatura { get; set; }
    }
}
