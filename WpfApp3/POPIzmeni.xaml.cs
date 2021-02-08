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
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for POPIzmeni.xaml
    /// </summary>
    public partial class POPIzmeni : Window
    {
        private string vrsta_vina;
        string kolicina;
        string lokacija;
        string datum;

        public POPIzmeni()
        {
            InitializeComponent();
        }

        List<POPCL> lista2 = new List<POPCL>();

        public POPIzmeni (string Vrsta_vina, string Kolicina, string Lokacija, string Datum)
        {
            InitializeComponent();

            this.vrsta_vina = Vrsta_vina;
            this.kolicina = Kolicina;
            this.lokacija = Lokacija;
            this.datum = Datum;

            vrstavinA.Text = Vrsta_vina;
            lokacija2.Text = Lokacija;
            datum2.Text = Datum;
            kolicina2.Text = Kolicina;

            UcitajDatotekuResursa();
        }

 

        private readonly string _pop = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "_pop.bin");


        private void UcitajDatotekuResursa()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;





            try
            {
                stream = File.Open(_pop, FileMode.OpenOrCreate);
                lista2 = (List<POPCL>)formatter.Deserialize(stream);

                Console.WriteLine(lista2);

                foreach (POPCL item in lista2)
                {
                    Console.WriteLine(item.Vrsta_Vina);
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


            foreach (POPCL popizmena in lista2)
            {
                if (popizmena.Vrsta_Vina == this.vrsta_vina)
                {
                    popizmena.Vrsta_Vina = vrstavinA.Text;
                    popizmena.Lokacija = lokacija2.Text;
                    popizmena.Datum = datum2.Text;
                    popizmena.Kolicina = kolicina2.Text;
                }
            }

            try
            {


                stream = File.Open(_pop, FileMode.OpenOrCreate);
                formatter.Serialize(stream, lista2);
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

        private void kolicina2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void addIng4_Click(object sender, RoutedEventArgs e)
        {
            MemorisiDatotekuResursa();
            UcitajDatotekuResursa();
            this.Visibility = Visibility.Collapsed;
        }

        private void giveUp4_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }
    }
}
