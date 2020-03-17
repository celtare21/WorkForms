using System;
using System.Globalization;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.Tables;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private ExcelWorksheet worksheet;
        private ExcelFile ef;
        private Table table;
        private List<WorkStuff> elements;
        private static int i;
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
            comboBox3.Items.AddRange(hours);
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.SelectedItem = "0";

            elements = new List<WorkStuff>();

            worksheet.Cells[0, 0].Value = "Data";
            worksheet.Cells[0, 1].Value = "Ora incepere";
            worksheet.Cells[0, 2].Value = "Ora sfarsit";
            worksheet.Cells[0, 3].Value = "Curs alocat";
            worksheet.Cells[0, 4].Value = "Pregatire alocat";
            worksheet.Cells[0, 5].Value = "Recuperare alocat";
            worksheet.Cells[0, 6].Value = "Ora total";
            worksheet.Columns[0].SetWidth(90, LengthUnit.Pixel);
            worksheet.Columns[1].SetWidth(110, LengthUnit.Pixel);
            worksheet.Columns[2].SetWidth(100, LengthUnit.Pixel);
            worksheet.Columns[3].SetWidth(100, LengthUnit.Pixel);
            worksheet.Columns[4].SetWidth(120, LengthUnit.Pixel);
            worksheet.Columns[5].SetWidth(140, LengthUnit.Pixel);
            worksheet.Columns[6].SetWidth(90, LengthUnit.Pixel);

            init = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string day;
            string start_hour_final = null, stop_hour_final = null, stop_total_hour = null, curs_hours = null, pregatire_hours = null, recuperare_hours = null;

            day = monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyy");
            allHours(ref start_hour_final, ref stop_hour_final, ref stop_total_hour);
            otherHours(ref curs_hours, ref pregatire_hours, ref recuperare_hours);

            elements.Add(new WorkStuff(day, start_hour_final, stop_hour_final, curs_hours, pregatire_hours, recuperare_hours, stop_total_hour));
            setLoad(i);

            i++;
        }

        private void allHours(ref string start_hour_final, ref string stop_hour_final, ref string stop_total_hour)
        {
            DateTime result1, result2, result3;
            TimeSpan timeSpan_stop, timeSpan_final;
            string start_hour = "08:00:00", stop_hour, final_hour;
            double final;

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
            stop_total_hour = result3.ToString("HH:mm", CultureInfo.CurrentCulture);
        }

        private void otherHours(ref string curs_hours, ref string pregatire_hours, ref string recuperare_hours)
        {
            TimeSpan timeSpan_curs, timeSpan_pregatire, timeSpan_recuperare;
            DateTime result1, result2, result3;
            string curs, pregatire, recuperare;

            timeSpan_curs = TimeSpan.FromHours(getCursHours());
            curs = timeSpan_curs.ToString();
            result1 = Convert.ToDateTime(curs);
            curs_hours = result1.ToString("HH:mm", CultureInfo.CurrentCulture);

            timeSpan_pregatire = TimeSpan.FromHours(getPregatireHours());
            pregatire = timeSpan_pregatire.ToString();
            result2 = Convert.ToDateTime(pregatire);
            pregatire_hours = result2.ToString("HH:mm", CultureInfo.CurrentCulture);

            timeSpan_recuperare = TimeSpan.FromHours(getRecuperareHours());
            recuperare = timeSpan_recuperare.ToString();
            result3 = Convert.ToDateTime(recuperare);
            recuperare_hours = result3.ToString("HH:mm", CultureInfo.CurrentCulture);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcelFile loadedFile;
            bool first_run = true;
            string day = null, start_hour = null, stop_hour = null, final_hours = null, curs_hours = null, pregatire_hours = null, recuperare_hours = null;
            int j = 0;

            i = 0;

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
                                setLoad(cell, j, ref day, ref start_hour, ref stop_hour, ref curs_hours, ref pregatire_hours, ref recuperare_hours, ref final_hours);
                                ++j;
                            }
                        }
                        elements.Add(new WorkStuff(day, start_hour, stop_hour, curs_hours, pregatire_hours, recuperare_hours, final_hours));
                        setLoad(i);
                        ++i;
                        j = 0;
                    }
                    first_run = false;
                }
            }

            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveTable();
        }

        private void saveTable()
        {
            if (init)
            {
                table = worksheet.Tables.Add("Table1", "A1:G40", true);
                table.BuiltInStyle = BuiltInTableStyleName.TableStyleMedium2;
                init = false;
            }

            ef.Save("Table.xlsx");
        }

        private double getFinalHour()
        {
            double sum = 8.00;

            return sum + getCursHours() + getPregatireHours() + getRecuperareHours();
        }

        private double getCursHours()
        {
            return Convert.ToInt32(comboBox1.Text) * 1.50;
        }

        private double getPregatireHours()
        {
            return Convert.ToInt32(comboBox2.Text) * 0.50;
        }

        private double getRecuperareHours()
        {
            return Convert.ToInt32(comboBox3.Text) * 0.50;
        }

        private void setLoad(int i)
        {
            int j;

            for (j = 0; j < Constants.entries; j++)
            {
                switch (j)
                {
                    case 0:
                        worksheet.Cells[i + 1, j].Value = elements[i].day;
                        break;
                    case 1:
                        worksheet.Cells[i + 1, j].Value = elements[i].start_hour;
                        break;
                    case 2:
                        worksheet.Cells[i + 1, j].Value = elements[i].stop_hour;
                        break;
                    case 3:
                        worksheet.Cells[i + 1, j].Value = elements[i].curs_hours;
                        break;
                    case 4:
                        worksheet.Cells[i + 1, j].Value = elements[i].pregatire_hours;
                        break;
                    case 5:
                        worksheet.Cells[i + 1, j].Value = elements[i].recuperare_hours;
                        break;
                    case 6:
                        worksheet.Cells[i + 1, j].Value = elements[i].total_hours;
                        break;
                }
            }
        }

        private void setLoad(ExcelCell cell, int j, ref string day, ref string start_hour, ref string stop_hour, ref string curs_hours, ref string pregatire_hours, ref string recuperare_hours, ref string final_hour)
        {
            switch (j)
            {
                case 0:
                    day = cell.Value.ToString();
                    break;
                case 1:
                    start_hour = cell.Value.ToString();
                    break;
                case 2:
                    stop_hour = cell.Value.ToString();
                    break;
                case 3:
                    curs_hours = cell.Value.ToString();
                    break;
                case 4:
                    pregatire_hours = cell.Value.ToString();
                    break;
                case 5:
                    recuperare_hours = cell.Value.ToString();
                    break;
                case 6:
                    final_hour = cell.Value.ToString();
                    break;
            }
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class WorkStuff
    {
        public string day;
        public string start_hour;
        public string stop_hour;
        public string curs_hours;
        public string pregatire_hours;
        public string recuperare_hours;
        public string total_hours;

        public WorkStuff(string day, string start_hour, string stop_hour, string curs_hours, string pregatire_hours, string recuperare_hours, string total_hours)
        {
            this.day = day;
            this.start_hour = start_hour;
            this.stop_hour = stop_hour;
            this.curs_hours = curs_hours;
            this.pregatire_hours = pregatire_hours;
            this.recuperare_hours = recuperare_hours;
            this.total_hours = total_hours;
        }
    }

    static class Constants
    {
        public const int entries = 7;
    }
}