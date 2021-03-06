//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DersaneOtomasyonu.DAL.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class OgrenciKayitlari
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OgrenciKayitlari()
        {
            this.OdemeVadeleri = new HashSet<OdemeVadeleri>();
        }
    
        public int OgrenciID { get; set; }
        public int VeliID { get; set; }
        public int HaftalıkOdevID { get; set; }
        public int SinifID { get; set; }
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public byte OgrenciNumarasi { get; set; }
        public string OgrenciTcKimlikNo { get; set; }
        public string OgrenciBolumu { get; set; }
        public string OgrenciAdresi { get; set; }
        public string OgrenciPostaKodu { get; set; }
        public string OgrenciSemt { get; set; }
        public string OgrenciSehir { get; set; }
        public byte ToplamTaksitSayisi { get; set; }
        public decimal OdenecekToplamTutar { get; set; }
        public System.DateTime KayitTarihi { get; set; }
    
        public virtual HaftalikOdevler HaftalikOdevler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OdemeVadeleri> OdemeVadeleri { get; set; }
        public virtual Siniflarr Siniflarr { get; set; }
        public virtual VeliKayit VeliKayit { get; set; }
    }
}
