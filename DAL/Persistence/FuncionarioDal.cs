using System;
using MySql.Data.MySqlClient;
using BLL.Model;
using System.Collections.Generic;

namespace DAL.Persistence
{
    public class FuncionarioDal : Conexao
    {
        public void Salvar(Funcionario funcionario)
        {
            try
            {

                var sql = "INSERT INTO funcionario(nome, CodigoRegidtro, dtCadastro)" +
                          "VALUES(@nome, @CodigoRegistro, CURRENT_TIMESTAMP())";

                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@nome", funcionario.Nome);
                command.Parameters.AddWithValue("@CodigoRegistro", funcionario.CodigoRegistro);
                command.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao registrar dado " + erro.Message + erro.ToString());
            }
            finally
            {

            }
        }

        public List<Funcionario> ListarPorNome(string nome)
        {
            try
            {
                var sql = "SELECT * FROM funcionario WHERE nome LIKE  '%" + nome + "%'  ";
                command = new MySqlCommand(sql, connection);

                dataReader = command.ExecuteReader();

                List<Funcionario> listaFuncionario = new List<Funcionario>();

                while (dataReader.Read())
                {
                    Funcionario funcionario = new Funcionario();

                    funcionario.Id = Convert.ToInt32(dataReader["id"]);
                    funcionario.Nome = dataReader["nome"].ToString();
                    funcionario.CodigoRegistro = dataReader["codigoRegistro"].ToString();

                    listaFuncionario.Add(funcionario);
                }

                //listaFuncionario.Sort();

                return listaFuncionario;

            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao registrar dado " + erro.Message + erro.ToString());
            }
            finally
            {

            }
        }

        public List<Funcionario> Listar()
        {
            try
            {

                var sql = "SELECT * FROM funcionario";
                command = new MySqlCommand(sql, connection);
                dataReader = command.ExecuteReader();

                List<Funcionario> listaFuncionario = new List<Funcionario>();

                while (dataReader.Read())
                {
                    Funcionario funcionario = new Funcionario();

                    funcionario.Id = Convert.ToInt32(dataReader["id"]);
                    funcionario.Nome = dataReader["nome"].ToString();
                    funcionario.CodigoRegistro = dataReader["codigoRegistro"].ToString();

                    listaFuncionario.Add(funcionario);
                }

                //listaFuncionario.Sort();

                return listaFuncionario;

            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao registrar dado " + erro.Message + erro.ToString());
            }
            finally
            {

            }
        }


        public Funcionario PesquisarPorId(int id)
        {
            try
            {
                var sql = "SELECT * FROM funcionario WHERE id = @id";
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                dataReader = command.ExecuteReader();

                Funcionario funcionario = new Funcionario();

                if (dataReader.Read())
                {
                    funcionario.Id = Convert.ToInt32(dataReader["id"]);
                    funcionario.Nome = dataReader["nome"].ToString();
                    funcionario.CodigoRegistro = dataReader["codigoRegistro"].ToString();
                }
                return funcionario;
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao consultar dado " + erro.ToString());
            }
            finally
            {
            }
        }



        public FuncionarioDal()
        {

        }

    }
}