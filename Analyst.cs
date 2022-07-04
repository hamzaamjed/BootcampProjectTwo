using System;
using System.Collections.Generic;
using System.Text;

namespace BootcampProjectTwo
{
    class Analyst : Employee 
    {
        public Analyst()
        {
            this.fuelAllowance = 150;
            this.medicalAllowance = 800;
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
