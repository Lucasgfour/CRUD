using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaterialSkin.Controls;
using CRUD.Controller;
using CRUD.Model;

namespace CRUD.View {
    public partial class CDPessoa : MaterialForm {
        public Pessoa pessoa = new Pessoa();
        public CDPessoa() {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager.Instance.AddFormToManage(this);
        }
        public CDPessoa(Pessoa pessoa) {
            this.pessoa = pessoa;
            InitializeComponent();
            MaterialSkin.MaterialSkinManager.Instance.AddFormToManage(this);
        }

        private void CDPessoa_Load(object sender, EventArgs e) {
            if(pessoa.codigo > 0) {
                txtNome.Text = pessoa.nome;
                txtEndereco.Text = pessoa.endereco;
                txtBairro.Text = pessoa.bairro;
                txtCidade.Text = pessoa.cidade;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            if(txtNome.Text.Equals("") || txtEndereco.Text.Equals("") || txtBairro.Text.Equals("") || txtCidade.Text.Equals("")) {
                MessageBox.Show("Favor conferir os dados, formato inválido.", "Campo em branco", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                pessoa.nome = txtNome.Text;
                pessoa.endereco = txtEndereco.Text;
                pessoa.bairro = txtBairro.Text;
                pessoa.cidade = txtCidade.Text;

                Resultado resultado = new Resultado(false, "");
                PessoaDao pessoaDao = new PessoaDao();
                if(pessoa.codigo > 0) {
                    resultado = pessoaDao.alterar(pessoa);
                } else {
                    resultado = pessoaDao.inserir(pessoa);
                }
                
                MessageBox.Show(resultado.mensagem, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if(resultado.condicao) {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
