namespace CatibilisimBlog.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MakaleKategori")]
    public partial class MakaleKategori
    {
        public int Id { get; set; }

        public int KategoriID { get; set; }

        public int MakaleID { get; set; }

        public virtual Kategori Kategori { get; set; }

        public virtual Makale Makale { get; set; }
    }
}
