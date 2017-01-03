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
using System.Windows.Forms;

namespace FormsProject
{
    /**
     * RoomManager class - handles room bookings based on roomtype 
     * 
    */
    public class RoomManager
    {
        /// <summary>
        /// Instance variables - Room manager uses different list based on roomtype
        /// Constants are set to determine maximum number of bookings.
        /// </summary>
        private List<Room> doubleRoomList = new List<Room>();
        private List<Room> singleRoomList = new List<Room>();
        private List<Room> superRoomList = new List<Room>();
        private List<Room> execRoomList = new List<Room>();
        private const int doubleMax = 10;
        private const int singleMax = 10;
        private const int superiorMax = 8;
        private const int execMax = 3;

        public RoomManager()
        {
            
        }

        /// <summary>
        /// Adds roomtype to specifed roomtype list if count is less than maximum const
        /// </summary>
        /// <param name="newRoom"></param>
        /// <returns></returns>
        public bool addDoubleRoom(Room newRoom)
        {
            bool okAdd = true;
            if (Doublecount >= doubleMax)
            {
                okAdd = false;
            }
            else
            {
                doubleRoomList.Add(newRoom);
                okAdd = true;
            }

            return okAdd;
        }
        
        public bool addSingleRoom(Room newRoom)
        {
            bool okAdd = true;
            if (Singlecount >= singleMax)
            {
                okAdd = false;
            }
            else
            {
                singleRoomList.Add(newRoom);
                okAdd = true;
            }

            return okAdd;
        }

        public bool addSuperRoom(Room newRoom)
        {
            bool okAdd = true;
            if (Supercount >= superiorMax)
            {
                okAdd = false;
            }
            else
            {
                superRoomList.Add(newRoom);
                okAdd = true;
            }

            return okAdd;
        }

        public bool addExecRoom(Room newRoom)
        {
            bool okAdd = true;
            if (Execcount >= execMax)
            {
                okAdd = false;
            }
            else
            {
                execRoomList.Add(newRoom);
                okAdd = true;
            }

            return okAdd;
        }

        /// <summary>
        /// Function to delete a room, recies the Room object and checks wich type is used.
        /// Loops through all lists and deletes matching roomnumber
        /// </summary>
        /// <param name="tmpRoom"></param>
        /// <returns>if found and deleted</returns>
        public bool deleteRoom(Room tmpRoom)
        {
            bool deleted = false;
            for (int index = 0; index < Singlecount; index++)
            {
                if (singleRoomList[index].Roomnumber == tmpRoom.Roomnumber)
                {
                    singleRoomList.RemoveAt(index);
                    deleted = true;
                }

            }
            for (int index = 0; index < Doublecount; index++)
            {
                if (doubleRoomList[index].Roomnumber == tmpRoom.Roomnumber)
                {
                    doubleRoomList.RemoveAt(index);
                    deleted = true;
                }
            }
            for (int index = 0; index < Execcount; index++)
            {
                if (execRoomList[index].Roomnumber == tmpRoom.Roomnumber)
                {
                    execRoomList.RemoveAt(index);
                    deleted = true;
                }
            }

            for (int index = 0; index < Supercount; index++)
            {
                if (superRoomList[index].Roomnumber == tmpRoom.Roomnumber)
                {
                    superRoomList.RemoveAt(index);
                    deleted = true;
                }
            }

            return deleted;
        }

        
        /// <summary>
        /// Load rooms - loads the read rooms when reading from file into the different lists
        /// </summary>
        /// <param name="currBookings">The current list read in</param>
        public void loadRooms(List<Booking> currBookings)
        {
            for (int index = 0; index < currBookings.Count; index++)
            {
                if (currBookings[index].Roominfo.Rumstyp == RoomType.Single)
                {
                    addSingleRoom(currBookings[index].Roominfo);
                }
                else if (currBookings[index].Roominfo.Rumstyp == RoomType.Double)
                {
                    addDoubleRoom(currBookings[index].Roominfo);
                }
                else if (currBookings[index].Roominfo.Rumstyp == RoomType.Executive)
                {
                    addExecRoom(currBookings[index].Roominfo);
                }
                else if (currBookings[index].Roominfo.Rumstyp == RoomType.Superior)
                {
                    addSuperRoom(currBookings[index].Roominfo);
                }
            }


        }

        /// <summary>
        /// Properties for counting the room types
        /// </summary>
        public int Doublecount
        {
            get { return doubleRoomList.Count; }
        }

        public int Singlecount
        {
            get { return singleRoomList.Count; }
        }

        public int Supercount
        {
            get { return superRoomList.Count; }
        }

        public int Execcount
        {
            get { return execRoomList.Count; }
        }

        public int SingleMax
        {
            get { return singleMax; }
        }

        public int Doublemax
        {
            get { return doubleMax; }
        }

        public int Superiormax
        {
            get { return superiorMax; }
        }

        public int Execmax
        {
            get { return execMax; }
        }

    }
}
