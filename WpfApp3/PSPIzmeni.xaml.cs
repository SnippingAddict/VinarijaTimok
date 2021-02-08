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
    /// Interaction logic for PSPIzmeni.xaml
    /// </summary>
    public partial class PSPIzmeni : Window
    {
        string sorta;
        string kolicina;
        string vinograd;
        string datum;
        string prevoznik;

        List<PSPCL> lista1 = new List<PSPCL>();


        public PSPIzmeni(string Sorta, string Kolicina, string Datum, string Prevoznik, string Vinograd)
        {
            InitializeComponent();

            this.sorta = Sorta;
            this.kolicina = Kolicina;
            this.datum = Datum;
            this.prevoznik = Prevoznik;
            this.vinograd = Vinograd;

            sortA.Text = Sorta;
            kolicinA.Text = Kolicina;
            datuM.Text = Datum;
            prevozniK.Text = Prevoznik;
            vinograD.Text = Vinograd;

            UcitajDatotekuResursa();
        }

        private readonly string _psp = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "psp.bin");


        private void UcitajDatotekuResursa()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;



            try
            {
                stream = File.Open(_psp, FileMode.OpenOrCreate);
                lista1 = (List<PSPCL>)formatter.Deserialize(stream);

                Console.WriteLine(lista1);

                foreach (PSPCL item in lista1)
                {
                    Console.WriteLine(item.Sorta);
                }

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

        private void MemorisiDatotekuResursa()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;


            foreach (PSPCL pspadd in lista1)
            {
                if (pspadd.Sorta == this.sorta)
                {
                    pspadd.Sorta = sortA.Text;
                    pspadd.Kolicina = kolicinA.Text;
                    pspadd.Datum = datuM.Text;
                    pspadd.Prevoznik = prevozniK.Text;
                    pspadd.Vinograd = vinograD.Text;
                }
            }

            try
            {

                //lista ima ugradjen konstuktor za obsCol

                stream = File.Open(_psp, FileMode.OpenOrCreate);
                formatter.Serialize(stream, lista1);
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

        private void adddIng2_Click(object sender, RoutedEventArgs e)
        {
            MemorisiDatotekuResursa();
            UcitajDatotekuResursa();
            this.Visibility = Visibility.Collapsed;
        }

        private void giveeUp2_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }

        private void sortA_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[a-zA-Z]"))
            {
                e.Handled = true;
            }
        }

        private void kolicinA_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void datuM_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            
        }

        private void prevozniK_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[a-zA-Z]"))
            {
                e.Handled = true;
            }
        }

        private void vinograD_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[a-zA-Z]"))
            {
                e.Handled = true;
            }
        }
    }
}
