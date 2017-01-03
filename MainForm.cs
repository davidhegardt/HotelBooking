/**
 * David Hegardt 
 * Final Project - Hotel booking
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
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FormsProject
{

    public partial class MainForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]             // Creates rounden borders for the form
        private static extern IntPtr CreateRoundRectRgn
(
int nLeftRect, // x-coordinate of upper-left corner
int nTopRect, // y-coordinate of upper-left corner
int nRightRect, // x-coordinate of lower-right corner
int nBottomRect, // y-coordinate of lower-right corner
int nWidthEllipse, // height of ellipse
int nHeightEllipse // width of ellipse
);
        Booking currBooking = new Booking();
        Guest currGuest = new Guest();
        Registry currRegistry = new Registry();
        Billing newBilling;
        RoomManager currRoomMngr = new RoomManager();

        public MainForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(10, 10,
            Width - 10, Height - 15, 20, 20));
            ControlBox = false;
            Text = "";

            boxInfo.Visible = false;
            //currRoomMngr.createRooms();
            startScreen();
        }

        /// <summary>
        /// Shows the inital screen with information labels on how to use 
        /// application. Makes labels visible. Screen is shown when returning
        /// from a menu
        /// </summary>
        private void startScreen()
        {
            lblMenu.Text = "Welcome";
            boxInfo.Visible = false;
            lblInfo1.Visible = true;
            lblInfo2.Visible = true;
            lblInfo3.Visible = true;
            lblInfo4.Visible = true;
            lblInfo5.Visible = true;
            lblInfo6.Visible = true;
            lblInfo7.Visible = true;
            lblInfo1.Text = "Welcome to the HotelBooking Reservation system";
            lblInfo2.Text = "- New Booking lets you input a new booking in the system";
            lblInfo3.Text = "- To calculate bill for the guest, press the Billing button";
            lblInfo4.Text = "- To get to the Hotel Register, press the registry key";
            lblInfo5.Text = "- Search and Delete can be done from the Registry menu";
            lblInfo6.Text = "- To Change a booking and see bill for customer, ";
            lblInfo7.Text = "select Change from the Registry Menu then press Billing";
            
        }
        /// <summary>
        /// Hide labels in main form so that Registry can be displayed
        /// </summary>
        private void hideLabels()
        {
            lblInfo1.Visible = false;
            lblInfo2.Visible = false;
            lblInfo3.Visible = false;
            lblInfo4.Visible = false;
            lblInfo5.Visible = false;
            lblInfo6.Visible = false;
            lblInfo7.Visible = false;
        }
        /// <summary>
        /// Action even when clicking booking button. Make registry box invisible.
        /// Instantiates bookForm object. Calls function to show labels in the background
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBooking_Click(object sender, EventArgs e)
        {
            //
            boxInfo.Visible = false;            
            bookGUI();
            startScreen();

        }

        /// <summary>
        /// Hides labels, calls function for Registry and sets the heading label
        /// to proper text. Enables listbox of guests
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistry_Click(object sender, EventArgs e)
        {
            hideLabels();
            registryGUI();
            boxInfo.Text = "Registry";
            lstGuests.Enabled = true;
        }

        /// <summary>
        /// Hides registry combobox, calls Startscreen to be displayed in background
        /// and calls function for billing gui.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBilling_Click(object sender, EventArgs e)
        {
            boxInfo.Visible = false;
            //hideLabels();
            startScreen();
            calcGUI();
        }

        /// <summary>
        /// Custom button created to close application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            
        }

        /// <summary>
        /// Takes user to the startscreen when clicking the logo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            lblMenu.Text = "Welcome";
            startScreen();
        }

        public RoomManager Manager
        {
            get { return currRoomMngr; }
            set
            {
                currRoomMngr = value;
            }
        }

        /// <summary>
        /// Main function to start the booking form class.
        /// After form is filled in, assigns the booking instance object
        /// to be copied from the formbooking class.
        /// Also retrieves the guestobject from the booking form.
        /// </summary>
        private void bookGUI()
        {
            btnBooking.BackColor = Color.FromArgb(41, 53, 65);
            btnRegistry.BackColor = Color.DimGray;
            btnBilling.BackColor = Color.DimGray;            

            lblMenu.Text = "New Booking";
            

            bookForm formBooking = new bookForm(currRoomMngr);           
            if ( formBooking.ShowDialog() == DialogResult.OK)
            {
                currBooking = formBooking.BookData;                 // Retrieve booking from booking form
                
                currGuest = formBooking.GuestData;                  // Retrieve guest from booking form

                string tmp = currGuest.Firstname;

                MessageBox.Show(tmp);                

                currRegistry.addGuest(currGuest);                   // Adds guest to the registry
                currRegistry.addBooking(currBooking);               // Adds booking to the registry
                Manager = formBooking.RoomManager;                  // Assigns the current manager object to the updated from booking
            }
        }

        /// <summary>
        /// Main function to start Registry gui.
        /// Registry updates the mainform and does not start a new form for registry.
        /// Sets correct form utilities.
        /// </summary>
        private void registryGUI()
        {
            btnRegistry.BackColor = Color.FromArgb(41, 53, 65);
            btnBilling.BackColor = Color.DimGray;
            btnBooking.BackColor = Color.DimGray;
            txtGuestInfo.Text = String.Empty;

            btnDelete.Enabled = true;
            btnChange.Enabled = true;

            boxInfo.Visible = true;
            lstGuests.Visible = true;
            btnSearch.Visible = true;
            btnDelete.Visible = true;
            btnLoad.Visible = true;
            btnSave.Visible = true;
            txtGuestInfo.Visible = true;

            lstGuests.Items.Clear();
            String[] guestListString = currRegistry.getCustomerInfo();              // Retrieve customer list as string
            lstGuests.Items.AddRange(guestListString);                              // Adds list to the listbox guest

            lblMenu.Text = "Registry";
        }

        /// <summary>
        /// Main function to start Booking gui. Billing is always calculated
        /// based on the current booking and the billing object. Billing
        /// is only displayed and not stored, no instance variable needed.
        /// </summary>
        private void calcGUI()
        {
            btnBilling.BackColor = Color.FromArgb(41, 53, 65);
            btnBooking.BackColor = Color.DimGray;
            btnRegistry.BackColor = Color.DimGray;

            lblMenu.Text = "Calculator";

            Billing newBill = new Billing(currBooking);                                                     // Call Billing constructor with booking as argument

            CalcForm billingForm = new CalcForm(newBill,currGuest.Firstname,currGuest.Lastname);            // Call bilingform constructor with params needed to be displayed.

            billingForm.ShowDialog();                                                                       // Does not require Dialogresult verification

        }

        /// <summary>
        /// Function to display booking and guest information when user clicks
        /// the selected guest name in the listbox. Appends both booking information
        /// and guest information, since they are stored as different objects.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstGuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGuestInfo.Text = String.Empty;
            int index = lstGuests.SelectedIndex;
            if (index > -1)
            {
                Booking tmpBooking = currRegistry.getBooking(index);
                Guest tmpGuest = currRegistry.getGuest(index);
                txtGuestInfo.AppendText("First Name : " + tmpGuest.Firstname);
                txtGuestInfo.AppendText(Environment.NewLine);
                txtGuestInfo.AppendText("Last Name : " + tmpGuest.Lastname);
                
                txtGuestInfo.AppendText(Environment.NewLine);
                txtGuestInfo.AppendText(Environment.NewLine);
                txtGuestInfo.AppendText("Incheckning : " + tmpBooking.Incheckning.ToShortDateString());
                txtGuestInfo.AppendText(Environment.NewLine);
                txtGuestInfo.AppendText("Utcheckning : " + tmpBooking.Utcheckning.ToShortDateString());
                txtGuestInfo.AppendText(Environment.NewLine);
                txtGuestInfo.AppendText("Roomtype : " + tmpBooking.Roomtype.ToString());
                txtGuestInfo.AppendText(Environment.NewLine);
                txtGuestInfo.AppendText("Payment type : " + tmpBooking.Payment);
                txtGuestInfo.AppendText(Environment.NewLine);
                txtGuestInfo.AppendText("Breakfast : " + tmpBooking.Breakfast);
                txtGuestInfo.AppendText(Environment.NewLine);
                txtGuestInfo.AppendText(Environment.NewLine);
                txtGuestInfo.AppendText("Country : " + tmpGuest.Country);
                txtGuestInfo.AppendText(Environment.NewLine);
                txtGuestInfo.AppendText("Gender : " + tmpGuest.Gender);
                txtGuestInfo.AppendText(Environment.NewLine);
                txtGuestInfo.AppendText("Number of Days : " + tmpBooking.calcTimeStay());
                txtGuestInfo.AppendText(Environment.NewLine);
                txtGuestInfo.AppendText("Roomnumber : " + tmpBooking.Roominfo.Roomnumber);


            }
        }

        /// <summary>
        /// Save button calls registry function to save booking to one file and guest information to one file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            currRegistry.saveToFile();
            currRegistry.saveBookFile();
            
        }

        /// <summary>
        /// Load function calls registry function to load guests and bookings and also loads bookings into the room manager.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            currRegistry.LoadBookingFile();
            currRegistry.LoadGuestFile();
            currRoomMngr.loadRooms(currRegistry.Bokninglist);

            registryGUI();
        }


        /// <summary>
        /// Function to call all the search functions. Instantiates an object of the searchform.
        /// Searches both through the guest object and call different methods based on this.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm newSearch = new SearchForm(currRegistry);                                    // Create new searchform object, send registry into constructor

            if (newSearch.ShowDialog() == DialogResult.OK)                                          // After search has been made
            {
                lstGuests.Items.Clear();                                                            // Clear listbox and disable change and delete buttons
                btnDelete.Enabled = false;
                btnChange.Enabled = false;               
                boxInfo.Text = "Search Results for " + newSearch.Searchword;                        // Change text to searchword
                lblMenu.Text = "Search Results ";
                lblMenu.ForeColor = Color.DarkSalmon;
                txtGuestInfo.Visible = false;                                                       // Disabled guest info box to not display wrong entry
                if (newSearch.Foundlist.Count != 0)                                                 // If something was found in the booking object
                {
                    List<Guest> results = newSearch.Foundlist;                                      // Retrieve list from the search form
                    if (results.Count != 0)
                    {
                        String[] foundListString = currRegistry.getSearchString(results);           // Retrieve string based on the foundlist object
                        lstGuests.Items.AddRange(foundListString);
                        txtGuestInfo.Visible = false;
                    }
                }

                List<Booking> bookResult = newSearch.Booklist;                                      // Retrieve booking results if serach was found in booking object
                               

                if (bookResult.Count != 0)                                                          // If list is empty, no results where found in the booking object
                {
                    List<Guest> newFoundList = new List<Guest>();                                   // Retrieve booking list and retrieve the Guest object
                    for (int i = 0; i < bookResult.Count; i++)                                      // Since guest objects are used to retrieve string list below
                    {                        
                        newFoundList.Add(bookResult[i].Guesten);
                        //MessageBox.Show("" + i);
                    }

                    String[] foundListString = currRegistry.getSearchString(newFoundList);          // When list has been made into a list of guest, call function
                    lstGuests.Items.AddRange(foundListString);                                      // to convert into string
                }

                int foundIndex = newSearch.Index;

                if (foundIndex > -1)                                                                // Retrieve index from search form
                {                    
                    Guest foundGuest = currRegistry.getGuest(foundIndex);                           // Retrieve found guest, used when searching for name
                    Booking foundBook = currRegistry.getBooking(foundIndex);
               
                    lstGuests.Items.Clear();

                    lstGuests.Items.Add(foundGuest.Firstname + " " + foundGuest.Lastname);          // Add found guest to listbox
                    
                    

                }
                
            }
        }

        /// <summary>
        /// Delete function, retrieves index from the selected list index.
        /// Calls delete function in the registry and show the roomnomber
        /// where booking will be removed. Also calls room manager to free up the room.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstGuests.SelectedIndex;

            if (index > -1)
            {
                MessageBox.Show(currRegistry.getBooking(index).Roominfo.Roomnumber.ToString());                 // Retrieve and display the roomnumber for guest
                if (currRoomMngr.deleteRoom(currRegistry.getBooking(index).Roominfo))                           // Call delete function in room manager
                {
                    MessageBox.Show("Room booking deleted");
                }
                currRegistry.deleteBooking(index);                                                              // Delete booking from the registry
                registryGUI();                                                                                  // Call function to update registry

            } else
            {
                MessageBox.Show("No customer selected");
            }
        }

        /// <summary>
        /// Change button, creates a new book form object.
        /// Calls function to send booking data and guest data to the bookform.
        /// When form is closed, retrieve the guest and assing to instance object booking and guest.
        /// This is used for Billing form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            bookForm changeBooking = new bookForm(currRoomMngr);                        // Send room manager object when calling constructor

            int index = lstGuests.SelectedIndex;

            if (index > -1)
            {
                changeBooking.GuestData = currRegistry.getGuest(index);                 // Assign guest of selected index to the bookform
                changeBooking.BookData = currRegistry.getBooking(index);                // Assign booking of selected index to the bookform
                changeBooking.displayData();                                            // Display information in the bookform

                if (changeBooking.ShowDialog() == DialogResult.OK)
                {
                    currBooking = changeBooking.BookData;                               // Assing instance variable to the changed guest and booking
                    currGuest = changeBooking.GuestData;

                    currRegistry.changeBooking(currBooking, index);                     // call registry to update booking list
                    currRegistry.changeGuest(currGuest, index);                         // call registry to update guest list
                    registryGUI();
                }

            } else
            {
                MessageBox.Show("No Guest selected..");
            }
        }
    }
}
