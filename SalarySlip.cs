using System;
using System.Collections.Generic;
using System.Text;

namespace BootcampProjectTwo
{
    class SalarySlip
    {
        private int baseSalary;
        public SalarySlip()
        {
            this.baseSalary = 1500;
        }

        public int GetBaseSalary()
        {
            return this.baseSalary;
        }
        public int GrossSalary(int fuelAllowance, int medicalAllowance)
        {

            int total = GetBaseSalary() + fuelAllowance + medicalAllowance;
            return total;
        }
    }
}
