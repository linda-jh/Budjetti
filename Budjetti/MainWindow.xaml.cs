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
        private Tulot t = new Tulot();

        public MainWindow()
        {
            InitializeComponent();

            //LinearGradientBrush gradientBrush = new LinearGradientBrush(Color.FromRgb(228, 231, 228), Color.FromRgb(10, 22, 71), new Point(0, 0), new Point(1, 1));
            //borderMain.Background = gradientBrush;

            List<Meno> menot = new List<Meno>();
            menot.Add(new Meno() { Pv = new DateTime(2020, 7, 23), Nimi = "Semma", Summa = 10 });
            menot.Add(new Meno() { Pv = new DateTime(2020, 7, 30), Nimi = "Prisma", Summa = 58.45 });
            menot.Add(new Meno() { Pv = new DateTime(2020, 8, 3), Nimi = "Alko", Summa = 9.90 });

            dgMenot.ItemsSource = menot;

            AlustaTulot();
        }

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public class Meno
        {
            public DateTime Pv { get; set; }

            public string Nimi { get; set; }

            public double Summa { get; set; }
        }

        /*
        public class Tulo
        {
            public int Id { get; set; }

            public double Summa { get; set; }
        }*/

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

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

        private void MuokkaaTuloja(object sender, RoutedEventArgs e)
        {
            TuloIkkuna a = new TuloIkkuna();
            a.Show();
        }

        private void MuokkaaSaastoja(object sender, RoutedEventArgs e)
        {
            
        }

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public void AlustaTulot()
        {
            string euro = " €";

            Label[] tulotLb = { asumistukiLb, opintotukiLb, opintolainaLb, palkkaLb, muutLb, tulotYht };

            Tulo[] tt = t.GetTulot();

            for (int i = 0; i < t.Pituus(); i++)
            {
                tulotLb[i].Content = tt[i].GetSumma() + euro;
            }

            double yht = 0;

            foreach (Tulo element in tt)
            {
                yht += element.GetSumma();
            }

            tulotLb[5].Content = yht + euro;
        }

    }    
}
