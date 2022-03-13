
namespace MedicalLaba
{
    partial class Information
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.sexLabel = new System.Windows.Forms.Label();
            this.birthLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.diagnozList = new System.Windows.Forms.ListBox();
            this.historyList = new System.Windows.Forms.ListBox();
            this.patientTabs = new System.Windows.Forms.TabControl();
            this.diagnosisPage = new System.Windows.Forms.TabPage();
            this.historyPage = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.patientTabs.SuspendLayout();
            this.diagnosisPage.SuspendLayout();
            this.historyPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox.Location = new System.Drawing.Point(12, 12);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(143, 135);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox.TabIndex = 29;
            this.imageBox.TabStop = false;
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(161, 38);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(30, 13);
            this.sexLabel.TabIndex = 23;
            this.sexLabel.Text = "Пол:";
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Location = new System.Drawing.Point(161, 51);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(92, 13);
            this.birthLabel.TabIndex = 22;
            this.birthLabel.Text = "Дата рождения: ";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(161, 25);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(62, 13);
            this.surnameLabel.TabIndex = 21;
            this.surnameLabel.Text = "Фамилия: ";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(161, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 20;
            this.nameLabel.Text = "Имя: ";
            // 
            // diagnozList
            // 
            this.diagnozList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagnozList.FormattingEnabled = true;
            this.diagnozList.Location = new System.Drawing.Point(3, 3);
            this.diagnozList.Name = "diagnozList";
            this.diagnozList.Size = new System.Drawing.Size(545, 344);
            this.diagnozList.TabIndex = 31;
            // 
            // historyList
            // 
            this.historyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyList.FormattingEnabled = true;
            this.historyList.Location = new System.Drawing.Point(3, 3);
            this.historyList.Name = "historyList";
            this.historyList.Size = new System.Drawing.Size(545, 344);
            this.historyList.TabIndex = 32;
            // 
            // patientTabs
            // 
            this.patientTabs.Controls.Add(this.diagnosisPage);
            this.patientTabs.Controls.Add(this.historyPage);
            this.patientTabs.Location = new System.Drawing.Point(12, 153);
            this.patientTabs.Name = "patientTabs";
            this.patientTabs.SelectedIndex = 0;
            this.patientTabs.Size = new System.Drawing.Size(559, 376);
            this.patientTabs.TabIndex = 38;
            // 
            // diagnosisPage
            // 
            this.diagnosisPage.Controls.Add(this.diagnozList);
            this.diagnosisPage.Location = new System.Drawing.Point(4, 22);
            this.diagnosisPage.Name = "diagnosisPage";
            this.diagnosisPage.Padding = new System.Windows.Forms.Padding(3);
            this.diagnosisPage.Size = new System.Drawing.Size(551, 350);
            this.diagnosisPage.TabIndex = 0;
            this.diagnosisPage.Text = "Диагнозы";
            this.diagnosisPage.UseVisualStyleBackColor = true;
            // 
            // historyPage
            // 
            this.historyPage.Controls.Add(this.historyList);
            this.historyPage.Location = new System.Drawing.Point(4, 22);
            this.historyPage.Name = "historyPage";
            this.historyPage.Padding = new System.Windows.Forms.Padding(3);
            this.historyPage.Size = new System.Drawing.Size(551, 350);
            this.historyPage.TabIndex = 1;
            this.historyPage.Text = "История";
            this.historyPage.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "PNG (*.png)|*.png|JPEG (*.jpeg)|*.jpeg|JPG (*.jpg)|*.jpg|GIF (*.gif)|*.gif";
            this.openFileDialog1.Title = "Открыть";
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 534);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.patientTabs);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.birthLabel);
            this.Controls.Add(this.sexLabel);
            this.MaximumSize = new System.Drawing.Size(591, 573);
            this.MinimumSize = new System.Drawing.Size(591, 573);
            this.Name = "Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Инфо";
            this.Load += new System.EventHandler(this.InfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.patientTabs.ResumeLayout(false);
            this.diagnosisPage.ResumeLayout(false);
            this.historyPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ListBox diagnozList;
        private System.Windows.Forms.ListBox historyList;
        private System.Windows.Forms.TabControl patientTabs;
        private System.Windows.Forms.TabPage diagnosisPage;
        private System.Windows.Forms.TabPage historyPage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}