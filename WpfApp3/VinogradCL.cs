using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    [Serializable]
    class VinogradCL : INotifyPropertyChanged
    {
        string sorta;
        string lokacija;
        string datum;
        string prevoznik;
        string vinograd;


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnNotifyPropertyChanged(string p)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(p));
            }
        }

        public VinogradCL()
        {
            sorta = "";
            lokacija = "";
            datum = "";
            prevoznik = "";
            vinograd = "";
        }

        public VinogradCL (string Sorta, string Lokacija, string Datum, string Prevoznik, string Vinograd)
        {
            this.Sorta = Sorta;
            this.Lokacija = Lokacija;
            this.Datum = Datum;
            this.Prevoznik = Prevoznik;
            this.Vinograd = Vinograd;
        }

        public string Sorta { get => sorta; set { sorta = value; OnNotifyPropertyChanged("Sorta"); } }
        public string Lokacija { get => lokacija; set { lokacija = value; OnNotifyPropertyChanged("Lokacija"); } }
        public string Datum { get => datum; set { datum = value; OnNotifyPropertyChanged("Datum"); } }
        public string Prevoznik { get => prevoznik; set { prevoznik = value; OnNotifyPropertyChanged("Prevoznik"); } }
        public string Vinograd { get => vinograd; set { vinograd = value; OnNotifyPropertyChanged("Vinograd"); } }
    }
}
