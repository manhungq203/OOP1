using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenManhHung_He172300_OOP1
{
    internal class PartTimeEmployee : Employee
    {
        private int workingHour { get; set; }

        public PartTimeEmployee(string name, int workingHour,int paymentPerHour) : base(name,paymentPerHour)
        {
            this.workingHour = workingHour;
        }

        public override int calculateSalary()
        {
            return workingHour * paymentPerHour;
        }

        public override string toString()
        {
            return base.toString() + $" Working Hour = {workingHour}";
        }
    }
}
