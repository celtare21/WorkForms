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
            this.load_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.get_hours_normal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.get_hours_custom = new System.Windows.Forms.Button();
            this.go_back = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.pret_pregatire = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.pret_recuperare = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pret_curs = new System.Windows.Forms.TextBox();
            this.pret_fixed = new System.Windows.Forms.TextBox();
            this.go_back_2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.enter_get_hours_custom = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.enter_pret = new System.Windows.Forms.Button();
            this.ora_inceput_text = new System.Windows.Forms.TextBox();
            this.ora_inceput_box = new System.Windows.Forms.TextBox();
            this.select_1_check = new System.Windows.Forms.CheckBox();
            this.select_2_check = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
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
            this.comboBox1.Text = "Ore curs";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(155, 219);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Text = "Ore Pregatire";
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
            this.textBox1.Text = "Ore Curs";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(292, 219);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(90, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Ore Pregatire";
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(307, 287);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(75, 23);
            this.load_button.TabIndex = 6;
            this.load_button.Text = "Load";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
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
            this.comboBox3.Text = "Ore recuperare";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(292, 247);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(90, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Ore Recuperare";
            // 
            // get_hours_normal
            // 
            this.get_hours_normal.Location = new System.Drawing.Point(155, 325);
            this.get_hours_normal.Name = "get_hours_normal";
            this.get_hours_normal.Size = new System.Drawing.Size(75, 23);
            this.get_hours_normal.TabIndex = 10;
            this.get_hours_normal.Text = "Get Hours";
            this.get_hours_normal.UseVisualStyleBackColor = true;
            this.get_hours_normal.Click += new System.EventHandler(this.get_hours_normal_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.get_hours_custom);
            this.panel1.Controls.Add(this.go_back);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.browse);
            this.panel1.Location = new System.Drawing.Point(65, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 333);
            this.panel1.TabIndex = 11;
            // 
            // get_hours_custom
            // 
            this.get_hours_custom.Location = new System.Drawing.Point(56, 265);
            this.get_hours_custom.Name = "get_hours_custom";
            this.get_hours_custom.Size = new System.Drawing.Size(75, 23);
            this.get_hours_custom.TabIndex = 3;
            this.get_hours_custom.Text = "Get Hours";
            this.get_hours_custom.UseVisualStyleBackColor = true;
            this.get_hours_custom.Click += new System.EventHandler(this.get_hours_custom_Click);
            // 
            // go_back
            // 
            this.go_back.Location = new System.Drawing.Point(337, 268);
            this.go_back.Name = "go_back";
            this.go_back.Size = new System.Drawing.Size(75, 23);
            this.go_back.TabIndex = 2;
            this.go_back.Text = "Go Back";
            this.go_back.UseVisualStyleBackColor = true;
            this.go_back.Click += new System.EventHandler(this.go_back_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(56, 139);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(249, 20);
            this.textBox4.TabIndex = 1;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(342, 136);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 0;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox11);
            this.panel2.Controls.Add(this.pret_pregatire);
            this.panel2.Controls.Add(this.textBox15);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.pret_recuperare);
            this.panel2.Controls.Add(this.textBox10);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.pret_curs);
            this.panel2.Controls.Add(this.pret_fixed);
            this.panel2.Controls.Add(this.go_back_2);
            this.panel2.Location = new System.Drawing.Point(94, 12);
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
            this.textBox6.Text = "Ore recuperare:";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pret_recuperare
            // 
            this.pret_recuperare.Location = new System.Drawing.Point(185, 180);
            this.pret_recuperare.Name = "pret_recuperare";
            this.pret_recuperare.Size = new System.Drawing.Size(100, 20);
            this.pret_recuperare.TabIndex = 11;
            this.pret_recuperare.Text = "0";
            this.pret_recuperare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.textBox5.Text = "Ore curs:";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pret_curs
            // 
            this.pret_curs.Location = new System.Drawing.Point(185, 62);
            this.pret_curs.Name = "pret_curs";
            this.pret_curs.Size = new System.Drawing.Size(100, 20);
            this.pret_curs.TabIndex = 6;
            this.pret_curs.Text = "0";
            this.pret_curs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // enter_get_hours_custom
            // 
            this.enter_get_hours_custom.Location = new System.Drawing.Point(155, 359);
            this.enter_get_hours_custom.Name = "enter_get_hours_custom";
            this.enter_get_hours_custom.Size = new System.Drawing.Size(121, 23);
            this.enter_get_hours_custom.TabIndex = 12;
            this.enter_get_hours_custom.Text = "Get Hours Custom";
            this.enter_get_hours_custom.UseVisualStyleBackColor = true;
            this.enter_get_hours_custom.Click += new System.EventHandler(this.enter_get_hours_custom_Click);
            // 
            // enter_pret
            // 
            this.enter_pret.Location = new System.Drawing.Point(307, 359);
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
            // select_1_check
            // 
            this.select_1_check.AutoSize = true;
            this.select_1_check.Checked = true;
            this.select_1_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.select_1_check.Location = new System.Drawing.Point(417, 250);
            this.select_1_check.Name = "select_1_check";
            this.select_1_check.Size = new System.Drawing.Size(65, 17);
            this.select_1_check.TabIndex = 16;
            this.select_1_check.Text = "Select 1";
            this.select_1_check.UseVisualStyleBackColor = true;
            this.select_1_check.CheckedChanged += new System.EventHandler(this.select_1_check_CheckedChanged);
            // 
            // select_2_check
            // 
            this.select_2_check.AutoSize = true;
            this.select_2_check.Location = new System.Drawing.Point(417, 276);
            this.select_2_check.Name = "select_2_check";
            this.select_2_check.Size = new System.Drawing.Size(65, 17);
            this.select_2_check.TabIndex = 17;
            this.select_2_check.Text = "Select 2";
            this.select_2_check.UseVisualStyleBackColor = true;
            this.select_2_check.CheckedChanged += new System.EventHandler(this.select_2_check_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 394);
            this.Controls.Add(this.select_2_check);
            this.Controls.Add(this.select_1_check);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ora_inceput_box);
            this.Controls.Add(this.ora_inceput_text);
            this.Controls.Add(this.enter_pret);
            this.Controls.Add(this.enter_get_hours_custom);
            this.Controls.Add(this.get_hours_normal);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.load_button);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button get_hours_normal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button enter_get_hours_custom;
        private System.Windows.Forms.Button go_back;
        private System.Windows.Forms.Button get_hours_custom;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox pret_curs;
        private System.Windows.Forms.TextBox pret_fixed;
        private System.Windows.Forms.Button go_back_2;
        private System.Windows.Forms.Button enter_pret;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox pret_pregatire;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox pret_recuperare;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox ora_inceput_text;
        private System.Windows.Forms.TextBox ora_inceput_box;
        private System.Windows.Forms.CheckBox select_1_check;
        private System.Windows.Forms.CheckBox select_2_check;
    }
}

