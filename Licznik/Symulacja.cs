using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Data.Sqlite;

namespace Licznik
{
    public partial class Symulacja : Form
    {   
        
        private glowne g;
        public Symulacja(glowne g)
        {
            this.g = g;
            InitializeComponent();
            SG11.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            SG12.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            SG13.CheckedChanged += new EventHandler(ARadioButton_CheckedChanged);
            
            timer1.Start();
            G11Info.SetToolTip(SG11, "0.3385 zł/kWh");
            G12Info.SetToolTip(SG12, "Strefa 1: 0.4037 zł/kWh\nStrefa 2: 0.2572 zł/kWh");
            G13Info.SetToolTip(SG13, "Strefa 1: 0.3793 zł/kWh\nStrefa 2: 0.5534 zł/kWh\nStrefa 3: 0.275 zł/kWh");
            label2.Text = glowne.SetValueForText1;
           
            void ARadioButton_CheckedChanged(object sender, EventArgs e)
            {
                using (var connection = new SqliteConnection("Data Source=stan.db"))
                {
                    connection.Open();
                    List<double> lst = new List<double>();
                    connection.Open();
                    var zuzycie = connection.CreateCommand();
                    zuzycie.CommandText =
                        @"SELECT strftime('%m',data), godzina,  zuzycie FROM stan";

                    var reader = zuzycie.ExecuteReader();
                    while (reader.Read())
                    {
                        var zuzyciestr = reader["zuzycie"].ToString();
                        lst.Add(double.Parse(zuzyciestr));
                    }

                    List<double> lst2 = new List<double>();
                    var miesiac = connection.CreateCommand();
                    miesiac.CommandText =
                        @"SELECT strftime('%m',data), godzina,  zuzycie FROM stan";

                    var reader2 = miesiac.ExecuteReader();
                    while (reader2.Read())
                    {
                        var msc = reader2["strftime('%m',data)"].ToString();
                        lst2.Add(double.Parse(msc));
                    }
                    List<int> lst3 = new List<int>();
                    var godziny = connection.CreateCommand();
                    godziny.CommandText =
                        @"SELECT strftime('%m',data), godzina,  zuzycie  FROM stan";

                    var reader3 = godziny.ExecuteReader();
                    while (reader3.Read())
                    {
                        var godzina = reader3["godzina"].ToString();
                        lst3.Add(int.Parse(godzina));
                    }
                                    
                    var line1 = new OxyPlot.Series.LineSeries()
                    {
                        Title = $"Series  1",
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
                    
                    double G11s = 0;
                    double nocny = 0;
                    double dzienny = 0;
                    double przed = 0;
                    double po = 0;
                    double pozostale = 0;
                  if (label2.Text == "1 miesięczne")
                  { 
                        for (int j = 0; j < lst2.Count; j++)
                        {
                            if (lst2[j] == mscrozliczanie)
                            {

                                G11s = G11s + lst[j];
                            }
                        }
                 
                        for (int i = 0; i < lst3.Count; i++)
                        {
                            if (lst2[i] == mscrozliczanie)
                            {
                                if (lst3[i] >= 7 && lst3[i] <= 13)
                                {
                                    dzienny = dzienny + lst[i];
                                }
                                else if (lst3[i] >= 16 && lst3[i] <= 22)
                                {
                                    dzienny = dzienny + lst[i];
                                }
                            }
                        }
                        for (int k = 0; k < lst3.Count; k++)
                        {
                            if (lst2[k] == mscrozliczanie)
                            {
                                if (lst2[k] >= 4 && lst2[k] <= 9)
                                {
                                    if (lst3[k] >= 8 && lst3[k] <= 12)
                                    {
                                        przed = przed + lst[k];
                                    }
                                    else if (lst3[k] >= 20 && lst3[k] <= 21)
                                    {
                                        po = po + lst[k];
                                    }
                                    else
                                    {
                                        pozostale = pozostale + lst[k];
                                    }

                                }
                                else
                                {
                                    if (lst3[k] >= 8 && lst3[k] <= 12)
                                    {
                                        przed = przed + lst[k];
                                    }
                                    else if (lst3[k] >= 17 && lst3[k] <= 20)
                                    {
                                        po = po + lst[k];
                                    }
                                    else
                                    {
                                        pozostale = pozostale + lst[k];
                                    }
                                }

                            }
                        }
                    }
                  else if (label2.Text == "2 miesięczne")
                    {
                        for (int j = 0; j < lst2.Count; j++)
                        {
                            if (lst2[j] == mscrozliczanie-1)
                            {

                                G11s = G11s + lst[j];
                            }
                        }

                        for (int i = 0; i < lst3.Count; i++)
                        {
                            if (lst2[i] == mscrozliczanie - 1)
                            {
                                if (lst3[i] >= 7 && lst3[i] <= 13)
                                {
                                    dzienny = dzienny + lst[i];
                                }
                                else if (lst3[i] >= 16 && lst3[i] <= 22)
                                {
                                    dzienny = dzienny + lst[i];
                                }
                            }
                        }
                        for (int k = 0; k < lst3.Count; k++)
                        {
                            if (lst2[k] == mscrozliczanie - 1)
                            {
                                if (lst2[k] >= 4 && lst2[k] <= 9)
                                {
                                    if (lst3[k] >= 8 && lst3[k] <= 12)
                                    {
                                        przed = przed + lst[k];
                                    }
                                    else if (lst3[k] >= 20 && lst3[k] <= 21)
                                    {
                                        po = po + lst[k];
                                    }
                                    else
                                    {
                                        pozostale = pozostale + lst[k];
                                    }

                                }
                                else
                                {
                                    if (lst3[k] >= 8 && lst3[k] <= 12)
                                    {
                                        przed = przed + lst[k];
                                    }
                                    else if (lst3[k] >= 17 && lst3[k] <= 20)
                                    {
                                        po = po + lst[k];
                                    }
                                    else
                                    {
                                        pozostale = pozostale + lst[k];
                                    }
                                }

                            }
                        }
                        for (int j = 0; j < lst2.Count; j++)
                        {
                            if (lst2[j] == mscrozliczanie)
                            {

                                G11s = G11s + lst[j];
                            }
                        }

                        for (int i = 0; i < lst3.Count; i++)
                        {
                            if (lst2[i] == mscrozliczanie)
                            {
                                if (lst3[i] >= 7 && lst3[i] <= 13)
                                {
                                    dzienny = dzienny + lst[i];
                                }
                                else if (lst3[i] >= 16 && lst3[i] <= 22)
                                {
                                    dzienny = dzienny + lst[i];
                                }
                            }
                        }
                        for (int k = 0; k < lst3.Count; k++)
                        {
                            if (lst2[k] == mscrozliczanie)
                            {
                                if (lst2[k] >= 4 && lst2[k] <= 9)
                                {
                                    if (lst3[k] >= 8 && lst3[k] <= 12)
                                    {
                                        przed = przed + lst[k];
                                    }
                                    else if (lst3[k] >= 20 && lst3[k] <= 21)
                                    {
                                        po = po + lst[k];
                                    }
                                    else
                                    {
                                        pozostale = pozostale + lst[k];
                                    }

                                }
                                else
                                {
                                    if (lst3[k] >= 8 && lst3[k] <= 12)
                                    {
                                        przed = przed + lst[k];
                                    }
                                    else if (lst3[k] >= 17 && lst3[k] <= 20)
                                    {
                                        po = po + lst[k];
                                    }
                                    else
                                    {
                                        pozostale = pozostale + lst[k];
                                    }
                                }

                            }
                        }
                    }
                    nocny = G11s - dzienny;
                    double G12s = 0;
                    G12s = nocny * 0.2572 + dzienny * 0.4037;
                    double G13s = 0;
                    G13s = przed * 0.3793 + po * 0.5534 + pozostale * 0.275;
                   
                    if (sender is RadioButton)
                    {
                        RadioButton radioButton = (RadioButton)sender;
                        if (SG11.Checked)
                        {
                            WynikSzacowania.Text = (G11s * 0.3385).ToString("0.00");
                        }
                        else if (SG12.Checked)
                        {
                            WynikSzacowania.Text = (G12s.ToString("0.00"));
                        }
                        else if (SG13.Checked)
                        {
                            WynikSzacowania.Text = (G13s.ToString("0.00"));
                        }

                        
                    }

                }

            }
        }
  
        private void powrot2_Click(object sender, EventArgs e)
        {
            this.Hide();
            g.Visible = true;
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            czas.Text = DateTime.Now.ToString();
        }
        private void Symulacja_FormClosing(object sender, FormClosingEventArgs e)
        {
          
            string Currentdate = DateTime.Now.ToString("s");
            File.WriteAllTextAsync("data.txt", Currentdate);
            e.Cancel = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chart chart = new Chart();
            chart.Show();
        }
    }
}
