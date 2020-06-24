using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1.ListForm
{
    public partial class FormList : Form
    {
        private Form1 main_form;

        public FormList(Form1 __main)
        {
            InitializeComponent();

            main_form = __main;
        }

        private void FormList_Load(object sender, EventArgs e)
        {
            string[] string_elements;
            int i, j = 0;

            elements_list.View = View.Details;
            elements_list.GridLines = true;
            elements_list.FullRowSelect = true;

            elements_list.Columns.Add("ID", 120);
            elements_list.Columns.Add("Data", 140);
            elements_list.Columns.Add("Ora incepere", 110);
            elements_list.Columns.Add("Ora sfarsit", 100);
            elements_list.Columns.Add("Pricipal alocat", 140);
            elements_list.Columns.Add("Secundar alocat", 120);
            elements_list.Columns.Add("Pregatire alocat", 140);
            elements_list.Columns.Add("Ora total", 90);
            elements_list.Columns.Add("Observatii", 270);

            string_elements = new string[Constants.entries];

            foreach (WorkStuff element in main_form.elements)
            {
                ListViewItem itm;

                for (i = 0; i < Constants.entries; i++)
                    setLoad(main_form.elements, ref string_elements, i, j);

                itm = new ListViewItem(string_elements);
                elements_list.Items.Add(itm);

                ++j;
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            string id;
            int i;

            if (elements_list.SelectedItems.Count == 0)
            {
                MessageBox.Show("No element selected!");
                return;
            }

            id = elements_list.SelectedItems[0].SubItems[0].Text;
            elements_list.SelectedItems[0].Remove();

            for (i = 0; i < main_form.elements.Count; i++)
                if (id == main_form.elements[i].id)
                {
                    main_form.elements.RemoveAt(i);
                    --main_form.total_rows;
                    MessageBox.Show("Elements removed!");
                    return;
                }

            MessageBox.Show("No elements found!");
        }

        private void setLoad(List<WorkStuff> elements, ref string[] string_elements, int i, int j)
        {
            switch (i)
            {
                case 0:
                    string_elements[i] = elements[j].id;
                    break;
                case 1:
                    string_elements[i] = elements[j].day;
                    break;
                case 2:
                    string_elements[i] = elements[j].start_hour;
                    break;
                case 3:
                    string_elements[i] = elements[j].stop_hour;
                    break;
                case 4:
                    string_elements[i] = elements[j].principal_hours;
                    break;
                case 5:
                    string_elements[i] = elements[j].secundar_hours;
                    break;
                case 6:
                    string_elements[i] = elements[j].pregatire_hours;
                    break;
                case 7:
                    string_elements[i] = elements[j].total_hours;
                    break;
                case 8:
                    string_elements[i] = elements[j].observatii;
                    break;
            }
        }
    }
}
