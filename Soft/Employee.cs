using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft
{
    public class Employee
        //useing contractor

    {
        int Empid;
        string Empname;
        double Empsalary;
        public Employee(int id, string name, double salary)
        {
            this.Empid = id;
            this.Empname = name;
            this.Empsalary = salary;
        
    }
        public string print()
        {
            return $" id is {Empid}\n name is {Empname}\n salary is {Empsalary}";
        }
        
           
        }
    }

