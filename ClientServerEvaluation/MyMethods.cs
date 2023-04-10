using ClientServerEvaluation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientServerEvaluation
{
    public static class MyMethods
    {
        public static void TopLevelProjection()
        {
            SchoolDbContext db = new SchoolDbContext();
            var blogs = db.Students
            .OrderByDescending(s => s.FirstName)
            .Select(
                s => new { Name = (StandardizeName(s.FirstName)) })
            .ToList();
        }

        public static void UnsupportedClientEvaluation()
        {
            SchoolDbContext db = new SchoolDbContext();
            var blogs = db.Students
            .OrderByDescending(s => StandardizeName(s.FirstName))
            .Select(
                s => new { Name = s.FirstName })
            .ToList();
        }

        private static string StandardizeName(string name)
        {
            name = name.ToLower();

            return name;
        }
    }
}
