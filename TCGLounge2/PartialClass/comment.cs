namespace TCGLounge2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tcglounge.comment")]
    public partial class comment
    {
        [Key]
        public int idcomment { get; set; }

        public int idoffer { get; set; }

        [Required]
        [StringLength(300)]
        public string content { get; set; }

        public virtual offer offer { get; set; }
    }
}
