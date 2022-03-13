using System;
using System.Windows.Forms;

namespace MedicalLaba
{
    public partial class AddDiagnoz : Form
    {
        public string result;
        public AddDiagnoz()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            result = null;
            Close();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            result = textBox.Text;
            Close();
        }
    }
}
