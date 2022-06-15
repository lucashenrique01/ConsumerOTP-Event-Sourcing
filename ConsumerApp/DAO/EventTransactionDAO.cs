using System;
using MysqlContext;
using ConsumerApp.Models;
using MySqlConnector;

namespace EventDaoNamespace{

    public class EventTransactionDAO{
        
        Mysql mysql = new Mysql();
        public async void createTableEventTransaction() {
            var builder = mysql.conection();
            using (var conn = new MySqlConnection(builder.ConnectionString))
            {
                try
            {
                Console.WriteLine("Opening connection");
                    await conn.OpenAsync();
                    using (var command = conn.CreateCommand())
                    {
                        command.CommandText = "CREATE TABLE IF NOT EXISTS eventTransaction (Id serial PRIMARY KEY auto_increment, token VARCHAR(50), idClient VARCHAR(50), idTransacao VARCHAR(50), canalSolicitante VARCHAR(50), duracaoToken datetime);";
                        await command.ExecuteNonQueryAsync();
                        Console.WriteLine("Finished creating table");
                    }


                }
            catch (Exception e) {
                Console.WriteLine("Erro ao criar a tabela: " + e);
            }
            finally
            {
                Console.WriteLine("Closing connection");
                conn.Close();
            }
        }
        }

        public async void insertEventTransaction(EventTransaction newEvent){
            var builder = mysql.conection();
            using (var conn = new MySqlConnection(builder.ConnectionString))
            {
                Console.WriteLine("Opening connection");
                try
                {
                    await conn.OpenAsync();
                    using (var command = conn.CreateCommand())
                    {
                        command.CommandText = @"INSERT INTO eventTransaction (token, idClient, idTransacao, canalSolicitante, duracaoToken) VALUES 
                    (@token, @idClient, @idTransacao, @canalSolicitante, @duracaoToken);";
                        command.Parameters.AddWithValue("@token", newEvent.token);
                        command.Parameters.AddWithValue("@idClient", newEvent.idClient);
                        command.Parameters.AddWithValue("@idTransacao", newEvent.idTransacao);
                        command.Parameters.AddWithValue("@canalSolicitante", newEvent.canalSolicitante);
                        command.Parameters.AddWithValue("@duracaoToken", newEvent.duracaoToken);
                        await command.ExecuteNonQueryAsync();
                        Console.WriteLine("Um evento gravado");
                    }
                }
                catch (Exception e)
                {
                    Console.Write("Erro ao tentar inserir um evento: " + e);
                }
                finally
                {
                    Console.WriteLine("Closing connection");
                    conn.Close();
                }
            }
        }
    }
}