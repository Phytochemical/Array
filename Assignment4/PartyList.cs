using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    /// <summary>
    /// process all data and tasks
    /// </summary>
    class PartyList
    {
        // stores cost
        private double costPerPerson;

        /// <summary>
        /// store guest names
        /// </summary>
        private string[] guestList;

        /// <summary>
        /// create array size
        /// </summary>
        /// <param name="maxNumGuest"></param>
        public PartyList(int maxNumGuest)
        {
            guestList = new string[maxNumGuest];
        }

        // property for cost
        public double CostPerPerson
        {
            get { return costPerPerson; }

            set
            {
                // cost shouldn't be negative amount
                if (value >= 0)
                {
                    costPerPerson = value;
                }
            }
        }

        /// <summary>
        /// count number of elements that aren't empty and save in array
        /// </summary>
        /// <param name="coutGuest"></param>
        /// <returns></returns>
        private int NumOfGuest(int coutGuest)
        {
            int guestCount = 0;
            int index;

            for (index = 0; index < guestList.Length; index++)
            {
                // check if list is empty
                if (string.IsNullOrEmpty(guestList[index]))
                {
                    guestCount++;
                    Console.Out.WriteLine(guestCount);
                }
            }

            return guestCount;
        }

        // add new guest
        // add first/last name

    }
}
