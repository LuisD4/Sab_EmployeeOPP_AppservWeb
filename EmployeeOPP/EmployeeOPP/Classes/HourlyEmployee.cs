namespace EmployeeOPP.Classes
{
    public class HourlyEmployee : Employee //llamo a la clase abstracta 
    {
        public int? Hours { get; set; } //creo los constructores
        public decimal HourValue { get; set; }
        public decimal TotalHoursPrice { get; set; }
        public HourlyEmployee()// "buena practica"
        {

        }
        public override decimal GetValueToPay()//retorno el valor 
        {
            return TotalHoursPrice;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $" Horas trabajadas: {Hours}\n\t" + $" Precio hora: {HourValue}\n\t" + $" Total de salario por horas trabajas: {TotalHoursPrice:C2}\n\t";
        }

    }

}
