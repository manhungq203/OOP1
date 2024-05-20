using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenManhHung_He172300_OOP1
{
    internal class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name, int paymentPerHour) : base(name, paymentPerHour)
        {

        }
        public override int calculateSalary()
        {
            return 8*paymentPerHour;
        }


        public override string toString()
        {
            return $"Name = {name} PaymentPerHour = {paymentPerHour}";
        }

    }
}
