namespace EmployeeOPP.Classes
{
    internal class SalaryEmployee : Employee
    {
        #region Properties
        public decimal Salary { get; set; } // decimal se crea unicamente para temas de Dinero

        #endregion

        #region Methods
        public SalaryEmployee()
        {
            
        }
        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Salario Empleado: {Salary:C2}\n\t";
        }
        #endregion
    }
}
