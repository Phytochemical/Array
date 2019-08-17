using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class MainForm : Form
    {
        PartyList myPartyList;

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;

            lblTotalCost.Text = "0.0";
            lblTotalGuest.Text = string.Empty;
            lstAllGuest.Items.Clear();

            grpAddGuest.Enabled = false;
            grpNewParty.Enabled = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreateList_Click(object sender, EventArgs e)
        {
            bool isMAxNumValid = CreateParty();
            bool isAmountValid = ReadCostPerPerson();

            if (isMAxNumValid == false)
            {
                return;
            }

            if (isAmountValid && isMAxNumValid)
            {
                grpAddGuest.Enabled = true;
                UpdateGUI();
            }
        }

        private bool CreateParty()
        {
            int maxNumber = 0;
            bool isValueValid = true;

            if (int.TryParse (txtMaxNum.Text, out maxNumber) && (maxNumber > 0 ))
            {
                myPartyList = new PartyList(maxNumber);
                MessageBox.Show($"Party list with total of {maxNumber} guests created.", "Success");
            }
            else
            {
                MessageBox.Show("Invalid number. Please use correct format.", "Error");
                isValueValid = false;
            }

            return isValueValid;
        }

        private bool ReadCostPerPerson()
        {
            double amount = 0.0;
            bool isValueValid = true;

            if (double.TryParse (txtAmount.Text, out amount) && (amount >= 1))
            {
                myPartyList.CostPerPerson = amount;
            }
            else
            {
                MessageBox.Show("Invalid amount. Please enter again");
                isValueValid = false;
            }

            return isValueValid;
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateGUI()
        {
            int index;
            lstAllGuest.Items.Clear();
            string[] guestList = myPartyList.GetGuestList();
            

            if (guestList != null)
            {
                for (index = 0; index < guestList.Length; index++)
                {
                    string str = $"{index + 1, 4} {guestList[index],-20}";
                    lstAllGuest.Items.Add(str);
                }
            }
            else
            {
                return;
            }

            double totalCost = myPartyList.CalcTotalCost();
            lblTotalCost.Text = totalCost.ToString("0.00");
            lblTotalGuest.Text = myPartyList.Count.ToString();
        }

        /// <summary>
        /// verify if the text is empty
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private bool ValidateText(string text)
        {
            text = text.Trim();

            if (string.IsNullOrEmpty (text))
            {
                MessageBox.Show("Please provide the first and last name", "Error");

                return false;
            }
            else
            {
                return true;
            }
        }

        private bool TrimName()
        {
            if ( (!ValidateText (txtFirstName.Text)) || (!ValidateText (txtLastName.Text)) )
            {
                return false;
            }
            else
            {
                txtFirstName.Text = txtFirstName.Text.Trim();
                txtLastName.Text = txtLastName.Text.Trim();

                return true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (TrimName ())
            {
                bool isInputValid = myPartyList.AddNewGuest(txtFirstName.Text, txtLastName.Text);

                if (isInputValid == false)
                {
                    MessageBox.Show("New guest could not be added. The list is full", "Error");
                }
                else
                {
                    UpdateGUI();
                }
            }
        }

        /// <summary>
        /// check
        /// </summary>
        /// <returns></returns>
        private int ListItemBoxSelectCheck()
        {
            int index = lstAllGuest.SelectedIndex;

            if (lstAllGuest.SelectedIndex < 0)
            {
                MessageBox.Show("Select an item from the list");

                return -1;
            }

            return index;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = ListItemBoxSelectCheck();
            
            if (index < 0)
            {
                //return;
            }
            else
            {
                //myPartyList.DeleteAt();
                UpdateGUI();
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            int index = ListItemBoxSelectCheck();

            if (index < 0)
            {

            }
            else if (TrimName())
            {
                //myPartyList.ChangeAt(index, txtFirstName.Text, txtLastName.Text);
                UpdateGUI();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}