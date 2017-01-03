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
     * Booking form - used to create bookings in the system 
     * 
    */
    public partial class bookForm : Form
    {
        // Instance variables - uses existing classes booking and guest
        private Guest newGuest = new Guest();
        private Booking newBook = new Booking();
        private RoomManager roomMngr;
        private bool closeForm;

        /// <summary>
        /// Main constructor - assings room manger to existing room manager
        /// </summary>
        /// <param name="currMngr"></param>
        public bookForm(RoomManager currMngr)
        {
            InitializeComponent();
            initGUI();            
            this.roomMngr = currMngr;

        }

        /// <summary>
        /// Initialize and populate GUI, retireve enum types Roomtype and Country to drop
        /// down lists.
        /// </summary>
        private void initGUI()
        {
            boxCountry.DataSource = Enum.GetNames(typeof(Country));
            boxRoom.DataSource = Enum.GetNames(typeof(RoomType));
            boxPayment.Items.Add("Card");
            boxPayment.Items.Add("Cash");
            boxPayment.Items.Add("Faktura");
            boxBreakfast.Items.Add("Yes");
            boxBreakfast.Items.Add("No");
            lblAvail.Text = string.Empty;
        }

        /// <summary>
        /// Properites to set and get booking and guest
        /// </summary>
        public Guest GuestData
        {
            get { return newGuest; }
            set
            {
                if (value != null)
                newGuest = value;
            }
        }

        public Booking BookData
        {
            get { return newBook; }
            set
            {
                if (value != null)
                newBook = value;
            }
        }

        public RoomManager RoomManager
        {
            get { return roomMngr; }
            set
            {
                roomMngr = value;
            }
        }

        /// <summary>
        /// Main function called when making a booking, verifies that fields are filled in correctly.
        /// Retrieves data and enum from form elements.
        /// </summary>
        /// <returns>If false, do not close the form until error is corrected.</returns>
        private bool ReadInput()
        {
            bool verify = true;

            newGuest.Firstname = txtFName.Text;
            if ( String.IsNullOrEmpty(txtFName.Text) )
            {
                MessageBox.Show("Firstname must be filled in");
                verify = false;
            }

            newGuest.Lastname = txtLName.Text;
            if (String.IsNullOrEmpty(txtLName.Text))
            {
                MessageBox.Show("Lastname must be filled in");
                verify = false;
            }

            if (btnFemale.Checked)
            {
                newGuest.Gender = "Female";
            }
            else if (btnMale.Checked)
            {
                newGuest.Gender = "Male";
            }

            newGuest.Country = (Country)boxCountry.SelectedIndex;
            if (boxCountry.SelectedItem == null)
            {
                MessageBox.Show("Country must be selected");
                verify = false;
            }

            newBook = new Booking(newGuest);

            newBook.Roomtype = (RoomType)boxRoom.SelectedIndex;
            if (boxRoom.SelectedItem == null)
            {
                MessageBox.Show("Roomtype must be selected");
                verify = false;
            }

            if (boxBreakfast.SelectedItem == null)
            {
                MessageBox.Show("Please select breakfast or not");
                verify = false;
            }
            if (boxBreakfast.SelectedItem != null)
            {
                if (boxBreakfast.SelectedItem.Equals("Yes"))
                {
                    newBook.Breakfast = true;
                }
                if (boxBreakfast.SelectedItem.Equals("No"))
                {
                    newBook.Breakfast = false;
                }
            }

            newBook.Payment = boxPayment.Text;

            if (newBook.verifyStay(dateCheckIn.Value, dateCheckOut.Value) == false) {
                string error = newBook.errorMessage;
                MessageBox.Show(error);
                verify = false;
            } else {
                newBook.Incheckning = dateCheckIn.Value;
                newBook.Utcheckning = dateCheckOut.Value;
            }

            string currRoom = boxRoom.SelectedValue.ToString();            
            
            switch (currRoom)                                                   // Switch cases, adds to different lists based
            {                                                                   // on roomtype, to track bookings.
                case "Single":
                    newBook.Roominfo.Rumstyp = RoomType.Single;                 // Check current renum roomtype
                    if (roomMngr.addSingleRoom(newBook.Roominfo))               // Add to different list based on type
                    {
                        int singleNr = roomMngr.Singlecount + 100;              // Create roomnumber based on roomtyp, Single starts at 100
                        newBook.Roominfo.Roomnumber = singleNr;
                    } else
                    {
                        MessageBox.Show("Single Rooms full!");                  // If room type list is full, prohibit booking
                        verify = false;
                    }
                    
                    break;
                case "Double":
                    newBook.Roominfo.Rumstyp = RoomType.Double;
                    if (roomMngr.addDoubleRoom(newBook.Roominfo))
                    {
                        int doubleNr = roomMngr.Doublecount + 200;              // Double rooms start at 200
                        newBook.Roominfo.Roomnumber = doubleNr;
                    }
                    else
                    {
                        MessageBox.Show("Double Rooms full!");
                        verify = false;
                    }
                    break;
                case "Superior":
                    newBook.Roominfo.Rumstyp = RoomType.Superior;
                    if (roomMngr.addSuperRoom(newBook.Roominfo))
                    {
                        int superNr = roomMngr.Supercount + 300;                // Superior rooms start at 300
                        newBook.Roominfo.Roomnumber = superNr;
                    }
                    else
                    {
                        MessageBox.Show("Superior Rooms full!");
                        verify = false;
                    }
                    
                    break;
                case "Executive":
                    newBook.Roominfo.Rumstyp = RoomType.Executive;
                    if (roomMngr.addExecRoom(newBook.Roominfo))
                    {
                        int execNr = roomMngr.Execcount + 400;                  // Executive rooms start at 400
                        newBook.Roominfo.Roomnumber = execNr;
                    }
                    else
                    {
                        MessageBox.Show("Executive Rooms full!");
                        verify = false;
                    }
                    break;
            }



            return verify;                                                      // Return if fills are filled in and rooms are not full
        }

        /// <summary>
        /// Display data used if change button is pressed, populate field based on current guest and booking
        /// </summary>
        public void displayData ()
        {
            txtFName.Text = GuestData.Firstname;
            txtLName.Text = GuestData.Lastname;
            if (GuestData.Gender == "Male")
            {
                btnMale.Checked = true;
            }
            if (GuestData.Gender == "Female")
            {
                btnFemale.Checked = true;
            }

            
            boxCountry.SelectedIndex = (int)GuestData.Country;
            boxRoom.SelectedIndex = (int)BookData.Roomtype;
            boxPayment.Text = BookData.Payment;

            if (BookData.Breakfast == true)
            {
                boxBreakfast.Text = "Yes";
            }
            if (BookData.Breakfast == false)
            {
                boxBreakfast.Text = "No";
            }

            dateCheckIn.Value = BookData.Incheckning;
            dateCheckOut.Value = BookData.Utcheckning;
            
        }

        /// <summary>
        /// When book button is pressed, call readinput and verify.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBook_Click(object sender, EventArgs e)
        {
            if (!ReadInput())                                       // If false, set closeform to false so that window is not closed
            {
                closeForm = false;
            } else
            {
                GuestData = newGuest;                               
                BookData = newBook;

                string temp = GuestData.Firstname;
                

                closeForm = true;
            }
        }

        /// <summary>
        /// Before form is closed, check the variable if form should be closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeForm)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            closeForm = true;
        }

        /// <summary>
        /// When roomtypes are changed in the selection, change labels
        /// and check availiblity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currRoom = boxRoom.SelectedValue.ToString();                             // Retrieve roomtype enum and convert to string

            

            switch(currRoom)
            {
                case "Single":
                    lblPrice.Text = "400kr per natt";                                       // Change price label based on selection
                    int singleAvail = roomMngr.SingleMax - roomMngr.Singlecount;            // Check avalibilty of the roomtype
                    lblAvail.Text = singleAvail + " Rooms left";
                    break;
                case "Double":
                    lblPrice.Text = "800kr per natt";
                    int doubleAvail = roomMngr.Doublemax - roomMngr.Doublecount;                  
                    lblAvail.Text = doubleAvail + " Rooms left";                    
                    break;
                case "Superior":
                    lblPrice.Text = "1400kr per natt";
                    int superAvail = roomMngr.Superiormax - roomMngr.Supercount;
                    lblAvail.Text = superAvail + " Rooms left";
                    break;
                case "Executive":
                    lblPrice.Text = "2200kr per natt";
                    int execAvail = roomMngr.Execmax - roomMngr.Execcount;
                    lblAvail.Text = execAvail + " Rooms left";
                    break;                
            }
        }

    }
}
