using netDxf;
using netDxf.Entities;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
namespace HasPoint
{
    internal class Class2
    {
     
            static void Main(string[] args)
            {



                // Create a new DXF document
                var document = new DxfDocument();

            // Connection string to SQLite database
            string databaseName = "C:\\Users\\hp\\Desktop\\Nouveau dossier\\D.db";
                string connectionString = $"Data Source={databaseName};Version=3;";



                // Rest of your code to draw lines, labels, etc.

                // Define the origin and some points
                var origin = new Vector2(0, 0); //markaz
                var point1 = new Vector2(0, 110); //maalm x
                var point2 = new Vector2(100, 0); //maalan y
                var point3 = new Vector2(100, -10); //1
                var point4 = new Vector2(100, -20); //2
                var point5 = new Vector2(100, -30); //3
                var point6 = new Vector2(100, -40); //4
                var point30 = new Vector2(100, -50); //1
                var point31 = new Vector2(100, -60); //2
                var point32 = new Vector2(100, -70); //3
                var point33 = new Vector2(100, -80); //4
                var point34 = new Vector2(100, -90); //4


                // var point7 = new Vector2(0, -100); // mallam contr y
                var point8 = new Vector2(-70, 0); //  mallam contr x
                var point50 = new Vector2(0, -20); // pour demi line
                var point51 = new Vector2(0, -10);

                var point52 = new Vector2(10, -10); // pour demi line
                var point53 = new Vector2(10, -20);

                var point54 = new Vector2(20, -10); // pour demi line
                var point55 = new Vector2(20, -20);

                var point56 = new Vector2(40, -10); // pour demi line
                var point57 = new Vector2(40, -20);

                var point58 = new Vector2(50, -10); // pour demi line
                var point59 = new Vector2(50, -20);

                var point60 = new Vector2(60, -10); // pour demi line
                var point61 = new Vector2(60, -20);




                var point9 = new Vector2(-70, -10); //1-
                var point10 = new Vector2(-70, -20); //2-
                var point11 = new Vector2(-70, -30); //3-
                var point13 = new Vector2(-70, -40); //4-
                var point20 = new Vector2(-70, -50); //5-
                var point21 = new Vector2(-70, -60); //6-

                var point22 = new Vector2(-70, -70); //7- POUR FAIRE LISON
                var point88 = new Vector2(-10, -80);

                var point23 = new Vector2(-70, -80); //8-
                var point24 = new Vector2(-70, -90); //9-

                var point40 = new Vector2(-10, -90); //9-
                var point41 = new Vector2(-10, 0); //9-

                var point14 = new Vector2(-80, -100); // Caree
                var point15 = new Vector2(110, -100); // Caree
                var point16 = new Vector2(-80, 110); //  Caree
                var point17 = new Vector2(110, 110); //  Caree



                // Add the points to the document
                document.Entities.Add(new Point(origin)); //pour ajouter les points au document
                document.Entities.Add(new Point(point1));
                document.Entities.Add(new Point(point2));
                document.Entities.Add(new Point(point3));
                document.Entities.Add(new Point(point4));
                document.Entities.Add(new Point(point5));
                document.Entities.Add(new Point(point6));
                //  document.Entities.Add(new Point(point7));
                document.Entities.Add(new Point(point8));
                document.Entities.Add(new Point(point9));
                document.Entities.Add(new Point(point10));
                document.Entities.Add(new Point(point11));
                document.Entities.Add(new Point(point6));



                document.Entities.Add(new Point(point13));
            document.Entities.Add(new Point(point14));
            document.Entities.Add(new Point(point15));
            document.Entities.Add(new Point(point16));
            document.Entities.Add(new Point(point17));
            document.Entities.Add(new Point(point20));
            document.Entities.Add(new Point(point21));
            document.Entities.Add(new Point(point22));
            document.Entities.Add(new Point(point23));
            document.Entities.Add(new Point(point24));
            document.Entities.Add(new Point(point30));
            document.Entities.Add(new Point(point31));
            document.Entities.Add(new Point(point32));
            document.Entities.Add(new Point(point33));
            document.Entities.Add(new Point(point34));

            document.Entities.Add(new Point(point40));
            document.Entities.Add(new Point(point41));

            document.Entities.Add(new Point(point50));
            document.Entities.Add(new Point(point51));

            document.Entities.Add(new Point(point52));
            document.Entities.Add(new Point(point53));

            document.Entities.Add(new Point(point54));
            document.Entities.Add(new Point(point54));

            document.Entities.Add(new Point(point55));
            document.Entities.Add(new Point(point56));

            document.Entities.Add(new Point(point57));

            document.Entities.Add(new Point(point58));
            document.Entities.Add(new Point(point59));
            document.Entities.Add(new Point(point60));
            document.Entities.Add(new Point(point61));

            document.Entities.Add(new Point(point88));



            // Draw lines connecting the points
            document.Entities.Add(new Line(origin, point1)); //pour relie entr eux
            document.Entities.Add(new Line(origin, point2));
            document.Entities.Add(new Line(origin, point8));
            document.Entities.Add(new Line(point3, point9));
            document.Entities.Add(new Line(point4, point10));
            document.Entities.Add(new Line(point5, point11));
            // document.Entities.Add(new Line(origin, point1));
            document.Entities.Add(new Line(point6, point13));

            document.Entities.Add(new Line(point3, point4));
            document.Entities.Add(new Line(point4, point5));
            document.Entities.Add(new Line(point9, point10));
            document.Entities.Add(new Line(point10, point11));
            document.Entities.Add(new Line(point5, point6));
            document.Entities.Add(new Line(point11, point13));
            document.Entities.Add(new Line(point8, point9));
            document.Entities.Add(new Line(point2, point3));
            document.Entities.Add(new Line(point14, point15));
            document.Entities.Add(new Line(point14, point16));
            document.Entities.Add(new Line(point17, point16));
            document.Entities.Add(new Line(point17, point15));

            document.Entities.Add(new Line(point20, point30));
            document.Entities.Add(new Line(point21, point31));
            document.Entities.Add(new Line(point22, point32));
            document.Entities.Add(new Line(point23, point33));
            document.Entities.Add(new Line(point24, point34));

            document.Entities.Add(new Line(point6, point30));
            document.Entities.Add(new Line(point30, point31));
            document.Entities.Add(new Line(point31, point32));
            document.Entities.Add(new Line(point32, point33));
            document.Entities.Add(new Line(point33, point34));

            document.Entities.Add(new Line(point13, point20));
            document.Entities.Add(new Line(point20, point21));
            document.Entities.Add(new Line(point21, point22));
            document.Entities.Add(new Line(point22, point23));
            document.Entities.Add(new Line(point23, point24));


            document.Entities.Add(new Line(point40, point41));
            document.Entities.Add(new Line(point50, point51));

            document.Entities.Add(new Line(point52, point53));
            document.Entities.Add(new Line(point54, point55));


            document.Entities.Add(new Line(point56, point57));
            document.Entities.Add(new Line(point54, point55));

            document.Entities.Add(new Line(point58, point59));
            document.Entities.Add(new Line(point60, point61));

            document.Entities.Add(new Line(point22, point88));


            try
            {

                List<Vector2> points = GetDataFromDatabase();
                DrawPointsAndLines(document, points);
                AddTexts(document, points);
                SaveAndOpenDxfFile(document);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }






        static List<Vector2> GetDataFromDatabase()
        {

            string databaseName = "C:\\Users\\hp\\Desktop\\Nouveau dossier\\D.db";
            string connectionString = $"Data Source={databaseName};Version=3;";
            List<Vector2> points = new List<Vector2>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                // Execute a query to retrieve points from the database
                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Dp", connection))
                {

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double x = Convert.ToDouble(reader["x"]);
                            double y = Convert.ToDouble(reader["y"]);


                            points.Add(new Vector2(x, y));


                        }
                    }
                }
            }

