namespace ChatSovellus.Models.ChatDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Message")]
    public partial class Message
    {
        [Key]
        public int Message_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Subject { get; set; }

        [Required]
        [StringLength(1000)]
        public string MessageText { get; set; }

        public DateTime SendTime { get; set; }

        public int From_Person_Id { get; set; }

        public bool PrivateMessage { get; set; }

        public int? To_Person_Id { get; set; }

        public DateTime? ExpireAt { get; set; }

        [StringLength(20)]
        public string Category { get; set; }

        public virtual Person Person { get; set; }
    }
}
