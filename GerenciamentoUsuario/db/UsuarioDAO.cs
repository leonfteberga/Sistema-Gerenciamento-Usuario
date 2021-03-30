using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoUsuario.db
{
    class UsuarioDAO
    {


        public static DataTable listar()
        {
            Banco objBanco = new Banco();

            DataTable tabela = new DataTable();

            objBanco.Conectar();

            var cmd = objBanco.conexao.CreateCommand();

            cmd.CommandText = "SELECT * FROM Usuarios";

            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, objBanco.conexao);

            da.Fill(tabela);

            objBanco.Desconectar();

            return tabela;
        }

        public static bool cadastrar(Usuario usu)
        {
            // Instanciar e conectar ao banco:
            Banco banco = new Banco();
            try
            {

                banco.Conectar();
                // Criar o objeto SQLiteCommand:
                var cmd = banco.conexao.CreateCommand();
                // Definir qual comando DML (Insert - Delete - Update) será executado:
                cmd.CommandText = "INSERT INTO Usuarios (Nome, Email, Senha, Data) values (@nome, @Email, @senha, @data)";
                cmd.Parameters.AddWithValue("@nome", usu.Nome);
                cmd.Parameters.AddWithValue("@email", usu.Email);
                cmd.Parameters.AddWithValue("@senha", usu.Senha);
                cmd.Parameters.AddWithValue("@data", usu.Data);
                // Executar:
                cmd.ExecuteNonQuery();
                // Desconectar:
                banco.Desconectar();

                return true;



            }
            catch
            {

                banco.Desconectar();
                return false;


            }
        }

        public static DataTable buscarUsuario(int id)
        {
            // Definir o objeto de "tabela" que será preenchido com a consulta:
            DataTable tabela = new DataTable();
            // Instanciar e conectar ao banco:
            Banco bancod = new Banco();
            bancod.Conectar();
            // Criar o objeto SQLiteCommand:
            var cmd = bancod.conexao.CreateCommand();
            // Definir qual comando DQL será executado:
            cmd.CommandText = "SELECT * FROM Usuarios WHERE id = " + id;
            // Executar e "atribuir" o resultado em um objeto SQLiteDA
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, bancod.conexao);
            // Definir qual "tabela" será preenchida com o resultado da consulta:
            da.Fill(tabela);
            // Desconectar:
            bancod.Desconectar();
            return tabela;
        }

        public static bool excluir(int id)
        {
            // comandos para manipulação:
            // Instanciar e conectar ao banco:
            Banco bancod = new Banco();
            try
            {
                bancod.Conectar();
                // Criar o objeto SQLiteCommand:
                var cmd = bancod.conexao.CreateCommand();
                // Definir qual comando DML (Insert - Delete - Update) será executado:
                cmd.CommandText = "DELETE FROM Usuarios WHERE id = @id";
                // Definir a substituição dos parametros:
                cmd.Parameters.AddWithValue("@id", id);
                // Executar:
                cmd.ExecuteNonQuery();
                // Desconectar
                bancod.Desconectar();
                // Se chegou até aqui é pq deu certo!
                // Retornar true:
                return true;
            }
            catch
            {
                // Desconectar
                bancod.Desconectar();
                // Se chegou aqui é pq deu algum erro!
                // Retornar false:
                return false;
            }
        }

        public static bool editar(Usuario func, int id)
        {
            // comandos para manipulação:
            // Instanciar e conectar ao banco:
            Banco bancod = new Banco();
            try
            {
                bancod.Conectar();
                // Criar o objeto SQLiteCommand:
                var cmd = bancod.conexao.CreateCommand();
                // Definir qual comando DML (Insert - Delete - Update) será executado:
                cmd.CommandText = "UPDATE Usuarios SET Nome = @nome, Email = @email , Senha = @senha, Data = @data WHERE id = @id";
                // Definir a substituição dos parametros:
                cmd.Parameters.AddWithValue("@nome", func.Nome);
                cmd.Parameters.AddWithValue("@email", func.Email);
                cmd.Parameters.AddWithValue("@senha", func.Senha);
                cmd.Parameters.AddWithValue("@data", func.Data);
                cmd.Parameters.AddWithValue("@id", id);
                // Executar:
                cmd.ExecuteNonQuery();
                // Desconectar
                bancod.Desconectar();
                // Se chegou até aqui é pq deu certo!
                // Retornar true:
                return true;
            }
            catch
            {
                // Desconectar
                bancod.Desconectar();
                // Se chegou aqui é pq deu algum erro!
                // Retornar false:
                return false;
            }







        }

       







        }
    }

 