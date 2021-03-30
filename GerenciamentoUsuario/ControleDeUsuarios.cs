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
    public partial class ControleDeUsuarios : Form
    {
        // Variáveis globais: 
        int idUsuario = 0;
        
        public ControleDeUsuarios()
        {
            InitializeComponent();
        }

        public void atualizardados()
        {


            dgvUsuarios.DataSource = db.UsuarioDAO.listar();

        }
        private void ControleDeUsuarios_Load(object sender, EventArgs e)
        {
            atualizardados();

        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            // Garantir que a pessoa selecionou alguma linha:
            var dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                // Declarar um DataTable para obter a resposta de um consulta:
                DataTable dt = new DataTable();
                // Obter o id do usuário selecionado:
                idUsuario = int.Parse(dgv.SelectedRows[0].Cells[0].Value.ToString());
                // Buscar o usuário com base no ID:
                // Obter o resultado da consulta no nosso datatable local:
                dt = db.UsuarioDAO.buscarUsuario(idUsuario);
                // obter linha 0:
                var linha = dt.Rows[0];
                // Preencher os campos do editar:
                txbNomeEdit.Text = linha.Field<string>("Nome").ToString();
                txbEmailEdit.Text = linha.Field<string>("Email").ToString();
                txbSenhaEdit.Text = linha.Field<string>("Senha").ToString();
                txbDataEdit.Text = linha.Field<string>("Data").ToString();


            }

            }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
                // Instanciar o objeto Funcionario:
                Usuario usu = new Usuario();
                // Inserir os dados dos campos nos atributos do obj:
               usu.Nome = txbNomeEdit.Text;
                usu.Email = txbEmailEdit.Text;
                usu.Data = txbDataEdit.Text;
                usu.Senha = txbSenhaEdit.Text;
                // Sabemos que o ID a editar está no iUsuario global!
                // Chamamos nosso método de editar os dados, passando nosso obj e o id do funcionario selecionado
                var resultado = db.UsuarioDAO.editar(usu, idUsuario);
                // Deu certo?
                if (resultado == true)
                {
                    MessageBox.Show("Informações modificadas!");
                    txbNomeEdit.Clear();
                    txbDataEdit.Clear();
                    txbEmailEdit.Clear();
                    txbSenhaEdit.Clear();
                    atualizardados();                 
                }
                // Deu errado?
                else
                {
                    MessageBox.Show("Erro! Verifique os dados informados!");
                }
            
           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
                // chamar o método excluir do DAO já dentro do IF:
                if (db.UsuarioDAO.excluir(idUsuario))
                {
                    // Deu certo?
                    MessageBox.Show("Usuário excluído!");
                    txbNomeEdit.Clear();
                    txbDataEdit.Clear();
                    txbEmailEdit.Clear();                
                    txbSenhaEdit.Clear();
                    atualizardados();
                }
                // Deu errado?
                else
                {
                    MessageBox.Show("Erro! Verifique os dados informados!");
                }
            
          
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}



