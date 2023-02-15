﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    public class SalaryEmployee : Employee
    {
        #region Properties
            public decimal Salary { get; set; }
        #endregion

        #region Methods
        public override decimal GetValueTopay()
        {
           return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()} \n\t Value to pay: {GetValueTopay()}";
        }

        #endregion
    }
}
