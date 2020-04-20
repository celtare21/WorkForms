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
        private ExcelFile ef;
        private List<WorkStuff> elements;
        private static int total_rows;
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

            worksheet.Cells[0, 0].Value = "Data";
            worksheet.Cells[0, 1].Value = "Ora incepere";
            worksheet.Cells[0, 2].Value = "Ora sfarsit";
            worksheet.Cells[0, 3].Value = "Curs alocat";
            worksheet.Cells[0, 4].Value = "Pregatire alocat";
            worksheet.Cells[0, 5].Value = "Recuperare alocat";
            worksheet.Cells[0, 6].Value = "Ora total";
            worksheet.Columns[0].SetWidth(140, LengthUnit.Pixel);
            worksheet.Columns[1].SetWidth(110, LengthUnit.Pixel);
            worksheet.Columns[2].SetWidth(100, LengthUnit.Pixel);
            worksheet.Columns[3].SetWidth(100, LengthUnit.Pixel);
            worksheet.Columns[4].SetWidth(120, LengthUnit.Pixel);
            worksheet.Columns[5].SetWidth(140, LengthUnit.Pixel);
            worksheet.Columns[6].SetWidth(90, LengthUnit.Pixel);
            worksheet.Cells[60, 0].Value = "TOTAL:";
            worksheet.Cells[61, 0].Value = "TOTAL CURS:";
            worksheet.Cells[62, 0].Value = "TOTAL RECUPERARE:";
            worksheet.Cells[63, 0].Value = "TOTAL PREGATIRE:";
            worksheet.Cells[60, 2].Value = "PRET/H";
            worksheet.Cells[60, 3].Value = "INDICE";
            worksheet.Cells[60, 4].Value = "VALOARE";

            save_button.Enabled = false;
            get_hours_normal.Enabled = false;
            get_hours_custom.Enabled = false;
            panel1.Hide();
            panel2.Hide();

            elements = new List<WorkStuff>();

            init = true;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string start_hour_final = null, stop_hour_final = null, stop_total_hour = null, curs_hours = null, pregatire_hours = null, recuperare_hours = null;
            string day;

            if (comboBox1.Text == "0" && comboBox2.Text == "0" && comboBox3.Text == "0")
            {
                MessageBox.Show("No hours chosen!");
                return;
            }

            day = monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyy");
            allHours(ref start_hour_final, ref stop_hour_final, ref stop_total_hour);
            otherHours(ref curs_hours, ref pregatire_hours, ref recuperare_hours);

            elements.Add(new WorkStuff(day, start_hour_final, stop_hour_final, curs_hours, pregatire_hours, recuperare_hours, stop_total_hour));
            setLoad(total_rows);

            ++total_rows;

            MessageBox.Show("New data added!");

            save_button.Enabled = true;
            get_hours_normal.Enabled = true;
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog;
            ExcelFile loadedFile;

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

            loadFile(loadedFile, ref elements, true);

            MessageBox.Show("File loaded!");

            load_button.Enabled = false;
            save_button.Enabled = true;
            get_hours_normal.Enabled = true;
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

        private void get_hours_normal_Click(object sender, EventArgs e)
        {
            MessageBox.Show(getTotalFinalHours(elements));
        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog;

            openFileDialog = new OpenFileDialog
            {
                Title = "Browse Excel Files",
                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xlsx",
                Filter = "xlsx files (*.xlsx)|*.xlsx",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = openFileDialog.FileName;
                get_hours_custom.Enabled = true;
            }
        }

        private void enter_get_hours_custom_Click(object sender, EventArgs e)
        {
            panel1.Show();
            save_button.Hide();
            get_hours_normal.Hide();
            enter_get_hours_custom.Hide();
            enter_pret.Hide();
        }

        private void enter_pret_Click_1(object sender, EventArgs e)
        {
            panel2.Show();
            save_button.Hide();
            get_hours_normal.Hide();
            enter_get_hours_custom.Hide();
            enter_pret.Hide();
        }

        private void go_back_Click(object sender, EventArgs e)
        {
            save_button.Show();
            get_hours_normal.Show();
            enter_get_hours_custom.Show();
            enter_pret.Show();
            panel1.Hide();
        }

        private void go_back_2_Click(object sender, EventArgs e)
        {
            save_button.Show();
            get_hours_normal.Show();
            enter_get_hours_custom.Show();
            enter_pret.Show();
            panel2.Hide();
        }

        private void get_hours_custom_Click(object sender, EventArgs e)
        {
            List<WorkStuff> custom_elements = new List<WorkStuff>();
            ExcelFile loadedFile;

            loadedFile = ExcelFile.Load(textBox4.Text);

            loadFile(loadedFile, ref custom_elements, false);

            MessageBox.Show(getTotalFinalHours(custom_elements));
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

        private void allHours(ref string start_hour_final, ref string stop_hour_final, ref string stop_total_hour)
        {
            DateTime result1 = default, result2 = default;
            double final;

            start_hour_final = transformHour(Constants.first_hour, ref result1);
            stop_hour_final = transformHour(getFinalHour(), ref result2);
            final = (result2 - result1).TotalHours;
            stop_total_hour = transformHour(final);
        }

        private void otherHours(ref string curs_hours, ref string pregatire_hours, ref string recuperare_hours)
        {
            curs_hours = transformHour(getCursHours());
            pregatire_hours = transformHour(getPregatireHours());
            recuperare_hours = transformHour(getRecuperareHours());
        }

        private string getTotalFinalHours(List<WorkStuff> f_elements)
        {
            DateTime result, tmp = DateTime.Parse("00:00");
            double sum = 0;
            int i;

            for (i = 0; i < f_elements.Count; i++)
            {
                result = DateTime.Parse(f_elements[i].total_hours);
                sum += (result - tmp).TotalHours;
            }

            return transformHour(sum);
        }

        private string getTotalCursHours()
        {
            DateTime result, tmp = DateTime.Parse("00:00");
            double sum = 0;
            int i;

            for (i = 0; i < elements.Count; i++)
            {
                result = DateTime.Parse(elements[i].curs_hours);
                sum += (result - tmp).TotalHours;
            }

            return transformHour(sum);
        }

        private string getTotalRecuperareHours()
        {
            DateTime result, tmp = DateTime.Parse("00:00");
            double sum = 0;
            int i;

            for (i = 0; i < elements.Count; i++)
            {
                result = DateTime.Parse(elements[i].recuperare_hours);
                sum += (result - tmp).TotalHours;
            }

            return transformHour(sum);
        }

        private string getTotalPregatireHours()
        {
            DateTime result, tmp = DateTime.Parse("00:00");
            double sum = 0;
            int i;

            for (i = 0; i < elements.Count; i++)
            {
                result = DateTime.Parse(elements[i].pregatire_hours);
                sum += (result - tmp).TotalHours;
            }

            return transformHour(sum);
        }

        private void loadPret(ExcelWorksheet worksheet)
        {
            if (worksheet.Cells[61, 2].ValueType == CellValueType.Int)
                pret_curs.Text = worksheet.Cells[61, 2].IntValue.ToString();
            if (worksheet.Cells[61, 3].ValueType == CellValueType.Int)
                indice_curs.Text = worksheet.Cells[61, 3].IntValue.ToString();

            if (worksheet.Cells[62, 2].ValueType == CellValueType.Int)
                pret_recuperare.Text = worksheet.Cells[62, 2].IntValue.ToString();
            if (worksheet.Cells[62, 3].ValueType == CellValueType.Int)
                indice_recuperare.Text = worksheet.Cells[62, 3].IntValue.ToString();

            if (worksheet.Cells[63, 2].ValueType == CellValueType.Int)
                pret_pregatire.Text = worksheet.Cells[63, 2].IntValue.ToString();
            if (worksheet.Cells[63, 3].ValueType == CellValueType.Int)
                indice_pregatire.Text = worksheet.Cells[63, 3].IntValue.ToString();
        }

        private void saveTable(string path)
        {
            if (init)
            {
                Table table_main, table_little;

                table_main = worksheet.Tables.Add("TableMain", "A1:G" + (total_rows + 1).ToString(), true);
                table_main.BuiltInStyle = BuiltInTableStyleName.TableStyleMedium2;

                worksheet.Cells[60, 1].Value = getTotalFinalHours(elements);
                worksheet.Cells[61, 1].Value = getTotalCursHours();
                worksheet.Cells[62, 1].Value = getTotalRecuperareHours();
                worksheet.Cells[63, 1].Value = getTotalPregatireHours();
                worksheet.Cells[61, 2].Value = Convert.ToDouble(pret_curs.Text);
                worksheet.Cells[61, 3].Value = Convert.ToDouble(indice_curs.Text);
                worksheet.Cells[61, 4].Value = Convert.ToDouble(pret_curs.Text) * Convert.ToDouble(indice_curs.Text);
                worksheet.Cells[62, 2].Value = Convert.ToDouble(pret_recuperare.Text);
                worksheet.Cells[62, 3].Value = Convert.ToDouble(indice_recuperare.Text);
                worksheet.Cells[62, 4].Value = Convert.ToDouble(pret_recuperare.Text) * Convert.ToDouble(indice_recuperare.Text);
                worksheet.Cells[63, 2].Value = Convert.ToDouble(pret_pregatire.Text);
                worksheet.Cells[63, 3].Value = Convert.ToDouble(indice_pregatire.Text);
                worksheet.Cells[63, 4].Value = Convert.ToDouble(pret_pregatire.Text) * Convert.ToDouble(indice_pregatire.Text);
                worksheet.Cells[64, 4].Value = Convert.ToDouble(worksheet.Cells[61, 4].Value) + Convert.ToDouble(worksheet.Cells[62, 4].Value) + Convert.ToDouble(worksheet.Cells[63, 4].Value);

                table_little = worksheet.Tables.Add("TableLittle", "A61:E64", true);
                table_little.BuiltInStyle = BuiltInTableStyleName.TableStyleMedium2;

                init = false;
            }

            ef.Save(path);

            MessageBox.Show("Data saved!");
        }

        private void loadFile(ExcelFile file, ref List<WorkStuff> f_elements, bool rows)
        {
            string day = null, start_hour = null, stop_hour = null, final_hours = null, curs_hours = null, pregatire_hours = null, recuperare_hours = null;
            bool first_run = true;
            bool write = false;
            int j = 0;

            if (rows)
                total_rows = 0;

            foreach (ExcelWorksheet worksheet in file.Worksheets)
            {
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
                                setLoad(cell, j, ref day, ref start_hour, ref stop_hour, ref curs_hours, ref pregatire_hours, ref recuperare_hours, ref final_hours);
                                ++j;
                                write = true;
                            }
                        }
                        if (write)
                        {
                            f_elements.Add(new WorkStuff(day, start_hour, stop_hour, curs_hours, pregatire_hours, recuperare_hours, final_hours));
                            if (rows)
                            {
                                setLoad(total_rows);
                                ++total_rows;
                            }
                            write = false;
                        }
                        j = 0;
                    }
                    first_run = false;
                }
            }
        }

        private double getFinalHour()
        {
            return Constants.first_hour + getCursHours() + getPregatireHours() + getRecuperareHours();
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

    public static class Constants
    {
        public const int entries = 7;
        public const double first_hour = 8.00;
    }
}