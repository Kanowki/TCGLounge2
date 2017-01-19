namespace TCGLounge2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tcglounge.exchange")]
    public partial class exchange
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public exchange()
        {
            offer = new HashSet<offer>();
        }

        [Key]
        public int idexchange { get; set; }

        public int idowner { get; set; }

        public int idofferowner { get; set; }

        public int idwantowner { get; set; }

        [Required]
        [StringLength(10)]
        public string status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<offer> offer { get; set; }

        public virtual offer offer1 { get; set; }

        public virtual user user { get; set; }

        public virtual offer offer2 { get; set; }
    }
}
