using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    public class ContractEmployee: Employee
    {
        #region Properties
        public float Hours { get; set; }
        public decimal HourValue { get; set; }
        #endregion


        public override decimal GetValueTopay()
        {
            return ((decimal)Hours * HourValue);
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tNumber of hours....{Hours}" +
                $"\n\tValue per hour.....{HourValue:C2}" +
                $"\n\tValue to pay.......{GetValueTopay():C2}";
        }
    }
}