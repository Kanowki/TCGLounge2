namespace TCGLounge2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tcglounge.card")]
    public partial class card
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public card()
        {
            offer = new HashSet<offer>();
        }

        [Key]
        public int idcard { get; set; }

        [Required]
        [StringLength(45)]
        public string name { get; set; }

        public int refnumber { get; set; }

        public int idext { get; set; }

        [Required]
        [StringLength(5)]
        public string rarity { get; set; }

        [Required]
        [StringLength(10)]
        public string type { get; set; }

        public decimal value { get; set; }

        public virtual extension extension { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<offer> offer { get; set; }
    }
}
