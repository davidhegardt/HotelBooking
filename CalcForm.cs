/**
 * David Hegardt 
 * Final Project - Hotel booking system
 * 2017-01-03
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject
{
    /**
     * Class to display calculations of hotel room cost.
     * 
    */
    public partial class CalcForm : Form
    {
        private Billing currBill;
        private String firstName;
        private String lastName;

        /// <summary>
        /// Constructor to retrieve and set labels
        /// </summary>
        /// <param name="theBill">Billing class object</param>
        /// <param name="fName">Firtname of guest</param>
        /// <param name="lName">Lastname of guest</param>
        public CalcForm(Billing theBill, String fName, String lName)
        {
            currBill = theBill;
            firstName = fName;
            lastName = lName;

            InitializeComponent();
            initGUI();
        }

        /// <summary>
        /// Initialize gui, retireve calculations from bill class to be displayed.
        /// </summary>
        public void initGUI()
        {
            currBill.calcTotal();
            txtSumNoVat.Text = currBill.getSum.ToString();
            txtSumTax.Text = currBill.getVat.ToString();
            int cleanbill = currBill.sumCleaning();
            double breakfast = currBill.sumBreakfast();
            txtSumBreakfast.Text = breakfast.ToString();
            txtSumClean.Text = cleanbill.ToString();
            txtSumDeposit.Text = currBill.getTotDeposit.ToString();
            txtGrandTotal.Text = currBill.Grandtotal.ToString();

            lblGuest.Text = firstName + " " + lastName;

            lblDays.Text = currBill.DayNumbers.ToString() + " Days";
        }

        /// <summary>
        /// Function for user to set roomservice cost, updates the calculations based on this
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRoomService_TextChanged(object sender, EventArgs e)
        {
            
            if (!(string.IsNullOrEmpty(txtRoomService.Text))) {
                double value;
                if (double.TryParse(txtRoomService.Text, out value))
                {
                    currBill.RoomService = value;
                    initGUI();
                }
            }

        }
    }
}
