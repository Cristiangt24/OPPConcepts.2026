namespace OPPConcepts.Backend
{
    public class CommisionEmployee : Employee
    {
        // Fields
        private float _commissionPorcent;
        private decimal _sales;

        // Constructors
        public CommisionEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate, float comissionPorcent, decimal sales) :
            base(id, firstName, lastName, isActive, bornDate, hireDate)
        {
            ComissionPorcent = comissionPorcent;
            Sales = sales;
        }
        // Properties
        public float ComissionPorcent 
        { 
            get => _commissionPorcent;
            set => _commissionPorcent = ValidateComissionPorcent(value);
        }
        public decimal Sales 
        { 
            get => _sales;
            set => _sales = value;
        }

        // Methods
        public override string ToString() => base.ToString() + $"\n\t" +
           $"Comission %......: {ComissionPorcent,20:P2}\n\t" +
           $"Sales............: {Sales,20:C2}";
        public override decimal GetValueToPay() => Sales * (decimal)ComissionPorcent;

        private float ValidateComissionPorcent(float ComissionPorcent)
        {
            if (ComissionPorcent < 0 || ComissionPorcent > 1)
            {
                throw new ArgumentOutOfRangeException(nameof(ComissionPorcent), "Comission porcentaje must be between 0 and 1.");
            }
            return ComissionPorcent;
        }
         private decimal ValidateSales(decimal sales)
        {
            if (sales < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(sales), "Sales must be greater than or equal to 0.");
            }
            return sales;
        }




    }
}
