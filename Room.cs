/**
 * David Hegardt 
 * Final Project - Hotel booking system
 * 2017-01-03
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsProject
{
    /**
     * Class used for Room object, used by booking system 
     * 
    */
    public class Room
    {
        //Instance variables
        private RoomType rumstyp;
        private int roomNr;
        private Boolean booked = false;

        public Room()
        {

        }
        /// <summary>
        /// Overloaded constructor - takes roomtype and roomnumber
        /// </summary>
        /// <param name="currTyp"></param>
        /// <param name="currNr"></param>
        public Room(RoomType currTyp, int currNr)
        {
            this.rumstyp = currTyp;
            this.roomNr = currNr;
            //this.booked = false;
        }

        /// <summary>
        /// Properties to set roomtype,number and booking status
        /// </summary>
        public RoomType Rumstyp
        {
            get { return rumstyp; }
            set
            {
                rumstyp = value;
            }
        }

        public int Roomnumber
        {
            get {
                return roomNr; }
            set
            {
                roomNr = value;
            }
        }

        public Boolean Booked
        {
            get { return booked; }
            set
            {
                booked = value;
            }
        }
           

    }
}
