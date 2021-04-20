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

namespace Licznik
{
    
    public partial class glowne : Form
    {
                      
        private float zczytanie = 3277;
      
        
        public glowne()
        {
            InitializeComponent();
            string tekst = File.ReadAllText("file.txt");
            var olddate = Convert.ToDateTime(File.ReadAllText("data.txt"));
            string nowadata = DateTime.Now.ToString("s");
            var newdate = Convert.ToDateTime(nowadata);
            var roznica = newdate.Subtract(olddate);
            var res = String.Format("{0}:{1}", roznica.Hours, roznica.Minutes);
            MessageBox.Show(res);
            zczytanie = float.Parse(tekst);
            
        }

        private void glowne_Load(object sender, EventArgs e)
        {
            nazwa.Text = Logowanie.SetValueForText1;
          
            timer1.Start();
            timer2.Start();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Interval = 4000;
            zczytanie += 1;
            Stan.Text = zczytanie.ToString();
            

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
