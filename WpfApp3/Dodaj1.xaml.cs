using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for Dodaj1.xaml
    /// </summary>
    public partial class Dodaj1 : UserControl
    {
        List<VinogradCL> lista = new List<VinogradCL>();

        public Dodaj1()
        {
            InitializeComponent();

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

            Random number = new Random();

            VinogradCL vinoGr = new VinogradCL();
            vinoGr.Sorta = soRta.Text;
            vinoGr.Lokacija = lokaCija.Text;
            vinoGr.Datum = daTum.Text;
            vinoGr.Prevoznik = prevoZnik.Text;
            vinoGr.Vinograd = vinoGrad.Text;

            lista.Add(vinoGr);

            foreach (VinogradCL person in lista)
            {
                Console.WriteLine(person.Lokacija);
            }

            try
            {


                stream = File.Open(_vinograd, FileMode.OpenOrCreate);
                formatter.Serialize(stream, lista);
            }
            catch
            {
                
            }
            finally
            {
                if (stream != null)
                    stream.Dispose();
            }
        }

        private void addIng_Click(object sender, RoutedEventArgs e)
        {
            UcitajDatotekuResursa();

            MemorisiDatotekuResursa();
            UcitajDatotekuResursa();
            PocetniProzor pocetniProzor = Window.GetWindow(this) as PocetniProzor;
            UcitajDatotekuResursa();
            if (pocetniProzor != null)
            {
                UcitajDatotekuResursa();
                pocetniProzor.Vinograd.Visibility = Visibility.Visible;
                this.Visibility = Visibility.Collapsed;
                UcitajDatotekuResursa();


            }
        }

        private void giveUp_Click(object sender, RoutedEventArgs e)
        {
            UcitajDatotekuResursa();
            this.Visibility = Visibility.Collapsed;
            UcitajDatotekuResursa();
            PocetniProzor pocetniProzor = Window.GetWindow(this) as PocetniProzor;
            if (pocetniProzor != null)
            {
                UcitajDatotekuResursa();
                pocetniProzor.Vinograd.Visibility = Visibility.Visible;
                this.Visibility = Visibility.Collapsed;

            }
        }



        private void lokaCija_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
 
        }

        private void prevoZnik_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[a-zA-Z]"))
            {
                e.Handled = true;
            }
        }

        private void vinoGrad_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[a-zA-Z]"))
            {
                e.Handled = true;
            }
        }

        private void soRta_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[a-zA-Z]"))
            {
                e.Handled = true;
            }
        }

        private void daTum_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }
    }
}
