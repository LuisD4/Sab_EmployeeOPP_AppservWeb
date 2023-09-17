namespace EmployeeOPP.Classes
{
    public class Date
    {
        #region Atributos
        int _year;
        int _month;
        int _day;
        #endregion Atributos
        //ctor + doble tab (crea un constructor)
        public Date(int day, int month, int year)
        {
            _day = validateDay(day, month, year);
            _month = ValidateMonth(month);
            _year = ValidateYear(year);

        }

        private int validateDay(int day, int month, int year)
        {
            //valido si el dia ingresado pertence a un año bisiesto
            if (month == 2 && day == 29 && IsLeapYear(year)) // ingrese 29/2/2023
            {
                return day;
            }
            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                bool isLeapYear = false;
                IsLeapYearException(isLeapYear, year);

            }
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (day >= 1 && day <= daysPerMonth[month])
            {
                return day;
            }
            else
            {
                throw new DayException(String.Format("El dia {0} no es valido para el mes {1}.", day, month));
            }
        }

        private void IsLeapYearException(bool isLeapYear, int year)
        {
            if (!isLeapYear)
            {
                throw new YearException(string.Format("El año {0} no es bisiesto", year));
            }
        }


        private bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }

        private int ValidateYear(int year)
        {
            if (year >= 1900)
            {
                return year;
            }
            else
            {
                throw new YearException(String.Format("El Año {0} no es valido ", year));
            }
        }

        private int ValidateMonth(int month)
        {
            if (month >= 1 && month <= 12) //si el mes Month => 13 saldra un error 
            {
                return month;
            }
            else
            {
                //Exception Creation
                throw new MonthException(String.Format("El mes {0} no es valido.", month));
            }

        }

        public override string ToString() //se esta controlando la forma en la que se mostraran los datoa
        {
            //dia/mes/año
            var dateConcatenated1 = _day + "/" + _month + "/" + _year;// vieja y fea
            var dateConcatenated2 = $"{_day:00}/{_month:00}/{_year:0000}";// Interpolacion
            var dateConcatenated3 = String.Format("{0}/{1}/{2}", _day, _month, _year);//Class String.Format //se puede poner return en vez de "Var"
            return dateConcatenated3;

        }
    }

}
