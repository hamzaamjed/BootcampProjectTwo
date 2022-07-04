using System;
using System.Collections.Generic;
using System.Text;

namespace BootcampProjectTwo
{
    abstract class Employee
    {
        protected SalarySlip salSlip;
        protected int fuelAllowance;
        protected int medicalAllowance;


        public abstract int CreateSalarySlip();
        
       
        public abstract int GetFuelAllowance();
        public abstract int GetMedicalAllowance();

    }
}
