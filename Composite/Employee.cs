using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    interface IEmployee
    {
        string GetName();

        void SetSalary(float salary);
        float GetSalary();
        IEnumerable<string> GetRoles();
    }

    class Developer : IEmployee
    {
        private readonly string name;
        private  float salary;
        private readonly IEnumerable<string> roles;

        public Developer(string name, float salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public string GetName()
        {
            return this.name;
        }

        public IEnumerable<string> GetRoles()
        {
            return this.roles;
        }

        public float GetSalary()
        {
            return this.salary;
        }

        public void SetSalary(float salary)
        {
            this.salary = salary;
        }
    }

    class Designer : IEmployee
    {
        private readonly string name;
        private readonly IEnumerable<string> roles;
        private  float salary;

        public Designer(string name, float salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public string GetName()
        {
            return this.name;
        }

        public IEnumerable<string> GetRoles()
        {
            return this.roles;        }

        public float GetSalary()
        {
            return this.salary;
        }

        public void SetSalary(float salary)
        {
            this.salary = salary;
        }
    }
}
