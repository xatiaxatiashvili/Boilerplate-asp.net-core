using System;
using System.Collections.Generic;
using System.Text;
using static Acme.SimpleTaskSystem.Employee;

namespace Acme.SimpleTaskSystem.Employees
{
   public class UpdateEmployeeInput
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PersonalNumber { get; set; }
        public DateTime Date { get; set; }
        public NationalityType Nationality { get; set; }
        public int Salary { get; set; }
        public CurrencyType Currency { get; set; }
        public int Mobile { get; set; }
    }
}
