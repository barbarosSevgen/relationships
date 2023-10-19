using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace one_to_many_relationship
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("one to many relationship");
        }

        #region Default Convention
        //Worker class'ı içine public int WorkerId { get; set; } tanımlamasam bile otomatik tanımlayacaktır. foreign key yapacaktır.
        //class Worker
        //{
        //    public int Id { get; set; }
        //    public string? Name { get; set; }
        //    public Department? Department { get; set; }
        //}

        //class Department
        //{
        //    public int Id { get; set; }
        //    public int DepartmentName { get; set; }
        //    public ICollection<Worker>? Workers { get; set; }

        //}
        #endregion
        #region Data Annotations
        //class Worker
        //{
        //    public int Id { get; set; }
        //    [ForeignKey(nameof(Department))]
        //    public int x { get; set; }
        //    public string? Name { get; set; }
        //    public Department? Department { get; set; }
        //}

        //class Department
        //{
        //    public int Id { get; set; }
        //    public int DepartmentName { get; set; }
        //    public ICollection<Worker>? Workers { get; set; }

        //}
        #endregion
        #region Fluent API
        //class Worker
        //{
        //    public int Id { get; set; }
        //    public int WorkerIdamakendimisimvermekistiyorum { get; set; }
        //    public string? Name { get; set; }
        //    public Department? Department { get; set; }
        //}

        //class Department
        //{
        //    public int Id { get; set; }
        //    public int DepartmentName { get; set; }
        //    public ICollection<Worker>? Workers { get; set; }

        //}

        //class ECompanyDbContext : DbContext
        //{
        //    public DbSet<Worker> workers { get; set; }

        //    public DbSet<Department> Departments { get; set; }

        //    protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    {
        //        modelBuilder.Entity<Worker>()
        //            .HasOne(c => c.Department)
        //            .WithMany(c => c.Workers)
        //            .HasForeignKey(c => c.WorkerIdamakendimisimvermekistiyorum);// bu bildiri foreign key'e isimini kendim belirmek istediğimde kullanıyorum.
        //    }
        //}
        #endregion

        //class ECompanyDbContext : DbContext
        //{
        //    public DbSet<Worker> workers { get; set; }

        //    public DbSet<Department> Departments { get; set; }
        //}
    }
}