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
    /// Interaction logic for POPDodaj.xaml
    /// </summary>
    public partial class POPDodaj : UserControl
    {
        List<POPCL> lista2 = new List<POPCL>();

        public POPDodaj()
        {
            InitializeComponent();

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

            Random number = new Random();

            POPCL popadd = new POPCL();
            popadd.Vrsta_Vina = vrstavinA.Text;
            popadd.Kolicina = kolicina2.Text;
            popadd.Datum = datum2.Text;
            popadd.Lokacija = lokacija2.Text;

            lista2.Add(popadd);

            foreach (POPCL person in lista2)
            {
                Console.WriteLine(person.Kolicina);
            }

            try
            {
                stream = File.Open(_pop, FileMode.OpenOrCreate);
                formatter.Serialize(stream, lista2);
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

        private void addIng3_Click(object sender, RoutedEventArgs e)
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

        private void giveUp3_Click(object sender, RoutedEventArgs e)
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

        private void kolicina2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
