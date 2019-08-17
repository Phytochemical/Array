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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.lbTotalCost = new System.Windows.Forms.Label();
            this.lblTotalGuest = new System.Windows.Forms.Label();
            this.lstAllGuest = new System.Windows.Forms.ListBox();
            this.grpNewParty.SuspendLayout();
            this.grpAddGuest.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total number of guests";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cost per person";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "First name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Last name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total cost";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total guests";
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
            this.txtFirstName.Location = new System.Drawing.Point(87, 33);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(133, 20);
            this.txtFirstName.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(87, 62);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(133, 20);
            this.txtLastName.TabIndex = 11;
            // 
            // buttonCreateList
            // 
            this.buttonCreateList.Location = new System.Drawing.Point(72, 91);
            this.buttonCreateList.Name = "buttonCreateList";
            this.buttonCreateList.Size = new System.Drawing.Size(91, 26);
            this.buttonCreateList.TabIndex = 14;
            this.buttonCreateList.Text = "Create list";
            this.buttonCreateList.UseVisualStyleBackColor = true;
            this.buttonCreateList.Click += new System.EventHandler(this.buttonCreateList_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(71, 107);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(91, 26);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(298, 339);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(91, 26);
            this.buttonChange.TabIndex = 17;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(406, 339);
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
            this.grpNewParty.Controls.Add(this.label3);
            this.grpNewParty.Controls.Add(this.label2);
            this.grpNewParty.Location = new System.Drawing.Point(24, 36);
            this.grpNewParty.Name = "grpNewParty";
            this.grpNewParty.Size = new System.Drawing.Size(240, 133);
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
            this.grpAddGuest.Controls.Add(this.label6);
            this.grpAddGuest.Controls.Add(this.label5);
            this.grpAddGuest.Location = new System.Drawing.Point(25, 183);
            this.grpAddGuest.Name = "grpAddGuest";
            this.grpAddGuest.Size = new System.Drawing.Size(239, 140);
            this.grpAddGuest.TabIndex = 20;
            this.grpAddGuest.TabStop = false;
            this.grpAddGuest.Text = "Invite guest";
            this.grpAddGuest.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(358, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Guest list";
            // 
            // lbTotalCost
            // 
            this.lbTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTotalCost.Location = new System.Drawing.Point(147, 339);
            this.lbTotalCost.Name = "lbTotalCost";
            this.lbTotalCost.Size = new System.Drawing.Size(117, 13);
            this.lbTotalCost.TabIndex = 22;
            // 
            // lblTotalGuest
            // 
            this.lblTotalGuest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalGuest.Location = new System.Drawing.Point(147, 366);
            this.lblTotalGuest.Name = "lblTotalGuest";
            this.lblTotalGuest.Size = new System.Drawing.Size(117, 13);
            this.lblTotalGuest.TabIndex = 23;
            // 
            // lstAllGuest
            // 
            this.lstAllGuest.FormattingEnabled = true;
            this.lstAllGuest.Location = new System.Drawing.Point(272, 52);
            this.lstAllGuest.Name = "lstAllGuest";
            this.lstAllGuest.Size = new System.Drawing.Size(225, 264);
            this.lstAllGuest.TabIndex = 24;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 412);
            this.Controls.Add(this.lstAllGuest);
            this.Controls.Add(this.lblTotalGuest);
            this.Controls.Add(this.lbTotalCost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grpAddGuest);
            this.Controls.Add(this.grpNewParty);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.Label lbTotalCost;
        private System.Windows.Forms.Label lblTotalGuest;
        private System.Windows.Forms.ListBox lstAllGuest;
    }
}

