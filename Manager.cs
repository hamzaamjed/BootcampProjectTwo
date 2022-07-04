using System;
using System.Collections.Generic;
using System.Text;

namespace BootcampProjectTwo
{
    class Manager : Employee
    {
        public Manager()
        {
            this.fuelAllowance = 250;
            this.medicalAllowance = 1000;
        }

        public override int CreateSalarySlip()
        {
            salSlip = new SalarySlip();
            return salSlip.GrossSalary(GetFuelAllowance(), GetMedicalAllowance());
        }

        public override int GetFuelAllowance()
        {
            return this.fuelAllowance;
        }

        public override int GetMedicalAllowance()
        {
            return this.medicalAllowance;
        }
    }
}
