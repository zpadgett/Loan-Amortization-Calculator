using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Major_Project_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        //global variables
        double totalInterestTemp;
        double totalInterestAmount;
        double totalLoanTemp;
        double totalLoanAmount;


        private void rebateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //enable the rebate text box if user clicks
            rebateTextBox.Enabled = true;
            rebateTextBox.Focus();
        }

        private void sixMonthRadio_CheckedChanged(object sender, EventArgs e)
        {
            //clear listbox
            listBox.Items.Clear();
        }

        private void twelveMonthRadio_CheckedChanged(object sender, EventArgs e)
        {
            //clear listbox
            listBox.Items.Clear();
        }

        private void eighteenMonthRadio_CheckedChanged(object sender, EventArgs e)
        {
            //clear listbox
            listBox.Items.Clear();
        }

        private void twentyfourMonthRadio_CheckedChanged(object sender, EventArgs e)
        {
            //clear listbox
            listBox.Items.Clear();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double loanRaw, loan, rebateAmount, months = 6, rate, principalPayment = 0, interest, pmt, intCum = 0, prinCum = 0, payCum = 0;


            try
            {
                //parse data
                double.TryParse(loanTextBox.Text, out loanRaw);
                double.TryParse(rebateTextBox.Text, out rebateAmount);
                rate = Convert.ToDouble(aprComboBox.Text) / 100;

                //options for radio buttons
                if (sixMonthRadio.Checked)
                    months = 6;
                if (twelveMonthRadio.Checked)
                    months = 12;
                if (eighteenMonthRadio.Checked)
                    months = 18;
                if (twentyfourMonthRadio.Checked)
                    months = 24;

                //loan = loan - rebate
                if (rebateCheckBox.Checked)
                    loan = loanRaw - rebateAmount;
                else
                    loan = loanRaw;



                principalPayment = rate / 12 * (loan + 0 * Math.Pow(1 + rate / 12, months)) / ((Math.Pow(1 + rate /
    12, months) - 1) * (1 + rate / 12 * 0));

                interest = loan * rate / 12;


                for (int monthCounter = 1; monthCounter <= months; monthCounter++)
                {

                    //full payment
                    pmt = principalPayment + interest;

                    //balance
                    loan = loan - principalPayment;


                    //add to listbox
                    string formatString = "{0,5}{1,12}{2,12}{3,12}{4,12}";
                    listBox.Items.Add(string.Format(
                        formatString, monthCounter, interest.ToString("C2"), principalPayment.ToString("C2"), pmt.ToString("C2"), loan.ToString("C2")
                        ));


                    //add values to cumulative totals
                    intCum += interest;
                    prinCum += principalPayment;
                    payCum += pmt;


                    //recalculate interest payment
                    interest = loan * rate / 12;

                    //recalculate principal
                    principalPayment = pmt - interest;



                }

                //add totals to listbox
                listBox.Items.Add("");
                listBox.Items.Add(string.Format(
                    "{0,5}{1,12}{2,12}{3,12}", "Total: ", intCum.ToString("C2"), prinCum.ToString("C2"), payCum.ToString("C2")
                    ));
                
                //add totals to temporary global variables
                totalInterestTemp = intCum;
                totalLoanTemp = prinCum;

              
            }
            catch (Exception err)

            {
                //Issue error message and reset focus
                MessageBox.Show(err.Message, "Error Message");
                loanTextBox.Focus();
            }  

        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            //set global variables
            totalLoanAmount += totalLoanTemp;
            totalInterestAmount += totalInterestTemp;

            loanTextBox.Text = null;
            aprComboBox.Items.Clear();
            rebateTextBox.Clear();
            loanTextBox.Focus();

        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            totalInterestLabel.Text = totalInterestAmount.ToString("C2");
            totalLoansLabel.Text = totalLoanAmount.ToString("C2");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exit Confirmation
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", this.Text,
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //If answer is yes, close the app
            if (dialog == DialogResult.Yes)
                this.Close();

        }

        private void loanTextBox_TextChanged(object sender, EventArgs e)
        {
            //clear listbox
            listBox.Items.Clear();
        }

        private void loanTextBox_Click(object sender, EventArgs e)
        {
            loanTextBox.SelectAll();
        }

        private void loanTextBox_Enter(object sender, EventArgs e)
        {
            loanTextBox.SelectAll();
        }

        private void aprComboBox_Click(object sender, EventArgs e)
        {
            aprComboBox.SelectAll();
        }

        private void aprComboBox_Enter(object sender, EventArgs e)
        {
            aprComboBox.SelectAll();
        }

        private void rebateTextBox_TextChanged(object sender, EventArgs e)
        {
            //clear listbox
            listBox.Items.Clear();
        }

        private void rebateTextBox_Click(object sender, EventArgs e)
        {
            rebateTextBox.SelectAll();
        }

        private void rebateTextBox_Enter(object sender, EventArgs e)
        {
            rebateTextBox.SelectAll();

        }

        private void loanTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //This event handler only allows digits, control characters, 
            //and the period.
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != '.')
            {
                // If we get anything other than a digit, backspace, or period tell the rest of
                // the event processing logic to ignore this event (it is handled). Note: ! means not.
                e.Handled = true;
                return;
            }
        }

        private void aprComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //This event handler only allows digits, control characters, 
            //and the period.
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != '.')
            {
                // If we get anything other than a digit, backspace, or period tell the rest of
                // the event processing logic to ignore this event (it is handled). Note: ! means not.
                e.Handled = true;
                return;
            }
        }

        private void rebateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //This event handler only allows digits, control characters, 
            //and the period.
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != '.')
            {
                // If we get anything other than a digit, backspace, or period tell the rest of
                // the event processing logic to ignore this event (it is handled). Note: ! means not.
                e.Handled = true;
                return;
            }
        }

        private void aprComboBox_TextChanged(object sender, EventArgs e)
        {
            //clear listbox
            listBox.Items.Clear();
        }
    }
}
