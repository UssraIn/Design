
using netDxf.Entities;
using System;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
namespace Design
{
    internal class Class2
    {
            static async Task Main(string[] args)
            {
                // path pour connection
                string dbpath = " C:\\Users\\hp\\Desktop\\Nouveau dossier\\D.db";
                SqliteConnection db = new SqliteConnection($"Filename={dbpath}");
                db.Open();

                // selection donnees du table 
                string sql = "SELECT Nom ,x, y FROM Lire";
                SqliteCommand command = new SqliteCommand(sql, db);

                
                SqliteDataReader reader = command.ExecuteReader();
                while (await reader.ReadAsync())
                {
                    string Nom = reader.GetString(0);
                    int x = reader.GetInt32(1);
                    int y = reader.GetInt32(2);
                        //l'affichage
                    Console.WriteLine($"Nom_de_point {Nom} (X:{x}, Y:{y})");
                }
                     //Fermer connection 
                db.Close();
            }
        }
    }





    /**
        static void Main()
        {
           
            string databaseName = "C:\\Users\\hp\\Desktop\\Nouveau dossier\\D.db";
            string connectionString = "Data Source=database.db;Version=3;";

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT X, Y FROM Lr";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                double x = Convert.ToDouble(reader["X"]);
                                double y = Convert.ToDouble(reader["Y"]);
                                Console.WriteLine($"Point: ({x}, {y})");
                            }
                        }
                    }
                }
            }
        }


          string databaseName = "C:\\Users\\hp\\Desktop\\Nouveau dossier\\D.db";
              string connectionString = $"Data Source={databaseName};Version=3;";
              using (SQLiteConnection connection = new SQLiteConnection(connectionString))
              {
                  connection.Open();
                  // Execute a query to retrieve points from the database
                  using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Dp", connection))
                  {

                      using (SQLiteDataReader reader = command.ExecuteReader())
                      {

                          {
                              while (reader.Read())
                              {
                                  
                                      double x = Convert.ToDouble(reader["X"]);
                                      double y = Convert.ToDouble(reader["Y"]);
                                      // Assuming you have a Point class with X and Y properties
                                     // Point point = new Point();
                              //    point.X = reader.GetFloat(0);
                                //  point.Y = reader.GetFloat(1);

                                  // Append the point to the appropriate data structure
                                  // For example, if you're using a list:
                                //  List<Point> points = new List<Point>();
                                 // points.Add(point);
                                   // Add points to the DXF document
                              // document.Entities.Add(new Point(new Vector2(x, y)));
                              //  points.Add(new Vector2(x, y));
                              //   points.Append(new Vector2(x, y));
                              // List<Point> points = new List<Point>();

                              }
                          }
                      }
                  }
              }
          }
      }
    }
          **/


