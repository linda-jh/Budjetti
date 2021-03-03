using System;
using System.Collections.Generic;
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

namespace Budjetti
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Meno> menot = new List<Meno>();
            menot.Add(new Meno() { Pv = new DateTime(2020, 7, 23), Nimi = "Semma", Summa = 10 });
            menot.Add(new Meno() { Pv = new DateTime(2020, 7, 30), Nimi = "Prisma", Summa = 58.45 });
            menot.Add(new Meno() { Pv = new DateTime(2020, 8, 3), Nimi = "Alko", Summa = 9.90 });

            dgMenot.ItemsSource = menot;

        }

        public class Meno
        {
            public DateTime Pv { get; set; }

            public string Nimi { get; set; }

            public double Summa { get; set; }
        }

        public void SuljeKokoOhjelma(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        public void MinimoiIkkuna(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        public void SuljeIkkuna(object sender, RoutedEventArgs e)
        {
            Window1 a = new Window1();
            a.Show();
        }
    }
}
