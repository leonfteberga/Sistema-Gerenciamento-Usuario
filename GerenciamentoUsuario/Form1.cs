using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GerenciamentoUsuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txbLinkCad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // Instanciar a 'classe da janela' WinFuncCadastrar:
            Cadastro janelaCadastrar = new Cadastro();
            //esconder a janela atual:
            this.Hide();
            // Mostrar a janela:
            janelaCadastrar.ShowDialog();
            // reexibir a janela principal:
            this.Show();
        }


        private void btnLog_Click(object sender, EventArgs e)
        {

            // Instanciar e conectar ao banco:
            db.Banco bancod = new db.Banco();
            bancod.Conectar();
            // Criar o objeto SQLiteCommand:
            var cmd = bancod.conexao.CreateCommand();
            // Definir qual comando DQL será executado:
            cmd.CommandText = "SELECT * FROM Usuarios WHERE Email = '" + txbEmailLog.Text + "' AND Senha = '" +  EasyEncryption.SHA.ComputeSHA256Hash(txbSenhaLog.Text); +"'";
            SQLiteDataAdapter dp = new SQLiteDataAdapter(cmd.CommandText, bancod.conexao);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            if(dt.Rows.Count == 1)
            {
                // Instanciar a 'classe da janela' WinFuncCadastrar:
                ControleDeUsuarios janelaGerenciamento = new ControleDeUsuarios();
                //esconder a janela atual:
                this.Hide();
                // Mostrar a janela:
                janelaGerenciamento.ShowDialog();
                // reexibir a janela principal:
                this.Show();

            }
            else
            {
                MessageBox.Show("Erro");
            }

           



        }
    }

}
