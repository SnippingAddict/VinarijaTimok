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
    /// Interaction logic for PSP.xaml
    /// </summary>
    public partial class PSP : UserControl
    {
        List<PSPCL> lista1 = new List<PSPCL>();

        private readonly string _psp = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "psp.bin");

        public PSP()
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

                stream = File.Open(_psp, FileMode.OpenOrCreate);
                lista1 = null;
                lista1 = (List<PSPCL>)formatter.Deserialize(stream);

                this.DataGridPSP.ItemsSource = lista1;


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

        private void dodaj2_Click(object sender, RoutedEventArgs e)
        {
            PSPDodaj.Visibility = Visibility.Visible;

            UcitajDatotekuResursa();
            MemorisiDatotekuResursa();      

        }

        private void izmeni2_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridPSP.SelectedIndex == 0)
            {
                PSPIzmeni updatePSP = new PSPIzmeni(
                lista1[DataGridPSP.SelectedIndex].Sorta,
                lista1[DataGridPSP.SelectedIndex].Kolicina,
                lista1[DataGridPSP.SelectedIndex].Datum,
                lista1[DataGridPSP.SelectedIndex].Prevoznik,
                lista1[DataGridPSP.SelectedIndex].Vinograd);

                UcitajDatotekuResursa();

                updatePSP.Show();

                UcitajDatotekuResursa();
            } else
            {
                UcitajDatotekuResursa();
            }
        }

        private void odustani2_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridPSP.SelectedIndex == 0)
            {

                lista1.RemoveAt(DataGridPSP.SelectedIndex);

                MemorisiDatotekuResursa();

                UcitajDatotekuResursa();
            } else
            {
                UcitajDatotekuResursa();
            }
        }
    }
}
