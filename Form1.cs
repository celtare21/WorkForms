using System;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.Tables;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private ExcelWorksheet worksheet;
        private ExcelFile loadedFile;
        private List<WorkStuff> elements;
        private static int total_rows, last_total_rows;
        private double first_hour_entry;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] hours = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8" };

            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            monthCalendar1.MaxSelectionCount = 10;

            comboBox1.Items.AddRange(hours);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedItem = "0";
            comboBox2.Items.AddRange(hours);
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.SelectedItem = "0";
            comboBox3.Items.AddRange(hours);
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.SelectedItem = "0";

            pret_principal.Text = "17";
            pret_secundar.Text = "10";
            pret_pregatire.Text = "5";

            ora_inceput_box.Text = "15:30";

            elements = new List<WorkStuff>();

            save_button.Enabled = false;
            panel2.Hide();

            loadOnStartup();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string day;

            if (comboBox1.Text == "0" && comboBox2.Text == "0" && comboBox3.Text == "0")
            {
                MessageBox.Show("No hours chosen!");
                return;
            }

            last_total_rows = total_rows;

            first_hour_entry = timeSpanToDouble(stringToTimeSpan(ora_inceput_box.Text));

            if (!isCheckBoxSelected())
            {
                int max = 1, i;

                if (monthCalendar1.MaxSelectionCount > 1 && !String.Equals(monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyy"), monthCalendar1.SelectionRange.End.ToString("dd/MM/yyy")))
                    max = 2;

                for (i = 0; i < max; i++)
                {
                    day = (i == 0) ? monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyy") : monthCalendar1.SelectionRange.End.ToString("dd/MM/yyy");

                    addNewItemsOnDay(day);
                }
            }
            else
            {
                foreach (DateTime date in AllDatesInMonth())
                {
                    day = null;

                    if (monday.Checked && date.DayOfWeek == DayOfWeek.Monday || tuesday.Checked && date.DayOfWeek == DayOfWeek.Tuesday ||
                                wednesday.Checked && date.DayOfWeek == DayOfWeek.Wednesday || thursday.Checked && date.DayOfWeek == DayOfWeek.Thursday ||
                                        friday.Checked && date.DayOfWeek == DayOfWeek.Friday || saturday.Checked && date.DayOfWeek == DayOfWeek.Saturday)
                        day = date.ToString("dd/MM/yyy");

                    if (day == null)
                        continue;

                    addNewItemsOnDay(day);
                }
            }

            MessageBox.Show("New data added!");

            save_button.Enabled = true;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            int diff = total_rows - last_total_rows;

            if (diff == 0)
            {
                MessageBox.Show("No elements in list!");
                return;
            }

            elements.RemoveRange(last_total_rows, diff);
            total_rows = last_total_rows;
            MessageBox.Show("Elements removed.");
        }

        private void loadOnStartup()
        {
            OpenFileDialog openFileDialog;

            openFileDialog = new OpenFileDialog
            {
                Title = "Browse Excel Files",

                CheckFileExists = true,
                CheckPathExists = true,
                RestoreDirectory = true,

                DefaultExt = "xlsx",
                Filter = "xlsx files (*.xlsx)|*.xlsx",
                FilterIndex = 2,

                ShowReadOnly = true
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            loadedFile = ExcelFile.Load(openFileDialog.FileName);

            loadFile(loadedFile);

            save_button.Enabled = true;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog;

            saveFileDialog = new SaveFileDialog
            {
                Title = "Save File",

                CheckPathExists = true,

                FilterIndex = 2,
                DefaultExt = "xlsx",
                Filter = "xlsx files (*.xlsx)|*.xlsx",
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                saveTable(saveFileDialog.FileName);
        }

        private void enter_pret_Click_1(object sender, EventArgs e)
        {
            panel2.Show();
            hideCommon();
        }

        private void go_back_Click(object sender, EventArgs e)
        {
            showCommon();
        }

        private void go_back_2_Click(object sender, EventArgs e)
        {
            showCommon();
            panel2.Hide();
        }

        private void hideCommon()
        {
            save_button.Hide();
            enter_pret.Hide();
            delete_button.Hide();
            ora_inceput_box.Hide();
            ora_inceput_text.Hide();
            observatii_box.Hide();
            observatii_text.Hide();
            monday.Hide();
            tuesday.Hide();
            wednesday.Hide();
            thursday.Hide();
            friday.Hide();
            saturday.Hide();
        }

        private void showCommon()
        {
            save_button.Show();
            enter_pret.Show();
            delete_button.Show();
            ora_inceput_box.Show();
            ora_inceput_text.Show();
            observatii_box.Show();
            observatii_text.Show();
            monday.Show();
            tuesday.Show();
            wednesday.Show();
            thursday.Show();
            friday.Show();
            saturday.Show();
        }

        private void populateTables()
        {
            worksheet.Columns[0].SetWidth(140, LengthUnit.Pixel);
            worksheet.Columns[1].SetWidth(110, LengthUnit.Pixel);
            worksheet.Columns[2].SetWidth(100, LengthUnit.Pixel);
            worksheet.Columns[3].SetWidth(140, LengthUnit.Pixel);
            worksheet.Columns[4].SetWidth(120, LengthUnit.Pixel);
            worksheet.Columns[5].SetWidth(140, LengthUnit.Pixel);
            worksheet.Columns[6].SetWidth(90, LengthUnit.Pixel);
            worksheet.Columns[7].SetWidth(140, LengthUnit.Pixel);

            worksheet.Cells[0, 0].Value = "Data";
            worksheet.Cells[0, 1].Value = "Ora incepere";
            worksheet.Cells[0, 2].Value = "Ora sfarsit";
            worksheet.Cells[0, 3].Value = "Pricipal alocat";
            worksheet.Cells[0, 4].Value = "Secundar alocat";
            worksheet.Cells[0, 5].Value = "Pregatire alocat";
            worksheet.Cells[0, 6].Value = "Ora total";
            worksheet.Cells[0, 7].Value = "Observatii";

            worksheet.Cells[60, 0].Value = "TOTAL:";
            worksheet.Cells[61, 0].Value = "TOTAL PRINCIPAL:";
            worksheet.Cells[62, 0].Value = "TOTAL SECUNDAR:";
            worksheet.Cells[63, 0].Value = "TOTAL PREGATIRE:";
            worksheet.Cells[60, 2].Value = "PRET/H";
            worksheet.Cells[60, 3].Value = "INDICE";
            worksheet.Cells[60, 4].Value = "VALOARE";

            worksheet.Cells[64, 3].Value = "TOTAL DEMO:";
            worksheet.Cells[65, 3].Value = "TOTAL ORE + DEMO:";
        }

        private void addNewItemsOnDay(string day)
        {
            string start_hour_final = null, stop_hour_final = null, stop_total_hour = null, principal_hours = null, secundar_hours = null, pregatire_hours = null, observatii = "";

            allHours(ref start_hour_final, ref stop_hour_final, ref stop_total_hour);
            otherHours(ref principal_hours, ref secundar_hours, ref pregatire_hours);
            getObservatii(ref observatii);

            elements.Add(new WorkStuff(day, start_hour_final, stop_hour_final, principal_hours, secundar_hours, pregatire_hours, stop_total_hour, observatii));

            ++total_rows;
        }

        public static IEnumerable<DateTime> AllDatesInMonth()
        {
            int days = DateTime.DaysInMonth(Constants.current_year, Constants.current_month);

            for (int day = 1; day <= days; day++)
                yield return new DateTime(Constants.current_year, Constants.current_month, day);
        }

        private bool isCheckBoxSelected()
        {
            return monday.Checked || tuesday.Checked || wednesday.Checked || thursday.Checked || friday.Checked || saturday.Checked;
        }

        private string transformHour(double hour)
        {
            DateTime result;
            TimeSpan timeSpan_hour;
            string string_hour;

            timeSpan_hour = TimeSpan.FromHours(hour);
            string_hour = timeSpan_hour.ToString();
            result = Convert.ToDateTime(string_hour);
            return result.ToString("HH:mm", CultureInfo.CurrentCulture);
        }

        private string transformHour(double hour, ref DateTime result)
        {
            TimeSpan timeSpan_hour;
            string string_hour;

            timeSpan_hour = TimeSpan.FromHours(hour);
            string_hour = timeSpan_hour.ToString();
            result = Convert.ToDateTime(string_hour);
            return result.ToString("HH:mm", CultureInfo.CurrentCulture);
        }

        private string transformOverHour(double hour)
        {
            TimeSpan span;

            span = TimeSpan.FromHours(hour);
            return $"{(int)span.TotalHours}:{span:mm}";
        }

        private TimeSpan stringToTimeSpan(string time)
        {
            return TimeSpan.Parse(time);
        }

        private double timeSpanToDouble(TimeSpan time)
        {
            return time.TotalHours;
        }

        private void allHours(ref string start_hour_final, ref string stop_hour_final, ref string stop_total_hour)
        {
            DateTime result1 = default, result2 = default;
            double final;

            start_hour_final = transformHour(first_hour_entry, ref result1);
            stop_hour_final = transformHour(getFinalHour(), ref result2);
            final = (result2 - result1).TotalHours;
            stop_total_hour = transformHour(final);
        }

        private void otherHours(ref string principal_hours, ref string secundar_hours, ref string pregatire_hours)
        {
            principal_hours = transformHour(getPrincipalHours());
            secundar_hours = transformHour(getSecundarHours());
            pregatire_hours = transformHour(getPregatireHours());
        }

        private void getObservatii(ref string observatii)
        {
            observatii = observatii_box.Text;
        }

        private string getTotalHours(int x)
        {
            return transformOverHour(getTotalHoursDouble(x));
        }

        private double getTotalHoursDouble(int x)
        {
            DateTime result, tmp = DateTime.Parse("00:00");
            double sum = 0;
            int i;

            for (i = 0; i < elements.Count; i++)
            {
                switch (x)
                {
                    case 0:
                        result = DateTime.Parse(elements[i].total_hours);
                        break;
                    case 1:
                        result = DateTime.Parse(elements[i].principal_hours);
                        break;
                    case 2:
                        result = DateTime.Parse(elements[i].secundar_hours);
                        break;
                    case 3:
                        result = DateTime.Parse(elements[i].pregatire_hours);
                        break;
                    default:
                        result = DateTime.Parse("00:00");
                        break;
                }
                sum += (result - tmp).TotalHours;
            }

            return sum;
        }

        private void sortByDate()
        {
            int i, j;

            for (i = 0; i < total_rows - 1; i++)
                for (j = 0; j < total_rows - i - 1; j++)
                    if (Convert.ToDateTime(elements[j].day, new CultureInfo("en-GB")) > Convert.ToDateTime(elements[j + 1].day, new CultureInfo("en-GB")))
                    {
                        WorkStuff tmp;

                        tmp = elements[j];
                        elements[j] = elements[j + 1];
                        elements[j + 1] = tmp;
                    }
        }

        private void loadPret(ExcelWorksheet worksheet)
        {
            if (worksheet.Cells[61, 2].ValueType == CellValueType.Int && !String.Equals(worksheet.Cells[61, 2].Value.ToString(), "0"))
                pret_principal.Text = worksheet.Cells[61, 2].IntValue.ToString();

            if (worksheet.Cells[62, 2].ValueType == CellValueType.Int && !String.Equals(worksheet.Cells[62, 2].Value.ToString(), "0"))
                pret_secundar.Text = worksheet.Cells[62, 2].IntValue.ToString();

            if (worksheet.Cells[63, 2].ValueType == CellValueType.Int && !String.Equals(worksheet.Cells[63, 2].Value.ToString(), "0"))
                pret_pregatire.Text = worksheet.Cells[63, 2].IntValue.ToString();
        }

        private void saveTable(string path)
        {
            Table table_main, table_little;
            int i;
            double total_ore = 0;

            if (worksheet.Tables.Count > 0)
                for (i = 0; i <= worksheet.Tables.Count; i++)
                    worksheet.Tables.Remove(worksheet.Tables[0], RemoveShiftDirection.Left);

            populateTables();

            if (total_rows > 0)
            {
                sortByDate();
                for (i = 0; i < total_rows; i++)
                    setLoad(i);

                table_main = worksheet.Tables.Add("TableMainDemo", "A1:H" + (total_rows + 1).ToString(), true);
                table_main.BuiltInStyle = BuiltInTableStyleName.TableStyleMedium2;
                table_little = worksheet.Tables.Add("TableLittleDemo", "A61:E64", true);
                table_little.BuiltInStyle = BuiltInTableStyleName.TableStyleMedium2;
            }

            worksheet.Cells[60, 1].Value = getTotalHours(0);
            worksheet.Cells[61, 1].Value = getTotalHours(1);
            worksheet.Cells[62, 1].Value = getTotalHours(2);
            worksheet.Cells[63, 1].Value = getTotalHours(3);
            worksheet.Cells[61, 2].Value = Convert.ToDouble(pret_principal.Text);
            worksheet.Cells[61, 3].Value = getTotalHoursDouble(1);
            worksheet.Cells[61, 4].Value = Convert.ToDouble(pret_principal.Text) * getTotalHoursDouble(1);
            worksheet.Cells[62, 2].Value = Convert.ToDouble(pret_secundar.Text);
            worksheet.Cells[62, 3].Value = getTotalHoursDouble(2);
            worksheet.Cells[62, 4].Value = Convert.ToDouble(pret_secundar.Text) * getTotalHoursDouble(2);
            worksheet.Cells[63, 2].Value = Convert.ToDouble(pret_pregatire.Text);
            worksheet.Cells[63, 3].Value = getTotalHoursDouble(3);
            worksheet.Cells[63, 4].Value = Convert.ToDouble(pret_pregatire.Text) * getTotalHoursDouble(3);
            worksheet.Cells[64, 4].Value = Convert.ToDouble(worksheet.Cells[61, 4].Value) + Convert.ToDouble(worksheet.Cells[62, 4].Value) + Convert.ToDouble(worksheet.Cells[63, 4].Value);

            worksheet = loadedFile.Worksheets[0];

            if (worksheet.Cells[64, 4].ValueType == CellValueType.Double || worksheet.Cells[64, 4].ValueType == CellValueType.Int)
                total_ore = Convert.ToDouble(worksheet.Cells[64, 4].Value);

            worksheet = loadedFile.Worksheets[1];

            worksheet.Cells[65, 4].Value = Convert.ToDouble(worksheet.Cells[61, 4].Value) + Convert.ToDouble(worksheet.Cells[62, 4].Value) + Convert.ToDouble(worksheet.Cells[63, 4].Value) + total_ore;

            loadedFile.Save(path);

            MessageBox.Show("Data saved!");
        }

        private void loadFile(ExcelFile file)
        {
            string day = null, start_hour = null, stop_hour = null, final_hours = null, principal_hours = null, secundar_hours = null, pregatire_hours = null, observatii = "";
            bool first_run = true;
            bool write = false;
            int j = 0;

            total_rows = 0;

            try
            {
                worksheet = file.Worksheets[1];
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("No Demo spreadsheet found! Run the initial software!");
                Environment.Exit(0);
            }

            loadPret(worksheet);

            foreach (ExcelRow row in worksheet.Rows)
            {
                if (!first_run)
                {
                    foreach (ExcelCell cell in row.AllocatedCells)
                    {
                        if (cell.ValueType != CellValueType.Null)
                        {
                            if (String.Equals(cell.Value.ToString(), "TOTAL:".ToString()))
                                return;
                            setLoad(cell, j, ref day, ref start_hour, ref stop_hour, ref principal_hours, ref secundar_hours, ref pregatire_hours, ref final_hours, ref observatii);
                            ++j;
                            write = true;
                        }
                    }
                    if (write)
                    {
                        elements.Add(new WorkStuff(day, start_hour, stop_hour, principal_hours, secundar_hours, pregatire_hours, final_hours, observatii));
                        ++total_rows;
                        write = false;
                    }
                    j = 0;
                }
                first_run = false;
            }
        }

        private double getFinalHour()
        {
            return first_hour_entry + getPrincipalHours() + getSecundarHours() + getPregatireHours();
        }

        private double getPrincipalHours()
        {
            return Convert.ToInt32(comboBox1.Text) * 1.50;
        }

        private double getSecundarHours()
        {
            return Convert.ToInt32(comboBox2.Text) * 1.50;
        }

        private double getPregatireHours()
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
                        worksheet.Cells[i + 1, j].Value = elements[i].principal_hours;
                        break;
                    case 4:
                        worksheet.Cells[i + 1, j].Value = elements[i].secundar_hours;
                        break;
                    case 5:
                        worksheet.Cells[i + 1, j].Value = elements[i].pregatire_hours;
                        break;
                    case 6:
                        worksheet.Cells[i + 1, j].Value = elements[i].total_hours;
                        break;
                    case 7:
                        worksheet.Cells[i + 1, j].Value = elements[i].observatii;
                        break;
                }
            }
        }

        private void setLoad(ExcelCell cell, int j, ref string day, ref string start_hour, ref string stop_hour, ref string principal_hours, ref string secundar_hours, ref string pregatire_hours, ref string final_hour, ref string observatii)
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
                    principal_hours = cell.Value.ToString();
                    break;
                case 4:
                    secundar_hours = cell.Value.ToString();
                    break;
                case 5:
                    pregatire_hours = cell.Value.ToString();
                    break;
                case 6:
                    final_hour = cell.Value.ToString();
                    break;
                case 7:
                    observatii = cell.Value.ToString();
                    break;
            }
        }
    }

    public class WorkStuff
    {
        public string day;
        public string start_hour;
        public string stop_hour;
        public string principal_hours;
        public string secundar_hours;
        public string pregatire_hours;
        public string total_hours;
        public string observatii;

        public WorkStuff(string day, string start_hour, string stop_hour, string principal_hours, string secundar_hours, string pregatire_hours, string total_hours, string observatii)
        {
            this.day = day;
            this.start_hour = start_hour;
            this.stop_hour = stop_hour;
            this.principal_hours = principal_hours;
            this.secundar_hours = secundar_hours;
            this.pregatire_hours = pregatire_hours;
            this.total_hours = total_hours;
            this.observatii = observatii;
        }
    }

    public static class Constants
    {
        public const int entries = 8;
        public static int current_year = DateTime.Now.Year;
        public static int current_month = DateTime.Now.Month;
    }
}
