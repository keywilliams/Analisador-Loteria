using System.Windows.Forms;

namespace Analisador_Loteria
{
    public partial class FormSummary : Form
    {
        public FormSummary()
        {
            InitializeComponent();
        }

        public string TextBoxSummary
        {
            get { return txtSummary.Text; }
            set { txtSummary.Text = value; }
        }
    }
}
