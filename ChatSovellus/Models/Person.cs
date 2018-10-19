namespace ChatSovellus.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person()
        {
            Message = new HashSet<Message>();
        }

        [Key]
        public int Person_Id { get; set; }

        [Required]
        [StringLength(25)]
        public string NickName { get; set; }

        [StringLength(50)]
        public string Hometown { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        public byte[] Photo { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        public int? PasswordHash { get; set; }

        public DateTime? RegistrationDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Message { get; set; }
    }
}
