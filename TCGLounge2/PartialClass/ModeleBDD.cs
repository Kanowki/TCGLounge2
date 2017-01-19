namespace TCGLounge2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModeleBDD : DbContext
    {
        public ModeleBDD()
            : base("name=ModeleBDD")
        {
        }

        public virtual DbSet<card> card { get; set; }
        public virtual DbSet<comment> comment { get; set; }
        public virtual DbSet<exchange> exchange { get; set; }
        public virtual DbSet<extension> extension { get; set; }
        public virtual DbSet<item> item { get; set; }
        public virtual DbSet<language> language { get; set; }
        public virtual DbSet<offer> offer { get; set; }
        public virtual DbSet<typeitem> typeitem { get; set; }
        public virtual DbSet<user> user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<card>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<card>()
                .Property(e => e.rarity)
                .IsUnicode(false);

            modelBuilder.Entity<card>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<card>()
                .HasMany(e => e.offer)
                .WithMany(e => e.card)
                .Map(m => m.ToTable("offer_card", "tcglounge").MapLeftKey("idcard").MapRightKey("idoffer"));

            modelBuilder.Entity<comment>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<exchange>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<exchange>()
                .HasMany(e => e.offer)
                .WithRequired(e => e.exchange)
                .HasForeignKey(e => e.idexchange)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<extension>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<extension>()
                .Property(e => e.imageurl)
                .IsUnicode(false);

            modelBuilder.Entity<extension>()
                .Property(e => e.abb)
                .IsUnicode(false);

            modelBuilder.Entity<extension>()
                .HasMany(e => e.card)
                .WithRequired(e => e.extension)
                .HasForeignKey(e => e.idext)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<item>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<item>()
                .Property(e => e.imageurl)
                .IsUnicode(false);

            modelBuilder.Entity<item>()
                .HasMany(e => e.offer)
                .WithMany(e => e.item)
                .Map(m => m.ToTable("offer_item", "tcglounge").MapLeftKey("iditem").MapRightKey("idoffer"));

            modelBuilder.Entity<language>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<language>()
                .HasMany(e => e.extension)
                .WithRequired(e => e.language)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<offer>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<offer>()
                .HasMany(e => e.comment)
                .WithRequired(e => e.offer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<offer>()
                .HasMany(e => e.exchange1)
                .WithRequired(e => e.offer1)
                .HasForeignKey(e => e.idofferowner)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<offer>()
                .HasMany(e => e.exchange2)
                .WithRequired(e => e.offer2)
                .HasForeignKey(e => e.idwantowner)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<typeitem>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<typeitem>()
                .HasOptional(e => e.item)
                .WithRequired(e => e.typeitem1);

            modelBuilder.Entity<user>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.twitch)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.youtube)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.ebay)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.e_mail)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.exchange)
                .WithRequired(e => e.user)
                .HasForeignKey(e => e.idowner)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.offer)
                .WithRequired(e => e.user)
                .HasForeignKey(e => e.idsender)
                .WillCascadeOnDelete(false);
        }
    }
}
