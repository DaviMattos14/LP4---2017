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
    /// Lógica interna para Atualizar.xaml
    /// </summary>
    public partial class Atualizar : Window
    {
        public Atualizar()
        {
            InitializeComponent();
            List<Carro> car = DadoSalvo();
            if (car.Count == 0)
                MessageBox.Show("Não há registros salvos!");
            else
            {
                dGtabela.ItemsSource = car;
                dGtabela.CanUserAddRows = false;
            }
        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand()
            {
                //Server = 127.0.0.1; Database = test; Uid = root; Pwd = root
                Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd="),
                CommandText = "UPDATE Carros SET Dono = @dono WHERE Placa = @placa"
            };

            cmd.Parameters.AddWithValue("@placa", txtPlaca.Text);
            cmd.Parameters.AddWithValue("@dono", txtDono.Text);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            List<Carro> car = DadoSalvo();
            if (car.Count == 0)
                MessageBox.Show("Não há registros salvos!");
            else
            {
                dGtabela.ItemsSource = car;
                dGtabela.CanUserAddRows = false;
            }
            Limpar();
            MessageBox.Show("Atualizado com Sucesso");

        }


        private static List<Carro> DadoSalvo()
        {
            List<Carro> car = new List<Carro>();
            MySqlCommand cmd = new MySqlCommand()
            {
                //Connection = new MySqlConnection("Server=127.0.0.1;Database=test;Uid=root;Pwd=root"),
                Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd="),
                CommandText = "SELECT * FROM Carros"
            };

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

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnDeletar_Click(object sender, RoutedEventArgs e)
        {
            if(txtPlaca.Text != "" && txtDono.Text == "")
            {
                MySqlCommand cmd = new MySqlCommand()
                {
                    //Server = 127.0.0.1; Database = test; Uid = root; Pwd = root
                    Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd="),
                    CommandText = "DELETE FROM Carros WHERE Placa = @placa"
                };

                cmd.Parameters.AddWithValue("@placa", txtPlaca.Text);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                List<Carro> car = DadoSalvo();
                if (car.Count == 0)
                    MessageBox.Show("Não há registros salvos!");
                else
                {
                    dGtabela.ItemsSource = car;
                    dGtabela.CanUserAddRows = false;
                }
            }
            else if (txtDono.Text != "" && txtPlaca.Text == "")
            {
                MySqlCommand cmd = new MySqlCommand()
                {
                    //Server = 127.0.0.1; Database = test; Uid = root; Pwd = root
                    Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd="),
                    CommandText = "DELETE FROM Carros WHERE Dono = @dono"
                };

                cmd.Parameters.AddWithValue("@dono", txtDono.Text);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                List<Carro> car = DadoSalvo();
                if (car.Count == 0)
                    MessageBox.Show("Não há registros salvos!");
                else
                {
                    dGtabela.ItemsSource = car;
                    dGtabela.CanUserAddRows = false;
                }
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand()
                {
                    //Server = 127.0.0.1; Database = test; Uid = root; Pwd = root
                    Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd="),
                    CommandText = "DELETE FROM Carros WHERE Dono = @dono AND Placa = @placa"
                };

                cmd.Parameters.AddWithValue("@dono", txtDono.Text);
                cmd.Parameters.AddWithValue("@placa", txtPlaca.Text);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                List<Carro> car = DadoSalvo();
                if (car.Count == 0)
                    MessageBox.Show("Não há registros salvos!");
                else
                {
                    dGtabela.ItemsSource = car;
                    dGtabela.CanUserAddRows = false;
                }
            }
            Limpar();
            MessageBox.Show("Deletado com sucesso!");
        }

        private void Limpar()
        {
            txtDono.Clear();
            txtPlaca.Clear();
        }
    }
}
