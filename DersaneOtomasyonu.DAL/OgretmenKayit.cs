//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DersaneOtomasyonu.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class OgretmenKayit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OgretmenKayit()
        {
            this.Siniflarr = new HashSet<Siniflarr>();
        }
    
        public int OgretmenID { get; set; }
        public int IDBrans { get; set; }
        public string OgretmenAdi { get; set; }
        public string OgretmenTcKimlikNo { get; set; }
        public string OgretmenCinsiyet { get; set; }
        public string OgretmenAdres { get; set; }
        public string OgretmenPostaKodu { get; set; }
        public string OgretmenSemt { get; set; }
        public string OgretmenSehir { get; set; }
        public string OgretmenEvTel { get; set; }
        public string OgretmenCepTel { get; set; }
        public string OgretmenMailAdresi { get; set; }
        public decimal OgretmenMaas { get; set; }
    
        public virtual Branslar Branslar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siniflarr> Siniflarr { get; set; }
    }
}
