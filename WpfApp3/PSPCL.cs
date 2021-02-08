using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    [Serializable]
    class PSPCL : INotifyPropertyChanged
    {
        string sorta;
        string kolicina;
        string vinograd;
        string datum;
        string prevoznik;


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnNotifyPropertyChanged(string p)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(p));
            }
        }

        public PSPCL()
        {
            sorta = "";
            kolicina = "";
            datum = "";
            prevoznik = "";
            vinograd = "";
        }

        public PSPCL(string Sorta, string Kolicina, string Datum, string Prevoznik, string Vinograd)
        {
            this.Sorta = Sorta;
            this.Kolicina = Kolicina;
            this.Datum = Datum;
            this.Prevoznik = Prevoznik;
            this.Vinograd = Vinograd;
        }

        public string Sorta { get => sorta; set { sorta = value; OnNotifyPropertyChanged("Sorta"); } }
        public string Kolicina { get => kolicina; set { kolicina = value; OnNotifyPropertyChanged("Kolicina"); } }
        public string Datum { get => datum; set { datum = value; OnNotifyPropertyChanged("Datum"); } }
        public string Prevoznik { get => prevoznik; set { prevoznik = value; OnNotifyPropertyChanged("Prevoznik"); } }
        public string Vinograd { get => vinograd; set { vinograd = value; OnNotifyPropertyChanged("Vinograd"); } }
    }
}
