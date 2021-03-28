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
using System.Windows.Shapes;

namespace Budjetti
{
    /// <summary>
    /// Interaction logic for TuloIkkuna.xaml
    /// </summary>
    public partial class TuloIkkuna : Window
    {

        private MainWindow mw = (MainWindow)Application.Current.MainWindow;

        public TuloIkkuna()
        {
            
            InitializeComponent();

            Alusta();
        }

        public void SuljeIkkuna(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        public void LisaaTulot(object sender, RoutedEventArgs e)
        {
            TextBox[] tulotTxt = { asumistukiTxt, opintotukiTxt, opintolainaTxt, palkkaTxt, muutTxt };
            Label[] tulotLb = { mw.asumistukiLb, mw.opintotukiLb, mw.opintolainaLb, mw.palkkaLb, mw.muutLb, mw.tulotYht };
            string euro = " €";

            for (int i = 0; i < tulotTxt.Length; i++)
            {
                if (tulotTxt[i].Text != "")
                {
                    string s = tulotLb[i].Content.ToString();
                    int ind = s.IndexOf(" ");
                    double a =  + Convert.ToDouble(tulotTxt[i].Text);

                    tulotLb[i].Content = a + euro;
                }
                
            }

            double yht = 0;

            foreach(Label t in tulotLb)
            {
                yht += Convert.ToDouble(t.Content);
            }

            tulotLb[5].Content = yht + euro;

            this.Close();
        }

//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public void Alusta()
        {
            TextBox[] tulotTxt = { asumistukiTxt, opintotukiTxt, opintolainaTxt, palkkaTxt, muutTxt };
            Label[] tulotLb = { mw.asumistukiLb, mw.opintotukiLb, mw.opintolainaLb, mw.palkkaLb, mw.muutLb, mw.tulotYht };
        
        }

       
    }
}
