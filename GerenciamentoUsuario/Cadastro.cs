using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GerenciamentoUsuario
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            Usuario func = new Usuario();
            func.Nome = txbNomeCad.Text;
            func.Email = txbEmailCad.Text;
            func.Senha = EasyEncryption.SHA.ComputeSHA256Hash(txbSenhaCad.Text); 
            func.Data = txbDataCad.Text;



           var resultado = db.UsuarioDAO.cadastrar(func);

            if(resultado == true)
            {
                MessageBox.Show("Cadastrado com sucesso!");

                //Limpar os dados do formulario:
                txbNomeCad.Clear();
                txbEmailCad.Clear();
                txbSenhaCad.Clear();
                txbDataCad.Clear();

                //Retornar para tela inicial
                Form1 login = new Form1();
                this.Hide();
                login.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Verifique os campos!");
            }

            
        }
    }
}
