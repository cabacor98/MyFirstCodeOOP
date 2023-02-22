using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    public class BaseCommissionEmployee : CommissionEmployee
    {
        #region Properties
        public decimal Base { get; set; }
        #endregion

        #region Methods
        public override decimal GetValueTopay()
        {
            return base.GetValueTopay() + Base;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tSalary Base................{Base:C2}" +
                $"\n\tTotal to pay...............{GetValueTopay():C2}";
        }
        #endregion
    }
}