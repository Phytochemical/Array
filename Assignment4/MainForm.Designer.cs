namespace Assignment4
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTotalNumberOfGuests = new System.Windows.Forms.Label();
            this.lblCostPerPerson = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalGuests = new System.Windows.Forms.Label();
            this.txtMaxNum = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.buttonCreateList = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.grpNewParty = new System.Windows.Forms.GroupBox();
            this.grpAddGuest = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTotalGuest = new System.Windows.Forms.Label();
            this.lstAllGuest = new System.Windows.Forms.ListBox();
            this.grpNewParty.SuspendLayout();
            this.grpAddGuest.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalNumberOfGuests
            // 
            this.lblTotalNumberOfGuests.AutoSize = true;
            this.lblTotalNumberOfGuests.Location = new System.Drawing.Point(6, 33);
            this.lblTotalNumberOfGuests.Name = "lblTotalNumberOfGuests";
            this.lblTotalNumberOfGuests.Size = new System.Drawing.Size(115, 13);
            this.lblTotalNumberOfGuests.TabIndex = 1;
            this.lblTotalNumberOfGuests.Text = "Total number of guests";
            // 
            // lblCostPerPerson
            // 
            this.lblCostPerPerson.AutoSize = true;
            this.lblCostPerPerson.Location = new System.Drawing.Point(11, 60);
            this.lblCostPerPerson.Name = "lblCostPerPerson";
            this.lblCostPerPerson.Size = new System.Drawing.Size(81, 13);
            this.lblCostPerPerson.TabIndex = 2;
            this.lblCostPerPerson.Text = "Cost per person";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(8, 33);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(55, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(7, 62);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 13);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last name";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(34, 314);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total cost";
            this.lblTotal.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblTotalGuests
            // 
            this.lblTotalGuests.AutoSize = true;
            this.lblTotalGuests.Location = new System.Drawing.Point(34, 337);
            this.lblTotalGuests.Name = "lblTotalGuests";
            this.lblTotalGuests.Size = new System.Drawing.Size(65, 13);
            this.lblTotalGuests.TabIndex = 7;
            this.lblTotalGuests.Text = "Total guests";
            // 
            // txtMaxNum
            // 
            this.txtMaxNum.Location = new System.Drawing.Point(169, 33);
            this.txtMaxNum.Name = "txtMaxNum";
            this.txtMaxNum.Size = new System.Drawing.Size(55, 20);
            this.txtMaxNum.TabIndex = 8;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(169, 60);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(55, 20);
            this.txtAmount.TabIndex = 9;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(88, 33);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(133, 20);
            this.txtFirstName.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(88, 62);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(133, 20);
            this.txtLastName.TabIndex = 11;
            // 
            // buttonCreateList
            // 
            this.buttonCreateList.Location = new System.Drawing.Point(74, 86);
            this.buttonCreateList.Name = "buttonCreateList";
            this.buttonCreateList.Size = new System.Drawing.Size(91, 26);
            this.buttonCreateList.TabIndex = 14;
            this.buttonCreateList.Text = "Create list";
            this.buttonCreateList.UseVisualStyleBackColor = true;
            this.buttonCreateList.Click += new System.EventHandler(this.buttonCreateList_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(71, 97);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(91, 26);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(281, 293);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(91, 26);
            this.buttonChange.TabIndex = 17;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(394, 293);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(91, 26);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // grpNewParty
            // 
            this.grpNewParty.Controls.Add(this.buttonCreateList);
            this.grpNewParty.Controls.Add(this.txtAmount);
            this.grpNewParty.Controls.Add(this.txtMaxNum);
            this.grpNewParty.Controls.Add(this.lblCostPerPerson);
            this.grpNewParty.Controls.Add(this.lblTotalNumberOfGuests);
            this.grpNewParty.Location = new System.Drawing.Point(24, 26);
            this.grpNewParty.Name = "grpNewParty";
            this.grpNewParty.Size = new System.Drawing.Size(240, 121);
            this.grpNewParty.TabIndex = 19;
            this.grpNewParty.TabStop = false;
            this.grpNewParty.Text = "New party";
            this.grpNewParty.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grpAddGuest
            // 
            this.grpAddGuest.Controls.Add(this.buttonAdd);
            this.grpAddGuest.Controls.Add(this.txtLastName);
            this.grpAddGuest.Controls.Add(this.txtFirstName);
            this.grpAddGuest.Controls.Add(this.lblLastName);
            this.grpAddGuest.Controls.Add(this.lblFirstName);
            this.grpAddGuest.Location = new System.Drawing.Point(27, 153);
            this.grpAddGuest.Name = "grpAddGuest";
            this.grpAddGuest.Size = new System.Drawing.Size(239, 133);
            this.grpAddGuest.TabIndex = 20;
            this.grpAddGuest.TabStop = false;
            this.grpAddGuest.Text = "Invite guest";
            this.grpAddGuest.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Guest list";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCost.Location = new System.Drawing.Point(131, 313);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(117, 13);
            this.lblTotalCost.TabIndex = 22;
            // 
            // lblTotalGuest
            // 
            this.lblTotalGuest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalGuest.Location = new System.Drawing.Point(131, 337);
            this.lblTotalGuest.Name = "lblTotalGuest";
            this.lblTotalGuest.Size = new System.Drawing.Size(117, 13);
            this.lblTotalGuest.TabIndex = 23;
            // 
            // lstAllGuest
            // 
            this.lstAllGuest.FormattingEnabled = true;
            this.lstAllGuest.Location = new System.Drawing.Point(272, 36);
            this.lstAllGuest.Name = "lstAllGuest";
            this.lstAllGuest.Size = new System.Drawing.Size(225, 251);
            this.lstAllGuest.TabIndex = 24;
            this.lstAllGuest.SelectedIndexChanged += new System.EventHandler(this.lstAllGuest_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 362);
            this.Controls.Add(this.lstAllGuest);
            this.Controls.Add(this.lblTotalGuest);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grpAddGuest);
            this.Controls.Add(this.grpNewParty);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.lblTotalGuests);
            this.Controls.Add(this.lblTotal);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpNewParty.ResumeLayout(false);
            this.grpNewParty.PerformLayout();
            this.grpAddGuest.ResumeLayout(false);
            this.grpAddGuest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTotalNumberOfGuests;
        private System.Windows.Forms.Label lblCostPerPerson;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalGuests;
        private System.Windows.Forms.TextBox txtMaxNum;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button buttonCreateList;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox grpNewParty;
        private System.Windows.Forms.GroupBox grpAddGuest;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblTotalGuest;
        private System.Windows.Forms.ListBox lstAllGuest;
    }
}

