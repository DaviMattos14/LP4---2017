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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace aula_dia_180517
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

        private void Cadastrar()
        {
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd="),
                CommandText = "INSERT INTO Pessoa(Nome,Idade) VALUES (@nome, @idade)"
            };

            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@idade", txtIdade.Text);

            string pessoa = "Nome: " + txtNome + "Idade: " + txtIdade;

            txtLista.Items.Add(pessoa);


            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
        //private void CarregarLista()
        //{
        //    MySqlCommand cmd = new MySqlCommand()
        //    {
        //        Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd="),
        //        CommandText = "SLECT Nome, Idade FROM PESSOA"
        //    };

        //    cmd.Connection.Open();

        //    MySqlDataReader result = cmd.ExecuteReader();

        //    if (result.HasRows)
        //    {
        //        while (result.Read())
        //        {
        //            string nome = result.GetString(0);
        //            int idade = result.GetInt32(1);
        //            txtLista.Items.Add(nome);
        //            txtLista.Items.Add(idade);
        //        }
        //    }

        //    cmd.Connection.Close();
        //}

        private void btCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Cadastrar();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //CarregarLista();
        }

        private void btClear_Click(object sender, RoutedEventArgs e)
        {
            txtNome.Clear();
            txtIdade.Clear();
        }

        
    }
}
