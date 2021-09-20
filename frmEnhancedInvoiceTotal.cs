using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classProject
{
    public partial class frmEnhancedInvoiceTotal : Form
    {
        public frmEnhancedInvoiceTotal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ex 4-2, Project 4-2. 09/19/2021
        /// adding three variables to create the enhanced Invoice Total form from page 129 from the book
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        int numberOfInvoices = 0; //new var for user input value of number of invoiced
        decimal totalOfInvoices = 0m; //new var for the total $ amount of all invoices
        decimal invoiceAverage = 0m; // average of the totalOfInvoices
        
        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /*******************************
             * Daria Kazak, ex. 3.1 from Murach's Cs 7th edition. 
             * this method calculates the total for an invoice
             * depending on a discount that's based on the subtotal.
             * ****************************/

            //*********** 9/16/2021 update:
            //trying to convert using TryParse method, but haven't gotten to chapter 9 yet to understand it completely
            //decimal subtotal;
            //decimal.TryParse(txtSubtotal.Text, out subtotal); //static member. class.method(object)
            //****************************/

            //Ex 4-1|Part 5, Experiment with the code
            //using parse method of the decimal class 

            //Ex 5-1. Adding customer type control to the event handler
            string customerType = txtCustomerType.Text;
            decimal subtotal = Decimal.Parse(txtEnterSubtotal.Text);
            decimal discountPercent = .0m; //initialize discount percent

            //Ex. 5-1, Part2: change if-else statement so customers of type R with a subtotal>=250 by<=500 get dicount of 25%
            if (customerType == "R" | customerType =="r") //Ex. 5-1, Part 4: making sure the user is able to type a capital or lowercase letters
            {
                if (subtotal > -250 && subtotal <= 500)
                    discountPercent = .25m;

                else
                    discountPercent = .3m; //if subtotal >=500, discount percent is 30%
            }
            else if (customerType == "C" | customerType =="c")
            {
                discountPercent = .3m; //if customerType =C, discount percent is 30%
            }

            //Ex. 5-1, Part 3: adding type T who gets a conditional discount based on subtotal

            else if (customerType == "T" | customerType == "t")
            {
                if (subtotal <= 500)
                    discountPercent = .4m;
                else if (subtotal >= 500)
                    discountPercent = .5m;
            }

            else
            {
                discountPercent = .1m; //Customers who aren't types R,C,T get a 10% discount
            }

            //Ex. 5-1, Part 5. Use a switch statement to provide structure for handling the 3 cases for customer types R,C,T (but not r,c,t)
            //If-else statements will be nested within the switch statements
            


            //calculate and assign the values for the
            //discountAMount and invoiceTotal variables

            //ex. 4.1 Part 6: Rounding the values to 2 decimal places
            decimal discountAmount = Math.Round((subtotal * discountPercent),2);
          
            decimal invoiceTotal = Math.Round((subtotal - discountAmount),2);
            

            //format the values and display them in their boxes
            //ex. 4.1 Part 6: ROunding the values to 2 decimal places and deleting formatting statements p1 and c

            txtSubtotal.Text = subtotal.ToString("c");
            txtDiscountPercent.Text = discountPercent.ToString("p1"); //percent format with 1 decimal place
            txtDiscountAmount.Text = discountAmount.ToString(); //"c"; //currency format
            txtTotal.Text = invoiceTotal.ToString();

            //Part 8 & 9, adding controls to find and dispplay smallest and largest invoices

            decimal largestInvoice = Math.Max(invoiceTotal,totalOfInvoices);
            decimal smallestInovice = Math.Min(invoiceTotal, totalOfInvoices);



            /// Ex 4-2, Project 4-2. 09/19/2021
            /// Calculationf for the enhanced form
            numberOfInvoices++;
            totalOfInvoices += invoiceTotal;
            invoiceAverage = totalOfInvoices / numberOfInvoices;

            txtLargestInvoice.Text = largestInvoice.ToString("c");
            txtSmallestInvoice.Text = smallestInovice.ToString("c");
            txtNumberOfinvoices.Text = numberOfInvoices.ToString();
            txtTotalOfInovices.Text = totalOfInvoices.ToString("c");
            txtInvoiceAverage.Text = invoiceAverage.ToString("c");

            //Ex 4 - 2, Project 4 - 2. 09 / 19 / 2021
           
            //move the focus to the Subtotal text box
            txtEnterSubtotal.Text = "";
            txtSubtotal.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// Ex 4-2, Project 4-2. 09/19/2021
        /// Adding clear button event handler for the enhanced form. 
        private void btnClearTotals_Click(object sender, EventArgs e)
        {
            ///reset the class vars to 0s so the iser can enter the subtotals for more invoices
            numberOfInvoices = 0;
            totalOfInvoices = 0m;
            invoiceAverage = 0m;

            ///set the textboxes that display these variables to empty strings
            txtNumberOfinvoices.Text = " ";
            txtTotalOfInovices.Text = " ";
            txtInvoiceAverage.Text = " ";
            txtLargestInvoice.Text = "";
            txtSmallestInvoice.Text = "";
            ///moves foucs to enterSubtotal textbox to start over
            txtEnterSubtotal.Focus();
        } 
        
    }
}
