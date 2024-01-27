using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PRUEBA_AZ.Models
{
    public partial class Prueba_Tecnica_AZContext : DbContext
    {
        public Prueba_Tecnica_AZContext()
        {
        }

        public Prueba_Tecnica_AZContext(DbContextOptions<Prueba_Tecnica_AZContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autor> Autors { get; set; } = null!;
        public virtual DbSet<Libro> Libros { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=root1201.database.windows.net; database=Prueba_Tecnica_AZ;User Id=admin1201;Password=@dmin1201;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>(entity =>
            {
                entity.ToTable("Autor");

                entity.HasComment("Tabla que almacena los datos del autor");

                entity.Property(e => e.AutorId)
                    .HasColumnName("AutorID")
                    .HasComment("ID del autor");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Nombre del autor");
            });

            modelBuilder.Entity<Libro>(entity =>
            {
                entity.HasComment("Tabla que almacena los distintos libros registrados");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ID del libro");

                entity.Property(e => e.AutorId)
                    .HasColumnName("autorID")
                    .HasComment("ID del autor (Foranea)");

                entity.Property(e => e.Título)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Titulo del libro");

                entity.HasOne(d => d.Autor)
                    .WithMany(p => p.Libros)
                    .HasForeignKey(d => d.AutorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Libros_FK");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
