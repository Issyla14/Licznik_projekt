using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Licznik
{
    public partial class formarozliczania : Form
    {
        private glowne g;
        public formarozliczania(glowne g)
        {
            this.g = g;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo(@"cmd", $"/c start https://www.tauron.pl/-/media/formularze-i-wnioski/pdf/woz-pzo/ts/ts-gd-woz-wniosek-o-zawarcie-umowy-e.ashx") { CreateNoWindow = true });
            Process.Start(new ProcessStartInfo(@"cmd", $"/c start https://www.tauron.pl/-/media/formularze-i-wnioski/pdf/woz-pzo/ts/ts-gd-msp-woz-pzo-zal2-mikroinstalacja-e.ashx") { CreateNoWindow = true });
            Process.Start(new ProcessStartInfo(@"cmd", $"/c start https://www.tauron.pl/-/media/formularze-i-wnioski/pdf/dom/ts/ts_zgody_klienta_podstawowe_pdf_edyt_k-(1).ashx") { CreateNoWindow = true });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo(@"cmd", $"/c start https://www.tauron.pl/-/media/formularze-i-wnioski/pdf/woz-pzo/ts/ts-gd-woz-wniosek-o-zawarcie-umowy-e.ashx") { CreateNoWindow = true });
            Process.Start(new ProcessStartInfo(@"cmd", $"/c start https://www.tauron.pl/-/media/formularze-i-wnioski/pdf/woz-pzo/ts/ts-gd-msp-woz-pzo-zal2-mikroinstalacja-e.ashx") { CreateNoWindow = true });
            Process.Start(new ProcessStartInfo(@"cmd", $"/c start https://www.tauron.pl/-/media/formularze-i-wnioski/pdf/dom/ts/ts_zgody_klienta_podstawowe_pdf_edyt_k-(1).ashx") { CreateNoWindow = true });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo(@"cmd", $"/c start https://www.tauron.pl/-/media/formularze-i-wnioski/pdf/woz-pzo/ts/ts-gd-woz-wniosek-o-zawarcie-umowy-e.ashx") { CreateNoWindow = true });
            Process.Start(new ProcessStartInfo(@"cmd", $"/c start https://www.tauron.pl/-/media/formularze-i-wnioski/pdf/woz-pzo/ts/ts-gd-msp-woz-pzo-zal2-mikroinstalacja-e.ashx") { CreateNoWindow = true });
            Process.Start(new ProcessStartInfo(@"cmd", $"/c start https://www.tauron.pl/-/media/formularze-i-wnioski/pdf/dom/ts/ts_zgody_klienta_podstawowe_pdf_edyt_k-(1).ashx") { CreateNoWindow = true });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            g.Visible = true;
            this.Close();
        }
    }
}
