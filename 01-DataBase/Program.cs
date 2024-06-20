using _01_DataBase.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        NorthwindContext db = new NorthwindContext();
        db.Products
            .Where(x => x.CategoryId == 2)
            .OrderBy(x => x.ProductName)
            .ToList();
        //  .ForEach(p=>Console.WriteLine(p.ProductName)); 

        Select();
        static void Select()
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                List<Employee> employees = db.Employees.ToList();
                foreach (var emp in employees)
                {
                    Console.WriteLine($"ID:{emp.EmployeeId}Name:{emp.FirstName} {emp.LastName}");
                }
            }
        }


        static void Add()
        {
            //Context nesnesi oluştur
            using (NorthwindContext db = new NorthwindContext())
            {
                //Veri tabanına ekleyeceğimiz nesneyi oluştururz
                Employee newEmployee = new Employee();
                //veri tabanına ekleyeceğimiz nesnein özelliklerini doldur.
                newEmployee.FirstName = "ZAFER";
                newEmployee.LastName = "Dörter";
                //context nesnesine veri tabanına ekleyeceğimiz nesneyi ekliyoruz.
                db.Employees.Add(newEmployee);
                //veri tabanında gerçekleşmesini stediğmiz değişiklikleri kaydediyoruz.
                db.SaveChanges();
                Select();
            }

        }

        static void Update()
        {
            using (var db = new NorthwindContext())
            {
                Employee emp = db.Employees.First(x => x.FirstName == "Bengü su" && x.LastName == "Akay");
                emp.LastName = "AKAY";
                db.SaveChanges();
                Select();
            }
        }

        //static void Update()
        /*{
            using (var db=new NorthwindContext())
            {
                Employee emp = db.Employees.First(x => x.FirstName == "bengü su" && x.LastName == "akay");
                if(emp is not null)
                {
                    emp.LastName = "deniz";
                    emp.TitleOfCourtesy = "MR";
                    emp.Title = "SALES MENAGER";

                }
            }
        }*/

        static void Remove()
        {
          using (NorthwindContext db = new NorthwindContext())
            {
           //   Employee.removeEmployee = db.Employees.First(x => x.FirstName == "ibrahim" && x.LastName == "deniz");
           //   db.Employees.Remove(removeEmployee);
                db.SaveChanges();
                Select();
            }
        }

    }

}