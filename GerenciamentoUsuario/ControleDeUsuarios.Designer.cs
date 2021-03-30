
namespace GerenciamentoUsuario
{
    partial class ControleDeUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpxEditar = new System.Windows.Forms.GroupBox();
            this.txbSenhaEdit = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbEmailEdit = new System.Windows.Forms.TextBox();
            this.txbNomeEdit = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txbDataEdit = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpxEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gpxEditar
            // 
            this.gpxEditar.Controls.Add(this.txbSenhaEdit);
            this.gpxEditar.Controls.Add(this.lblSenha);
            this.gpxEditar.Controls.Add(this.btnExcluir);
            this.gpxEditar.Controls.Add(this.btnEditar);
            this.gpxEditar.Controls.Add(this.txbEmailEdit);
            this.gpxEditar.Controls.Add(this.txbNomeEdit);
            this.gpxEditar.Controls.Add(this.lblData);
            this.gpxEditar.Controls.Add(this.txbDataEdit);
            this.gpxEditar.Controls.Add(this.lblEmail);
            this.gpxEditar.Controls.Add(this.lblNome);
            this.gpxEditar.Location = new System.Drawing.Point(70, 225);
            this.gpxEditar.Name = "gpxEditar";
            this.gpxEditar.Size = new System.Drawing.Size(327, 203);
            this.gpxEditar.TabIndex = 7;
            this.gpxEditar.TabStop = false;
            this.gpxEditar.Text = "Editar";
            // 
            // txbSenhaEdit
            // 
            this.txbSenhaEdit.Location = new System.Drawing.Point(117, 60);
            this.txbSenhaEdit.Name = "txbSenhaEdit";
            this.txbSenhaEdit.Size = new System.Drawing.Size(194, 20);
            this.txbSenhaEdit.TabIndex = 24;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(10, 60);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(56, 16);
            this.lblSenha.TabIndex = 23;
            this.lblSenha.Text = "Senha:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(13, 161);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(109, 36);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Blue;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(128, 161);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(183, 36);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txbEmailEdit
            // 
            this.txbEmailEdit.Location = new System.Drawing.Point(117, 96);
            this.txbEmailEdit.Name = "txbEmailEdit";
            this.txbEmailEdit.Size = new System.Drawing.Size(194, 20);
            this.txbEmailEdit.TabIndex = 18;
            // 
            // txbNomeEdit
            // 
            this.txbNomeEdit.BackColor = System.Drawing.Color.MintCream;
            this.txbNomeEdit.Location = new System.Drawing.Point(117, 25);
            this.txbNomeEdit.Name = "txbNomeEdit";
            this.txbNomeEdit.Size = new System.Drawing.Size(194, 20);
            this.txbNomeEdit.TabIndex = 17;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(12, 132);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(85, 16);
            this.lblData.TabIndex = 14;
            this.lblData.Text = "Data Nasc:";
            // 
            // txbDataEdit
            // 
            this.txbDataEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDataEdit.Location = new System.Drawing.Point(117, 126);
            this.txbDataEdit.Mask = "00/00/0000";
            this.txbDataEdit.Name = "txbDataEdit";
            this.txbDataEdit.Size = new System.Drawing.Size(91, 22);
            this.txbDataEdit.TabIndex = 13;
            this.txbDataEdit.ValidatingType = typeof(System.DateTime);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 100);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 16);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(10, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 16);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome:";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(61, 12);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(661, 191);
            this.dgvUsuarios.TabIndex = 5;
            this.dgvUsuarios.SelectionChanged += new System.EventHandler(this.dgvUsuarios_SelectionChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(204, -27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(213, 25);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Funcionários :: Listar";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(612, 395);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 33);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // ControleDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(788, 457);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.gpxEditar);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ControleDeUsuarios";
            this.Text = "ControleDeUsuarios";
            this.Load += new System.EventHandler(this.ControleDeUsuarios_Load);
            this.gpxEditar.ResumeLayout(false);
            this.gpxEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpxEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbEmailEdit;
        private System.Windows.Forms.TextBox txbNomeEdit;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.MaskedTextBox txbDataEdit;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txbSenhaEdit;
        private System.Windows.Forms.Label lblSenha;
    }
}