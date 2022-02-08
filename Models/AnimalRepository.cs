using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySqlConnector;


namespace petVet.Models
{
    public class AnimalRepository
    {
        private const string conectaDados = "Database=petvet;Data Source=localhost;User id=root";
        
        public void TestaConecao()
        {
            MySqlConnection conexao = new MySqlConnection(conectaDados);
            conexao.Open();
            Console.WriteLine("Funcionou");
            conexao.Close();
        }
        public void Inserir(Animal pet)
        {
            MySqlConnection conexao = new MySqlConnection(conectaDados);
            conexao.Open();
            string query ="INSERT INTO animal (nomeAnimal, idadeAnimal, tipoAnimal) VALUES (@nomeAnimal, @idadeAnimal, @tipoAnimal)";
            MySqlCommand comando = new MySqlCommand(query,conexao);

            comando.Parameters.AddWithValue("@nomeAnimal", pet.nomeAnimal);
            comando.Parameters.AddWithValue("@idadeAnimal", pet.idadeAnimal);
            comando.Parameters.AddWithValue("@tipoAnimal", pet.tipoAnimal);
            


            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public List<Animal> Lista()
        {
            MySqlConnection conexao = new MySqlConnection(conectaDados);
            conexao.Open();

            string query = "SELECT * FROM animal";
            
            MySqlCommand comando = new MySqlCommand(query,conexao);
            MySqlDataReader reader = comando.ExecuteReader();
            
            List<Animal> listaAnimal = new List<Animal>();

            while(reader.Read())
            {
                Animal pet = new Animal();

                pet.idPet = reader.GetInt32("idPet");
                
                if(!reader.IsDBNull(reader.GetOrdinal("nomeAnimal")))
                pet.nomeAnimal = reader.GetString("nomeAnimal");

                pet.idadeAnimal = reader.GetInt32("idadeAnimal");

                if(!reader.IsDBNull(reader.GetOrdinal("tipoAnimal")))
                pet.tipoAnimal = reader.GetString("tipoAnimal");

                listaAnimal.Add(pet);
            }

            conexao.Close();
            return listaAnimal;
        }
        public void Excluir (Animal pet)
        {
            MySqlConnection conexao = new MySqlConnection(conectaDados);
            conexao.Open();

            string query="DELETE FROM animal WHERE idPet=@idPet";
            MySqlCommand comando = new MySqlCommand(query,conexao);
            comando.Parameters.AddWithValue("@idPet", pet.idPet);
            comando.ExecuteNonQuery();
            
            conexao.Close();
        }
        public Animal BuscarId(int idPet)
        {
            MySqlConnection conexao = new MySqlConnection(conectaDados);
            conexao.Open();
            
            string query = "SELECT * FROM animal WHERE idPet=@idPet";
            MySqlCommand comando = new MySqlCommand(query,conexao);
            comando.Parameters.AddWithValue("@idPet", idPet);
            MySqlDataReader reader = comando.ExecuteReader();

            Animal pet = new Animal();

            if(reader.Read())
            {
                pet.idadeAnimal = reader.GetInt32("idPet");

                if(!reader.IsDBNull(reader.GetOrdinal("nomeAnimal")))
                pet.nomeAnimal = reader.GetString("nomeAnimal");

                if(!reader.IsDBNull(reader.GetOrdinal("tipoAnimal")))
                pet.tipoAnimal = reader.GetString("tipoAnimal");

                pet.idadeAnimal = reader.GetInt32("idadeAnimal");
            }   
                conexao.Close();
                return pet;
        }
        public void Atualizar(Animal pet)
        {
            MySqlConnection conexao = new MySqlConnection(conectaDados);
            conexao.Open();

            string query = "UPDATE animal SET nomeAnimal=@nomeAnimal, tipoAnimal=@tipoAnimal, idadeAnimal=@idadeAnimal WHERE idPet=@idPet";
            MySqlCommand comando = new MySqlCommand(query,conexao);
            
            comando.Parameters.AddWithValue("@idPet", pet.idPet);
            comando.Parameters.AddWithValue("@nomeAnimal", pet.nomeAnimal);
            comando.Parameters.AddWithValue("@tipoAnimal", pet.tipoAnimal);
            comando.Parameters.AddWithValue("@idadeAnimal", pet.idadeAnimal);

            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}