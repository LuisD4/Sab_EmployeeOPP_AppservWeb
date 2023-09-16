using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOPP.Classes
{
    internal class Date
    {
        #region Atributos
        int _year;
        int _month;
        int _day;
        #endregion Atributos
        //ctor + doble tab (crea un constructor)
        public Date( int day, int month, int year)
        {
            _day = day;
            _month = month; 
            _year = year;   

        }
        public override string ToString() //se esta controlando la forma en la que se mostraran los datoa
        { 
            //dia/mes/año
            var dateConcatenated1 = _day +"/"+_month +"/"+_year;// vieja y fea
            var dateConcatenated2 = $"{_day}/{_month}/{_year}";// Interpolacion
            var dateConcatenated3 = String.Format("{0}/{1}/{2}", _day, _month,_year) ;//Class String.Format //se puede poner return en vez de "Var"
            return dateConcatenated3;

        }
    }
    
}
