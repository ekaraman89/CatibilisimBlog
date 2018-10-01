namespace CatibilisimBlog.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Makale")]
    public partial class Makale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Makale()
        {
            MakaleKategori = new HashSet<MakaleKategori>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Baslik { get; set; }

        [Required]
        [StringLength(100)]
        public string Ozet { get; set; }

        [Required]
        public string Icerik { get; set; }

        public DateTime YayimTarihi { get; set; }

        public int KullaniciID { get; set; }

        [Required]
        [StringLength(50)]
        public string KapakResimYol { get; set; }

        public int? Goruntuleme { get; set; }

        [Required]
        [StringLength(50)]
        public string SeoLink { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MakaleKategori> MakaleKategori { get; set; }
    }
}
