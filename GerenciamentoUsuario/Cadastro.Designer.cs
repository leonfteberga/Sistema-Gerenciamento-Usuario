
namespace GerenciamentoUsuario
{
    partial class Cadastro
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
            this.txbNome = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.Label();
            this.txbData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNomeCad = new System.Windows.Forms.TextBox();
            this.txbEmailCad = new System.Windows.Forms.TextBox();
            this.txbSenhaCad = new System.Windows.Forms.TextBox();
            this.btnCad = new System.Windows.Forms.Button();
            this.txbDataCad = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txbNome
            // 
            this.txbNome.AutoSize = true;
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(60, 101);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(53, 16);
            this.txbNome.TabIndex = 0;
            this.txbNome.Text = "Nome:";
            // 
            // txbEmail
            // 
            this.txbEmail.AutoSize = true;
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(60, 141);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(51, 16);
            this.txbEmail.TabIndex = 1;
            this.txbEmail.Text = "Email:";
            // 
            // txbSenha
            // 
            this.txbSenha.AutoSize = true;
            this.txbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenha.Location = new System.Drawing.Point(60, 177);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(56, 16);
            this.txbSenha.TabIndex = 2;
            this.txbSenha.Text = "Senha:";
            // 
            // txbData
            // 
            this.txbData.AutoSize = true;
            this.txbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbData.Location = new System.Drawing.Point(60, 219);
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(85, 16);
            this.txbData.TabIndex = 3;
            this.txbData.Text = "Data Nasc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "CADASTRO";
            // 
            // txbNomeCad
            // 
            this.txbNomeCad.Location = new System.Drawing.Point(121, 101);
            this.txbNomeCad.Name = "txbNomeCad";
            this.txbNomeCad.Size = new System.Drawing.Size(183, 20);
            this.txbNomeCad.TabIndex = 5;
            // 
            // txbEmailCad
            // 
            this.txbEmailCad.Location = new System.Drawing.Point(121, 137);
            this.txbEmailCad.Name = "txbEmailCad";
            this.txbEmailCad.Size = new System.Drawing.Size(183, 20);
            this.txbEmailCad.TabIndex = 6;
            // 
            // txbSenhaCad
            // 
            this.txbSenhaCad.Location = new System.Drawing.Point(126, 176);
            this.txbSenhaCad.Name = "txbSenhaCad";
            this.txbSenhaCad.Size = new System.Drawing.Size(178, 20);
            this.txbSenhaCad.TabIndex = 7;
            // 
            // btnCad
            // 
            this.btnCad.BackColor = System.Drawing.Color.White;
            this.btnCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCad.ForeColor = System.Drawing.Color.Green;
            this.btnCad.Location = new System.Drawing.Point(144, 269);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(118, 37);
            this.btnCad.TabIndex = 9;
            this.btnCad.Text = "CADASTRAR";
            this.btnCad.UseVisualStyleBackColor = false;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // txbDataCad
            // 
            this.txbDataCad.Location = new System.Drawing.Point(152, 214);
            this.txbDataCad.Mask = "00/00/0000";
            this.txbDataCad.Name = "txbDataCad";
            this.txbDataCad.Size = new System.Drawing.Size(81, 20);
            this.txbDataCad.TabIndex = 10;
            this.txbDataCad.ValidatingType = typeof(System.DateTime);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(376, 336);
            this.Controls.Add(this.txbDataCad);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.txbSenhaCad);
            this.Controls.Add(this.txbEmailCad);
            this.Controls.Add(this.txbNomeCad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbData);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbNome);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txbNome;
        private System.Windows.Forms.Label txbEmail;
        private System.Windows.Forms.Label txbSenha;
        private System.Windows.Forms.Label txbData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNomeCad;
        private System.Windows.Forms.TextBox txbEmailCad;
        private System.Windows.Forms.TextBox txbSenhaCad;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.MaskedTextBox txbDataCad;
    }
}