
namespace Licznik
{
    partial class Symulacja
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
            this.SG11 = new System.Windows.Forms.RadioButton();
            this.SG12 = new System.Windows.Forms.RadioButton();
            this.SG13 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.WynikSzacowania = new System.Windows.Forms.Label();
            this.powrot2 = new System.Windows.Forms.Button();
            this.czas = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.G11Info = new System.Windows.Forms.ToolTip(this.components);
            this.G12Info = new System.Windows.Forms.ToolTip(this.components);
            this.G13Info = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SG11
            // 
            this.SG11.AutoSize = true;
            this.SG11.Location = new System.Drawing.Point(24, 47);
            this.SG11.Name = "SG11";
            this.SG11.Size = new System.Drawing.Size(45, 19);
            this.SG11.TabIndex = 0;
            this.SG11.TabStop = true;
            this.SG11.Text = "G11";
            this.SG11.UseVisualStyleBackColor = true;
            // 
            // SG12
            // 
            this.SG12.AutoSize = true;
            this.SG12.Location = new System.Drawing.Point(24, 73);
            this.SG12.Name = "SG12";
            this.SG12.Size = new System.Drawing.Size(45, 19);
            this.SG12.TabIndex = 1;
            this.SG12.TabStop = true;
            this.SG12.Text = "G12";
            this.SG12.UseVisualStyleBackColor = true;
            // 
            // SG13
            // 
            this.SG13.AutoSize = true;
            this.SG13.Location = new System.Drawing.Point(24, 99);
            this.SG13.Name = "SG13";
            this.SG13.Size = new System.Drawing.Size(45, 19);
            this.SG13.TabIndex = 2;
            this.SG13.TabStop = true;
            this.SG13.Text = "G13";
            this.SG13.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sumaryczna kwota";
            // 
            // WynikSzacowania
            // 
            this.WynikSzacowania.AutoSize = true;
            this.WynikSzacowania.Location = new System.Drawing.Point(276, 86);
            this.WynikSzacowania.Name = "WynikSzacowania";
            this.WynikSzacowania.Size = new System.Drawing.Size(70, 15);
            this.WynikSzacowania.TabIndex = 4;
            this.WynikSzacowania.Text = "wynikkwoty";
            // 
            // powrot2
            // 
            this.powrot2.Location = new System.Drawing.Point(180, 323);
            this.powrot2.Name = "powrot2";
            this.powrot2.Size = new System.Drawing.Size(75, 23);
            this.powrot2.TabIndex = 5;
            this.powrot2.Text = "Powrót";
            this.powrot2.UseVisualStyleBackColor = true;
            this.powrot2.Click += new System.EventHandler(this.powrot2_Click);
            // 
            // czas
            // 
            this.czas.AutoSize = true;
            this.czas.Location = new System.Drawing.Point(276, 22);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(53, 15);
            this.czas.TabIndex = 6;
            this.czas.Text = "Dataczas";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Wykres";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // Symulacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 413);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.czas);
            this.Controls.Add(this.powrot2);
            this.Controls.Add(this.WynikSzacowania);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SG13);
            this.Controls.Add(this.SG12);
            this.Controls.Add(this.SG11);
            this.Name = "Symulacja";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton SG11;
        private System.Windows.Forms.RadioButton SG12;
        private System.Windows.Forms.RadioButton SG13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WynikSzacowania;
        private System.Windows.Forms.Button powrot2;
        private System.Windows.Forms.Label czas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip G11Info;
        private System.Windows.Forms.ToolTip G12Info;
        private System.Windows.Forms.ToolTip G13Info;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}