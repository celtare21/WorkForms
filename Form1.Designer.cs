namespace WindowsFormsApp1
{
    partial class Form1
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.add_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.pret_pregatire = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.pret_secundar = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pret_principal = new System.Windows.Forms.TextBox();
            this.pret_fixed = new System.Windows.Forms.TextBox();
            this.go_back_2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.enter_pret = new System.Windows.Forms.Button();
            this.ora_inceput_text = new System.Windows.Forms.TextBox();
            this.ora_inceput_box = new System.Windows.Forms.TextBox();
            this.monday = new System.Windows.Forms.CheckBox();
            this.tuesday = new System.Windows.Forms.CheckBox();
            this.wednesday = new System.Windows.Forms.CheckBox();
            this.thursday = new System.Windows.Forms.CheckBox();
            this.friday = new System.Windows.Forms.CheckBox();
            this.saturday = new System.Windows.Forms.CheckBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(155, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(155, 192);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Ore principal";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(155, 219);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Text = "Ore secundar";
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(155, 287);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 3;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(292, 193);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Ore Principal";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(292, 219);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(90, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Ore Secundar";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(307, 325);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 7;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(155, 246);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.Text = "Ore pregatire";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(292, 247);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(90, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Ore Pregatire";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox11);
            this.panel2.Controls.Add(this.pret_pregatire);
            this.panel2.Controls.Add(this.textBox15);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.pret_secundar);
            this.panel2.Controls.Add(this.textBox10);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.pret_principal);
            this.panel2.Controls.Add(this.pret_fixed);
            this.panel2.Controls.Add(this.go_back_2);
            this.panel2.Location = new System.Drawing.Point(76, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 370);
            this.panel2.TabIndex = 4;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(39, 261);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 18;
            this.textBox11.Text = "Ore pregatire:";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pret_pregatire
            // 
            this.pret_pregatire.Location = new System.Drawing.Point(185, 287);
            this.pret_pregatire.Name = "pret_pregatire";
            this.pret_pregatire.Size = new System.Drawing.Size(100, 20);
            this.pret_pregatire.TabIndex = 16;
            this.pret_pregatire.Text = "0";
            this.pret_pregatire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(39, 287);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(100, 20);
            this.textBox15.TabIndex = 14;
            this.textBox15.Text = "Pret/h";
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(39, 148);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 13;
            this.textBox6.Text = "Ore secundar:";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pret_secundar
            // 
            this.pret_secundar.Location = new System.Drawing.Point(185, 180);
            this.pret_secundar.Name = "pret_secundar";
            this.pret_secundar.Size = new System.Drawing.Size(100, 20);
            this.pret_secundar.TabIndex = 11;
            this.pret_secundar.Text = "0";
            this.pret_secundar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(39, 180);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 9;
            this.textBox10.Text = "Pret/h";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(39, 36);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "Ore principal:";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pret_principal
            // 
            this.pret_principal.Location = new System.Drawing.Point(185, 62);
            this.pret_principal.Name = "pret_principal";
            this.pret_principal.Size = new System.Drawing.Size(100, 20);
            this.pret_principal.TabIndex = 6;
            this.pret_principal.Text = "0";
            this.pret_principal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pret_fixed
            // 
            this.pret_fixed.Location = new System.Drawing.Point(39, 62);
            this.pret_fixed.Name = "pret_fixed";
            this.pret_fixed.ReadOnly = true;
            this.pret_fixed.Size = new System.Drawing.Size(100, 20);
            this.pret_fixed.TabIndex = 4;
            this.pret_fixed.Text = "Pret/h";
            this.pret_fixed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // go_back_2
            // 
            this.go_back_2.Location = new System.Drawing.Point(286, 344);
            this.go_back_2.Name = "go_back_2";
            this.go_back_2.Size = new System.Drawing.Size(75, 23);
            this.go_back_2.TabIndex = 3;
            this.go_back_2.Text = "Go Back";
            this.go_back_2.UseVisualStyleBackColor = true;
            this.go_back_2.Click += new System.EventHandler(this.go_back_2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // enter_pret
            // 
            this.enter_pret.Location = new System.Drawing.Point(155, 325);
            this.enter_pret.Name = "enter_pret";
            this.enter_pret.Size = new System.Drawing.Size(75, 23);
            this.enter_pret.TabIndex = 13;
            this.enter_pret.Text = "Price";
            this.enter_pret.UseVisualStyleBackColor = true;
            this.enter_pret.Click += new System.EventHandler(this.enter_pret_Click_1);
            // 
            // ora_inceput_text
            // 
            this.ora_inceput_text.Location = new System.Drawing.Point(407, 192);
            this.ora_inceput_text.Name = "ora_inceput_text";
            this.ora_inceput_text.ReadOnly = true;
            this.ora_inceput_text.Size = new System.Drawing.Size(100, 20);
            this.ora_inceput_text.TabIndex = 14;
            this.ora_inceput_text.Text = "Ora inceput";
            this.ora_inceput_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ora_inceput_box
            // 
            this.ora_inceput_box.Location = new System.Drawing.Point(407, 219);
            this.ora_inceput_box.Name = "ora_inceput_box";
            this.ora_inceput_box.Size = new System.Drawing.Size(100, 20);
            this.ora_inceput_box.TabIndex = 15;
            this.ora_inceput_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // monday
            // 
            this.monday.AutoSize = true;
            this.monday.Location = new System.Drawing.Point(34, 62);
            this.monday.Name = "monday";
            this.monday.Size = new System.Drawing.Size(64, 17);
            this.monday.TabIndex = 16;
            this.monday.Text = "Monday";
            this.monday.UseVisualStyleBackColor = true;
            // 
            // tuesday
            // 
            this.tuesday.AutoSize = true;
            this.tuesday.Location = new System.Drawing.Point(34, 85);
            this.tuesday.Name = "tuesday";
            this.tuesday.Size = new System.Drawing.Size(67, 17);
            this.tuesday.TabIndex = 17;
            this.tuesday.Text = "Tuesday";
            this.tuesday.UseVisualStyleBackColor = true;
            // 
            // wednesday
            // 
            this.wednesday.AutoSize = true;
            this.wednesday.Location = new System.Drawing.Point(34, 108);
            this.wednesday.Name = "wednesday";
            this.wednesday.Size = new System.Drawing.Size(83, 17);
            this.wednesday.TabIndex = 18;
            this.wednesday.Text = "Wednesday";
            this.wednesday.UseVisualStyleBackColor = true;
            // 
            // thursday
            // 
            this.thursday.AutoSize = true;
            this.thursday.Location = new System.Drawing.Point(34, 131);
            this.thursday.Name = "thursday";
            this.thursday.Size = new System.Drawing.Size(70, 17);
            this.thursday.TabIndex = 19;
            this.thursday.Text = "Thursday";
            this.thursday.UseVisualStyleBackColor = true;
            // 
            // friday
            // 
            this.friday.AutoSize = true;
            this.friday.Location = new System.Drawing.Point(34, 154);
            this.friday.Name = "friday";
            this.friday.Size = new System.Drawing.Size(54, 17);
            this.friday.TabIndex = 20;
            this.friday.Text = "Friday";
            this.friday.UseVisualStyleBackColor = true;
            // 
            // saturday
            // 
            this.saturday.AutoSize = true;
            this.saturday.Location = new System.Drawing.Point(34, 177);
            this.saturday.Name = "saturday";
            this.saturday.Size = new System.Drawing.Size(68, 17);
            this.saturday.TabIndex = 21;
            this.saturday.Text = "Saturday";
            this.saturday.UseVisualStyleBackColor = true;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(307, 359);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 22;
            this.delete_button.Text = "Delete Last";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 394);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.saturday);
            this.Controls.Add(this.friday);
            this.Controls.Add(this.thursday);
            this.Controls.Add(this.wednesday);
            this.Controls.Add(this.tuesday);
            this.Controls.Add(this.monday);
            this.Controls.Add(this.ora_inceput_box);
            this.Controls.Add(this.ora_inceput_text);
            this.Controls.Add(this.enter_pret);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tabel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox pret_principal;
        private System.Windows.Forms.TextBox pret_fixed;
        private System.Windows.Forms.Button go_back_2;
        private System.Windows.Forms.Button enter_pret;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox pret_pregatire;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox pret_secundar;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox ora_inceput_text;
        private System.Windows.Forms.TextBox ora_inceput_box;
        private System.Windows.Forms.CheckBox monday;
        private System.Windows.Forms.CheckBox tuesday;
        private System.Windows.Forms.CheckBox wednesday;
        private System.Windows.Forms.CheckBox thursday;
        private System.Windows.Forms.CheckBox friday;
        private System.Windows.Forms.CheckBox saturday;
        private System.Windows.Forms.Button delete_button;
    }
}

