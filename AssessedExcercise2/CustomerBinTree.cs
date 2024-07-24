using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AssessedExercise2
{
    internal class CustomerBinTree
    {
        private CustomerNode root;

        public CustomerBinTree() 
        {		     

            root = null;
        }
        public CustomerBinTree(CustomerNode root) 
        {
            this.root = root;
        }

        public string InOrderCustomer()  
        {
            StringBuilder sb = new StringBuilder();
            inOrderCustomer(root, sb);
            return sb.ToString();
        }

        private void inOrderCustomer(CustomerNode tree, StringBuilder sb)
        {
            if (tree != null)  
            {
                inOrderCustomer(tree.Left, sb);
                sb.Append("Name: " + tree.Customer.Name);
                sb.AppendLine();
                sb.Append("Age: " + tree.Customer.Age);
                sb.AppendLine();
                sb.Append("Address: " + tree.Customer.Address);
                sb.AppendLine();
                sb.Append("Amount Owed: " + tree.Customer.AmountOwed);
                sb.Append("------------------------");
                inOrderCustomer(tree.Right, sb);
            }
        }

        public string CustomerPostOrder()
        {
            StringBuilder sb = new StringBuilder();
            customerPostOrder(root, sb);
            return sb.ToString();

        }

        public void customerPostOrder(CustomerNode tree, StringBuilder sb)
        {
            if (tree != null)
            {
                customerPostOrder(tree.Left, sb);
                customerPostOrder(tree.Right, sb);
                sb.Append("Name: " + tree.Customer.Name);
                sb.AppendLine();
                sb.Append("Age: " + tree.Customer.Age);
                sb.AppendLine();
                sb.Append("Address: " + tree.Customer.Address);
                sb.AppendLine();
                sb.Append("Amount owed: " + tree.Customer.AmountOwed);
                sb.Append("------------------------");
            }
        }

        public string CustomerPreOrder()
        {
            StringBuilder sb = new StringBuilder();
            customerPreOrder(root, sb);
            return sb.ToString();
        }

        public void customerPreOrder(CustomerNode tree, StringBuilder sb)
        {
            if (tree != null)
            {
                sb.Append("Name: " + tree.Customer.Name);
                sb.AppendLine();
                sb.Append("Age: " + tree.Customer.Age);
                sb.AppendLine();
                sb.Append("Address: " + tree.Customer.Address);
                sb.AppendLine();
                sb.Append("Amount owed: " + tree.Customer.AmountOwed);
                sb.Append("------------------------");
                customerPreOrder(tree.Left, sb);
                customerPreOrder(tree.Right, sb);

            }
        }
        public int heightCustomer()
        {
            return heightCustomer(root);
        }

        private int heightCustomer(CustomerNode tree)
        {
            if (tree == null)
            {
                return 0;
            }
            else
            {
                return 1 + Math.Max(heightCustomer(tree.Left), heightCustomer(tree.Right));
            }

        }

        public int CountCustomer()
        {
            return countCustomer(root);
        }

        private int countCustomer(CustomerNode tree)
        {
            if (tree == null)
            {
                return 0;
            }

            return countCustomer(tree.Left) + countCustomer(tree.Right) + 1;
        }

        public void InsertCustomer(Customer customer)
        {
            insertCustomer(customer, ref root);
        }

        private void insertCustomer(Customer customer, ref CustomerNode tree)
        {
            if (tree == null)
                tree = new CustomerNode(customer);

            else if (customer.CompareTo(tree.Customer) < 0)
                insertCustomer(customer, ref tree.Left);

            else if (customer.CompareTo(tree.Customer) > 0)
                insertCustomer(customer, ref tree.Right);

        }

        public string FindCustomer(string name)
        {
            StringBuilder sb = new StringBuilder();
            findCustomer(name, ref root, sb);

            string result = sb.ToString();
            if (string.IsNullOrWhiteSpace(result))
            {
                result = "Customer not found";
            }
            return result;
        }

        private void findCustomer(string name, ref CustomerNode tree, StringBuilder sb)
        {
            if (tree != null)
            {
                findCustomer(name, ref tree.Left, sb);
                if (name.CompareTo(tree.Customer.Name) == 0)
                {
                    sb.Append("Name: " + tree.Customer.Name);
                    sb.Append("Age: " + tree.Customer.Age);
                    sb.Append("Address: " + tree.Customer.Address);
                    sb.Append("Amount owed: " + tree.Customer.AmountOwed);
                }
                findCustomer(name, ref tree.Right, sb);
            } 
        }
    }
}
