using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AssessedExercise2
{
    public partial class Form1 : Form
    {
        BinTree tree = new BinTree();
        CustomerBinTree cTree = new CustomerBinTree();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InsertIntButton_Click(object sender, EventArgs e)
        {
            int item = 0;
            bool itemParsed = false;
            try
            {
              item = Int32.Parse(InsertIntTextBox.Text);
                itemParsed = true;
            } catch (FormatException)
            {
                MessageBox.Show("You must enter a number");
            }

            if (itemParsed == true)
            {
                tree.InsertItem(item);
                int TreeCount = tree.Count();
                TotalItemsTextBox.Text = TreeCount.ToString();
            }
        }

        private void PreOrderButton_Click(object sender, EventArgs e)
        {
            PreOrderTextBox.Text = tree.PreOrder();
        }

        private void PostOrderButton_Click(object sender, EventArgs e)
        {
            PostOrderTextBox.Text = tree.PostOrder();
        }

        private void InOrderButton_Click(object sender, EventArgs e)
        {
            InOrderTextBox.Text = tree.InOrder();
        }

        private void InsertCustomerButton_Click(object sender, EventArgs e)
        {

            int CustomerAgeToInt = 0;
            float CustomerOwedToFloat = 0;
            bool ageParsed = false;
            bool amountParsed = false;
            bool noExcludedChars = true;
            string excludedChars = "!\"£$%^&*()-_=+}{[].,?/><:;|1234567890";
            string name = CustomerNameTextBox.Text;

            // this solution was taken and tweaked from StackOverFlow @ https://stackoverflow.com/questions/4503542/check-for-special-characters-in-a-string 
            foreach (char C in excludedChars)
            {
                if (name.Contains(C))
                    noExcludedChars = false;
            }
            if (noExcludedChars == false)
                MessageBox.Show("Name cannot contain special characters or numbers");

           try
            {
                CustomerAgeToInt = Int32.Parse(customerAgeTextBox.Text);
                ageParsed = true;

            } catch (FormatException)
            {
                MessageBox.Show("Age cannot be null & must be a number.");
            }
           
            string address = CustomerAddressTextbox.Text;

            try
            {
                CustomerOwedToFloat = float.Parse(amountOwedTextBox.Text);
                amountParsed = true;
            } catch (FormatException)
            {
                MessageBox.Show("Amount owed cannot be null & must be a number.");
            }
            
            if (noExcludedChars == true && ageParsed == true && amountParsed == true)
            {
                Customer customer = new Customer(name, CustomerAgeToInt, address, CustomerOwedToFloat);
                cTree.InsertCustomer(customer);

                TotalCustomersTextbox.Text = cTree.CountCustomer().ToString();
            }
        }

        private void customerSearchButton_Click(object sender, EventArgs e)
        {
            bool noExcludedChars = true;
            string excludedChars = "!\"£$%^&*()-_=+}{[].,?/><:;|1234567890";

            string name = CustomerNameSearchTextbox.Text;

            // this solution was taken and tweaked from StackOverFlow @ https://stackoverflow.com/questions/4503542/check-for-special-characters-in-a-string 
            foreach (char C in excludedChars)
            {
                if (name.Contains(C))
                    noExcludedChars = false;
            }
            if (noExcludedChars == false)
                MessageBox.Show("Name cannot contain special characters or numbers");

            if (noExcludedChars == true)
            CustomerSearchResultTextbox.Text = cTree.FindCustomer(name);

        }

   
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void preOrderCustomerButton_Click(object sender, EventArgs e)
        {
            preOrderCustomerTextbox.Text = cTree.CustomerPreOrder();
        }

        private void postOrderCustomerButton_Click(object sender, EventArgs e)
        {
            postOrderCustomerTextbox.Text = cTree.CustomerPostOrder();
        }

        private void inOrderCustomerButton_Click(object sender, EventArgs e)
        {
            inOrderCustomerTextbox.Text = cTree.InOrderCustomer();
        }
    }
}
