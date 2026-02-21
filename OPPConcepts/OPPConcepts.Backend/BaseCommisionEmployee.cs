namespace OPPConcepts.Backend;

public class BaseCommisionEmployee : CommisionEmployee
{
    // Fields
    private decimal _Salary;

    // Constructors
    public BaseCommisionEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate, float comissionPorcent, decimal sales, decimal salary) : 
        base(id, firstName, lastName, isActive, bornDate, hireDate, comissionPorcent, sales)
    {
        Salary = salary;
    }
    // Properties
    public decimal Salary 
    { 
        get => _Salary;
        set => _Salary = ValidateSalary(value);
    }
    // Methods
    public override decimal GetValueToPay() => base.GetValueToPay() + Salary;

    public override string ToString() => $"{base.ToString()}" +
        $"\n\tSalary base.....: {Salary,20:C2}";


    private decimal ValidateSalary(decimal salary)
    {
        if (salary < 500000)
        {
            throw new ArgumentOutOfRangeException(nameof(salary), "Salary base must be greater than or equal to $500.000");
        }
        return salary;
    }
}
