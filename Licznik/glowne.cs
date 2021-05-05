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
    
    public partial class glowne : Form
    {
                      
        private double zczytanie = 3277;


        public glowne()
        {
            //obliczanie różnicy w czasie między uruchomieniami aplikacji
            InitializeComponent();
            string tekst = File.ReadAllText("file.txt");
            var olddate = Convert.ToDateTime(File.ReadAllText("data.txt"));
            string nowadata = DateTime.Now.ToString("s");
            var newdate = Convert.ToDateTime(nowadata);
            var roznica = newdate.Subtract(olddate);
            var dni = String.Format("{0}", roznica.Days);
            var godziny = String.Format("{0}", roznica.Hours);
            double days = double.Parse(dni);
            double hours = double.Parse(godziny);
            
            //dodanie danych do bazy bazując na różnicy czasu
            using (var connection = new SqliteConnection("Data Source=stan.db"))
            {
                connection.Open();
                Random r = new Random();
                for (int i = olddate.Hour; i < days * 24 + hours+olddate.Hour; i++)
                {
                    var daysdiff = i / 24;
                    var hoursdiff = i % 24;
                    var tempdate = olddate.AddDays(daysdiff);
                    var command = connection.CreateCommand();
                    command.CommandText =
                       String.Format(@"
                        INSERT INTO stan(data, godzina, zuzycie) values('{0}',{1},{2})

                    ", tempdate.ToString("yyyy-MM-dd") ,hoursdiff, r.NextDouble()*0.15+0.2);
                    command.ExecuteNonQuery();
                }
                var command2 = connection.CreateCommand();
                command2.CommandText =
                    @"SELECT sum(zuzycie) FROM stan ";
                zczytanie = float.Parse(command2.ExecuteScalar().ToString());
                
            }

        }

        private void glowne_Load(object sender, EventArgs e)
        {
            nazwa.Text = Logowanie.SetValueForText1;
            timer1.Interval = 1000 * 60 *60;
            Stan.Text = zczytanie.ToString("0.00");
            timer1.Start();
            timer2.Start();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            //dodanie danych jeżeli minie godzina
            timer1.Interval = 1000*60*60;

            using (var connection = new SqliteConnection("Data Source=stan.db"))
            {
                connection.Open();
                Random r = new Random();
                var randomnumber = r.NextDouble() * 0.15 + 0.2;

                    var command = connection.CreateCommand();
                    command.CommandText =
                       String.Format(@"
                        INSERT INTO stan(data, godzina, zuzycie) values('{0}',{1},{2})

                    ", DateTime.Now.ToShortDateString(), DateTime.Now.Hour, randomnumber);
                    command.ExecuteNonQuery();
                zczytanie += randomnumber;
            }  
            Stan.Text = zczytanie.ToString("0.00");
            

        }

        private void Zmianataryfy_Click(object sender, EventArgs e)
        {
            Taryfy t = new Taryfy(this);
            this.Visible = false;
            t.ShowDialog();

        }

        private void Symulacja_Click(object sender, EventArgs e)
        {
            Symulacja s = new Symulacja(this);
            this.Visible = false;
            s.ShowDialog();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 1000; 
            czas.Text = DateTime.Now.ToString();
        }

        private void Wyloguj_Click(object sender, EventArgs e)
        {
            string StanK = Stan.Text;
            File.WriteAllTextAsync("file.txt", StanK);
            string Currentdate = DateTime.Now.ToString("s");
            File.WriteAllTextAsync("data.txt", Currentdate);
            Logowanie l = new Logowanie();
            this.Hide();
            l.ShowDialog();
            this.Close();
        }
        private void glowne_FormClosing(object sender, FormClosingEventArgs e)
        {

            string StanK = Stan.Text;
            File.WriteAllTextAsync("file.txt", StanK);
            string Currentdate = DateTime.Now.ToString("s");
            File.WriteAllTextAsync("data.txt", Currentdate);
            e.Cancel = false;
            
           
           
        }
    }
}
