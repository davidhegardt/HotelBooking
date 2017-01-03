/**
 * David Hegardt 
 * Final project - Hotel booking
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
     * Billing class - used to calculate cost of stay in the hotel booking system. 
     * Uses booking class for calculations
    */
    public class Billing
    {
        /// <summary>
        /// Instance variables - booking object and constants used for calculation
        /// </summary>
        private Booking theBook;
        private const double TaxRate = 0.15;
        private const int CleanRate = 60;
        private const int breakCost = 100;
        private const double deposit = 0.05;
        private double roomService;
        private double sumNoVat;
        private double VAT;
        private double sumDeposit;
        private double grandTotal;

        /// <summary>
        /// Main constructor
        /// </summary>
        /// <param name="currBook"> Booking object</param>
        public Billing(Booking currBook)
        {
            this.theBook = currBook;
        }

        /// <summary>
        /// Function to determine day rate based on room
        /// </summary>
        /// <returns>return current day rate based on roomtype enum</returns>
        private int calcRoomCost()
        {
            RoomType rummet = theBook.Roomtype;
            int Cost = 0;

            switch(rummet)
            {
                case RoomType.Single:
                    Cost = 400;
                    break;
                case RoomType.Double:
                    Cost = 800;
                    break;
                case RoomType.Superior:
                    Cost = 1400;
                    break;
                case RoomType.Executive:
                    Cost = 2200;
                    break;
            }

            return Cost;
        }

        /// <summary>
        /// Properties for room service cost and calculate number of days
        /// </summary>
        public double RoomService
        {
            get { return roomService; }
            set
            {
                roomService = value;
            }
        }

        /// <summary>
        /// Calls function to calculate number of days
        /// </summary>
        public int DayNumbers
        {
            get { int count = theBook.calcTimeStay();
                  return count; }
        }

        /// <summary>
        /// Calculates roomcost based on room and number of days stayed
        /// </summary>
        /// <returns></returns>
        private double sumRoom()
        {
            double sumRoomCost = calcRoomCost() * DayNumbers;
            return sumRoomCost;
        }

        /// <summary>
        /// Calculates breakfast if breakfast is chosen - otherwise returns 0
        /// </summary>
        /// <returns></returns>
        public double sumBreakfast()
        {
            double sumBreakfast;
            if (theBook.Breakfast)
            {
                sumBreakfast = breakCost * DayNumbers;
            } else
            {
                sumBreakfast = 0.0;
            }
            return sumBreakfast;
        }      

        /// <summary>
        /// Calculates cost of cleaning based on cleaning cost and number of days
        /// </summary>
        /// <returns></returns>
        public int sumCleaning()
        {
            int sumClean = CleanRate * DayNumbers;
            return sumClean;
        }

        /// <summary>
        /// Properties to retrieve data
        /// </summary>
        public Double getVat
        {
            get { return VAT; }
        }

        public Double getSum
        {
            get { return sumNoVat; }
        }

        public Double getTotDeposit
        {
            get { return sumDeposit; }
        }

        public Double Grandtotal
        {
            get { return grandTotal; }
        }

        /// <summary>
        /// Main calculation function to calculate totalt cost for room.
        /// </summary>
        public void calcTotal()        {

            double noVatCost = sumRoom() + sumBreakfast() + sumCleaning() + RoomService;                // Call calculation functions before VAT

            this.sumNoVat = noVatCost;                
                      
            double VAT = TaxRate * noVatCost;                                                           // Calculate VAT cost based on const

            this.VAT = VAT;

            double totDeposit = sumRoom() * deposit;                                                    // Calculate deposit cost based on const

            this.sumDeposit = totDeposit;

            double totalSum = noVatCost + VAT + totDeposit;                                             // Add everything to a total cost
            grandTotal = totalSum;
        }

    }
}
