namespace TCGLounge2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tcglounge.extension")]
    public partial class extension
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public extension()
        {
            card = new HashSet<card>();
        }

        [Key]
        public int idextension { get; set; }

        [Required]
        [StringLength(45)]
        public string name { get; set; }

        public int idlanguage { get; set; }

        [Required]
        [StringLength(200)]
        public string imageurl { get; set; }

        [Required]
        [StringLength(5)]
        public string abb { get; set; }

        [Column(TypeName = "year")]
        public short releasedate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<card> card { get; set; }

        public virtual language language { get; set; }
    }
}
