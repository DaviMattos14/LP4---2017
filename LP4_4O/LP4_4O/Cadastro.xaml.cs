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

namespace LP4_4O
{
    /// <summary>
    /// Interaction logic for Cadastro.xaml
    /// </summary>
    public partial class Cadastro : Window
    {
        public Cadastro()
        {
            InitializeComponent();

        }

        private void cb_Raca_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var  subracas = new List<string>();
            if (cb_Halfling.IsSelected)
            {

                subracas.Clear();
                subracas.Add("Pés-Leves");
                subracas.Add("Robusto");

                cb_Subraca.ItemsSource = subracas;
            }
            
            if (cb_Elfo.IsSelected) 
            {
                subracas.Clear();
                subracas.Add("Drow");
                subracas.Add("Elfo da floresta");
                subracas.Add("Alto Elfo");

                cb_Subraca.ItemsSource = subracas;
            }
            if (cb_Anao.IsSelected)
            {
                subracas.Clear();
                subracas.Add("Anão da Colina");
                subracas.Add("Anão da Montenha");

                cb_Subraca.ItemsSource = subracas;
            }
            if (cb_Gnomo.IsSelected)
            {
                subracas.Clear();
                subracas.Add("Gnomo da Floresta");
                subracas.Add("Gnomo das Rochas");

                cb_Subraca.ItemsSource = subracas;
            }
            
        }
    }
}
