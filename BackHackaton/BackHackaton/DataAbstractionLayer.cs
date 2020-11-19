using BackHackaton.Controllers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BackHackaton
{
    public static class DataAbstractionLayer
    {
        private static SqlConnection _connection = new SqlConnection();
        public static void Open(SqlConnectionStringBuilder stringBuilder)
        {
            _connection.ConnectionString = stringBuilder.ConnectionString;
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public static SqlConnection GetConnection()
        {
            return _connection;
        }

        public static List<Tournaments> SelectAllTournaments()
        {
            SqlCommand command = _connection.CreateCommand();
            command.CommandText = "SELECT " +
                                                                            "TournamentId, " +
                                                                            "ISNULL(TournamentName,'')," +
                                                                            "ISNULL(TournamentDate,'')," +
                                                                            "ISNULL(Price,'')," +
                                                                            "ISNULL(Prize,'')," +
                                                                            "ISNULL(TournamentLocation,'')," +
                                                                            "ISNULL(TournamentType, '')," +
                                                                            "ISNULL(Description,'')," +
                                                                            "ISNULL(Participants,'')," +
                                                                            "ISNULL(Champion, '')," +
                                                                            "ISNULL(Images,'')," +
                                                                            "ISNULL(Videos,'') " +
                                                                                "FROM Tournament " +
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
                    Description = reader.GetString(7),
                    Participants = reader.GetInt32(8),
                    Champion = reader.GetString(9),
                    Images = reader.GetString(10),
                    Videos = reader.GetString(11)
                };

                tournaments.Add(tournament);
            }

            reader.Close();
            return tournaments;
        }


            public static List<Knight> SelectAllKnights()
            {
                SqlCommand command = _connection.CreateCommand();
            command.CommandText = "SELECT " +
                                                                            "KnightId, " +
                                                                            "ISNULL(KnightName,'')," +
                                                                            "ISNULL(Age,'')," +
                                                                            "ISNULL(Victories, '')," +
                                                                            "ISNULL(Defeats,'')," +
                                                                            "ISNULL(Badge,'')," +
                                                                            "ISNULL(Weapons,'')," +
                                                                            "ISNULL(Armors,'')," +
                                                                            "ISNULL(Mount,'')," +
                                                                            "ISNULL(MountType,'')," +
                                                                            "ISNULL(MountName,'')," +
                                                                            "ISNULL(Moto,'')," +
                                                                            "ISNULL(Avatar,'')," +
                                                                            "ISNULL(Region,'')," +
                                                                             "ISNULL(Pigeon,'')," +
                                                                              "ISNULL(Alive,1)," +
                                                                              "ISNULL(Ranking,'')" +
                                                                                "FROM Knight " +
                                                                                "ORDER BY Ranking";

                SqlDataReader reader = command.ExecuteReader();
                List<Knight> knights = new List<Knight>();
                while (reader.Read())
                {
                    Knight knight= new Knight
                    {
                        KnightId=reader.GetInt32(0),
                        KnightName=reader.GetString(1),
                        Age=reader.GetInt32(2),
                        Victories=reader.GetInt32(3),
                        Defeats=reader.GetInt32(4),
                        Badge=reader.GetString(5),
                        Weapons=reader.GetString(6),
                        Armors=reader.GetString(7),
                        Mount=reader.GetBoolean(8),
                        MountType=reader.GetString(9),
                        MountName=reader.GetString(10),
                        Moto=reader.GetString(11),
                        Avatar=reader.GetString(12),
                        Region=reader.GetString(13),
                        Pigeon=reader.GetString(14),
                        Alive=reader.GetBoolean(15),
                        Ranking=reader.GetInt32(16)
                    };

                    knights.Add(knight);
                }
                reader.Close();
            return knights;
        }




        public static  void Close()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }

    
    }
