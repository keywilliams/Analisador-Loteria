using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Analisador_Loteria
{
    public partial class FormLotofacil : Form
    {
        public FormLotofacil()
        {
            InitializeComponent();
        }

        private async void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Text Documents | *.txt", Multiselect = false, ValidateNames = true })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
                        {
                            txtFechamentos.Text = await streamReader.ReadToEndAsync();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var allLines = txtFechamentos.Text.Split(new[] { "\r\n" }, StringSplitOptions.None);
            var lineList = new List<Tuple<string, int>>();
            var columnList = new List<Tuple<string, int>>();
            var sumList = new List<Tuple<string, int>>();
            foreach (var result in allLines)
            {
                int lineOne = 0, columnOne = 0;
                int lineTwo = 0, columnTwo = 0;
                int lineThree = 0, columnThree = 0;
                int lineFour = 0, columnFour = 0;
                int lineFive = 0, columnFive = 0;
                int sumAll = 0;

                var bolas = result.Split(new[] { ' ', '\t' }, StringSplitOptions.None);
                foreach (var bola in bolas)
                {
                    if (!string.IsNullOrEmpty(bola))
                    {
                        //Linha
                        switch (bola)
                        {
                            case "01":
                            case "02":
                            case "03":
                            case "04":
                            case "05":
                                lineOne++;
                                break;

                            case "06":
                            case "07":
                            case "08":
                            case "09":
                            case "10":
                                lineTwo++;
                                break;

                            case "11":
                            case "12":
                            case "13":
                            case "14":
                            case "15":
                                lineThree++;
                                break;

                            case "16":
                            case "17":
                            case "18":
                            case "19":
                            case "20":
                                lineFour++;
                                break;

                            case "21":
                            case "22":
                            case "23":
                            case "24":
                            case "25":
                                lineFive++;
                                break;
                        }

                        //Coluna
                        switch (bola)
                        {
                            case "01":
                            case "06":
                            case "11":
                            case "16":
                            case "21":
                                columnOne++;
                                break;

                            case "02":
                            case "07":
                            case "12":
                            case "17":
                            case "22":
                                columnTwo++;
                                break;

                            case "03":
                            case "08":
                            case "13":
                            case "18":
                            case "23":
                                columnThree++;
                                break;

                            case "04":
                            case "09":
                            case "14":
                            case "19":
                            case "24":
                                columnFour++;
                                break;

                            case "05":
                            case "10":
                            case "15":
                            case "20":
                            case "25":
                                columnFive++;
                                break;
                        }

                        //Sum
                        sumAll += int.Parse(bola);
                    }
                }

                //Linhas
                string lineDescription = $"{lineOne}{lineTwo}{lineThree}{lineFour}{lineFive}";
                var oldLine = lineList.Where(x => x.Item1.Equals(lineDescription)).FirstOrDefault();
                if (oldLine != null)
                {
                    var newLine = new Tuple<string, int>(oldLine.Item1, oldLine.Item2 + 1);
                    lineList.Remove(oldLine);
                    lineList.Add(newLine);
                }
                else
                {
                    lineList.Add(new Tuple<string, int>(lineDescription, 1));
                }

                //Colunas
                string colunDescription = $"{columnOne}{columnTwo}{columnThree}{columnFour}{columnFive}";
                var oldColumn = columnList.Where(x => x.Item1.Equals(colunDescription)).FirstOrDefault();
                if (oldColumn != null)
                {
                    var newLine = new Tuple<string, int>(oldColumn.Item1, oldColumn.Item2 + 1);
                    columnList.Remove(oldColumn);
                    columnList.Add(newLine);
                }
                else
                {
                    columnList.Add(new Tuple<string, int>(colunDescription, 1));
                }

                //Sum
                var oldSum = sumList.Where(x => x.Item1.Equals(sumAll)).FirstOrDefault();
                if (oldSum != null)
                {
                    var newLine = new Tuple<string, int>(oldSum.Item1, oldSum.Item2 + 1);
                    sumList.Remove(oldSum);
                    sumList.Add(newLine);
                }
                else
                {
                    sumList.Add(new Tuple<string, int>(sumAll.ToString(), 1));
                }
            }

            lineList = lineList.OrderByDescending(x => x.Item1).ToList();
            columnList = columnList.OrderByDescending(x => x.Item1).ToList();
            sumList = sumList.OrderByDescending(x => x.Item1).ToList();
        }
    }
}
