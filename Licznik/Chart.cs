using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using OxyPlot;
using OxyPlot.Series;


namespace Licznik
{
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
        }

        private void Chart_Paint(object sender, PaintEventArgs pe)
        {
            using (var connection = new SqliteConnection("Data Source=stan.db"))
            {
                List<double> lst = new List<double>();
                connection.Open();
                var wykres = connection.CreateCommand();
                wykres.CommandText =
                    @"SELECT strftime('%m',data), sum(zuzycie) FROM stan 
                       GROUP BY data";

                var reader = wykres.ExecuteReader();
                while (reader.Read())
                {
                    var zuzyciestr = reader["sum(zuzycie)"].ToString();
                    lst.Add(double.Parse(zuzyciestr));
                }
                
                List<double> lst2 = new List<double>();
                var miesiac = connection.CreateCommand();
                miesiac.CommandText =
                    @"SELECT strftime('%m',data), sum(zuzycie) FROM stan 
                       GROUP BY data";

                var reader2 = miesiac.ExecuteReader();
                while (reader2.Read())
                {
                    var msc = reader2["strftime('%m',data)"].ToString();
                    lst2.Add(double.Parse(msc));
                }
                List<List<double>> lst3 = new List<List<double>>();
                lst3.Add(lst);
                lst3.Add(lst2);
                double ymax = lst.Max();
                
                var line1 = new OxyPlot.Series.LineSeries()
                {
                    Title = $"Zużycie",
                    Color = OxyPlot.OxyColors.Blue,
                    StrokeThickness = 1,
                };
                var m = connection.CreateCommand();
                m.CommandText =
                     @"SELECT strftime('%m',data) from stan
                            Group by data
                            ORDER by data DESC LIMIT 1";
                var month = m.ExecuteScalar();
                double mscrozliczanie = double.Parse(month.ToString());
                mscrozliczanie = mscrozliczanie - 1;
                double suma = 0;
                for (int j = 0; j < lst3.Count; j++)
                {
                    if (lst3[1][j]== mscrozliczanie)
                    {
                        suma = suma + lst3[0][j];
                    }

                }    
                for (int i = 0; i < lst.Count; i++)
                {
                    //int x1 = 25 + (i - 1) * 800 / lst.Count;
                    int x2 = 25 + i * 800 / lst.Count;
                   // int y1 = 25 + 400 - (int)Math.Round((lst[i - 1]) * 400 / ymax);
                    int y2 = 25 + 400 - (int)Math.Round((lst[i]) * 400 / ymax);
                    line1.Points.Add(new OxyPlot.DataPoint(x2, y2));
                }
                var model = new OxyPlot.PlotModel { Title = "Wykres zużycia energii" };
                model.Series.Add(line1);
                plotView1.Model = model;


            }

        }
    }
}
