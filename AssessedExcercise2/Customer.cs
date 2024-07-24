using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessedExercise2
{
    internal class Customer : IComparable
    {
            private string name;
            private int age;
            private string address;
            private float amountOwed;

            public Customer(string name, int age, string address, float amountOwed)
            {
                this.name = name;
                this.age = age;
                this.address = address;
                this.amountOwed = amountOwed;
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Age
            {
                get { return age; }
                set { age = value; }
            }

            public string Address
            {
                get { return address; }
                set { address = value; }
            }

            public float AmountOwed
            {
                get { return amountOwed; }
                set { amountOwed = value; }

            }
          
            public string getInformation(string name)
            {

                Customer customer = new Customer(name, age, address, amountOwed);
                customer.Name = name;
                customer.Age = age;
                customer.Address = address;
                customer.AmountOwed = amountOwed;

                string customerToString = "Customer Name = " + name + "Customer age = " + age + "Customer Address = " + address + "Customer Amount Owed = " + AmountOwed;

                return customerToString;
            }

            public int CompareTo(object obj)
            {
                int nameComparisonResult = name.CompareTo(((Customer)obj).Name);

          
                if (nameComparisonResult != 0)
                {
                    return nameComparisonResult;
                }

                return 0;
            }
        }
    }
