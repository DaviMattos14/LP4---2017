using MySql.Data.MySqlClient;
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

namespace Wpf_Carro
{
    /// <summary>
    /// Lógica interna para Cadastrar.xaml
    /// </summary>
    public partial class Cadastrar : Window
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            CadastrarCarro();
            Limpar();
            MessageBox.Show("Carro Cadastrado com Sucesso!");
        }

        private void CadastrarCarro()
        {
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd="),
                //Connection = new MySqlConnection("Server=127.0.0.1;Database=test;Uid=root;Pwd=root"),
                CommandText = "INSERT INTO Carros(Dono, Placa, Modelo, Ano) VALUES (@dono, @placa, @modelo, @ano)"
            };
            cmd.Parameters.AddWithValue("@dono", txtDono.Text);
            cmd.Parameters.AddWithValue("@placa", txtPlaca.Text);
            cmd.Parameters.AddWithValue("@modelo", txtModelo.Text);
            cmd.Parameters.AddWithValue("@ano", txtAno.Text);
            
            

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        private void Limpar()
        {
            txtModelo.Clear();
            txtAno.Clear();
            txtDono.Clear();
            txtPlaca.Clear();
        }
    }
}
