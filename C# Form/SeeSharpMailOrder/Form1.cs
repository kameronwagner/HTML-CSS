/*
 * Project:     Assignment #6 - See Sharp Order Form
 * Programmers: Jeremy Stroud, Kameron Wagner, Gary Sweet, Peter Moore, Lucas Henn, Victor Short
 * Date:        Fall 2016 CIS 160
 * Description: Order form for See Sharp, allows multiple item entries and a summary of order
 *              Includes validation and methods for Shipping, Handling, Discounts, and Sales Tax
 *              Includes ErrorProvider
*/

using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace SeeSharpMailOrder
{
    public partial class frmMailOrder : Form
    {
        decimal decRunningTotal = 0.0m;
        int intRunningQuantity = 0;

        public frmMailOrder()
        {
            InitializeComponent();
        }

        // Add item to order totals
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            decimal decAmountDue;
            int intQuantity;
            decimal decPrice;

            // Validate fields before adding order
            if (ValidateFields())
            {
                grpCustomer.Enabled = false;

                intQuantity = Convert.ToInt32(numQuantity.Value); // ValidateFields already confirms that this will parse
                decPrice = Convert.ToDecimal(txtPrice.Text);

                decAmountDue = intQuantity * decPrice;
                decRunningTotal += decAmountDue;
                intRunningQuantity += intQuantity;

                // Reset fields to ready for new input
                ResetItemFields();
                txtDescription.Focus();

                btnSummary.Enabled = true;
            }
        }

        // Clear Customer Information and Item Information fields as well as running total
        private void btnClear_Click(object sender, EventArgs e)
        {
            grpCustomer.Enabled = true;

            txtName.Clear();
            txtStreet.Clear();
            txtCity.Clear();
            txtState.Clear();
            mskZip.Clear();
            chkNewCustomer.Checked = true;

            ResetItemFields();

            radShippingExpress.Checked = true;
            //radPaymentCharge.Checked = true;

            txtAmountDue.Clear();
            lblDiscount.Text = "";
            lblDiscount.Visible = false;
            txtSalesTax.Clear();
            lblTaxRate.Text = "";
            lblTaxRate.Visible = false;
            txtShippingHandling.Clear();
            txtTotalAmountDue.Clear();

            lblPayment.Text = "";

            decRunningTotal = 0.0m;
            intRunningQuantity = 0;

            btnSummary.Enabled = false;
            txtName.Focus();
        }

        // Exit the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Calculates total due plus discounts, shipping, and handling and displays to user
        private void btnSummary_Click(object sender, EventArgs e)
        {
            decimal decSalesTax, decTaxRate, decShippingHandling, decTotalDue;

            decRunningTotal -= GetDiscount();

            decTaxRate = GetTaxRate();
            decSalesTax = decRunningTotal * decTaxRate;

            decShippingHandling = GetShipping() + GetHandling();

            decTotalDue = decRunningTotal + decSalesTax + decShippingHandling;

            txtAmountDue.Text = decRunningTotal.ToString("c");
            txtSalesTax.Text = decSalesTax.ToString("c");
            txtShippingHandling.Text = decShippingHandling.ToString("c");
            txtTotalAmountDue.Text = decTotalDue.ToString("c");

            //For Express and Shipping addtional days
            string msgtitle = "";
            int days = 0;
            
            if (radShippingExpress.Checked)
            {
                days = 3;
                msgtitle = "Express";
            }
            else if(radShippingGround.Checked)
            {
                days = 7;
                msgtitle = "Ground";
            }
            else {
                return;
            }
            MessageBox.Show(CalculateDeliveryDate(days), string.Format("{0} (in {1} days)", msgtitle, days));
        }

        // Opens Shipper's website in internet browser
        private void rtbShipperWebsite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(rtbShipperWebsite.Text);
        }


        // Display current date to user
        private void frmMailOrder_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Today.ToString("M/d/yyyy");
        }

        // Determines Discount rate and returns discount amount as decimal
        private decimal GetDiscount()
        {
            const decimal decDISCOUNT_RATE = 0.1m;

            if(chkNewCustomer.Checked)
            {
                lblDiscount.Text = "(" + decDISCOUNT_RATE.ToString("p") + " discount)";
                lblDiscount.Visible = true;
                return decDISCOUNT_RATE * decRunningTotal;
            }
            else
            {
                lblDiscount.Text = "";
                lblDiscount.Visible = false;
                return 0m;
            }
        }

        // Returns Sales Tax rate as decimal
        private decimal GetTaxRate()
        {
            const decimal decTAX_RATE = 0.087m;

            if (txtState.Text == "WA")
            {
                lblTaxRate.Text = "(" + decTAX_RATE.ToString("p") + ")";
                lblTaxRate.Visible = true;
                return decTAX_RATE;
            }
            else
            {
                lblTaxRate.Text = "";
                lblTaxRate.Visible = false;
                return 0m;
            }
        }

        // Returns Shipping fees as decimal
        private decimal GetShipping()
        {
            const decimal decEXPRESS_SHIPPING = 13.25m;
            const decimal decGROUND_SHIPPING = 5.75m;
            decimal decShipping = 0m;

            if (radShippingExpress.Checked)
            {
                decShipping = decEXPRESS_SHIPPING;
            }
            else if (radShippingGround.Checked)
            {
                decShipping = decGROUND_SHIPPING;
            }

            return decShipping;

        }

        // Returns Handling fees as decimal
        private decimal GetHandling()
        {
            const decimal decHANDLING_FEE01 = 1.50m;
            const decimal decHANDLING_FEE02 = 2.75m;
            const decimal decHANDLING_FEE03 = 5.50m;
            decimal decHandling = 0m;

            if (intRunningQuantity <= 2)
            {
                decHandling = decHANDLING_FEE01;
            }
            else if (intRunningQuantity <= 4)
            {
                decHandling = decHANDLING_FEE02;
            }
            else if (intRunningQuantity >= 5)
            {
                decHandling = decHANDLING_FEE03;
            }

            return decHandling;
        }

        // Clears item fields
        private void ResetItemFields()
        {
            // Order group
            txtDescription.Clear();
            numQuantity.Value = 1;
            txtPrice.Clear();
        }

        // Adds parameter Days to the current date and returns result
        private String CalculateDeliveryDate(int days)
        {
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(days);
            return answer.ToLongDateString();
        }

        // Returns true if string is a valid state
        private bool IsValidState(string state)
        {
            string[] strStates = new string[50] { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" };
            if (strStates.Contains(state))
                return true;
            else
                return false;
        }

        // Validates that Control is not empty or null
        private bool IsPresent(Control control)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
                return false;
            else
                return true;
        }

        // Validates is a valid decimal number
        public bool IsDecimal(string number)
        {
            decimal dec = 0m;
            if (Decimal.TryParse(number, out dec))
                return true;
            else
                return false;
        }

        // Validate all fields, return to field on error and display error message - returns true if all fields are valid
        private bool ValidateFields()
        {
            // clear any previous errorProvider errors
            errorProvider1.Clear();

            // Fields to be validated, control followed by control name
            // Use fields.add to validate a new field
            Dictionary<Control, string> fields = new Dictionary<Control, string>();
            fields.Add(txtName, "Full name");
            fields.Add(txtStreet, "Street address");
            fields.Add(txtCity, "City");
            fields.Add(txtState, "State");
            fields.Add(mskZip, "Zip code");
            fields.Add(txtDescription, "Item description");
            fields.Add(numQuantity, "Item quantity");  // Note: numQuantity does not require advanced validation as inputs are forced between 1 and 10, takes into account blanks and invalid characters
            fields.Add(txtPrice, "Item price");

            bool isValid = true;

            foreach (KeyValuePair<Control, string> item in fields)
            {
                Control control = item.Key;

                // Check if control value is present
                if (!IsPresent(control))
                    isValid = false;

                // Perform additional validation as required
                else if (control.Name == "txtState" && !IsValidState(control.Text))
                    isValid = false;

                else if (control.Name == "mskZip" && !((MaskedTextBox)control).MaskCompleted)
                    isValid = false;

                else if (control.Name == "txtPrice" && !IsDecimal(control.Text))
                    isValid = false;

                // If any checks return false, set error provider and return
                if (!isValid)
                {
                    string message = string.Format("Please enter a valid {0}.", item.Value);
                    errorProvider1.SetError(control, message);
                    control.Focus();
                    if (control.GetType() == typeof(TextBox))
                    {
                        // Recast control as TextBox so that Select All method can be accessed
                        ((TextBox)control).SelectAll();
                    }
                    return isValid;
                }
            }
            return isValid;
        }

        private void radPaymentCharge_CheckedChanged(object sender, EventArgs e)
        {
            Form paymentForm = new frmPayment();
            DialogResult selectedButton = paymentForm.ShowDialog();
            if (selectedButton == DialogResult.OK)
            {
                lblPayment.Text = (string)paymentForm.Tag;
            }
        }
    }
}