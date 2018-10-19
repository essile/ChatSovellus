namespace ChatSovellus.Models.ChatDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ChatDBModel : DbContext
    {
        public ChatDBModel()
            : base("name=ChatDBModel")
        {
        }

        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<Person> Person { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasMany(e => e.Message)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.From_Person_Id);
        }
    }
}
