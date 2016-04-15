using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class EmpArrayList
    {
        int EmpID;
        string Name;
        int Age;

        public int EmpID1
        {
            get
            {
                return EmpID;
            }

            set
            {
                EmpID = value;
            }
        }

        public string Name1
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public int Age1
        {
            get
            {
                return Age;
            }

            set
            {
                Age = value;
            }
        }

        public EmpArrayList(int empID, string name, int age)
        {
            EmpID1 = empID;
            Name1 = name;
            Age1 = age;
        }
    }
}
