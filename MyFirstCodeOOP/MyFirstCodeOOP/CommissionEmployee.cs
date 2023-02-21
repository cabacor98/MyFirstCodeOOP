using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    public class CommissionEmployee : Employee
    {
        #region Properties
        public float CommissionPercentage { get; set; }
        public decimal Sales { get; set; } 
        #endregion

        #region Methods
        public override decimal GetValueTopay()
        {
            return Sales * (decimal)CommissionPercentage / 100;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t Comission Percentage: {CommissionPercentage:P2} \n\t Sales: {Sales:C2} \n\t Value to pay: {GetValueTopay():C2}";
        }
        #endregion

    }
}
