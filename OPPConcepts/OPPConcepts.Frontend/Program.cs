using OPPConcepts.Backend;

try
{
  var employees = new List<Employee>();
  decimal payroll = 0;
  var employee1 = new SalaryEmployee(1010, "John", "Doe", true, new Date(1990, 5, 15), new Date(2020, 1, 1), 2500000); 
  employees.Add(employee1);
  var employee2 = new SalaryEmployee(2020, "Jane", "Smith", true, new Date(1985, 8, 20), new Date(2018, 3, 15), 3000000);
  employees.Add(employee2);
  var employee3 = new HourlyEmployee(3030, "Bob", "Johnson", true, new Date(1995, 12, 10), new Date(2021, 6, 1), 15000, 160);
  employees.Add(employee3);
  var employee4 = new HourlyEmployee(4040, "Alice", "Williams", true, new Date(1992, 3, 5), new Date(2019, 9, 10), 12000, 120);
  employees.Add(employee4);
  var employee5 = new CommisionEmployee(5050, "Charlie", "Brown", true, new Date(1988, 11, 25), new Date(2017, 5, 20), 0.03f, 120000000);
  employees.Add(employee5);
  var employee6 = new CommisionEmployee(6060, "Eve", "Davis", true, new Date(1993, 7, 30), new Date(2022, 2, 1), 0.03f, 600000000);
  employees.Add(employee6);

    foreach (var employee in employees)
  {
      Console.WriteLine(new string('-', 47));
      Console.WriteLine(employee);
      payroll += employee.GetValueToPay();
  }
    Console.WriteLine(new string('=', 47));
    Console.WriteLine($"Payroll..................: {payroll,20:C2}");


}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}