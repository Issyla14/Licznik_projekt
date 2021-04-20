
namespace Licznik
{
    partial class glowne
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Stan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.czas = new System.Windows.Forms.Label();
            this.Zmianataryfy = new System.Windows.Forms.Button();
            this.ZmianaRozliczania = new System.Windows.Forms.Button();
            this.Symulacja = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ARozliczanie = new System.Windows.Forms.Label();
            this.Rozliczanie = new System.Windows.Forms.Label();
            this.Wyloguj = new System.Windows.Forms.Button();
            this.nazwa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aktualny stan licznika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aktualna taryfa";
            // 
            // Stan
            // 
            this.Stan.AutoSize = true;
            this.Stan.Location = new System.Drawing.Point(28, 97);
            this.Stan.Margin = new System.Windows.Forms.Padding(0);
            this.Stan.Name = "Stan";
            this.Stan.Size = new System.Drawing.Size(72, 15);
            this.Stan.TabIndex = 2;
            this.Stan.Text = "Stan licznika";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "G11";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // czas
            // 
            this.czas.AutoSize = true;
            this.czas.Location = new System.Drawing.Point(28, 24);
            this.czas.Margin = new System.Windows.Forms.Padding(0);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(53, 15);
            this.czas.TabIndex = 4;
            this.czas.Text = "Dataczas";
            // 
            // Zmianataryfy
            // 
            this.Zmianataryfy.Location = new System.Drawing.Point(285, 285);
            this.Zmianataryfy.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Zmianataryfy.Name = "Zmianataryfy";
            this.Zmianataryfy.Size = new System.Drawing.Size(100, 46);
            this.Zmianataryfy.TabIndex = 5;
            this.Zmianataryfy.Text = "Zmiana taryfy";
            this.Zmianataryfy.UseVisualStyleBackColor = true;
            this.Zmianataryfy.Click += new System.EventHandler(this.Zmianataryfy_Click);
            // 
            // ZmianaRozliczania
            // 
            this.ZmianaRozliczania.Location = new System.Drawing.Point(62, 285);
            this.ZmianaRozliczania.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.ZmianaRozliczania.Name = "ZmianaRozliczania";
            this.ZmianaRozliczania.Size = new System.Drawing.Size(100, 46);
            this.ZmianaRozliczania.TabIndex = 6;
            this.ZmianaRozliczania.Text = "Zmiana Rozliczania";
            this.ZmianaRozliczania.UseVisualStyleBackColor = true;
            // 
            // Symulacja
            // 
            this.Symulacja.Location = new System.Drawing.Point(173, 285);
            this.Symulacja.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Symulacja.Name = "Symulacja";
            this.Symulacja.Size = new System.Drawing.Size(100, 46);
            this.Symulacja.TabIndex = 7;
            this.Symulacja.Text = "Symulacja";
            this.Symulacja.UseVisualStyleBackColor = true;
            this.Symulacja.Click += new System.EventHandler(this.Symulacja_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ARozliczanie
            // 
            this.ARozliczanie.AutoSize = true;
            this.ARozliczanie.Location = new System.Drawing.Point(248, 67);
            this.ARozliczanie.Margin = new System.Windows.Forms.Padding(0);
            this.ARozliczanie.Name = "ARozliczanie";
            this.ARozliczanie.Size = new System.Drawing.Size(153, 15);
            this.ARozliczanie.TabIndex = 8;
            this.ARozliczanie.Text = "Aktualny sposób rozliczania";
            // 
            // Rozliczanie
            // 
            this.Rozliczanie.AutoSize = true;
            this.Rozliczanie.Location = new System.Drawing.Point(248, 97);
            this.Rozliczanie.Margin = new System.Windows.Forms.Padding(0);
            this.Rozliczanie.Name = "Rozliczanie";
            this.Rozliczanie.Size = new System.Drawing.Size(65, 15);
            this.Rozliczanie.TabIndex = 9;
            this.Rozliczanie.Text = "Rozliczanie";
            // 
            // Wyloguj
            // 
            this.Wyloguj.Location = new System.Drawing.Point(351, 19);
            this.Wyloguj.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Wyloguj.Name = "Wyloguj";
            this.Wyloguj.Size = new System.Drawing.Size(68, 24);
            this.Wyloguj.TabIndex = 10;
            this.Wyloguj.Text = "Wyloguj";
            this.Wyloguj.UseVisualStyleBackColor = true;
            this.Wyloguj.Click += new System.EventHandler(this.Wyloguj_Click);
            // 
            // nazwa
            // 
            this.nazwa.AutoSize = true;
            this.nazwa.Location = new System.Drawing.Point(248, 24);
            this.nazwa.Margin = new System.Windows.Forms.Padding(0);
            this.nazwa.Name = "nazwa";
            this.nazwa.Size = new System.Drawing.Size(42, 15);
            this.nazwa.TabIndex = 11;
            this.nazwa.Text = "Nazwa";
            // 
            // glowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 405);
            this.Controls.Add(this.nazwa);
            this.Controls.Add(this.Wyloguj);
            this.Controls.Add(this.Rozliczanie);
            this.Controls.Add(this.ARozliczanie);
            this.Controls.Add(this.Symulacja);
            this.Controls.Add(this.ZmianaRozliczania);
            this.Controls.Add(this.Zmianataryfy);
            this.Controls.Add(this.czas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Stan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Name = "glowne";
            this.Text = "Strona główna";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.glowne_FormClosing);
            this.Load += new System.EventHandler(this.glowne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Stan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label czas;
        private System.Windows.Forms.Button Zmianataryfy;
        private System.Windows.Forms.Button ZmianaRozliczania;
        private System.Windows.Forms.Button Symulacja;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label ARozliczanie;
        private System.Windows.Forms.Label Rozliczanie;
        private System.Windows.Forms.Button Wyloguj;
        private System.Windows.Forms.Label nazwa;
    }
}