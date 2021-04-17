using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licznik
{
    public partial class Symulacja : Form
    {
        private glowne g;
        public Symulacja(glowne g)
        {
            this.g = g;
            InitializeComponent();
            timer1.Start();
            G11Info.SetToolTip(SG11, "0.3385 zł/kWh");
            G12Info.SetToolTip(SG12, "Strefa 1: 0.4037 zł/kWh\nStrefa 2: 0.2572 zł/kWh");
            G13Info.SetToolTip(SG13, "Strefa 1: 0.3793 zł/kWh\nStrefa 2: 0.5534 zł/kWh\nStrefa 3: 0.275 zł/kWh");
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
    }
}
