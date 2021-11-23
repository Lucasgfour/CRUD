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
using System.Linq;

namespace CRUD.View {
    public partial class CSPessoa : MaterialForm {

        private List<Pessoa> dados;

        public CSPessoa() {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager.Instance.AddFormToManage(this);
        }

        private void CSPessoa_Load(object sender, EventArgs e) {
            atualizar();
        }

        public void atualizar() {
            listaDados.Items.Clear();
            PessoaDao pDao = new PessoaDao();
            Resultado resConsulta = pDao.listar();
            if(resConsulta.condicao) {
                dados = (List<Pessoa>)resConsulta.resultado;
                foreach(Pessoa p in dados) {
                    ListViewItem itm = new ListViewItem();
                    itm.Text = p.codigo.ToString();
                    itm.SubItems.Add(p.nome);
                    itm.SubItems.Add(p.endereco);
                    itm.SubItems.Add(p.bairro);
                    itm.SubItems.Add(p.cidade);
                    listaDados.Items.Add(itm);
                }
            } else {
                MessageBox.Show(resConsulta.mensagem);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            CDPessoa cadastro = new CDPessoa();
            if(cadastro.ShowDialog() == DialogResult.OK) {
                atualizar();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            if(listaDados.FocusedItem.Index > -1) {
                Pessoa p = dados.ElementAt(listaDados.FocusedItem.Index);
                CDPessoa alterar = new CDPessoa(p);
                if(alterar.ShowDialog() == DialogResult.OK) {
                    atualizar();
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e) {
            if(listaDados.FocusedItem.Index > -1) {
                if(MessageBox.Show("Tem certeza que deseja deletar o registro selecionado ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    Pessoa p = dados.ElementAt(listaDados.FocusedItem.Index);
                    PessoaDao pDao = new PessoaDao();
                    Resultado resDelete = pDao.deletar(p);
                    MessageBox.Show(resDelete.mensagem, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(resDelete.condicao) {
                        atualizar();
                    }
                }
            }
        }
    }
}
