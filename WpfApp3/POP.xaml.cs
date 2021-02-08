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
    /// Interaction logic for POP.xaml
    /// </summary>
    public partial class POP : UserControl
    {

        List<POPCL> lista2 = new List<POPCL>();

        private readonly string _pop = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "_pop.bin");

        public POP()
        {
            InitializeComponent();

            UcitajDatotekuResursa();
        }

        private void UcitajDatotekuResursa()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = null;

            try
            {

                stream = File.Open(_pop, FileMode.OpenOrCreate);
                lista2 = null;
                lista2 = (List<POPCL>)formatter.Deserialize(stream);

                this.DataGridPOP.ItemsSource = lista2;


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

            try
            {

                //lista ima ugradjen konstuktor za obsCol

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




        private void dodaj3_Click(object sender, RoutedEventArgs e)
        {
            POPDodaj.Visibility = Visibility.Visible;

            UcitajDatotekuResursa();
            MemorisiDatotekuResursa();

        }

        private void izmeni3_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridPOP.SelectedIndex == 0)
            {
                POPIzmeni updatePOP = new POPIzmeni(
                lista2[DataGridPOP.SelectedIndex].Vrsta_Vina,
                lista2[DataGridPOP.SelectedIndex].Kolicina,
                lista2[DataGridPOP.SelectedIndex].Datum,
                lista2[DataGridPOP.SelectedIndex].Lokacija);

                UcitajDatotekuResursa();

                updatePOP.Show();

                UcitajDatotekuResursa();
            } else
            {
                UcitajDatotekuResursa();
            }
        }

        private void odustani3_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridPOP.SelectedIndex == 0)
            {
                lista2.RemoveAt(DataGridPOP.SelectedIndex);

                MemorisiDatotekuResursa();

                UcitajDatotekuResursa();
            } else
            {
                MemorisiDatotekuResursa();
                UcitajDatotekuResursa();
            }
        }
    }
}
