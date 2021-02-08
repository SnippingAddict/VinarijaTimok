using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    [Serializable]
    class POPCL : INotifyPropertyChanged
    {
        string vrsta_vina;
        string kolicina;
        string lokacija;
        string datum;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnNotifyPropertyChanged(string p)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(p));
            }
        }

        public POPCL()
        {
            vrsta_vina = "";
            kolicina = "";
            lokacija = "";
            datum = "";
        }

        public POPCL(string Vrsta_Vina, string Kolicina, string Lokacija, string Datum)
        {
            this.Vrsta_Vina = Vrsta_Vina;
            this.Kolicina = Kolicina;
            this.Datum = Datum;
            this.Lokacija = Lokacija;
        }

        public string Vrsta_Vina { get => vrsta_vina; set { vrsta_vina = value; OnNotifyPropertyChanged("Vrsta vina"); } }
        public string Kolicina { get => kolicina; set { kolicina = value; OnNotifyPropertyChanged("Kolicina"); } }
        public string Datum { get => datum; set { datum = value; OnNotifyPropertyChanged("Datum"); } }
        public string Lokacija { get => lokacija; set { lokacija = value; OnNotifyPropertyChanged("Lokacija"); } }

    }
}
