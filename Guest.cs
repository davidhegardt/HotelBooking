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
    public class Guest
    {
        //Instance variables 
        private string firstName;
        private string lastName;
        private string gender;
        private Country currCountry;

        // Empty constructor
        public Guest()
        {

        }

        /// <summary>
        /// Properites for name, gender and country
        /// </summary>
        public String Firstname
        {
            get { return firstName; }
            set
            {
                firstName = value;
            }
        }

        public String Lastname
        {
            get { return lastName; }
            set
            {
                lastName = value;
            }
        }

        public String Gender
        {
            get { return gender; }
            set
            {
                gender = value;
            }
        }

        public Country Country
        {
            get { return currCountry; }
            set
            {
                currCountry = value;
            }
        }

    }
}
