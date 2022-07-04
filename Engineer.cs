using System;
using System.Collections.Generic;
using System.Text;

namespace BootcampProjectTwo
{
    class Engineer : Employee
    {
        public Engineer()
        {
            this.fuelAllowance = 100;
            this.medicalAllowance = 500;
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
