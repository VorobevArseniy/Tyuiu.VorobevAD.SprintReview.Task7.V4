using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VorobevAD.SprintReview.Task7.V4.Lib;

namespace Tyuiu.VorobevAD.SprintReview.Task7.V4.App
{
    public partial class BooksForm : Form
    {

        DataService ds = new();
        string path = @"C:\Users\alemi\source\repos\Tyuiu.VorobevAD.SprintReview.Task7.V4\BooksTable.csv";

        public BooksForm()
        {
            InitializeComponent();
        }

        private void buttonReturnMain_VAD_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mf = new MainForm();
            mf.ShowDialog();
        }

        private void BooksForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdd_VAD_Click(object sender, EventArgs e)
        {
            double[] array = { };
            if (array != null)
            {
                array = GetArrayRow(0);
                /*(dataGridViewGoods_KFA.DataSource as DataTable).Rows.Add();*/
                dataGridViewBooks_VAD.CurrentCell = dataGridViewBooks_VAD[0, dataGridViewBooks_VAD.Rows.Count - 1];
                dataGridViewBooks_VAD.CurrentCell.Value = array.Length + 1;
                dataGridViewBooks_VAD.CurrentCell = dataGridViewBooks_VAD[1, dataGridViewBooks_VAD.Rows.Count - 1];
            }
        }

        private void ImportCsvToDataGridView(string filePath)
        {
            DataTable dataTable = new DataTable();

            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");

                // Чтение заголовков
                string[] headers = parser.ReadFields();
                foreach (string header in headers)
                {
                    dataTable.Columns.Add(header);
                }

                // Чтение строк
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    dataTable.Rows.Add(fields);
                }
            }

            dataGridViewBooks_VAD.DataSource = dataTable; // Установка источника данных для DataGridView
            dataGridViewBooks_VAD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void buttonImportCSV_VAD_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            ImportCsvToDataGridView(path);
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            buttonImportCSV_VAD_Click(sender, e);
            DeleteNullCells();
        }

        private void buttonDelete_VAD_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewBooks_VAD.SelectedRows)
            {
                dataGridViewBooks_VAD.Rows.RemoveAt(row.Index);
            }
        }

        private void buttonSave_VAD_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                // Write the header row
                for (int i = 0; i < dataGridViewBooks_VAD.ColumnCount; i++)
                {
                    sw.Write(dataGridViewBooks_VAD.Columns[i].HeaderText);
                    if (i < dataGridViewBooks_VAD.ColumnCount - 1)
                    {
                        sw.Write(";");
                    }
                }
                sw.WriteLine();

                // Write the data rows
                foreach (DataGridViewRow row in dataGridViewBooks_VAD.Rows)
                {
                    for (int i = 0; i < dataGridViewBooks_VAD.ColumnCount; i++)
                    {
                        if (row.Cells[i].Value != null)
                        {
                            sw.Write(row.Cells[i].Value.ToString());
                        }
                        if (i < dataGridViewBooks_VAD.ColumnCount - 1)
                        {
                            sw.Write(";");
                        }
                    }
                    sw.WriteLine();
                }
            }
        }

        private void buttonFind_VAD_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewBooks_VAD.RowCount; i++)
            {
                dataGridViewBooks_VAD.Rows[i].Selected = false;
                for (int j = 0; j < dataGridViewBooks_VAD.ColumnCount; j++)
                    if (dataGridViewBooks_VAD.Rows[i].Cells[j].Value != null)
                        if (dataGridViewBooks_VAD.Rows[i].Cells[j].Value.ToString().Contains(textBoxFindValue_VAD.Text))
                        {
                            dataGridViewBooks_VAD.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        public double[] GetArrayRow(int row)
        {
            double[] array = new double[dataGridViewBooks_VAD.Rows.Count];
            for (int i = 0; i < dataGridViewBooks_VAD.Rows.Count; i++)
            {
                array[i] = dataGridViewBooks_VAD.Rows[i].Cells[0].Value == null ? array[i - 1] : Convert.ToInt32(dataGridViewBooks_VAD.Rows[i].Cells[row].Value);
                //второй, в конце Cells[1] - номер столбца
            }
            return array;
        }

        private void buttonMiddlePrice_VAD_Click(object sender, EventArgs e)
        {
            double[] matrix = GetArrayRow(4);
            textBoxResult_VAD.Text = ds.FindMiddleValue(matrix).ToString();
        }

        private void buttonMinPrice_Click(object sender, EventArgs e)
        {
            double[] matrix = GetArrayRow(4);
            textBoxResult_VAD.Text = ds.FindMinValue(matrix).ToString();
        }


        private void buttonMaxPrice_VAD_Click(object sender, EventArgs e)
        {
            double[] matrix = GetArrayRow(4);
            textBoxResult_VAD.Text = ds.FindMaxValue(matrix).ToString();

        }

        private void buttonSumPrice_VAD_Click(object sender, EventArgs e)
        {
            double[] matrix = GetArrayRow(4);
            textBoxResult_VAD.Text = ds.FindSumValue(matrix).ToString();
        }

        public void DeleteNullCells()
        {
            for (int i = 0; i < dataGridViewBooks_VAD.RowCount - 1; i++)
            {
                if (dataGridViewBooks_VAD.Rows[i].Cells[3].Value.ToString() == "")
                {
                    dataGridViewBooks_VAD.Rows.RemoveAt(i);
                    i--;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewBooks_VAD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
