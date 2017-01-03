/**
 * David Hegardt 
 * Final Project - Hotel booking
 * 2017-01-03
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject
{
    /**
     * Registry class - handles storage of guests and bookings.
     * Also handles delete, change and search functions and loading
     * and saving of data in the system.
    */
    public class Registry
    {
        private List<Guest> gastLista;
        private List<Booking> bookingList;

        /// <summary>
        /// Constructor - instantiates new list of guests and booking.
        /// </summary>
        public Registry()
        {
            gastLista = new List<Guest>();
            bookingList = new List<Booking>();
        }

        /// <summary>
        /// Adds guest object to guest list
        /// </summary>
        /// <param name="currGast"></param>
        public void addGuest(Guest currGast)
        {
            gastLista.Add(currGast);
        }

        /// <summary>
        /// Adds booking object to booking list
        /// </summary>
        /// <param name="currBook"></param>
        public void addBooking(Booking currBook)
        {
            bookingList.Add(currBook);
        }

        /// <summary>
        /// Function to change a guest object in the list
        /// </summary>
        /// <param name="currGuest">guest object to replace</param>
        /// <param name="index">index in the list of the object</param>
        /// <returns></returns>
        public bool changeGuest(Guest currGuest,int index)
        {
            bool valid = false;
            if (index > -1 && index < gastLista.Count)          // Verify before change
            {
                gastLista[index] = currGuest;                   // Assign guest to index in list
                valid = true;
            }

            return valid;
        }

        /// <summary>
        /// Function to change a booking object in the list
        /// </summary>
        /// <param name="currBooking"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool changeBooking(Booking currBooking, int index)
        {
            bool valid = false;
            if (index > -1 && index < bookingList.Count)
            {
                bookingList[index] = currBooking;
                valid = true;
            }

            return valid;
        }

        /// <summary>
        /// Properties for list of guests and booking
        /// </summary>
        public List<Guest> Guestlist
        {
            get { return gastLista; }
            set
            {
                gastLista = value;
            }
        }

        public List<Booking> Bokninglist
        {
            get { return bookingList; }
            set
            {
                bookingList = value;
            }
        }

        /// <summary>
        /// Function to delete booking, verify before delete
        /// </summary>
        /// <param name="index">booking to delete</param>
        public void deleteBooking(int index)
        {
            if (index > -1 && index < bookingList.Count)
            {
                bookingList.RemoveAt(index);
                gastLista.RemoveAt(index);
            }
        }

        /// <summary>
        /// Function to clear both lists of all objects
        /// </summary>
        public void clearAll()
        {
            bookingList.Clear();
            gastLista.Clear();
        }

        
        /// <summary>
        /// Function to retrieve first and lastname as string from the guestlist
        /// </summary>
        /// <returns></returns>
        public String[] getCustomerInfo()
        {
            string[] guestInfoString = new string[gastLista.Count];

            for (int index = 0; index < gastLista.Count; index++)
            {
                string strFormat = gastLista[index].Firstname + " " + gastLista[index].Lastname;

                guestInfoString[index] = strFormat;
            }

            return guestInfoString;
        }

        /// <summary>
        /// Retries a list of guests when searchfunction is used
        /// </summary>
        /// <param name="foundList">list of found guests</param>
        /// <returns></returns>
        public String[] getSearchString(List<Guest> foundList)
        {
            string[] foundInfoString = new string[foundList.Count];

            for (int index = 0; index < foundList.Count; index++)
            {
                string strFormat = foundList[index].Firstname + " " + foundList[index].Lastname;

                foundInfoString[index] = strFormat;
            }

            return foundInfoString;

        }
        
        /// <summary>
        /// Retrieve guest and booking object
        /// </summary>
        /// <param name="index">index of object to retrieve</param>
        /// <returns></returns>
        public Booking getBooking(int index)
        {
            Booking tmpBooking = bookingList[index];

            return tmpBooking;
        }

        public Guest getGuest(int index)
        {
            Guest tmpGuest = gastLista[index];

            return tmpGuest;
        }

        /// <summary>
        /// Function to save Guestlist to file
        /// </summary>
        public void saveToFile()
        {
            string filename = Application.StartupPath + "\\Gaster.txt";      // Set current path and filename to Tasks.txt

            StreamWriter writer = null;                                     // Create new Streamwriter object to read input stream
            
            try                                                             // Try to save to file
            {
                writer = new StreamWriter(filename);                        // Assign writer to current filename

                for (int i = 0; i < gastLista.Count; i++)              // Loop through all items in task list
                {
                    writer.WriteLine(gastLista[i].Firstname);
                    writer.WriteLine(gastLista[i].Lastname);
                    writer.WriteLine(gastLista[i].Gender);
                    writer.WriteLine(gastLista[i].Country);                    
                }

                MessageBox.Show("Data saved to file: " + filename);         // Show confirmation when file saved
            }
            catch (Exception e)                                             // Catch exception if IO failure, display message
            {
                MessageBox.Show("Problems saving data to file, error: " + e.Message);
            }
            finally                                                         // Close writer when operation is done
            {
                if (writer != null)
                    writer.Close();
            }
        }

        /// <summary>
        /// Function to save bookings to file
        /// </summary>
        public void saveBookFile()
        {
            string filename = Application.StartupPath + "\\Booking.txt";      // Set current path and filename to Tasks.txt

            StreamWriter writer = null;                                     // Create new Streamwriter object to read input stream

            try                                                             // Try to save to file
            {
                writer = new StreamWriter(filename);                        // Assign writer to current filename

                for (int i = 0; i < bookingList.Count; i++)              // Loop through all items in task list
                {
                    writer.WriteLine(bookingList[i].Incheckning);
                    writer.WriteLine(bookingList[i].Utcheckning);
                    writer.WriteLine(bookingList[i].Payment);
                    writer.WriteLine(bookingList[i].Roomtype);
                    writer.WriteLine(bookingList[i].Breakfast);
                    writer.WriteLine(bookingList[i].Roominfo.Roomnumber);
                }

                MessageBox.Show("Data saved to file: " + filename);         // Show confirmation when file saved
            }
            catch (Exception e)                                             // Catch exception if IO failure, display message
            {
                MessageBox.Show("Problems saving data to file, error: " + e.Message);
            }
            finally                                                         // Close writer when operation is done
            {
                if (writer != null)
                    writer.Close();
            }
        }


        /// <summary>
        /// Function to load guest data into the list from file
        /// </summary>
        public void LoadGuestFile()
        {
            string filename = Application.StartupPath + "\\Gaster.txt";      // Set current path and filename to Tasks.txt
            StreamReader reader = null;                                     // Create new streamreader object to read input stream


            gastLista.Clear();                                         // Clear current items in tasklist before loading

            

            //Use try and catch to read from file, if failure display message

            try                                                             // Try to read from file
            {
                

                reader = new StreamReader(filename);                        // Assign reader to current filestream

                while (!reader.EndOfStream)                                 // While file not empty
                {
                    Guest tmpGuest = new Guest();
                    tmpGuest.Firstname = reader.ReadLine();
                    tmpGuest.Lastname = reader.ReadLine();
                    tmpGuest.Gender = reader.ReadLine();
                    string cntrString = reader.ReadLine();
                    Country tmpCountry = (Country)Enum.Parse(typeof(Country), cntrString);
                    tmpGuest.Country = tmpCountry;
                    gastLista.Add(tmpGuest);
                }
                
                MessageBox.Show("Guest Data Read from file: \n\n" + filename);
            }
            catch                                                           // Don't cast exception but display errormessage
            {
                MessageBox.Show("Cannot read data from file!", "Error");
            }
            finally                                                         // When read has been done, close StreamReader object
            {
                if (reader != null)
                    reader.Close();
            }


        }

        /// <summary>
        /// Function to load booking data into the list from file
        /// </summary>
        public void LoadBookingFile()
        {
            string filename = Application.StartupPath + "\\Booking.txt";      // Set current path and filename to Tasks.txt
            StreamReader reader = null;                                     // Create new streamreader object to read input stream


            bookingList.Clear();                                         // Clear current items in tasklist before loading



            //Use try and catch to read from file, if failure display message

            try                                                             // Try to read from file
            {


                reader = new StreamReader(filename);                        // Assign reader to current filestream

                while (!reader.EndOfStream)                                 // While file not empty
                {
                    Booking tmpBook = new Booking();
                    Room tmpRoom = new Room();
                    tmpBook.Incheckning = DateTime.Parse(reader.ReadLine());
                    tmpBook.Utcheckning = DateTime.Parse(reader.ReadLine());
                    tmpBook.Payment = reader.ReadLine();
                    string roomString = reader.ReadLine();                    
                    RoomType tmpRmTp = (RoomType)Enum.Parse(typeof(RoomType), roomString);
                    tmpBook.Roomtype = tmpRmTp;               
                    tmpBook.Breakfast = Boolean.Parse(reader.ReadLine());
                    tmpRoom.Roomnumber = int.Parse(reader.ReadLine());
                    tmpRoom.Rumstyp = tmpRmTp;
                    tmpBook.Roominfo = tmpRoom;                                       
                    bookingList.Add(tmpBook);
                }

                MessageBox.Show("Booking Data Read from file: \n\n" + filename);
            }
            catch                                                           // Don't cast exception but display errormessage
            {
                MessageBox.Show("Cannot read data from file!", "Error");
            }
            finally                                                         // When read has been done, close StreamReader object
            {
                if (reader != null)
                    reader.Close();
            }


        }
        /// <summary>
        /// Function to search for first and lastname
        /// </summary>
        /// <param name="searchName">search string</param>
        /// <param name="searchType">type of search</param>
        /// <returns></returns>

        public int searchGuest(string searchName, string searchType)
        {
            int foundIndex = -1;

            switch (searchType)
            {
                case "Name":
                    foundIndex = searchNameFunc(searchName);
                    break;                                
                default:
                    foundIndex = -1;
                    break;
            }

            return foundIndex;
        }

        /// <summary>
        /// Function to search for firstname and lastname.
        /// Search independant of charactare case and last / firstname
        /// </summary>
        /// <param name="searchName"></param>
        /// <returns></returns>
        public int searchNameFunc(string searchName)
        {
            int found = -1;

            for (int index = 0; index < gastLista.Count; index++)
            {
                if (gastLista[index].Firstname.ToUpper() == searchName.ToUpper())             // Loop through list and see if firstname matches searchstring
                {
                    found = index;
                }
                else if (gastLista[index].Lastname.ToUpper() == searchName.ToUpper())         // Loop through list and see if lastname matches searchstring
                {
                    found = index;
                }                
            }            
            

            return found;
        }

        /// <summary>
        /// Function to find all instances of enum country, uses a lambda expression to create a new guest list
        /// </summary>
        /// <param name="searchName">Country as string</param>
        /// <returns></returns>
        public List<Guest> countrySearch(string searchName)
        {
            var foundList = gastLista.FindAll(s => s.Country.Equals((Country)Enum.Parse(typeof(Country), searchName)));

            return foundList;
        }

        /// <summary>
        /// Function to find all instances of gender, uses a lambda expression to create a new guest list to get all matches.
        /// Converts to upper to allow different case searches.
        /// </summary>
        /// <param name="searchName">gender as string</param>
        /// <returns></returns>
        public List<Guest> genderSearch(string searchName)
        {        

            var foundList = gastLista.FindAll(s => s.Gender.ToUpper().Equals(searchName.ToUpper()));

            return foundList;
        }

        /// <summary>
        /// Function to search for bookings, calls different functions if searching for roomtype
        /// or dates of checkin/chekout.
        /// </summary>
        /// <param name="searchName"></param>
        /// <param name="searchType"></param>
        /// <returns></returns>
        public List<Booking> searchBooking(string searchName,string searchType)
        {
            List<Booking> foundlist = new List<Booking>();

            switch(searchType)
            {
                case "Roomtype":
                    foundlist = roomSearch(searchName);
                    break;
                case "Checkin":
                    foundlist = incheckSearch(searchName);
                    break;
                case "Checkout":
                    foundlist = utcheckSearch(searchName);
                    break;
                case "Paytype":
                    foundlist = paySearch(searchName);
                    break;
                //default: foundIndex = -1;
                //    break;
            }

            return foundlist;
        }

        /// <summary>
        /// Function to find all instances of roomtype, uses a lambda expression to create a new guest list to get all matches.
        /// Since booking object is searched, must first retrieve all guest objects based on the index of booking.
        /// </summary>
        /// <param name="searchName"> searchterm</param>
        /// <returns></returns>
        private List<Booking> roomSearch(string searchName)
        {           
            for (int index = 0; index < gastLista.Count; index++)
            {
                bookingList[index].Guesten = gastLista[index];
            }


            var foundList = bookingList.FindAll(s => s.Roomtype.Equals((RoomType)Enum.Parse(typeof(RoomType), searchName)));
            
            return foundList;

            
        }

        /// <summary>
        /// Function to find all instances of payment type, uses a lambda expression to create a new guest list to get all matches.
        /// Since booking object is searched, must first retrieve all guest objects based on the index of booking.
        /// </summary>
        /// <param name="searchName"> searchterm</param>
        /// <returns></returns>
        private List<Booking> paySearch(string searchName)
        {
            for (int index = 0; index < gastLista.Count; index++)
            {
                bookingList[index].Guesten = gastLista[index];
            }           

            var foundList = bookingList.FindAll(s => s.Payment.ToUpper().Equals(searchName.ToUpper()));

            return foundList;
        }

        /// <summary>
        /// Function to find all instances of checkin date, uses a lambda expression to create a new guest list to get all matches.
        /// Since booking object is searched, must first retrieve all guest objects based on the index of booking.
        /// </summary>
        /// <param name="searchName"> searchterm</param>
        /// <returns></returns>
        private List<Booking> incheckSearch(string searchName)
        {
            for (int index = 0; index < gastLista.Count; index++)
            {
                bookingList[index].Guesten = gastLista[index];
            }           

            var foundList = bookingList.FindAll(s => s.Incheckning.ToShortDateString().Equals(searchName));         //Convert term to datestring

            return foundList;
        }

        /// <summary>
        /// Function to find all instances of checkout date, uses a lambda expression to create a new guest list to get all matches.
        /// Since booking object is searched, must first retrieve all guest objects based on the index of booking.
        /// </summary>
        /// <param name="searchName"> searchterm</param>
        /// <returns></returns>
        private List<Booking> utcheckSearch(string searchName)
        {
            for (int index = 0; index < gastLista.Count; index++)
            {
                bookingList[index].Guesten = gastLista[index];
            }

            var foundList = bookingList.FindAll(s => s.Utcheckning.ToShortDateString().Equals(searchName));         //Convert term to datestring

            return foundList;            
        }
        

    }
}
