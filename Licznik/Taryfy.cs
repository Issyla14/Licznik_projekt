using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licznik
{
    public partial class Taryfy : Form
    {
        private glowne g;
        public Taryfy(glowne g)
        {
            this.g = g;
            InitializeComponent();
            timer1.Start();
        }

        private void Powrót_Click(object sender, EventArgs e)
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

        private void Online_Click(object sender, EventArgs e)
        {
            
            Process.Start(new ProcessStartInfo(@"cmd", $"/c start https://www.tauron.pl/dla-domu/obsluga-i-pomoc/jestem-klientem/zmiany-w-umowie/zmiana-taryfy/formularz") { CreateNoWindow = true });
        }

        private void Recznie_Click(object sender, EventArgs e)
        {

            Process.Start(new ProcessStartInfo(@"cmd", $"/c start https://www.tauron.pl/-/media/formularze-i-wnioski/pdf/woz-pzo/ts/ts-gd-woz-wniosek-o-zawarcie-umowy-e.ashx") { CreateNoWindow = true });

        }
    }
     
 }
