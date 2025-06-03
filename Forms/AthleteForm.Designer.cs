namespace KickBlastJudo.Forms
{
    partial class AthleteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.AthleteIdBox = new System.Windows.Forms.TextBox();
            this.AthleteNicBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AthleteDob = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.MaleRadio = new System.Windows.Forms.RadioButton();
            this.FemaleRadio = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.BloodType = new System.Windows.Forms.ComboBox();
            this.AthleteAddbutton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 53);
            this.label1.TabIndex = 15;
            this.label1.Text = "Manage Athletes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Athlete ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "Name: ";
            // 
            // userNameBox
            // 
            this.userNameBox.AccessibleName = "userNameTextBox";
            this.userNameBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameBox.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameBox.Location = new System.Drawing.Point(106, 114);
            this.userNameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(211, 25);
            this.userNameBox.TabIndex = 18;
            // 
            // AthleteIdBox
            // 
            this.AthleteIdBox.AccessibleName = "userNameTextBox";
            this.AthleteIdBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AthleteIdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AthleteIdBox.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AthleteIdBox.Location = new System.Drawing.Point(143, 155);
            this.AthleteIdBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AthleteIdBox.Name = "AthleteIdBox";
            this.AthleteIdBox.Size = new System.Drawing.Size(174, 25);
            this.AthleteIdBox.TabIndex = 19;
            // 
            // AthleteNicBox
            // 
            this.AthleteNicBox.AccessibleName = "userNameTextBox";
            this.AthleteNicBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AthleteNicBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AthleteNicBox.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AthleteNicBox.Location = new System.Drawing.Point(106, 198);
            this.AthleteNicBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AthleteNicBox.Name = "AthleteNicBox";
            this.AthleteNicBox.Size = new System.Drawing.Size(211, 25);
            this.AthleteNicBox.TabIndex = 21;
            this.AthleteNicBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 31);
            this.label4.TabIndex = 20;
            this.label4.Text = "NIC: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 31);
            this.label5.TabIndex = 22;
            this.label5.Text = "DOB: ";
            // 
            // AthleteDob
            // 
            this.AthleteDob.Font = new System.Drawing.Font("Montserrat", 12F);
            this.AthleteDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AthleteDob.Location = new System.Drawing.Point(106, 244);
            this.AthleteDob.Name = "AthleteDob";
            this.AthleteDob.Size = new System.Drawing.Size(157, 32);
            this.AthleteDob.TabIndex = 23;
            this.AthleteDob.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 31);
            this.label6.TabIndex = 24;
            this.label6.Text = "Gender: ";
            // 
            // MaleRadio
            // 
            this.MaleRadio.AutoSize = true;
            this.MaleRadio.Font = new System.Drawing.Font("Montserrat", 8F);
            this.MaleRadio.Location = new System.Drawing.Point(121, 299);
            this.MaleRadio.Name = "MaleRadio";
            this.MaleRadio.Size = new System.Drawing.Size(64, 26);
            this.MaleRadio.TabIndex = 25;
            this.MaleRadio.TabStop = true;
            this.MaleRadio.Text = "Male";
            this.MaleRadio.UseVisualStyleBackColor = true;
            // 
            // FemaleRadio
            // 
            this.FemaleRadio.AutoSize = true;
            this.FemaleRadio.Font = new System.Drawing.Font("Montserrat", 8F);
            this.FemaleRadio.Location = new System.Drawing.Point(189, 299);
            this.FemaleRadio.Name = "FemaleRadio";
            this.FemaleRadio.Size = new System.Drawing.Size(83, 26);
            this.FemaleRadio.TabIndex = 26;
            this.FemaleRadio.TabStop = true;
            this.FemaleRadio.Text = "Female";
            this.FemaleRadio.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 31);
            this.label7.TabIndex = 27;
            this.label7.Text = "Blood Type: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // BloodType
            // 
            this.BloodType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BloodType.FormattingEnabled = true;
            this.BloodType.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.BloodType.Location = new System.Drawing.Point(160, 341);
            this.BloodType.Name = "BloodType";
            this.BloodType.Size = new System.Drawing.Size(121, 24);
            this.BloodType.TabIndex = 28;
            // 
            // AthleteAddbutton
            // 
            this.AthleteAddbutton.AccessibleName = "loginButton";
            this.AthleteAddbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AthleteAddbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AthleteAddbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AthleteAddbutton.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AthleteAddbutton.Location = new System.Drawing.Point(342, 491);
            this.AthleteAddbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AthleteAddbutton.Name = "AthleteAddbutton";
            this.AthleteAddbutton.Size = new System.Drawing.Size(113, 49);
            this.AthleteAddbutton.TabIndex = 29;
            this.AthleteAddbutton.Text = "Add";
            this.AthleteAddbutton.UseVisualStyleBackColor = false;
            // 
            // UpdateButton
            // 
            this.UpdateButton.AccessibleName = "loginButton";
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(461, 491);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(113, 49);
            this.UpdateButton.TabIndex = 30;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AccessibleName = "loginButton";
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(699, 491);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(113, 49);
            this.DeleteButton.TabIndex = 30;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(410, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(402, 411);
            this.dataGridView1.TabIndex = 31;
            // 
            // ClearButton
            // 
            this.ClearButton.AccessibleName = "";
            this.ClearButton.BackColor = System.Drawing.Color.Magenta;
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(580, 491);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(113, 49);
            this.ClearButton.TabIndex = 29;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            // 
            // AthleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AthleteAddbutton);
            this.Controls.Add(this.BloodType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FemaleRadio);
            this.Controls.Add(this.MaleRadio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AthleteDob);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AthleteNicBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AthleteIdBox);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AthleteForm";
            this.Text = "AthleteForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.TextBox AthleteIdBox;
        private System.Windows.Forms.TextBox AthleteNicBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker AthleteDob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton MaleRadio;
        private System.Windows.Forms.RadioButton FemaleRadio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox BloodType;
        private System.Windows.Forms.Button AthleteAddbutton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ClearButton;
    }
}