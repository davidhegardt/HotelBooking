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
     * Class used to display search form
     * and call different search functions
     * 
    */
    public partial class SearchForm : Form
    {
        private Registry tmpRegistry = new Registry();
        private String searchTerm;
        private int foundIndex = -1;
        private String typeOfSearch;
        private List<Guest> foundList = new List<Guest>();
        private List<Booking> foundBooking = new List<Booking>();


        /// <summary>
        /// Constructor uses registry do find data
        /// </summary>
        /// <param name="currReg"></param>
        public SearchForm(Registry currReg)
        {
            this.tmpRegistry = currReg;
            InitializeComponent();
            initGUI();
        }

        /// <summary>
        /// Properties
        /// </summary>
        public int Index
        {
            get { return foundIndex; }
            set
            {
                foundIndex = value;
            }
        }

        public List<Guest> Foundlist
        {
            get { return foundList; }

        }

        public String Searchword
        {
            get { return searchTerm; }
        }

        public List<Booking> Booklist
        {
            get { return foundBooking; }
            set
            {
                foundBooking = value;
            }
        }

        /// <summary>
        /// Initialize gui and populate comboboxes
        /// </summary>
        private void initGUI()
        {
            cmbxBook.Items.Add("Roomtype");
            
            cmbxBook.Items.Add("Paytype");
            
            cmbxBook.Items.Add("Checkin");
            
            cmbxBook.Items.Add("Checkout");
            

            cmbxGuest.Items.Add("Firstname");
            cmbxGuest.Items.Add("Lastname");
            cmbxGuest.Items.Add("Country");
            cmbxGuest.Items.Add("Gender");
        }

        /// <summary>
        /// Function to search in booking object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            if (typeOfSearch == "Paytype")                                          // Set searchterm variable based on type of search
            {
                searchTerm = txtBookSearch.Text;
            }
            else if (typeOfSearch == "Checkin")
            {
                searchTerm = dateTimePicker1.Value.ToShortDateString();
            }
            else if (typeOfSearch == "Checkout")
            {
                searchTerm = dateTimePicker1.Value.ToShortDateString();
            }
            else if (typeOfSearch == "Roomtype")
            {

                searchTerm = cmbxRoomType.SelectedValue.ToString();
            }

            MessageBox.Show(searchTerm);

            List<Booking> foundBooking = tmpRegistry.searchBooking(searchTerm, typeOfSearch);               // Call search function in registry

            if (foundBooking.Count != 0 )                                                                   // If list is empty, no matches found
            {
                MessageBox.Show(searchTerm + " Found!");
                Index = foundIndex;
                Booklist = foundBooking;
            }
            else
            {
                MessageBox.Show(searchTerm + " Not found..");
            }
        }

        /// <summary>
        /// Function to search in guest object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchGuest_Click(object sender, EventArgs e)
        {
            

            if (typeOfSearch == "Name")                                                     // Set searchterm based on selection
            {
                searchTerm = txtGuestSearch.Text;
            }
            else if(typeOfSearch == "Country")
            {
                searchTerm = cmbxCountry.SelectedValue.ToString();

                foundList = tmpRegistry.countrySearch(searchTerm);                          // Use different function to display multiple result
               
            }
            else if (typeOfSearch == "Gender")
            {
                searchTerm = txtGuestSearch.Text;
                foundList = tmpRegistry.genderSearch(searchTerm);                       
                

            }

            foundIndex = tmpRegistry.searchGuest(searchTerm, typeOfSearch);                 // Retrieve foundindex if search for name 

            if (foundIndex > -1 || foundList.Count != 0)                                    // Check if list is empty or foundindex = -1 means no match
            {
                MessageBox.Show(searchTerm + " Found!");
                Index = foundIndex;
            }
            else
            {
                MessageBox.Show(searchTerm + " Not found..");
            }
        }
      
        /// <summary>
        /// Set seach function based on selection in list - guest search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbxGuest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxGuest.SelectedItem.Equals("Firstname"))
            {
                typeOfSearch = "Name";
                cmbxCountry.Visible = false;
                txtGuestSearch.Visible = true;

            }
            if (cmbxGuest.SelectedItem.Equals("Lastname"))
            {
                typeOfSearch = "Name";
                cmbxCountry.Visible = false;
                txtGuestSearch.Visible = true;
            }
            if (cmbxGuest.SelectedItem.Equals("Country"))
            {
                typeOfSearch = "Country";
                cmbxCountry.Visible = true;
                txtGuestSearch.Visible = false;
                cmbxCountry.DataSource = Enum.GetNames(typeof(Country));
            }
            if (cmbxGuest.SelectedItem.Equals("Gender"))
            {
                typeOfSearch = "Gender";
                cmbxCountry.Visible = false;
                txtGuestSearch.Visible = true;
            }
        }

        /// <summary>
        /// Set seach function based on selection in list - booking search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbxBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxBook.SelectedItem.Equals("Roomtype"))
            {
                typeOfSearch = "Roomtype";
                cmbxRoomType.Visible = true;
                txtBookSearch.Visible = false;
                dateTimePicker1.Visible = false;
                cmbxRoomType.DataSource = Enum.GetNames(typeof(RoomType));
            }
            if (cmbxBook.SelectedItem.Equals("Checkin"))
            {
                typeOfSearch = "Checkin";
                cmbxRoomType.Visible = false;
                txtBookSearch.Visible = false;
                dateTimePicker1.Visible = true;
            }
            if (cmbxBook.SelectedItem.Equals("Checkout"))
            {
                typeOfSearch = "Checkout";
                cmbxRoomType.Visible = false;
                txtBookSearch.Visible = false;
                dateTimePicker1.Visible = true;
            }
            if (cmbxBook.SelectedItem.Equals("Paytype"))
            {
                typeOfSearch = "Paytype";
                cmbxRoomType.Visible = false;
                txtBookSearch.Visible = true;
                dateTimePicker1.Visible = false;
            }
        }
    }
}
