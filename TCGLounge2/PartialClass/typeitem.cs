namespace TCGLounge2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tcglounge.typeitem")]
    public partial class typeitem
    {
        [Key]
        public int idtypeitem { get; set; }

        [Required]
        [StringLength(45)]
        public string name { get; set; }

        public virtual item item { get; set; }
    }
}
