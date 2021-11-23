using System;
using System.Collections.Generic;
using System.Text;
using CRUD.Controller;
using CRUD.Model;
using MySql.Data.MySqlClient;

namespace CRUD.Model {
    public class PessoaDao {

        public Resultado consultar(int codigo) {
            Resultado saida = new Resultado(false, "");
            try {
                Conexao conexao = new Conexao();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM pessoa WHERE codigo = @codigo", conexao.objConexao);
                comando.Parameters.AddWithValue("@codigo", codigo);
                MySqlDataReader dados = comando.ExecuteReader();
                if (dados.Read()) {
                    Pessoa p = new Pessoa();
                    p.codigo = dados.GetInt32("codigo");
                    p.nome = dados.GetString("nome");
                    p.endereco = dados.GetString("endereco");
                    p.bairro = dados.GetString("bairro");
                    p.cidade = dados.GetString("cidade");

                    saida = new Resultado(true, "Consulta realizada com sucesso.", p);
                } else {
                    saida = new Resultado(false, "Nenhum registro encontrado.");
                }
            } catch (Exception eConsultar) {
                saida = new Resultado(false, eConsultar.Message);
            }
            return saida;
        }

        public Resultado listar() {
            Resultado saida = new Resultado(false, "");
            try {
                Conexao conexao = new Conexao();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM pessoa", conexao.objConexao);
                MySqlDataReader dados = comando.ExecuteReader();
                List<Pessoa> listaSaida = new List<Pessoa>();
                while (dados.Read()) {
                    Pessoa p = new Pessoa();
                    p.codigo = dados.GetInt32("codigo");
                    p.nome = dados.GetString("nome");
                    p.endereco = dados.GetString("endereco");
                    p.bairro = dados.GetString("bairro");
                    p.cidade = dados.GetString("cidade");
                    listaSaida.Add(p);
                }
                saida = new Resultado(true, "Consulta realizada com sucesso.", listaSaida);
            } catch (Exception eListar) {
                saida = new Resultado(false, eListar.Message);
            }
            return saida;
        }

        public Resultado inserir(Pessoa p) {
            Resultado saida = new Resultado(false, "");
            try {
                Conexao conexao = new Conexao();
                MySqlCommand comando = new MySqlCommand("INSERT INTO pessoa(nome, endereco, bairro, cidade) VALUES(@nome, @endereco, @bairro, @cidade)", conexao.objConexao);
                comando.Parameters.AddWithValue("@nome", p.nome);
                comando.Parameters.AddWithValue("@endereco", p.endereco);
                comando.Parameters.AddWithValue("@bairro", p.bairro);
                comando.Parameters.AddWithValue("@cidade", p.cidade);
                if(comando.ExecuteNonQuery() > 0) {
                    saida = new Resultado(true, "Comando realizado com sucesso.");
                } else {
                    saida = new Resultado(true, "Comando realizado, porem nenhuma linha afetada.");
                }
            } catch(Exception eInserir) {
                saida = new Resultado(false, eInserir.Message);
            }
            return saida;
        }

        public Resultado alterar(Pessoa p) {
            Resultado saida = new Resultado(false, "");
            try {
                Conexao conexao = new Conexao();
                MySqlCommand comando = new MySqlCommand("UPDATE pessoa SET nome = @nome, endereco = @endereco, bairro = @bairro, cidade = @cidade WHERE codigo = @codigo", conexao.objConexao);
                comando.Parameters.AddWithValue("@nome", p.nome);
                comando.Parameters.AddWithValue("@endereco", p.endereco);
                comando.Parameters.AddWithValue("@bairro", p.bairro);
                comando.Parameters.AddWithValue("@cidade", p.cidade);
                comando.Parameters.AddWithValue("@codigo", p.codigo);
                if (comando.ExecuteNonQuery() > 0) {
                    saida = new Resultado(true, "Comando realizado com sucesso.");
                } else {
                    saida = new Resultado(true, "Comando realizado, porem nenhuma linha afetada.");
                }
            } catch (Exception eInserir) {
                saida = new Resultado(false, eInserir.Message);
            }
            return saida;
        }

        public Resultado deletar(Pessoa p) {
            Resultado saida = new Resultado(false, "");
            try {
                Conexao conexao = new Conexao();
                MySqlCommand comando = new MySqlCommand("DELETE FROM pessoa WHERE codigo = @codigo", conexao.objConexao);
                comando.Parameters.AddWithValue("@codigo", p.codigo);
                if (comando.ExecuteNonQuery() > 0) {
                    saida = new Resultado(true, "Comando realizado com sucesso.");
                } else {
                    saida = new Resultado(true, "Comando realizado, porem nenhuma linha afetada.");
                }
            } catch (Exception eInserir) {
                saida = new Resultado(false, eInserir.Message);
            }
            return saida;
        }


    }
}
