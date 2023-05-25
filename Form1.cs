using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            String db_env_variables = "server=localhost;database=mydb;uid=root";
            MySqlConnection db_connection = new MySqlConnection(db_env_variables);
            db_connection.Open();


            MySqlCommand cmd = new MySqlCommand("SELECT * FROM FUNCIONARIOS", db_connection);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                MessageBox.Show($"{reader["funcionario_id"]} : {reader["funcionario_nome"]} => login: {reader["funcionario_login"]}, senha: {reader["funcionario_senha"]}");
            };
        }

        private void login_button_entrar_Click(object sender, EventArgs e)
        {
            String login = login_input_usuario.Text;
            String senha   = login_input_senha.Text;

            String db_env_variables = "server=localhost;database=mydb;uid=root";
            MySqlConnection db_connection = new MySqlConnection(db_env_variables);
            db_connection.Open();

            String query_login = $"Select funcionario_senha from FUNCIONARIOS WHERE funcionario_login = {login}";

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM FUNCIONARIOS", db_connection);
            var reader = cmd.ExecuteReader();












            if (Login.logar(login, senha)) {
                login_label_resposta.Text = "Você entrou como" + login;
                Form_principal form_principal = new Form_principal();
                form_principal.ShowDialog();
                
            }
            else
            {
                login_label_resposta.Text = "senha incorreta!";
            }





        }

    }
}
