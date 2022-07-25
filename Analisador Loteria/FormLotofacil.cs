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
            string lineSummary = string.Empty;
            if (cbLine.Checked)
                lineSummary = Lotofacil.Lotofacil.LineAnalysis(allLines);

            //Column
            string columnSummary = string.Empty;
            if (cbColumn.Checked)
                columnSummary = Lotofacil.Lotofacil.ColumnAnalysis(allLines);

            //Sum
            string sumSummary = string.Empty;
            if (cbSum.Checked)
                sumSummary = Lotofacil.Lotofacil.SumAnalysis(allLines);

            //Position
            string positionSummary = string.Empty;
            if (cbPosition.Checked)
                positionSummary = Lotofacil.Lotofacil.PositionAnalysis(allLines);

            //Position
            string primeNumberSummary = string.Empty;
            if (cbPrimeNumber.Checked)
                primeNumberSummary = Lotofacil.Lotofacil.PrimeNumberAnalysis(allLines);

            //Odd and Even
            string oddEvenSummary = string.Empty;
            if (cbOddEven.Checked)
                oddEvenSummary = Lotofacil.Lotofacil.OddEvenAnalysis(allLines);

            FormSummary formSummary = new FormSummary();
            formSummary.TextBoxSummary = $"TOTAL DE JOGOS: {allLines.Length}{Environment.NewLine}" +
                                         $"{quantitySummary}{Environment.NewLine}" +
                                         $"{lineSummary}{Environment.NewLine}" +
                                         $"{columnSummary}{Environment.NewLine}" +
                                         $"{sumSummary}{Environment.NewLine}" +
                                         $"{positionSummary}{Environment.NewLine}" +
                                         $"{primeNumberSummary}{Environment.NewLine}" +
                                         $"{oddEvenSummary}";
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

        private void cbTodos_CheckedChanged(object sender, EventArgs e)
        {
            cbLine.Checked = cbTodos.Checked;
            cbColumn.Checked = cbTodos.Checked;
            cbSum.Checked = cbTodos.Checked;
            cbPosition.Checked = cbTodos.Checked;
            cbPrimeNumber.Checked = cbTodos.Checked;
            cbOddEven.Checked = cbTodos.Checked;
            cbNormal.Checked = cbTodos.Checked;
            cbInvertido.Checked = cbTodos.Checked;
            cbDuplicado.Checked = cbTodos.Checked;
            cbMetodo65.Checked = cbTodos.Checked;
            cbFinais.Checked = cbTodos.Checked;
        }
    }
}
