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
            this.textMaxNum = new System.Windows.Forms.TextBox();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.buttonCreateList = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupAddGuests = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.labelTotalGuest = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupAddGuests.SuspendLayout();
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
            // textMaxNum
            // 
            this.textMaxNum.Location = new System.Drawing.Point(169, 33);
            this.textMaxNum.Name = "textMaxNum";
            this.textMaxNum.Size = new System.Drawing.Size(55, 20);
            this.textMaxNum.TabIndex = 8;
            // 
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(169, 60);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(55, 20);
            this.textAmount.TabIndex = 9;
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(87, 33);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(133, 20);
            this.textFirstName.TabIndex = 10;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(87, 62);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(133, 20);
            this.textLastName.TabIndex = 11;
            // 
            // buttonCreateList
            // 
            this.buttonCreateList.Location = new System.Drawing.Point(72, 91);
            this.buttonCreateList.Name = "buttonCreateList";
            this.buttonCreateList.Size = new System.Drawing.Size(91, 26);
            this.buttonCreateList.TabIndex = 14;
            this.buttonCreateList.Text = "Create list";
            this.buttonCreateList.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(71, 97);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(91, 26);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.textBox7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox7.Location = new System.Drawing.Point(270, 52);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(251, 281);
            this.textBox7.TabIndex = 16;
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCreateList);
            this.groupBox1.Controls.Add(this.textAmount);
            this.groupBox1.Controls.Add(this.textMaxNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 133);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New party";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupAddGuests
            // 
            this.groupAddGuests.Controls.Add(this.buttonAdd);
            this.groupAddGuests.Controls.Add(this.textLastName);
            this.groupAddGuests.Controls.Add(this.textFirstName);
            this.groupAddGuests.Controls.Add(this.label6);
            this.groupAddGuests.Controls.Add(this.label5);
            this.groupAddGuests.Location = new System.Drawing.Point(25, 183);
            this.groupAddGuests.Name = "groupAddGuests";
            this.groupAddGuests.Size = new System.Drawing.Size(239, 140);
            this.groupAddGuests.TabIndex = 20;
            this.groupAddGuests.TabStop = false;
            this.groupAddGuests.Text = "Invite guest";
            this.groupAddGuests.Enter += new System.EventHandler(this.groupBox2_Enter);
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
            // labelTotalCost
            // 
            this.labelTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalCost.Location = new System.Drawing.Point(147, 339);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(117, 13);
            this.labelTotalCost.TabIndex = 22;
            // 
            // labelTotalGuest
            // 
            this.labelTotalGuest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalGuest.Location = new System.Drawing.Point(147, 366);
            this.labelTotalGuest.Name = "labelTotalGuest";
            this.labelTotalGuest.Size = new System.Drawing.Size(117, 13);
            this.labelTotalGuest.TabIndex = 23;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 412);
            this.Controls.Add(this.labelTotalGuest);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupAddGuests);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupAddGuests.ResumeLayout(false);
            this.groupAddGuests.PerformLayout();
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
        private System.Windows.Forms.TextBox textMaxNum;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Button buttonCreateList;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupAddGuests;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.Label labelTotalGuest;
    }
}

