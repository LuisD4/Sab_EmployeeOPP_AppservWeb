// See https://aka.ms/new-console-template for more information
using EmployeeOPP.Classes;
try
{
    //declaracion de variables 
    int day, month, year, hours ,comissionPercentaje;
    string firstName, lastName;
    decimal salary,hourValue,sales;

    //Peticion de datos
    Console.WriteLine("OOP APPLICATION");
    Console.WriteLine("_________________________");

    Console.WriteLine("Ingresa el dia :");
    day = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingresa el mes :");
    month = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingresa el año :");
    year = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("_________________________");

    //Inicializacion de la clase Date 
    Date dateObject = new Date(day,month,year);
    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());

    Console.WriteLine("_________________________");

    //Peticion de datos SalaryEmploye : Employee
    Console.WriteLine("CONTRATO FIJO(SALARIO MENSUAL/QUINCENAL)");
    Console.WriteLine("Ingresar nombre completo");
    firstName = Console.ReadLine();

    Console.WriteLine("Ingresar apellido completo");
    lastName = Console.ReadLine();

    Console.WriteLine("Ingresar Salario");
    salary = Decimal.Parse(Console.ReadLine());

    Console.WriteLine("_________________________");

    //Peticion de datos HourlyEmployee : Employee
    Console.WriteLine("CONTRATO TEMPORAL(POR HORAS)");

    Console.WriteLine("Ingresar Horas trabajadas");
    hours = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingresar Precio de Hora ");
    hourValue= Decimal.Parse(Console.ReadLine());

    Console.WriteLine("_________________________");

    //Peticion de datos ComissionEmployee : Employee
    Console.WriteLine("CONTRATO DE COMISIONES POR VENTAS");

    Console.WriteLine("Ingresar porcentaje de comision");
    comissionPercentaje = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingresar venta ");
    sales = Decimal.Parse(Console.ReadLine());




    //HardCoding = QuemarCodigo
    //Employee employee = new Employee(); /// no deja por que es una clase abstracta
    //IMPRESION DE DATOS DE  SalaryEmploye : Employee
    SalaryEmployee salaryEmployee = new SalaryEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Salary = salary,
        

        
    };

    Console.WriteLine(salaryEmployee);

    //IMPRESION DE DATOS DE  HourlyEmployee : Employee
    HourlyEmployee hourlyEmployee = new HourlyEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Hours = hours,
        HourValue = hourValue,
        TotalHoursPrice = hours * hourValue,


    };

    Console.WriteLine(hourlyEmployee);

    //IMPRESION DE DATOS DE  ComissionEmployee : Employee
    ComissionEmployee comissionEmployee =new ComissionEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Sales = sales,
        CommisionPercentaje = comissionPercentaje,
        SalesTotal=sales*comissionPercentaje / 100,


    };

    Console.WriteLine(comissionEmployee);


}
catch (Exception ex )
{
    Console.WriteLine(ex.Message);
}



