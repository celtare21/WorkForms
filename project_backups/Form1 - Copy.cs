using System;
using System.Globalization;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.Tables;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private ExcelWorksheet worksheet;
        private ExcelFile ef;
        private Table table;
        private string[,] elements;
        private static int i, j;
        private static bool init;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] hours = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8" };

            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            ef = new ExcelFile();
            worksheet = ef.Worksheets.Add("Tables");

            monthCalendar1.MaxSelectionCount = 1;
            comboBox1.Items.AddRange(hours);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedItem = "0";
            comboBox2.Items.AddRange(hours);
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.SelectedItem = "0";

            elements = new string[10, 4];

            worksheet.Cells[0, 0].Value = "Data";
            worksheet.Cells[0, 1].Value = "Ora incepere";
            worksheet.Cells[0, 2].Value = "Ora sfarsit";
            worksheet.Cells[0, 3].Value = "Ora total";
            worksheet.Columns[0].SetWidth(80, LengthUnit.Pixel);
            worksheet.Columns[1].SetWidth(100, LengthUnit.Pixel);
            worksheet.Columns[2].SetWidth(100, LengthUnit.Pixel);
            worksheet.Columns[3].SetWidth(100, LengthUnit.Pixel);

            init = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string day = monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyy");
            string start_hour = "08:00:00";
            string stop_hour;
            DateTime result1;
            string start_hour_final;
            DateTime result2;
            string stop_hour_final;
            TimeSpan timeSpan_stop;
            string final_hour;
            string stop_final_hour;
            DateTime result3;
            TimeSpan timeSpan_final;
            double final;
            int z;

            result1 = Convert.ToDateTime(start_hour);
            start_hour_final = result1.ToString("HH:mm", CultureInfo.CurrentCulture);

            timeSpan_stop = TimeSpan.FromHours(getFinalHour());
            stop_hour = timeSpan_stop.ToString();
            result2 = Convert.ToDateTime(stop_hour);
            stop_hour_final = result2.ToString("HH:mm", CultureInfo.CurrentCulture);

            final = (result2 - result1).TotalHours;
            timeSpan_final = TimeSpan.FromHours(final);
            final_hour = timeSpan_final.ToString();
            result3 = Convert.ToDateTime(final_hour);
            stop_final_hour = result3.ToString("HH:mm", CultureInfo.CurrentCulture);

            j = 0;

            elements[i, j++] = day;
            elements[i, j++] = start_hour_final;
            elements[i, j++] = stop_hour_final;
            elements[i, j++] = stop_final_hour;

            for (z = 0; z < j; z++)
                worksheet.Cells[i + 1, z].Value = elements[i, z];

            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcelFile loadedFile;
            bool first_run = true;

            i = 0;
            j = 0;

            try
            {
                loadedFile = ExcelFile.Load("Table.xlsx");
            }
            catch (System.IO.FileNotFoundException)
            {
                return;
            }

            foreach (ExcelWorksheet worksheet in loadedFile.Worksheets)
            {
                foreach (ExcelRow row in worksheet.Rows)
                {
                    if (!first_run)
                    {
                        foreach (ExcelCell cell in row.AllocatedCells)
                        {
                            if (cell.ValueType != CellValueType.Null)
                            {
                                elements[i, j] = cell.Value.ToString();
                                ++j;
                            }
                        }
                        ++i;
                        j = 0;
                    }
                    first_run = false;
                }
            }


            j = 4;

            setStart();

            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveTable();
        }

        private void setStart()
        {
            int z, v;

            for (z = 0; z < i; z++)
                for (v = 0; v < j; v++)
                    worksheet.Cells[z + 1, v].Value = elements[z, v];
        }

        private void saveTable()
        {
            if (init)
            {
                table = worksheet.Tables.Add("Table1", "A1:D20", true);
                table.BuiltInStyle = BuiltInTableStyleName.TableStyleMedium2;
                init = false;
            }

            ef.Save("Table.xlsx");
        }

        private double getFinalHour()
        {
            double sum = 8.00;

            return sum + Convert.ToInt32(comboBox1.Text) * 1.50 + Convert.ToInt32(comboBox2.Text) * 0.50;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}