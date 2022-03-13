using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MedicalLaba
{
    public partial class Form1 : Form
    {
        private int MaxPatientId = -1;
        private int MaxDiagnozId = -1;
        private int MaxHistoryId = -1;

        private Patient selected;

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenAdd(object sender, EventArgs e)
        {
            Add addForm = new Add(MaxPatientId + 1);
            addForm.ShowDialog();
            Patient info = addForm.patient;
            if (info != null)
            {
                MaxPatientId++;
                DataGridViewRow dataRow = new DataGridViewRow();
                dataRow.CreateCells(dataGridView1);
                string polString;
                if (info.Pol == 0)
                {
                    polString = "Мужской";
                }
                else
                {
                    polString = "Женский";
                }
                dataRow.SetValues(new object[4] { info.Id, info.Surname + " " + info.Name, info.Birthday, polString });
                ToolStripButton contextButton = new ToolStripButton();
                contextButton.Text = "Инфо";
                contextButton.Tag = dataRow.Tag = info;
                contextButton.Click += Context_Click;
                ContextMenuStrip strip = new ContextMenuStrip();
                strip.Items.Add(contextButton);
                dataRow.ContextMenuStrip = strip;
                dataGridView1.Rows.Add(dataRow);

                if (File.Exists("dataPatient.txt") && File.Exists("diagnozPatient.txt") && File.Exists("historyPatient.txt"))
                {
                    File.AppendAllText("dataPatient.txt", $"{info.Id} {info.Name} {info.Surname} {info.Pol} {info.Birthday.ToString("dd.MM.yyyy")} {info.Image}\n");
                    foreach (string diagnoz in info.Diagnoz)
                    {
                        File.AppendAllText("diagnozPatient.txt", $"{++MaxDiagnozId} {info.Id} {diagnoz}\n");
                    }
                    foreach (string action in info.History)
                    {
                        File.AppendAllText("historyPatient.txt", $"{++MaxHistoryId} {info.Id} {action}\n");
                    }
                }
                else
                {
                    MessageBox.Show("Один или несколько из файлов с информацией отсутствует!", "Ошибка");
                }
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            if (File.Exists("dataPatient.txt") && File.Exists("diagnozPatient.txt") && File.Exists("historyPatient.txt"))
            {
                List<Patient> patients = new List<Patient>();
                //Читаю из файла пациентов
                string[] readLines = File.ReadAllLines("dataPatient.txt");
                foreach (string line in readLines)
                {
                    //Парсинг
                    string[] parseStrings = line.Split(' ');
                    int ID = int.Parse(parseStrings[0]);
                    if (ID > MaxPatientId)
                    {
                        MaxPatientId = ID;
                    }
                    Patient patient = new Patient(ID, parseStrings[1], parseStrings[2], int.Parse(parseStrings[3]), DateTime.Parse(parseStrings[4]), parseStrings[5]);
                    patients.Add(patient);
                    //Добавляю в таблицу
                    DataGridViewRow dataRow = new DataGridViewRow();
                    dataRow.CreateCells(dataGridView1);
                    string polString;
                    if (patient.Pol == 0)
                    {
                        polString = "Мужской";
                    }
                    else
                    {
                        polString = "Женский";
                    }
                    dataRow.SetValues(new object[4] { patient.Id, patient.Surname + " " + patient.Name, patient.Birthday.ToString("dd.MM.yyyy"), polString });
                    ToolStripButton contextButton = new ToolStripButton();
                    contextButton.Text = "Инфо";
                    contextButton.Tag = dataRow.Tag = patient;
                    contextButton.Click += Context_Click;
                    ContextMenuStrip strip = new ContextMenuStrip();
                    strip.Items.Add(contextButton);
                    dataRow.ContextMenuStrip = strip;
                    dataGridView1.Rows.Add(dataRow);
                }
                //Читаю из файла диагнозов
                readLines = File.ReadAllLines("diagnozPatient.txt");
                foreach (string line in readLines)
                {
                    //Парсинг
                    string[] parseStrings = line.Split(' ');
                    int ID = int.Parse(parseStrings[0]);
                    if (ID > MaxDiagnozId)
                    {
                        MaxDiagnozId = ID;
                    }
                    int PatientId = int.Parse(parseStrings[1]);
                    Patient linkedPatient = patients.FirstOrDefault(x=>x.Id == PatientId);
                    if (linkedPatient != null)
                    {
                        string diag = parseStrings[2];
                        for (int i = 3; i < parseStrings.Length; i++)
                        {
                            diag += " " + parseStrings[i];
                        }
                        linkedPatient.Diagnoz.Add(diag);
                    }
                }
                //Читаю из файла истории
                readLines = File.ReadAllLines("historyPatient.txt");
                foreach (string line in readLines)
                {
                    //Парсинг
                    string[] parseStrings = line.Split(' ');
                    int ID = int.Parse(parseStrings[0]);
                    if (ID > MaxHistoryId)
                    {
                        MaxHistoryId = ID;
                    }
                    int PatientId = int.Parse(parseStrings[1]);
                    Patient linkedPatient = patients.FirstOrDefault(x => x.Id == PatientId);
                    if (linkedPatient != null)
                    {
                        string hist = parseStrings[2];
                        for (int i = 3; i < parseStrings.Length; i++)
                        {
                            hist += " " + parseStrings[i];
                        }
                        linkedPatient.History.Add(hist);
                    }
                }
            }
            else
            {
                MessageBox.Show("Не найдены файлы с информацией!", "Ошибка!!!");
                Close();
            }
        }

        private void Context_Click(object sender, EventArgs e)
        {
            ToolStripButton contextButton = sender as ToolStripButton;
            Patient patient = contextButton.Tag as Patient;
            pictureBox.Image = null;
            if (File.Exists(patient.Image))
            {
                try
                {
                    pictureBox.Image = Image.FromFile(patient.Image);
                }
                catch
                {
                    MessageBox.Show("Ошибка загрузки фотографии!", "Ошибка");
                }
            }
            selected = patient;
            label1.Text = "Имя: " + patient.Name;
            label2.Text = "Фамилия: " + patient.Surname;
            string polString;
            if (patient.Pol == 0)
            {
                polString = "Мужской";
            }
            else
            {
                polString = "Женский";
            }
            label3.Text = "Пол: " + polString;
            label4.Text = "Возраст: " + CalcAge(patient.Birthday) + " (" + patient.Birthday.ToString("dd.MM.yyyy") + ")";
        }

        private int CalcAge(DateTime date)
        {
            int currentAge = DateTime.Today.Year - date.Year;
            if (date > DateTime.Today.AddYears(-currentAge)) currentAge--;
            return currentAge;
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            if (selected != null)
            {
                Information infoShow = new Information(selected);
                infoShow.ShowDialog();
            }
        }
    }
}
