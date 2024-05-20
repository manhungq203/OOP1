using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenManhHung_He172300_OOP1
{
    internal class Employee : IEMployee
    {
        public string name;
        public int paymentPerHour;

        public Employee(string name, int paymentPerHour)
        {
            this.name = name;
            this.paymentPerHour = paymentPerHour;
        }

        public void setName(string name) { this.name = name; }
        public string getName() { return this.name; }

        public int getPaymentPerHour() {  return this.paymentPerHour; }
        public void setPaymentPerHour(int paymentPerHour)
        {
            this.paymentPerHour= paymentPerHour;
        }

        public virtual int calculateSalary()
        {
            return this.paymentPerHour;
        }


        public virtual string toString()
        {
             return $"Name = {this.name}, PaymentPerHour = {this.paymentPerHour}";
        }
    }
}
