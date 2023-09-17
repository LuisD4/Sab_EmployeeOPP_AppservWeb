namespace EmployeeOPP.Classes
{
    public class ComissionEmployee : Employee //llamo a la clase abstracta 
    {
        public int? CommisionPercentaje { get; set; } //creo los constructores
        public decimal Sales { get; set; }

        public decimal SalesTotal { get; set; }

        public ComissionEmployee()
        {

        }
        public override decimal GetValueToPay()//retorno el valor 
        {
            return SalesTotal;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $" Porcentaje de comision por venta: {CommisionPercentaje}\n\t" + $" Venta: {Sales:C2}\n\t" + $" comision por venta: {SalesTotal}\n\t";
        }
    }

}

