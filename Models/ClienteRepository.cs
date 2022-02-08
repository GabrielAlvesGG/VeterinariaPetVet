using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySqlConnector;

namespace petVet.Models
{
    public class ClienteRepository
    {
        private const string conectaDados = "DataBase=petVet;Data Source=localhost;User Id=root";

        public void TestaCliente()
        {
            MySqlConnection conexao = new MySqlConnection(conectaDados);
            conexao.Open();
            Console.WriteLine("Funcionou Cliente");
            conexao.Close();
        }
        public void Inserir(Cliente cliente)
        {
            MySqlConnection conexao = new MySqlConnection(conectaDados);
            conexao.Open();
            string query = "INSERT INTO cliente (nome, dataNascimento, login, senha) VALUES (@nome, @dataNascimento, @login, @senha)";
            MySqlCommand comando = new MySqlCommand(query,conexao);
            
            comando.Parameters.AddWithValue("@nome", cliente.nome);
            comando.Parameters.AddWithValue("@dataNascimento", cliente.dataNascimento);
            comando.Parameters.AddWithValue("@login", cliente.login);
            comando.Parameters.AddWithValue("@senha", cliente.senha);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public List<Cliente> ListaClientes(Cliente cliente)
        {
            MySqlConnection conexao = new MySqlConnection(conectaDados);
            conexao.Open();

            string query = "SELECT * FROM cliente";
            MySqlCommand comando = new MySqlCommand(query,conexao);
            
            MySqlDataReader reader = comando.ExecuteReader();

            List<Cliente> lista = new List<Cliente>();

            while(reader.Read())
            {
                Cliente clienteEncontrado = new Cliente();

                clienteEncontrado.id = reader.GetInt32("id");
                
                if(!reader.IsDBNull(reader.GetOrdinal("nome")))
                clienteEncontrado.nome = reader.GetString("nome");

                clienteEncontrado.dataNascimento = reader.GetDateTime("dataNascimento");

                if(!reader.IsDBNull(reader.GetOrdinal("login")))
                clienteEncontrado.login = reader.GetString("login");

                if(!reader.IsDBNull(reader.GetOrdinal("senha")))
                clienteEncontrado.senha = reader.GetString("senha");

                lista.Add(clienteEncontrado);
            }
            conexao.Close();
            return lista;
        }
        public void Excluir (Cliente cliente)
        {
            MySqlConnection conexao = new MySqlConnection(conectaDados);
            conexao.Open();

            string query ="DELETE FROM cliente WHERE id=@id";

            MySqlCommand comando = new MySqlCommand(query,conexao);
            comando.Parameters.AddWithValue("@id", cliente.id);
            comando.ExecuteReader();
            conexao.Close();
        }
        public void Atualizar(Cliente cliente)
        {
            MySqlConnection conexao = new MySqlConnection(conectaDados);
            conexao.Open();

            string query = "UPDATE cliente SET nome=@nome, dataNascimento=@dataNascimento, login=@login, senha=@senha WHERE id=@id";
            MySqlCommand comando = new MySqlCommand(query,conexao);

            comando.Parameters.AddWithValue("@id", cliente.id);
            comando.Parameters.AddWithValue("@nome", cliente.nome);
            comando.Parameters.AddWithValue("@dataNascimento", cliente.dataNascimento);
            comando.Parameters.AddWithValue("@login", cliente.login);
            comando.Parameters.AddWithValue("@senha", cliente.senha);
            
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public Cliente BuscarId(int id)
        {
            MySqlConnection conexao = new MySqlConnection(conectaDados);
            conexao.Open();

            string query = "SELECT * FROM cliente WHERE id=@id";

            MySqlCommand comando =new MySqlCommand(query,conexao);
            comando.Parameters.AddWithValue("@id", id);

            MySqlDataReader reader = comando.ExecuteReader();

            Cliente clienteEncontrado = new Cliente();

            if(reader.Read())
            {
                clienteEncontrado.id = reader.GetInt32("id");

                if(!reader.IsDBNull(reader.GetOrdinal("nome")))
                clienteEncontrado.nome = reader.GetString("nome");

                clienteEncontrado.dataNascimento = reader.GetDateTime("dataNascimento");
                
                if(!reader.IsDBNull(reader.GetOrdinal("login")))
                clienteEncontrado.login = reader.GetString("login");

                if(!reader.IsDBNull(reader.GetOrdinal("senha")))
                clienteEncontrado.senha = reader.GetString("senha");
            }
            conexao.Close();
            return clienteEncontrado;
        }
        public Cliente ValidarCliente(Cliente cliente)
        {
            MySqlConnection conexao = new MySqlConnection(conectaDados);
            conexao.Open();

            string query ="SELECT * FROM cliente WHERE login=@login AND senha=@senha";
            MySqlCommand comando = new MySqlCommand(query,conexao);
            comando.Parameters.AddWithValue("@login", cliente.login);
            comando.Parameters.AddWithValue("@senha", cliente.senha);
            MySqlDataReader reader = comando.ExecuteReader();

            Cliente clienteLogado = null;

            if(reader.Read())
            {
                clienteLogado = new Cliente();

                clienteLogado.id = reader.GetInt32("id");

                if(!reader.IsDBNull(reader.GetOrdinal("nome")))
                clienteLogado.nome = reader.GetString("nome");

                clienteLogado.dataNascimento = reader.GetDateTime("dataNascimento");

                if(!reader.IsDBNull(reader.GetOrdinal("login")))
                clienteLogado.login = reader.GetString("login");

                if(!reader.IsDBNull(reader.GetOrdinal("senha")))
                clienteLogado.senha = reader.GetString("senha");
            }
            conexao.Close();
            return clienteLogado;
        }
    }
}