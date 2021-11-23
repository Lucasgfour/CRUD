using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using CRUD.Controller;
using MySql.Data.MySqlClient;

namespace CRUD.Model {
    public class Conexao {
        public MySqlConnection objConexao { get; private set; }

        public Conexao() {
            Resultado resConexao = abrirConexao("localhost", "crud", "root", "lucasg4");
            if (!resConexao.condicao) {
                MessageBox.Show("Não foi possível abrir a conexão, detalhes : " + resConexao.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public Resultado abrirConexao(String servidor, String banco, String usuario, String senha) {
            Resultado saida = new Resultado(false, "");
            try {
                MySqlConnectionStringBuilder abrirConexao = new MySqlConnectionStringBuilder() {
                    Server = servidor,
                    Database = banco,
                    UserID = usuario,
                    Password = senha
                };
                objConexao = new MySqlConnection(abrirConexao.ConnectionString);
                objConexao.Open();
                saida = new Resultado(true, "Conexão aberta com sucesso !");
            } catch(Exception eConexao) {
                saida = new Resultado(false, eConexao.Message);
            }
            return saida;
        }

        public void fecharConexao() {
            try { objConexao.Close(); } catch(Exception) { }
        }

    }
}
