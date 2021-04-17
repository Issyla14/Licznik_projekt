
namespace Licznik
{
    partial class Taryfy
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
            this.Powrót = new System.Windows.Forms.Button();
            this.czas = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Online = new System.Windows.Forms.Button();
            this.Recznie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Powrót
            // 
            this.Powrót.Location = new System.Drawing.Point(180, 371);
            this.Powrót.Name = "Powrót";
            this.Powrót.Size = new System.Drawing.Size(75, 23);
            this.Powrót.TabIndex = 3;
            this.Powrót.Text = "Powrót";
            this.Powrót.UseVisualStyleBackColor = true;
            this.Powrót.Click += new System.EventHandler(this.Powrót_Click);
            // 
            // czas
            // 
            this.czas.AutoSize = true;
            this.czas.Location = new System.Drawing.Point(279, 23);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(53, 15);
            this.czas.TabIndex = 5;
            this.czas.Text = "Dataczas";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "W jaki sposób chcesz złożyć wniosek";
            // 
            // Online
            // 
            this.Online.Location = new System.Drawing.Point(100, 139);
            this.Online.Name = "Online";
            this.Online.Size = new System.Drawing.Size(75, 23);
            this.Online.TabIndex = 7;
            this.Online.Text = "Online";
            this.Online.UseVisualStyleBackColor = true;
            this.Online.Click += new System.EventHandler(this.Online_Click);
            // 
            // Recznie
            // 
            this.Recznie.Location = new System.Drawing.Point(264, 139);
            this.Recznie.Name = "Recznie";
            this.Recznie.Size = new System.Drawing.Size(75, 23);
            this.Recznie.TabIndex = 8;
            this.Recznie.Text = "Ręcznie";
            this.Recznie.UseVisualStyleBackColor = true;
            this.Recznie.Click += new System.EventHandler(this.Recznie_Click);
            // 
            // Taryfy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 406);
            this.Controls.Add(this.Recznie);
            this.Controls.Add(this.Online);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.czas);
            this.Controls.Add(this.Powrót);
            this.Name = "Taryfy";
            this.Text = "Pesel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Powrót;
        private System.Windows.Forms.Label czas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Recznie;
        private System.Windows.Forms.Button Online;
    }
}