using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessedExercise2
{
    internal class CustomerNode
    {
        private Customer customer;
        public CustomerNode Left, Right;

        public CustomerNode(Customer customer)
        {
            this.customer = customer;
            this.Left = null;
            this.Right = null;
        }
        public CustomerNode(Customer customer, CustomerNode left, CustomerNode right)
        {
            this.customer = customer;
            this.Left = left;
            this.Right = right;
        }

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }
    }
}
