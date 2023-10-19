using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;

namespace many_to_many
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("many to many relationship");
        }

        #region default convention
        //class Book
        //{
        //    public int Id { get; set; }
        //    public string? BookName { get; set; }
        //    public ICollection<Author>? Authors { get; set; }
        //}

        //class Author
        //{
        //    public int Id { get; set; }
        //    public string? AuthorName { get; set; }
        //    public ICollection<Book>? Books { get; set; }
        //}
        #endregion
        #region Data Annotation
        //class Book
        //{
        //    public int Id { get; set; }
        //    public string? BookName { get; set; }
        //    public ICollection<CrossTable>? Authors { get; set; }
        //}

        //class CrossTable
        //{
        //    [ForeignKey(nameof(Book))]
        //    public int BookId { get; set; } // foreign key
        //    [ForeignKey(nameof(Authors))]
        //    public int AuthorsId { get; set; } // foreign key
        //    public Book? Book { get; set; }
        //    public Author? Authors { get; set; }
        //}

        //class Author
        //{
        //    public int Id { get; set; }
        //    public string? AuthorName { get; set; }
        //    public ICollection<CrossTable>? Books { get; set; }
        //}
        #endregion
        #region Fluent API
        //class Kitap
        //{
        //    public int id { get; set; }
        //    public string kitapAdi { get; set; }
        //    public ICollection<KitapYazar> yazarlar { get; set; }
        //}

        //class Yazar
        //{
        //    public int id { get; set; }
        //    public string yazarAdi { get; set; }
        //    public ICollection<KitapYazar> kitaplar { get; set; }
        //}

        //class KitapYazar
        //{
        //    public int kitapId { get; set; }
        //    public int yazarId { get; set; }
        //    public Yazar yazar { get; set; }
        //    public Kitap kitap { get; set; }
        //}

        //class ECompanyDbContext : DbContext
        //{

        //    protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    {
        //        modelBuilder.Entity<KitapYazar>()
        //            .HasKey(ky => new { ky.yazarId, ky.kitapId });
        //        modelBuilder.Entity<KitapYazar>()
        //            .HasOne(k => k.yazar)
        //            .WithMany(k => k.kitaplar)
        //            .HasForeignKey(c => c.yazarId);
        //        modelBuilder.Entity<KitapYazar>()
        //            .HasOne(k => k.kitap)
        //            .WithMany(k => k.yazarlar)
        //            .HasForeignKey(c => c.kitapId);
        //    }
        //}

        #endregion


        //class ECompanyDbContext : DbContext
        //{
        //    public DbSet<Book> Books { get; set; }

        //    public DbSet<Author> Authors { get; set; }
        //}
    }
}