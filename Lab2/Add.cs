using System;
using System.Drawing;
using System.Windows.Forms;

namespace MedicalLaba
{
    public partial class Add : Form
    {
        public Patient patient;
        private string pathToImage;
        private int id;

        public Add(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameBox.Text.Equals("") || nameBox.Text.Contains(" "))
            {
                MessageBox.Show("Неверно указано имя!", "Ошибка");
                return;
            }
            if (surnameBox.Text.Equals("") || surnameBox.Text.Contains(" "))
            {
                MessageBox.Show("Неверно указано фамилия!", "Ошибка");
                return;
            }
            if (SexBox.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали пол!","Ошибка");
                return;
            }
            patient = new Patient(id, nameBox.Text, surnameBox.Text, SexBox.SelectedIndex, birthPicker.Value, pathToImage);
            foreach (string diagnoz in listBox1.Items)
            {
                patient.Diagnoz.Add(diagnoz);
            }
            foreach (string history in listBox2.Items)
            {
                patient.History.Add(history);
            }
            Close();
        }

        private void pictureBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                    pathToImage = openFileDialog1.FileName;
                }
                catch
                {
                    MessageBox.Show("Невозможно загрузить картинку!","Ошибка!!!");
                }
            }
        }

        private void AddDiagBtn_Click(object sender, EventArgs e)
        {
            AddDiagnoz addForm = new AddDiagnoz();
            addForm.ShowDialog();
            if (addForm.result != null && addForm.result != "")
            {
                listBox1.Items.Add(addForm.result);
            }
        }

        private void AddHistBtn_Click(object sender, EventArgs e)
        {
            AddHistory addForm = new AddHistory();
            addForm.ShowDialog();
            if (addForm.result != null && addForm.result != "")
            {
                listBox2.Items.Add(addForm.result);
            }
        }
    }
}
