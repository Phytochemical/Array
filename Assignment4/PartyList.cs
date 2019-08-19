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

        // store guest names
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

        /// <summary>
        /// converts last name to upper case
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lasName"></param>
        /// <returns></returns>
        public string GustName(string firstName, string lasName)
        {
            return lasName.ToUpper() + " , " + firstName;
        }

        /// <summary>
        /// save guest name from guestList to registered guest array which contains no empty elements
        /// must save array to new array since it's immutable
        /// </summary>
        /// <returns></returns>
        public string[] GetGuestList()
        {
            int numOfRegisteredGuests = NumOfGuest();
            int i, j;

            if (numOfRegisteredGuests <= 0)
            {
                return null;
            }

            string[] guests = new string[numOfRegisteredGuests];

            for (i = 0, j = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    guests[j] = guestList[i];
                    j++;
                }
            }

            return guests;
        }

        public int Count
        {
            get { return NumOfGuest(); }
        }

        public double CalcTotalCost()
        {
            int numOfGuests = NumOfGuest();
            double totalCost = numOfGuests * costPerPerson;

            return totalCost;
        }

        /// <summary>
        /// check index out of upper bound
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool CheckIndex(int index)
        {
            return (index >= 0) && (index < guestList.Length);
        }

        /// <summary>
        /// check index and if it's empty returns null
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string GetItemAt(int index)
        {
            if (CheckIndex(index) )
            {
                return guestList[index];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// empties element to be deleted at specified index and moves the indes with value by one
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DeleteItemAt(int index)
        {
            bool isItemEmpty = false;

            if (CheckIndex (index) )
            {
                // do not use Array.Clear(guestList, index, length) it throws index out of bounds at the last index
                guestList[index] = null;
                // move empty 
                MoveEmptyElementOneStop(index);
                isItemEmpty = true;
            }
            return isItemEmpty;
        }

        /// <summary>
        /// moves index with empty element
        /// </summary>
        /// <param name="index"></param>
        private void MoveEmptyElementOneStop(int index)
        {
            for (int counter = index + 1; counter < guestList.Length; counter++)
            {
                // move element by one index from the index of element that is supposed to be deleted
                guestList[counter - 1] = guestList[counter];
                guestList[counter] = string.Empty;
            }
        }

        /// <summary>
        /// returns last name in upper case and prints the full name
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        private string FullName(string firstName, string lastName)
        {
            return lastName.ToUpper() + " , " + firstName;
        }

        public bool ChangeItemAt(int index, string firstName, string lastName)
        {
            bool isValid = false;

            if (CheckIndex(index))
            {
                guestList[index] = FullName(firstName, lastName);
            }
            else
            {
                isValid = true;
            }

            return isValid;
        }
        
    }
}
