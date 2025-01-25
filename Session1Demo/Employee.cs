using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1Demo
{
    class EqualityCopmarerEmployeeName : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return HashCode.Combine(obj.Name);
        }
    }

    class EmployeeComparerSalary : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x.Salary.CompareTo(y.Salary);
        }
    }

    internal class Employee : IComparable<Employee> , IEquatable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        //Operator Overloading ==
        //Incase struct 
        public static bool operator ==(Employee left, Employee right)
        {
            return left.Id==right.Id && left.Name==right.Name && left.Age==right.Age && left.Salary==right.Salary;
        }
        public static bool operator !=(Employee left, Employee right)
        {
            return left.Id != right.Id || left.Name != right.Name || left.Age != right.Age || left.Salary != right.Salary;
        }


        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name} , Age: {Age} , Salary: {Salary}";
        }

        public int CompareTo(Employee? other)
        {
            if (other is null) return 1; 
            return Age.CompareTo(other.Age);
        }

        public bool Equals(Employee? other)
        {
            if (other is null) return false;
            return this == other;
        }
    }
}
