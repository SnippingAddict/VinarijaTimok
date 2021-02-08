using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
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
    /// Interaction logic for PocetniProzor.xaml
    /// </summary>
    public partial class PocetniProzor : Window
    {
        public PocetniProzor()
        {
            InitializeComponent();

            Vinograd.Visibility = Visibility.Collapsed;
            timokSlika.Visibility = Visibility.Visible;
            Izvestaj.Visibility = Visibility.Collapsed;
            PSP.Visibility = Visibility.Collapsed;
            POP.Visibility = Visibility.Collapsed;

            IzvestajSave.IsEnabled = false;
            IzvestajExit.IsEnabled = false;

        }

        private void popUpIzlaz_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void odjavi_Click(object sender, RoutedEventArgs e)
        {
            LogIn nazad = new LogIn();
            nazad.Show();
            this.Close();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            timokSlika.Visibility = Visibility.Visible;

            Vinograd.Visibility = Visibility.Collapsed;
            PSP.Visibility = Visibility.Collapsed;
            POP.Visibility = Visibility.Collapsed;
            Izvestaj.Visibility = Visibility.Collapsed;

        }

        private void Vineyard_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dostava_Click(object sender, RoutedEventArgs e)
        {
            Vinograd.Visibility = Visibility.Visible;

            timokSlika.Visibility = Visibility.Collapsed;
            PSP.Visibility = Visibility.Collapsed;
            POP.Visibility = Visibility.Collapsed;
            Izvestaj.Visibility = Visibility.Collapsed;

        }

        private void WindowMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            HACCPIzradaWin haccpWin = new HACCPIzradaWin();
            haccpWin.ShowDialog();
        }

        private void psp_Click(object sender, RoutedEventArgs e)
        {
            PSP.Visibility = Visibility.Visible;

            timokSlika.Visibility = Visibility.Collapsed;
            Vinograd.Visibility = Visibility.Collapsed;
            POP.Visibility = Visibility.Collapsed;
            Izvestaj.Visibility = Visibility.Collapsed;

        }

        private void ostvPr_Click(object sender, RoutedEventArgs e)
        {
            POP.Visibility = Visibility.Visible;

            timokSlika.Visibility = Visibility.Collapsed;
            Vinograd.Visibility = Visibility.Collapsed;
            PSP.Visibility = Visibility.Collapsed;
            Izvestaj.Visibility = Visibility.Collapsed;

        }

        private void IzveštajNew_Click(object sender, RoutedEventArgs e)
        {
            Izvestaj.Visibility = Visibility.Visible;
            IzvestajSave.IsEnabled = true;
            IzvestajExit.IsEnabled = true;

            timokSlika.Visibility = Visibility.Collapsed;
            Vinograd.Visibility = Visibility.Collapsed;
            PSP.Visibility = Visibility.Collapsed;
            POP.Visibility = Visibility.Collapsed;
        }

        private void IzvestajOpen_Click(object sender, RoutedEventArgs e)
        {
            Izvestaj.Visibility = Visibility.Visible;
            IzvestajSave.IsEnabled = true;
            IzvestajExit.IsEnabled = true;

            timokSlika.Visibility = Visibility.Collapsed;
            Vinograd.Visibility = Visibility.Collapsed;
            PSP.Visibility = Visibility.Collapsed;
            POP.Visibility = Visibility.Collapsed;
        }

        private void IzvestajExit_Click(object sender, RoutedEventArgs e)
        {
            Izvestaj.Visibility = Visibility.Collapsed;
            IzvestajSave.IsEnabled = false;
            IzvestajExit.IsEnabled = false;
            Izvestaj.editor.Document.Blocks.Clear();


            timokSlika.Visibility = Visibility.Visible;
            Vinograd.Visibility = Visibility.Collapsed;
            PSP.Visibility = Visibility.Collapsed;
            POP.Visibility = Visibility.Collapsed;
        }

        public void izvestaj_Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                FileStream fileStream = new FileStream(dlg.FileName, FileMode.Create);
                TextRange range = new TextRange(Izvestaj.editor.Document.ContentStart, Izvestaj.editor.Document.ContentEnd);
                range.Save(fileStream, DataFormats.Rtf);
            }
        }

        private void izvestaj_Open_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                FileStream fileStream = new FileStream(dlg.FileName, FileMode.Open);
                TextRange range = new TextRange(Izvestaj.editor.Document.ContentStart, Izvestaj.editor.Document.ContentEnd);
                range.Load(fileStream, DataFormats.Rtf);
            }
        }

        private void pomoc_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://github.com/SnippingAddict/vinarija-timok/wiki/Pomo%C4%87");
        }

        private void Logistika_Click(object sender, RoutedEventArgs e)
        {
            HACCPIzradaWin haccpWin = new HACCPIzradaWin();
            haccpWin.ShowDialog();
        }
    }
}
