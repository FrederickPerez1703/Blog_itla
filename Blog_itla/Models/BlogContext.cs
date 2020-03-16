using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Blog_itla.Models
{
    public partial class BlogContext : DbContext
    {
        public BlogContext()
        {
        }

        public BlogContext(DbContextOptions<BlogContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Blog> Blog { get; set; }
        public virtual DbSet<BlogUsuario> BlogUsuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-CGRM0AKG;Database=Blog;persist security info=true;Integrated Security=SSPI;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Blog>(entity =>
            {
                entity.HasKey(e => e.IdBlog)
                    .HasName("pk2");

                entity.ToTable("blog");

                entity.Property(e => e.IdBlog).HasColumnName("Id_blog");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Mesajes).IsRequired();

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UsuarioBlog).HasColumnName("Usuario_blog");

                entity.HasOne(d => d.UsuarioBlogNavigation)
                    .WithMany(p => p.Blog)
                    .HasForeignKey(d => d.UsuarioBlog)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk1");
            });

            modelBuilder.Entity<BlogUsuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("pk1");

                entity.ToTable("blog_Usuario");

                entity.Property(e => e.IdUsuario).HasColumnName("Id_usuario");

                entity.Property(e => e.Dirrecion).HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(100);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(100);
            });
        }
    }
}
