namespace TCGLounge2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tcglounge.item")]
    public partial class item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public item()
        {
            offer = new HashSet<offer>();
        }

        [Key]
        public int iditem { get; set; }

        [Required]
        [StringLength(45)]
        public string name { get; set; }

        public decimal? value { get; set; }

        public int typeitem { get; set; }

        [StringLength(300)]
        public string imageurl { get; set; }

        public virtual typeitem typeitem1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<offer> offer { get; set; }
    }
}
