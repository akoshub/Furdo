using StrandC;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StrandWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Furdo> furdok = new List<Furdo>();
        public MainWindow()
        {
            InitializeComponent();
            Feltolt();
        }

        public void Feltolt()
        {
            foreach (var f in File.ReadAllLines("strandadatok.txt").Skip(1))
            {
                furdok.Add(new Furdo(f));
            }
            Dg_adatok.ItemsSource = furdok;
        }

        private void Btn_Mentes_Click(object sender, RoutedEventArgs e)
        {
            if (Dg_adatok.SelectedItem is Furdo kivalasztott)
            {
                var savefileDialog = new Microsoft.Win32.SaveFileDialog
                { 
                    FileName = kivalasztott.Nev,
                    DefaultExt = ".txt",
                    Filter = "Szöveges fájl (*.txt)|*.txt"
                };
                if (savefileDialog.ShowDialog() == true)
                {
                    using (StreamWriter sw = new StreamWriter(savefileDialog.FileName))
                    {
                        sw.WriteLine($"{kivalasztott.Nev}\n" +
                                    $"Cím: {kivalasztott.Cim}\n" +
                                    $"Ár: {kivalasztott.Ar}\n" +
                                    $"Vízhőfok: {kivalasztott.Vizhofok}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nem menthető, amíg nincs kiválasztva semmi.", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Dg_adatok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Dg_adatok.SelectedItem is Furdo kivalasztott)
            {
                Tbx_Nev.Text = kivalasztott.Nev;
                Tbx_Cim.Text = kivalasztott.Cim;
                Tbx_Ar.Text = kivalasztott.Ar.ToString();
                Tbx_Vizhofok.Text = kivalasztott.Vizhofok.ToString();
                Pb_toltes.Value = kivalasztott.Vizhofok;
            }
        }
    }
}
