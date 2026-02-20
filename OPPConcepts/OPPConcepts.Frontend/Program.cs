using OPPConcepts.Backend;

try
{
  var employee1 = new SalaryEmployee(1, "John", "Doe", true, new Date(1990, 5, 15), new Date(2020, 1, 1), 2500000);
    Console.WriteLine(employee1);
  var employee2 = new SalaryEmployee(2, "Jane", "Smith", true, new Date(1985, 8, 20), new Date(2018, 3, 15), 3000000);
    Console.WriteLine(employee2);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}