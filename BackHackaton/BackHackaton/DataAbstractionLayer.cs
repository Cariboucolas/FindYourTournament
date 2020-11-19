using BackHackaton.Controllers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BackHackaton
{
    public class DataAbstractionLayer
    {
        private SqlConnection _connection = new SqlConnection();
        public void Open(SqlConnectionStringBuilder stringBuilder)
        {
            _connection.ConnectionString = stringBuilder.ConnectionString;
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public SqlConnection GetConnection()
        {
            return _connection;
        }

        public  List<Tournaments> SelectAllTournamentss()
        {
            SqlCommand command = _connection.CreateCommand();
            command.CommandText = "SELECT " +
                                                                            "TournamentId, " +
                                                                            "TournamentName," +
                                                                            "TournamentDate," +
                                                                            "Price," +
                                                                            "Prize," +
                                                                            "TournamentLocation," +
                                                                            "ISNULL(TournamentType, '')," +
                                                                            "Description" +
                                                                            "Participants" +
                                                                            "ISNULL(Champion, '')," +
                                                                            "Images," +
                                                                            "Videos" +
                                                                                "FROM Tournament"+
                                                                                "ORDER BY TournamentDate";

            SqlDataReader reader = command.ExecuteReader();
            List<Tournaments> tournaments = new List<Tournaments>();
            while (reader.Read())
            {
                Tournaments tournament = new Tournaments
                {
                    TournamentId = reader.GetInt32(0),
                    TournamentName = reader.GetString(1),
                    TournamentDate = reader.GetDateTime(2),
                    Price = reader.GetInt32(3),
                    Prize = reader.GetInt32(4),
                    TournamentLocation = reader.GetString(5),
                    TournamentType = reader.GetString(6),
                    Descrpition = reader.GetString(7),
                    Participants = reader.GetInt32(8),
                    Champion = reader.GetString(9),
                    Images = reader.GetString(10),
                    Videos=reader.GetString(11)
                };

                tournaments.Add(tournament);
            }
            reader.Close();
            return tournaments;
        }


        public  void Close()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }
}
