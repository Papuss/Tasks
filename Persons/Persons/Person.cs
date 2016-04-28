using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Persons
{
    [Serializable]
    class Person
    {

        private string name;
        private string adress;
        private int phoneNum;
        private DateTime dateOfRecord;
        private int serialNumber;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Adress
        {
            get
            {
                return adress;
            }

            set
            {
                adress = value;
            }
        }

        public int PhoneNum
        {
            get
            {
                return phoneNum;
            }

            set
            {
                phoneNum = value;
            }
        }

        public DateTime DateOfRecord
        {
            get
            {
                return dateOfRecord;
            }

            set
            {
                dateOfRecord = value;
            }
        }

        public int SerialNumber
        {
            get
            {
                return serialNumber;
            }

            set
            {
                serialNumber = value;
            }
        }

        public Person(string name, string adress, int phoneNum)
        {
            this.Name = name;
            this.Adress = adress;
            this.PhoneNum = phoneNum;
        }
    }
}
