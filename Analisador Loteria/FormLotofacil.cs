using System;
using System.IO;
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

        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            var allLines = txtFechamentos.Text.Split(new[] { "\n" }, StringSplitOptions.None);

            //Quantity
            var quantitySummary = Lotofacil.Lotofacil.QuantityAnalysis(allLines);

            //Line
            var lineSummary = Lotofacil.Lotofacil.LineAnalysis(allLines);

            //Column
            var columnSummary = Lotofacil.Lotofacil.ColumnAnalysis(allLines);

            //Sum
            var sumSummary = Lotofacil.Lotofacil.SumAnalysis(allLines);

            //Position
            var positionSummary = Lotofacil.Lotofacil.PositionAnalysis(allLines);

            //Position
            var primeNumberSummary = Lotofacil.Lotofacil.PrimeNumberAnalysis(allLines);

            FormSummary formSummary = new FormSummary();
            formSummary.TextBoxSummary = $"TOTAL DE JOGOS: {allLines.Length}{Environment.NewLine}" +
                                         $"{quantitySummary}{Environment.NewLine}" +
                                         $"{lineSummary}{Environment.NewLine}" +
                                         $"{columnSummary}{Environment.NewLine}" +
                                         $"{sumSummary}{Environment.NewLine}" +
                                         $"{positionSummary}{Environment.NewLine}" +
                                         $"{primeNumberSummary}";
            formSummary.ShowDialog();
        }

        private void btnCarregarLocalPath_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog openFileDialog = new FolderBrowserDialog() { ShowNewFolderButton = true })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        txtSaveFilePath.Text = $"{openFileDialog.SelectedPath}/Lotofacil";
                    }
                }


                if (!Directory.Exists(txtSaveFilePath.Text))
                    Directory.CreateDirectory(txtSaveFilePath.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
