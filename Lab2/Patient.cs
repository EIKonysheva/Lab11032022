using System;
using System.Collections.Generic;

namespace MedicalLaba
{
    public class Patient
    {
        public Patient(int Id, string Name, string Surname, int Pol, DateTime Birthday, string Image)
        {
            this.Id = Id;
            this.Name = Name;
            this.Surname = Surname;
            this.Pol = Pol;
            this.Birthday = Birthday;
            this.Image = Image;
            Diagnoz = new List<string>();
            History = new List<string>();
        }

        public int Id;
        public string Name;
        public string Surname;
        public int Pol;
        public DateTime Birthday;
        public string Image;
        public List<string> Diagnoz;
        public List<string> History;
    }
}
