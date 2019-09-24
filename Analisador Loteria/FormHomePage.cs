using System;
using System.Windows.Forms;

namespace Analisador_Loteria
{
    public partial class FormHomePage : Form
    {
        public FormHomePage()
        {
            InitializeComponent();
        }

        private void btnLotofacil_Click(object sender, EventArgs e)
        {
            FormLotofacil formLotofacil = new FormLotofacil();
            formLotofacil.ShowDialog();
        }
    }
}