            return points;
        }

        static void DrawPointsAndLines(DxfDocument document, List<Vector2> points)
        {
            foreach (var point in points)
            {
                document.Entities.Add(new Point(point));
            }

            for (int i = 0; i < points.Count - 1; i++)
            {
                document.Entities.Add(new Line(points[i], points[i + 1]));
            }

            for (int i = 0; i < points.Count; i++)
            {
                double y = points[i].Y;
                document.Entities.Add(new Line(points[i], new Vector2(points[i].X, points[i].Y - (y))));
            }

        }

        static void AddTexts(DxfDocument document, List<Vector2> points)
        {
            for (int i = 0; i < points.Count - 1; i++)
            {
                double x = points[i].X;
                double y = points[i].Y;

                var text = new Text($"{i + 1}", new Vector2(points[i].X, points[i].Y - (y + 5)), 3);
                document.Entities.Add(text);
            }

            for (int i = 0; i < points.Count; i++)
            {
                double x = points[i].X;
                double y = points[i].Y;

                var text = new Text($"{points[i].X}", new Vector2(points[i].X + 2, points[i].Y - (y + 18)), 3);
                document.Entities.Add(text);
            }



            for (int i = 0; i < points.Count - 1; i++)
            {
                double x = points[i].X;
                double y = points[i].Y;
                var text = new Text($"{points[i].X + i + 1 + 10}", new Vector2(points[i].X + 2, points[i].Y - (y + 28)), 3);
                document.Entities.Add(text);
            }

            for (int i = 0; i < points.Count; i++)
            {
                double x = points[i].X;
                double y = points[i].Y;
                var text = new Text($"{123 + i}", new Vector2(points[i].X + 2, points[i].Y - (y + 38)), 3);
                document.Entities.Add(text);
            }



            for (int i = 1; i < points.Count; i++)
            {
                double x = points[i].X;
                double y = points[i].Y;
                var text = new Text($"", new Vector2(20, 10), 12);
                //document.Entities.Add(text);


                // var text = new Text($"{points[i].X}", new Vector2(points[i].X, points[i].Y - (y + 5)), 3);
                //document.Entities.Add(text);
                text = new Text($"No= des piquets et points", new Vector2(-68, -6), 3);
                document.Entities.Add(text);

                text = new Text($"Distances Partielles", new Vector2(-68, -16), 3);
                document.Entities.Add(text);

                text = new Text($"Distances Cumulaires", new Vector2(-68, -26), 3);
                document.Entities.Add(text);

                text = new Text($"Cotes terrah naturel", new Vector2(-68, -36), 3);
                document.Entities.Add(text);

                text = new Text($"Cotes projet (Gen inferieur)", new Vector2(-68, -46), 3);
                document.Entities.Add(text);

                text = new Text($"Profondeurs du debu", new Vector2(-68, -56), 3);
                document.Entities.Add(text);

                text = new Text($"Caracteristiques de conduits", new Vector2(-68, -66), 3);
                document.Entities.Add(text);

                text = new Text($"Pentes en (0/00)", new Vector2(-46, -73), 3);
                document.Entities.Add(text);

                text = new Text($"Longueur", new Vector2(-68, -79), 3);
                document.Entities.Add(text);

                text = new Text($"Nature du terrah", new Vector2(-68, -86), 3);
                document.Entities.Add(text);
            }




        }

        static void SaveAndOpenDxfFile(DxfDocument document)
        {
            document.Save("profile.dxf");
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\LibreCAD\LibreCAD.exe", "profile.dxf");
        }
    }
}










