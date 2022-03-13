using System;
using System.Windows.Forms;

namespace MedicalLaba
{
    public partial class AddHistory : Form
    {
        public string result;
        public AddHistory()
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
