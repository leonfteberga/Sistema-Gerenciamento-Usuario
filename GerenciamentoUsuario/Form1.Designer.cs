
namespace GerenciamentoUsuario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbEmail = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbEmailLog = new System.Windows.Forms.TextBox();
            this.txbSenhaLog = new System.Windows.Forms.TextBox();
            this.txbLinkCad = new System.Windows.Forms.LinkLabel();
            this.btnLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbEmail
            // 
            this.txbEmail.AutoSize = true;
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(24, 101);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(56, 16);
            this.txbEmail.TabIndex = 0;
            this.txbEmail.Text = "E-mail:";
            // 
            // txbSenha
            // 
            this.txbSenha.AutoSize = true;
            this.txbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenha.Location = new System.Drawing.Point(24, 145);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(56, 16);
            this.txbSenha.TabIndex = 1;
            this.txbSenha.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbEmailLog
            // 
            this.txbEmailLog.Location = new System.Drawing.Point(86, 97);
            this.txbEmailLog.Name = "txbEmailLog";
            this.txbEmailLog.Size = new System.Drawing.Size(167, 20);
            this.txbEmailLog.TabIndex = 3;
            // 
            // txbSenhaLog
            // 
            this.txbSenhaLog.Location = new System.Drawing.Point(86, 141);
            this.txbSenhaLog.Name = "txbSenhaLog";
            this.txbSenhaLog.Size = new System.Drawing.Size(167, 20);
            this.txbSenhaLog.TabIndex = 4;
            this.txbSenhaLog.UseSystemPasswordChar = true;
            // 
            // txbLinkCad
            // 
            this.txbLinkCad.AutoSize = true;
            this.txbLinkCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLinkCad.Location = new System.Drawing.Point(24, 184);
            this.txbLinkCad.Name = "txbLinkCad";
            this.txbLinkCad.Size = new System.Drawing.Size(78, 13);
            this.txbLinkCad.TabIndex = 5;
            this.txbLinkCad.TabStop = true;
            this.txbLinkCad.Text = "Cadastre-se!\r\n";
            this.txbLinkCad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txbLinkCad_LinkClicked);
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLog.Location = new System.Drawing.Point(123, 205);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(81, 31);
            this.btnLog.TabIndex = 6;
            this.btnLog.Text = "LOGIN";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(314, 289);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.txbLinkCad);
            this.Controls.Add(this.txbSenhaLog);
            this.Controls.Add(this.txbEmailLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbEmail);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txbEmail;
        private System.Windows.Forms.Label txbSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbEmailLog;
        private System.Windows.Forms.TextBox txbSenhaLog;
        private System.Windows.Forms.LinkLabel txbLinkCad;
        private System.Windows.Forms.Button btnLog;
    }
}

