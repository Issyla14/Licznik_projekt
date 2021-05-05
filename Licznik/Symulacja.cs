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
           
            void ARadioButton_CheckedChanged(object sender, EventArgs e)
            {
                using (var connection = new SqliteConnection("Data Source=stan.db"))
                {
                    connection.Open();
                    //dla taryfy G11
                    var strefa = connection.CreateCommand();
                    strefa.CommandText =
                        @"SELECT sum(zuzycie) FROM stan ";
                    double wynik = double.Parse(strefa.ExecuteScalar().ToString());
                    //dla taryfy G12
                    //strefa nocna
                    var nocna = connection.CreateCommand();
                    nocna.CommandText =
                     @"SELECT sum(zuzycie) FROM stan
                        WHERE godzina BETWEEN 14 AND 15 
                        OR  godzina = 23
                        OR godzina BETWEEN 0 AND 6
                        ";
                    double nocny = double.Parse(nocna.ExecuteScalar().ToString());
                    //strefa dzienna
                    var dzienna = connection.CreateCommand();
                    dzienna.CommandText =
                     @"SELECT sum(zuzycie) FROM stan
                        WHERE godzina BETWEEN 7 AND 13 
                        OR  godzina BETWEEN 16 AND 22
                        ";
                    double dzienny = double.Parse(dzienna.ExecuteScalar().ToString());

                    //lato dla taryfy G13
                    var latoprzed = connection.CreateCommand();
                    latoprzed.CommandText =
                     @"SELECT  sum(zuzycie) from stan
                        WHERE (strftime('%m',data) BETWEEN '04' AND '09')
                        AND godzina BETWEEN 8 and 12
                        ";
                    double latoprzedpoludniem = double.Parse(latoprzed.ExecuteScalar().ToString());

                    var latopo = connection.CreateCommand();
                    latopo.CommandText =
                     @"SELECT  sum(zuzycie) from stan
                        WHERE (strftime('%m',data) BETWEEN '04' AND '09')
                        AND godzina BETWEEN 20 and 21
                        ";
                    double latopopoludniu = double.Parse(latopo.ExecuteScalar().ToString());

                    var latopoz = connection.CreateCommand();
                    latopoz.CommandText =
                     @"SELECT  sum(zuzycie) from stan
                        WHERE (strftime('%m',data) BETWEEN '04' AND '09')
                        AND godzina BETWEEN 13 and 19
                        OR godzina BETWEEN 22 and 7
                        ";
                    double latopozostale = double.Parse(latopoz.ExecuteScalar().ToString());

                    // zima dla taryfy G13
                    var zimaprzed = connection.CreateCommand();
                    zimaprzed.CommandText =
                     @"SELECT  sum(zuzycie) from stan
                        WHERE (strftime('%m',data) BETWEEN '10' AND '12')
                        AND godzina BETWEEN 8 and 12
                        ";
                    var cos = zimaprzed.ExecuteScalar();
                    double zimaprzedpoludniem = 0;
                    if (cos != DBNull.Value && cos != null)
                    {
                        zimaprzedpoludniem = double.Parse(cos.ToString());
                    }

                    var zimapo = connection.CreateCommand();
                    zimapo.CommandText =
                     @"SELECT  sum(zuzycie) from stan
                        WHERE (strftime('%m',data) BETWEEN '10' AND '12')
                        AND godzina BETWEEN 17 and 20
                        ";
                    var cos2 = zimapo.ExecuteScalar();
                    double zimapopoludniu = 0;
                    if (cos2 != DBNull.Value && cos2 != null)
                    {
                        zimapopoludniu = double.Parse(cos2.ToString());
                    }
               

                    var zimapoz = connection.CreateCommand();
                    zimapoz.CommandText =
                     @"SELECT  sum(zuzycie) from stan
                        WHERE (strftime('%m',data) BETWEEN '10' AND '12')
                        AND godzina BETWEEN 13 and 16
                        OR godzina BETWEEN 21 and 7
                        ";
                    var cos3 = zimapoz.ExecuteScalar();
                    double zimapozostale = 0;
                     if (cos3 != DBNull.Value && cos3 != null)
                    {
                        zimapozostale = double.Parse(cos3.ToString());
                    }

                    //druga czesc
                    var zimaprzed2 = connection.CreateCommand();
                    zimaprzed2.CommandText =
                     @"SELECT  sum(zuzycie) from stan
                        WHERE (strftime('%m',data) BETWEEN '01' AND '03')
                        AND godzina BETWEEN 8 and 12
                        ";
                    var cos4 = zimaprzed2.ExecuteScalar();
                    double zimaprzedpoludniem2 = 0;
                    if (cos4 != DBNull.Value && cos4 != null)
                    {
                        zimaprzedpoludniem2 = double.Parse(cos4.ToString());
                    }

                    var zimapo2 = connection.CreateCommand();
                    zimapo2.CommandText =
                     @"SELECT  sum(zuzycie) from stan
                        WHERE (strftime('%m',data) BETWEEN '01' AND '03')
                        AND godzina BETWEEN 17 and 20
                        ";
                    var cos5 = zimapo2.ExecuteScalar();
                    double zimapopoludniu2 = 0;
                    if (cos5 != DBNull.Value && cos5 != null)
                    {
                        zimapopoludniu2 = double.Parse(cos5.ToString());
                    }

                    var zimapoz2 = connection.CreateCommand();
                    zimapoz2.CommandText =
                     @"SELECT  sum(zuzycie) from stan
                        WHERE (strftime('%m',data) BETWEEN '01' AND '03')
                        AND godzina BETWEEN 13 and 16
                        OR godzina BETWEEN 21 and 7
                        ";
                    var cos6 = zimapoz2.ExecuteScalar();
                    double zimapozostale2 = 0;
                    if (cos6 != DBNull.Value && cos6 != null)
                    {
                        zimapozostale2 = double.Parse(cos6.ToString());
                    }

                    if (sender is RadioButton)
                    {
                        RadioButton radioButton = (RadioButton)sender;
                        if (SG11.Checked)
                        {
                            WynikSzacowania.Text = (wynik * 0.3385).ToString("0.00");
                        }
                        else if (SG12.Checked)
                        {
                            WynikSzacowania.Text = (nocny * 0.2572 + dzienny *  0.4037).ToString("0.00");
                        }
                        else if (SG13.Checked)
                        {
                           WynikSzacowania.Text = ((latoprzedpoludniem + zimaprzedpoludniem + zimaprzedpoludniem2) * 0.3793 + (latopopoludniu+zimapopoludniu+ zimapopoludniu2) *0.5534 + (latopozostale+zimapozostale+ zimapozostale2) *0.2750).ToString("0.00");
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

        
    }
}
