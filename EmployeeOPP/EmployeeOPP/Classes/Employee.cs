namespace EmployeeOPP.Classes
{
    public abstract class Employee
    {
        #region properties
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; } // ? (permite que el valor pueda ser NULL)
        public Date? BirthDate { get; set; }
        public Date? HiringDate { get; set; }
        public bool? IsActive { get; set; }
        #endregion
        public Employee()
        {
            
        }
        #region Methods

        public abstract decimal GetValueToPay();
        public override string ToString()
        {
            return $"INFORMACION  EMPLEADO \n\t " +//preguntar como hacer para separar la informacion del empleado por tipo
                $"ID: {Id}\n\t" +
                $"Nombres: {FirstName}\n\t" +
                $"Apellidos: {LastName}\n\t" +
                $"Fecha de Cumpleaños: {BirthDate}\n\t" +
                $"Fecha de Contratacion: {HiringDate}\n\t" +
                $"Empleado Activo?: {IsActive}\n\t";

        }
        //CODE


        #endregion
    }
}

//como es una clase abstracta no deja crear objetos en el main (program.cs)
//entonces hay que crear una clase hija

