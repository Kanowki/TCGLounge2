namespace TCGLounge2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tcglounge.user")]
    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            exchange = new HashSet<exchange>();
            offer = new HashSet<offer>();
        }

        [Key]
        public int iduser { get; set; }

        [Required]
        [StringLength(30)]
        public string login { get; set; }

        [Required]
        [StringLength(30)]
        public string password { get; set; }

        [StringLength(200)]
        public string twitch { get; set; }

        [StringLength(200)]
        public string youtube { get; set; }

        [StringLength(200)]
        public string ebay { get; set; }

        [Column("e-mail")]
        [Required]
        [StringLength(200)]
        public string e_mail { get; set; }

        [Column(TypeName = "uint")]
        public long? reputation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<exchange> exchange { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<offer> offer { get; set; }
    }
}
