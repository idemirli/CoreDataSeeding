using CoreDataSeeding.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDataSeeding.Data
{
    public static class DataSeeding
    {
        public static void Seed(IApplicationBuilder app)
        {
           
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<SchoolContext>(); //Veri tabanıyla iletişimi sağlayan bir context nesnesi elimize geldi.

            context.Database.Migrate(); //Bekleyen bir Migration varsa Migrate et diyebiliriz. Veritabanına güncellemeleri göndermek için. İstersek veritabanını silebiliriz. Uygulama geliştirme aşamasında Seed methodu çalışacak ve gereken Migration'larla birlikte database ve datalar kendiliğinden oluşacak.

            if (context.Database.GetPendingMigrations().Count() == 0)  //Bize uygulanmış ama oluşturulmuş Migration'ların Listesini verir.
            {
                if (context.Students.Count() == 0)  //Eğer daha önce kayıt varsa ekleme diyoruz. Çünkü uygulama her ayağa kalktığında Seed methodu çalışacağı için üzerine aynı dataları oluşturmasın.
                {
                    context.Students.AddRange(
                        new List<Student>() {
                         new Student() { Name="Ahmet", Surname="Demirel", TelNo="123123" },
                         new Student() { Name="Mehmet", Surname="Çetin", TelNo="53345" },
                         new Student() { Name="Onur", Surname="Çakır", TelNo="5675" },
                         new Student() { Name="Enes", Surname="Canıtez", TelNo="8678" },
                         new Student() { Name="ibrahim", Surname="Demirli", TelNo="98767756" },
                        }
                        );
                }

                if (context.Departments.Count() == 0)  //Eğer daha önce kayıt varsa ekleme diyoruz. Çünkü uygulama her ayağa kalktığında Seed methodu çalışacağı için üzerine aynı dataları oluşturmasın.
                {
                    context.Departments.AddRange(
                        new List<Department>() {
                         new Department() {Name="Fen-Edebiyat" , Size=50 },
                         new Department() {Name="Mühendislik" , Size=65},
                         new Department() {Name="Dil" , Size=25},
                         new Department() {Name="Besyo" , Size=45},
                         new Department() {Name="Eğitim" , Size=70},
                        }
                        );
                }

                if (context.Lessons.Count() == 0)  //Eğer daha önce kayıt varsa ekleme diyoruz. Çünkü uygulama her ayağa kalktığında Seed methodu çalışacağı için üzerine aynı dataları oluşturmasın.
                {
                    context.Lessons.AddRange(
                        new List<Lesson>() {
                         new Lesson() { Name="Fizik"},
                         new Lesson() { Name="Matematik"},
                         new Lesson() { Name="Koşu"},
                         new Lesson() { Name="Almanca"},
                         new Lesson() { Name="Kişisel Gelişim" },
                        }
                        );
                }

                context.SaveChanges();
            }
        }
    }
}
