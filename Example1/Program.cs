// See https://aka.ms/new-console-template for more information
using Models;

Console.WriteLine("Hello, World!");
IEnumerable<Employee> empList = new Employee[]
{
    new Employee() { Id = 1, Name = "abc" },
    new Employee() { Id = 2, Name = "def" },
};
var aggregateList = empList.Aggregate<Employee, string>("Names: ", (a, b) => a + b.Name + ", ");
Console.WriteLine(aggregateList);
//var listTest = empList.Where(x => x.Name.Contains("abc"));
//foreach (var emp in listTest)
//{
//    Console.WriteLine(emp.Name);
//}
//var abc = from s in empList
//          orderby s.Name descending
//          select s;
//var groupedResult = from s in empList
//                     group s by s.Name;

//foreach (var nameGroup in groupedResult)
//{
//    foreach (var name in nameGroup)
//    {
        
//    }

//}

//Console.WriteLine(null > 0);
//Console.WriteLine(empList.CountTest());