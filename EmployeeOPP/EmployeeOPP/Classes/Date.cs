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
        public Date( int day, int month, int year)
        {
            _day = day;
            _month = month; 
            _year = year;   

        }
        public override string ToString() 
        { 
            //dia/mes/año
            var dateConcatenated = _day +"/"+_month +"/"+_year;
            return dateConcatenated;

        }
    }
    
}
