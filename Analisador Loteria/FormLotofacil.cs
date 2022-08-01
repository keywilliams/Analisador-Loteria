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

            FormSummary formSummary = new FormSummary();
            formSummary.TextBoxSummary = $"TOTAL DE JOGOS: {allLines.Length}{Environment.NewLine}";

            //Quantity
            var quantitySummary = Lotofacil.Lotofacil.QuantityAnalysis(allLines);
            formSummary.TextBoxSummary += $"{quantitySummary}{Environment.NewLine}";

            //Line
            if (cbLine.Checked)
            {
                var lineSummary = Lotofacil.Lotofacil.LineAnalysis(allLines);
                formSummary.TextBoxSummary += $"{lineSummary}{Environment.NewLine}";
            }

            //Column
            if (cbColumn.Checked)
            {
                var columnSummary = Lotofacil.Lotofacil.ColumnAnalysis(allLines);
                formSummary.TextBoxSummary += $"{columnSummary}{Environment.NewLine}";
            }

            //Sum
            if (cbSum.Checked)
            {
                var sumSummary = Lotofacil.Lotofacil.SumAnalysis(allLines);
                formSummary.TextBoxSummary += $"{sumSummary}{Environment.NewLine}";
            }

            //Position
            if (cbPosition.Checked)
            {
                var positionSummary = Lotofacil.Lotofacil.PositionAnalysis(allLines);
                formSummary.TextBoxSummary += $"{positionSummary}{Environment.NewLine}";
            }

            //Position
            if (cbPrimeNumber.Checked)
            {
                var primeNumberSummary = Lotofacil.Lotofacil.PrimeNumberAnalysis(allLines);
                formSummary.TextBoxSummary += $"{primeNumberSummary}{Environment.NewLine}";
            }

            //Odd and Even
            if (cbOddEven.Checked)
            {
                var oddEvenSummary = Lotofacil.Lotofacil.OddEvenAnalysis(allLines);
                formSummary.TextBoxSummary += $"{oddEvenSummary}{Environment.NewLine}";
            }

            //Group Of 2
            if (cbGroup2.Checked)
            {
                var groupOf2Summary = Lotofacil.Lotofacil.GroupOf2Analysis(allLines);
                formSummary.TextBoxSummary += $"{groupOf2Summary}{Environment.NewLine}";
            }

            //Group Of 3
            if (cbGroup3.Checked)
            {
                var groupOf3Summary = Lotofacil.Lotofacil.GroupOf3Analysis(allLines);
                formSummary.TextBoxSummary += $"{groupOf3Summary}{Environment.NewLine}";
            }

            //Group Of 4
            if (cbGroup4.Checked)
            {
                var groupOf4Summary = Lotofacil.Lotofacil.GroupOf4Analysis(allLines);
                formSummary.TextBoxSummary += $"{groupOf4Summary}{Environment.NewLine}";
            }

            //Group Of 5
            if (cbGroup5.Checked)
            {
                var groupOf5Summary = Lotofacil.Lotofacil.GroupOf5Analysis(allLines);
                formSummary.TextBoxSummary += $"{groupOf5Summary}{Environment.NewLine}";
            }

            //Group Of 6
            if (cbGroup6.Checked)
            {
                var groupOf6Summary = Lotofacil.Lotofacil.GroupOf6Analysis(allLines);
                formSummary.TextBoxSummary += $"{groupOf6Summary}{Environment.NewLine}";
            }

            //Group Of 7
            if (cbGroup7.Checked)
            {
                var groupOf7Summary = Lotofacil.Lotofacil.GroupOf7Analysis(allLines);
                formSummary.TextBoxSummary += $"{groupOf7Summary}{Environment.NewLine}";
            }

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
            cbGroup2.Checked = cbTodos.Checked;
            cbGroup3.Checked = cbTodos.Checked;
            cbGroup4.Checked = cbTodos.Checked;
            cbGroup5.Checked = cbTodos.Checked;
            cbGroup6.Checked = cbTodos.Checked;
            cbGroup7.Checked = cbTodos.Checked;
        }
    }
}
