// See https://aka.ms/new-console-template for more information
using EmployeeOPP.Classes;
try
{
    Console.WriteLine("OOP APPLICATION");
    Console.WriteLine("_______________");

    Console.WriteLine("Ingresa el dia :");
    int day = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingresa el mes :");
    int month = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingresa el año :");
    int year = Convert.ToInt32(Console.ReadLine());

    //Inicializacion de la clase Date 
    Date dateObject = new Date(day,month,year);
    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());

}
catch (Exception ex )
{
    Console.WriteLine(ex.Message);
}



