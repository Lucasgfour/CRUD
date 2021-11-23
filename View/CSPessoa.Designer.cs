
namespace CRUD.View {
    partial class CSPessoa {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.listaDados = new System.Windows.Forms.ListView();
            this.Col01 = new System.Windows.Forms.ColumnHeader();
            this.Col02 = new System.Windows.Forms.ColumnHeader();
            this.Col03 = new System.Windows.Forms.ColumnHeader();
            this.Col04 = new System.Windows.Forms.ColumnHeader();
            this.Col05 = new System.Windows.Forms.ColumnHeader();
            this.btnAdicionar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRemover = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // listaDados
            // 
            this.listaDados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col01,
            this.Col02,
            this.Col03,
            this.Col04,
            this.Col05});
            this.listaDados.FullRowSelect = true;
            this.listaDados.GridLines = true;
            this.listaDados.HideSelection = false;
            this.listaDados.Location = new System.Drawing.Point(12, 110);
            this.listaDados.MultiSelect = false;
            this.listaDados.Name = "listaDados";
            this.listaDados.Size = new System.Drawing.Size(882, 405);
            this.listaDados.TabIndex = 0;
            this.listaDados.UseCompatibleStateImageBehavior = false;
            this.listaDados.View = System.Windows.Forms.View.Details;
            // 
            // Col01
            // 
            this.Col01.Text = "Código";
            this.Col01.Width = 70;
            // 
            // Col02
            // 
            this.Col02.Text = "Nome";
            this.Col02.Width = 250;
            // 
            // Col03
            // 
            this.Col03.Text = "Endereço";
            this.Col03.Width = 200;
            // 
            // Col04
            // 
            this.Col04.Text = "Bairro";
            this.Col04.Width = 100;
            // 
            // Col05
            // 
            this.Col05.Text = "Cidade";
            this.Col05.Width = 200;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Depth = 0;
            this.btnAdicionar.Location = new System.Drawing.Point(12, 75);
            this.btnAdicionar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Primary = true;
            this.btnAdicionar.Size = new System.Drawing.Size(151, 29);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Depth = 0;
            this.btnEditar.Location = new System.Drawing.Point(169, 75);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Primary = true;
            this.btnEditar.Size = new System.Drawing.Size(151, 29);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Depth = 0;
            this.btnRemover.Location = new System.Drawing.Point(326, 75);
            this.btnRemover.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Primary = true;
            this.btnRemover.Size = new System.Drawing.Size(151, 29);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // CSPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 527);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.listaDados);
            this.MaximizeBox = false;
            this.Name = "CSPessoa";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Pessoas";
            this.Load += new System.EventHandler(this.CSPessoa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaDados;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdicionar;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditar;
        private MaterialSkin.Controls.MaterialRaisedButton btnRemover;
        private System.Windows.Forms.ColumnHeader Col01;
        private System.Windows.Forms.ColumnHeader Col02;
        private System.Windows.Forms.ColumnHeader Col03;
        private System.Windows.Forms.ColumnHeader Col04;
        private System.Windows.Forms.ColumnHeader Col05;
    }
}