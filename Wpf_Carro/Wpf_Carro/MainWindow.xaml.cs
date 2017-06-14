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

namespace Wpf_Carro
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Cadastrar c = new Cadastrar();
            c.ShowDialog();
        }

        private void btnConsultar_Click(object sender, RoutedEventArgs e)
        {
            Consultar c = new Consultar();
            c.ShowDialog();
        }
        
        private void btnDados_Click(object sender, RoutedEventArgs e)
        {
            DadosSalvos ds = new DadosSalvos();
            ds.ShowDialog();
        }

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            Atualizar c = new Atualizar();
            c.ShowDialog();
        }
    }
}
