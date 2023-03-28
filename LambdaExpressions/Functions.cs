using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    internal static class Functions
    {
        public static bool NameStartingWithA(this Employee employee)
        {
            return employee.Name.StartsWith("a");
        }
    }
}
