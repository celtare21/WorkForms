namespace WindowsFormsApp1.ListForm
{
    partial class FormList
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
            this.elements_list = new System.Windows.Forms.ListView();
            this.delete_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // elements_list
            // 
            this.elements_list.HideSelection = false;
            this.elements_list.Location = new System.Drawing.Point(73, 12);
            this.elements_list.Name = "elements_list";
            this.elements_list.Size = new System.Drawing.Size(1152, 554);
            this.elements_list.TabIndex = 0;
            this.elements_list.UseCompatibleStateImageBehavior = false;
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.Location = new System.Drawing.Point(518, 573);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(223, 49);
            this.delete_button.TabIndex = 1;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 634);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.elements_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormList";
            this.Text = "FormList";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView elements_list;
        private System.Windows.Forms.Button delete_button;
    }
}