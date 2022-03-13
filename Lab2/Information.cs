using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MedicalLaba
{
    public partial class Information : Form
    {
        private Patient patient;

        public Information(Patient patient)
        {
            this.patient = patient;
            InitializeComponent();
        }

        private int CalcAge(DateTime date)
        {
            int currentAge = DateTime.Today.Year - date.Year;
            if (date > DateTime.Today.AddYears(-currentAge)) currentAge--;
            return currentAge;
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = "Имя: " + patient.Name;
            surnameLabel.Text = "Фамилия: " + patient.Surname;
            string polString;
            if (patient.Pol == 0)
            {
                polString = "Мужской";
            }
            else
            {
                polString = "Женский";
            }
            sexLabel.Text = "Пол: " + polString;
            birthLabel.Text = "Возраст: " + CalcAge(patient.Birthday) + " (" + patient.Birthday.ToString("dd.MM.yyyy") + ")";
            if (File.Exists(patient.Image))
            {
                try
                {
                    imageBox.Image = Image.FromFile(patient.Image);
                }
                catch
                {
                    MessageBox.Show("Невозможно загрузить картинку!", "Ошибка!!!");
                }
            }
            historyList.Items.AddRange(patient.History.ToArray());
            diagnozList.Items.AddRange(patient.Diagnoz.ToArray());
        }

    }
}
