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

        public double CalcTotalCost()
        {
            return 0.0;
        }

        /// <summary>
        /// keeps track of number of saved guests in the array
        /// </summary>
        /// <param name="coutGuest"></param>
        /// <returns></returns>
        private int NumOfGuest()
        {
            int guestCount = 0;
            int index;

            for (index = 0; index < guestList.Length; index++)
            {
                // check if list isn't empty
                if (!string.IsNullOrEmpty(guestList[index]))
                {
                    guestCount++;
                    Console.Out.WriteLine(guestCount);
                }
            }

            return guestCount;
        }

            /// <summary>
            /// locate empty array index
            /// it indicates if the array is full by returning -1
            /// </summary>
            /// <returns></returns>
        private int LocateEmptyIndex()
        {
            // locate empty index on array
            int emptyIndexPos = -1;
            int index;

            // last index on array array.Length -1
            for (index = guestList.Length - 1; index >= 0; index--)
            {
                Console.Out.WriteLine(guestList[index]);
                if (string.IsNullOrEmpty(guestList[index]))
                {
                    emptyIndexPos = index;
                    Console.Out.WriteLine(guestList[index]);
                    break;
                }
            }

            return emptyIndexPos;
        }

        /// <summary>
        /// locate the empty index and add firstName/lasName on array
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public bool AddNewGuest(string firstName, string lastName)
        {
            bool isValid = true;
            int emptyIndex = LocateEmptyIndex();

            if (emptyIndex != -1)
            {
                guestList[emptyIndex] = GustName(firstName, lastName);
            }
            else
            {
                isValid = false;
            }

            return isValid;
        }

        public string GustName(string firstName, string lasName)
        {
            return lasName.ToUpper() + " , " + firstName;
        }

        public string[] GetGuestList()
        {
            int numOfRegisteredGuests = NumOfGuest();
            int i, j;

            if (numOfRegisteredGuests <= 0)
            {
                return null;
            }

            string[] guests = new string[numOfRegisteredGuests];

            for(i = 0, j = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty (guestList[i]))
                {
                    guests[j++] = guestList[i];
                }
            }

            return guests;
        }
    }
}
