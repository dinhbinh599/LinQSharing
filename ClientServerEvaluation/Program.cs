using ClientServerEvaluation.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientServerEvaluation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SchoolDbContext db = new SchoolDbContext();
            var davidName = db.Students.Where(x => x.FirstName == "David").FirstOrDefault();
            Console.WriteLine(davidName?.FirstName);
        }
    }
}