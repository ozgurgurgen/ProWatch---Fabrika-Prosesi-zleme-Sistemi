//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProWatch
{
    using System;
    using System.Collections.Generic;
    
    public partial class UretimBilgileri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UretimBilgileri()
        {
            this.Makineler = new HashSet<Makineler>();
        }
    
        public byte Id { get; set; }
        public Nullable<byte> MakineId { get; set; }
        public Nullable<int> UretimHedefi { get; set; }
        public Nullable<int> UretilenMiktar { get; set; }
        public string Urun { get; set; }
        public Nullable<bool> UretimBitisOnay { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Makineler> Makineler { get; set; }
    }
}
