using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for VinogradDodaj.xaml
    /// </summary>
    public partial class VinogradDodaj : UserControl
    {
        private string sorta;
        string lokacija;
        string datum;
        string prevoznik;
        string vinograd;

        public VinogradDodaj()
        {
            InitializeComponent();
        }

        List<VinogradCL> lista = new List<VinogradCL>();

        public VinogradDodaj(string Sorta, string Lokacija, string Datum, string Prevoznik, string Vinograd)
        {
            this.sorta = Sorta;
            this.lokacija = Lokacija;
            this.datum = Datum;
            this.prevoznik = Prevoznik;
            this.vinograd = Vinograd;

            soRta.Text = Sorta;
            lokaCija.Text = Lokacija;
            daTum.Text = Datum;
            prevoZnik.Text = Prevoznik;
            vinoGrad.Text = Vinograd;

            UcitajDatotekuResursa();
        }

        private readonly string _vinograd = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "vinograd.bin");


        private void UcitajDatotekuResursa()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;





            try
            {
                stream = File.Open(_vinograd, FileMode.OpenOrCreate);
                lista = (List<VinogradCL>)formatter.Deserialize(stream);

                Console.WriteLine(lista);

                foreach (VinogradCL item in lista)
                {
                    Console.WriteLine(item.Sorta);
                }

            }
            catch
            {
                // 
            }
            finally
            {
                if (stream != null)
                    stream.Dispose();
            }
        }

        private void MemorisiDatotekuResursa()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;


            foreach (VinogradCL vinoGr in lista)
            {
                if (vinoGr.Sorta == this.sorta)
                {
                    vinoGr.Sorta = soRta.Text;
                    vinoGr.Lokacija = lokaCija.Text;
                    vinoGr.Datum = daTum.Text;
                    vinoGr.Prevoznik = prevoZnik.Text;
                    vinoGr.Vinograd = vinoGrad.Text;
                }
            }

            try
            {


                stream = File.Open(_vinograd, FileMode.OpenOrCreate);
                formatter.Serialize(stream, lista);
            }
            catch
            {
                // 
            }
            finally
            {
                if (stream != null)
                    stream.Dispose();
            }
        }


        private void addIng_Click(object sender, RoutedEventArgs e)
        {
            MemorisiDatotekuResursa();
            UcitajDatotekuResursa();
            this.Visibility = Visibility.Collapsed;
        }

        private void giveUp_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }
    }
}
