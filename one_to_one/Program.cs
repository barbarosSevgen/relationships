using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace one_to_one_relationship
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("one to one relations");
        }

        #region Default Convention
        //her iki entity'de Navigation Property ile birbirlerini tekil olarak referans ederek fiziksel bir ilişkinin olacağını ifade edelir.
        //one to one ilişki türünde, dependent entity'nin hangisi olduğunu default olarak belirleyebilmek pek kolay değildir.
        //bu durumu fizksel olarak bir foreign key'e karşılık property/kolon tanımlayarak çözebiliyoruz.
        //böylece foreign key'e karşılık property tanımlayarak lüzumsuz bir kolon oluşturmuş oluyoruz.
        //class Worker
        //{
        //    public int Id { get; set; }
        //    public string? Name { get; set; }
        //    public WorkerAdress? WorkerAdress { get; set; } // Navigation property
        //}

        //class WorkerAdress
        //{
        //    public int Id { get; set; }
        //    public int WorkerId { get; set; } //Foreign key
        //    public string? adress { get; set; }
        //    public Worker? Worker { get; set; } // Navigation property
        //}
        #endregion
        #region Data Annotations
        //burada ise foreign key'i atribute şeklinde tanımlıyoruz ve diyoruzki aslında prensipal entity ile dependent entity arasındaki ilişki.
        //1 e 1 ilişkide ekstra foreign key koluna ihtiyaç olmayacağından dolayı depent entity'deki id kolonunun hem foreign key hem de primary key olarak
        //kullanmayı tercih ediyoruz ve bu durum özen gösterilmelidir.
        //class Worker
        //{
        //    public int Id { get; set; }
        //    public string? Name { get; set; }
        //    public WorkerAdress? WorkerAdress { get; set; } // Navigation property
        //}

        //class WorkerAdress
        //{
        //    [Key ,ForeignKey(nameof(x))]
        //    public int Id { get; set; }
        //    public string? adress { get; set; }
        //    public Worker? x { get; set; } // Navigation property
        //}
        #endregion
        #region FluentAPI
        //class Worker
        //{
        //    public int Id { get; set; }
        //    public string? Name { get; set; }
        //    public WorkerAdress? WorkerAdress { get; set; } // Navigation property
        //}

        //class WorkerAdress
        //{
        //    public int Id { get; set; }
        //    public string? adress { get; set; }
        //    public Worker? x { get; set; } // Navigation property
        //}

        //class ECompanyDbContext : DbContext
        //{
        //    public DbSet<Worker> workers { get; set; }

        //    public DbSet<WorkerAdress> WorkerAdresses { get; set; }

        //    //Model'ların(entity) veritabanında generate edilecek yapıları bu fonksiyonda içerisinde konfigure edilir.
        //    protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    {
        //        modelBuilder.Entity<WorkerAdress>().HasKey(c=> c.Id);
        //        modelBuilder.Entity<Worker>().HasOne(c => c.WorkerAdress).WithOne(c => c.x).HasForeignKey<WorkerAdress>(c=> c.Id);
        //    }
        //}
        #endregion

        //class ECompanyDbContext : DbContext
        //{
        //    public DbSet<Worker> workers { get; set; }

        //    public DbSet<WorkerAdress> WorkerAdresses { get; set; }
        //}

    }
}