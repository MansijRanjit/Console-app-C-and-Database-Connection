using ConsoleAppxyz.data;
using ConsoleAppxyz.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppxyz
{
    public class DbCon
    {
        private static defaultcontext db = new defaultcontext();

        public void GetAll()
        {
            var data = db.Student.ToList();
            foreach (var item in data)
            {
                Console.WriteLine("============================================================");
                Console.WriteLine($"Id : {item.Id}");
                Console.WriteLine($"Name : {item.name}");
                Console.WriteLine($"Email : {item.email}");
                Console.WriteLine($"Phone : {item.phoneno}");
                Console.WriteLine("============================================================");
            }
        }

        public void GetById()
        {
            Console.WriteLine("Enter the id:");
            var id = Convert.ToInt32(Console.ReadLine());
            var item = db.Student.Find(id);

            Console.WriteLine("============================================================");
            Console.WriteLine($"Id : {item.Id}");
            Console.WriteLine($"Name : {item.name}");
            Console.WriteLine($"Email : {item.email}");
            Console.WriteLine($"Phone : {item.phoneno}");
            Console.WriteLine("============================================================");
        }

        public void Create()
        {
            var std = new Students();

            Console.Write("Enter the name:");
            std.name = Console.ReadLine();
            Console.Write("Enter the email:");
            std.email = Console.ReadLine();
            Console.Write("Enter the phone:");
            std.phoneno = Console.ReadLine();

            db.Student.Add(std);
            db.SaveChanges();
        }

        public void Edit()
        {
            Console.Write("Enter the id:");
            var id = Convert.ToInt32(Console.ReadLine());

            var existing = db.Student.Find(id);

            if (existing != null)
            {
                Console.Write("Enter the name:");
                existing.name = Console.ReadLine();
                Console.Write("Enter the email:");
                existing.email = Console.ReadLine();
                Console.Write("Enter the phone:");
                existing.phoneno = Console.ReadLine();

                db.Student.Update(existing);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Record not found");
            }
        }

        public void Delete()
        {
            Console.Write("Enter the id:");
            var id = Convert.ToInt32(Console.ReadLine());

            var existing = db.Student.Find(id);

            if (existing != null)
            {
                db.Student.Remove(existing);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Record not found");
            }
        }
    }
}