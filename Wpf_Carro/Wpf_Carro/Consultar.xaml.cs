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
    /// Lógica interna para Consultar.xaml
    /// </summary>
    public partial class Consultar : Window
    {
        public Consultar()
        {
            InitializeComponent();
            //cbConsulta.Items.Add("Nome");
            cbConsulta.Items.Add("Placa");

        }

        //List<Carro> ConsultaNome(string nome)
        //{
        //    List<Carro> car = new List<Carro>();
        //    MySqlCommand cmd = new MySqlCommand()
        //    {
        //        Connection = new MySqlConnection("Server=127.0.0.1;Database=test;Uid=root;Pwd=root"),
        //        CommandText = "SELECT * FROM Carros WHERE Nome = @nome"
        //    };

        //    cmd.Parameters.AddWithValue("@nome", nome);

        //    cmd.Connection.Open();
        //    MySqlDataReader result = cmd.ExecuteReader();
        //    if (result.HasRows)
        //    {
        //        while (result.Read())
        //        {
        //            Carro c = new Carro();
        //            c.Id = result.GetInt32(0);
                    //c.Dono = result.GetString(1);
                    //c.Placa = result.GetString(2);
                    //c.Modelo = result.GetString(3);
                    //c.Ano = result.GetInt32(4);
        //            car.Add(c);
        //        }
        //    }

        //    cmd.Connection.Close();

        //    return car;
        //}

        List<Carro> ConsultaPlaca(string placa)
        {
            List<Carro> car = new List<Carro>();
            MySqlCommand cmd = new MySqlCommand()
            {
                //Connection = new MySqlConnection("Server=127.0.0.1;Database=test;Uid=root;Pwd=root"),
                Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd="),
                CommandText = "SELECT * FROM Carros WHERE Placa = @placa"
            };

            cmd.Parameters.AddWithValue("@placa", txtConsulta.Text);

            cmd.Connection.Open();
            MySqlDataReader result = cmd.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    Carro c = new Carro();
                    c.Id = result.GetInt32(0);
                    c.Dono = result.GetString(1);
                    c.Placa = result.GetString(2);
                    c.Modelo = result.GetString(3);
                    c.Ano = result.GetInt32(4);
                    car.Add(c);
                }
            }

            cmd.Connection.Close();

            return car;
        }

        private void btnConsultar_Click(object sender, RoutedEventArgs e)
        {
            //if(cbConsulta.Text == "Nome")
            //{
            //    List<Carro> car = ConsultaNome(txtConsulta.Text);
            //    if (car.Count == 0)
            //        MessageBox.Show("Esse nome não se encontra no nosso registro.");
            //    else
            //        dataTabela.ItemsSource = car;
            //    txtConsulta.Clear();
            //}
            if (cbConsulta.Text == "Placa")
            {
                List<Carro> car = ConsultaPlaca(txtConsulta.Text);
                if (car.Count == 0)
                    MessageBox.Show("Essa Placa não se encontra em nosso registro.");
                else
                {
                    dataTabela.ItemsSource = car;
                    dataTabela.CanUserAddRows = false;
                }
                    
                txtConsulta.Clear();
            }
            else MessageBox.Show("Selecione o tipo de Busca!");

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
