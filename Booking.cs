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
    public class Booking
    {
        //Instance variables
        private Guest theGuest;
        private RoomType theRoom;
        private Room roomInfo = new Room();
        private string payType;
        private bool breakfast;
        private DateTime checkIn;
        private DateTime checkOut;
        private string bookError;

        public Booking()
        {

        }

        public Booking(Guest currGuest)
        {
            this.theGuest = currGuest;
        }

        /// <summary>
        /// Properties to set and get guest object, roomtype, payment, breakfast, checkin/out, Room object
        /// </summary>
        public Guest Guesten
        {
            get { return theGuest; }
            set
            {
                theGuest = value;
            }
        }

        public RoomType Roomtype
        {
            get { return theRoom; }
            set
            {
                theRoom = value;
            }
        }

        public String Payment
        {
            get { return payType; }
            set
            {
                payType = value;
            }
        }

        public bool Breakfast
        {
            get { return breakfast; }
            set
            {
                breakfast = value;
            }
        }

        public DateTime Incheckning
        {
            get { return checkIn; }
            set
            {
                checkIn = value;
            }
        }

        public DateTime Utcheckning
        {
            get { return checkOut; }
            set
            {
                checkOut = value;
            }
        }

        public Room Roominfo
        {
            get { return roomInfo; }
            set
            {
                roomInfo = value;
            }
        }

        public String errorMessage
        {
            get { return bookError; }
        }

        /// <summary>
        /// Calculates time of stay based on checkin and checkout, uses timespan object to convert to days
        /// </summary>
        /// <returns>days as int</returns>
        public int calcTimeStay()
        {
            DateTime incheck = Incheckning;
            DateTime utcheck = Utcheckning;

            TimeSpan totalTime = utcheck - incheck;

            return Convert.ToInt32(totalTime.TotalDays);
        }

       
        /// <summary>
        /// Verifies stay so user cannot checkout before checking in
        /// </summary>
        /// <param name="currCheckin">Current datetime of checking</param>
        /// <param name="currCheckout">Current datetime of checkout</param>
        /// <returns></returns>
        public bool verifyStay(DateTime currCheckin, DateTime currCheckout)
        {
            bool bookOk = true;

            if (currCheckin.Date > currCheckout.Date)
            {
                bookOk = false;
                bookError = "Check in date cannot be before checkout! ";
            }

            if (currCheckin.Date == currCheckout.Date)
            {
                bookOk = false;
                bookError = "Check in and checkout cannot be on the same date";
            }

            return bookOk;
        }

    }
}
