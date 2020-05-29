using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Organization
    {
        private List<IEmployee> employees;

        public Organization()
        {
            employees = new List<IEmployee>();
        }
        public void AddEmployee(IEmployee employee)
        {
            this.employees.Add(employee);
        }

        public float GetNetSalaries()
        {
            float netSalary = 0f;

            foreach(var employee in this.employees)
            {
                netSalary += employee.GetSalary();
            }

            return netSalary;
        }
    }
}
