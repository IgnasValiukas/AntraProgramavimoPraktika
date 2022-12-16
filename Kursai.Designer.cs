
namespace KolegijosVertinimoSistema_admin_
{
    partial class Kursai
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
            this.Kursas = new System.Windows.Forms.Label();
            this.KurID = new System.Windows.Forms.TextBox();
            this.Redaguoti = new System.Windows.Forms.Button();
            this.Istrinti = new System.Windows.Forms.Button();
            this.DesCB = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Tru1 = new System.Windows.Forms.TextBox();
            this.lable56 = new System.Windows.Forms.Label();
            this.Pav1 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.FakCB = new System.Windows.Forms.ComboBox();
            this.Fak = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Prideti = new System.Windows.Forms.Button();
            this.KurDVG = new System.Windows.Forms.DataGridView();
            this.Tru = new System.Windows.Forms.Label();
            this.Pav = new System.Windows.Forms.Label();
            this.Vardas = new System.Windows.Forms.TextBox();
            this.Pavarde = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.KurDVG)).BeginInit();
            this.SuspendLayout();
            // 
            // Kursas
            // 
            this.Kursas.AutoSize = true;
            this.Kursas.Location = new System.Drawing.Point(850, 111);
            this.Kursas.Name = "Kursas";
            this.Kursas.Size = new System.Drawing.Size(62, 17);
            this.Kursas.TabIndex = 129;
            this.Kursas.Text = "Kurso ID";
            // 
            // KurID
            // 
            this.KurID.Location = new System.Drawing.Point(851, 131);
            this.KurID.Name = "KurID";
            this.KurID.Size = new System.Drawing.Size(138, 22);
            this.KurID.TabIndex = 128;
            // 
            // Redaguoti
            // 
            this.Redaguoti.Location = new System.Drawing.Point(851, 159);
            this.Redaguoti.Name = "Redaguoti";
            this.Redaguoti.Size = new System.Drawing.Size(138, 27);
            this.Redaguoti.TabIndex = 127;
            this.Redaguoti.Text = "Redaguoti";
            this.Redaguoti.UseVisualStyleBackColor = true;
            this.Redaguoti.Click += new System.EventHandler(this.Redaguoti_Click);
            // 
            // Istrinti
            // 
            this.Istrinti.Location = new System.Drawing.Point(851, 192);
            this.Istrinti.Name = "Istrinti";
            this.Istrinti.Size = new System.Drawing.Size(138, 27);
            this.Istrinti.TabIndex = 126;
            this.Istrinti.Text = "Ištrinti";
            this.Istrinti.UseVisualStyleBackColor = true;
            this.Istrinti.Click += new System.EventHandler(this.Istrinti_Click);
            // 
            // DesCB
            // 
            this.DesCB.FormattingEnabled = true;
            this.DesCB.Items.AddRange(new object[] {
            "Asistentas",
            "Lektorius",
            "Docentas",
            "Profesorius"});
            this.DesCB.Location = new System.Drawing.Point(548, 34);
            this.DesCB.Name = "DesCB";
            this.DesCB.Size = new System.Drawing.Size(138, 24);
            this.DesCB.TabIndex = 123;
            this.DesCB.SelectionChangeCommitted += new System.EventHandler(this.DesCB_SelectionChangeCommitted);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Location = new System.Drawing.Point(1002, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 602);
            this.panel3.TabIndex = 102;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(381, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 122;
            this.label10.Text = "Fakultetas:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(689, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 121;
            // 
            // Tru1
            // 
            this.Tru1.BackColor = System.Drawing.SystemColors.Window;
            this.Tru1.Location = new System.Drawing.Point(384, 36);
            this.Tru1.Name = "Tru1";
            this.Tru1.Size = new System.Drawing.Size(138, 22);
            this.Tru1.TabIndex = 120;
            // 
            // lable56
            // 
            this.lable56.AutoSize = true;
            this.lable56.Location = new System.Drawing.Point(545, 16);
            this.lable56.Name = "lable56";
            this.lable56.Size = new System.Drawing.Size(84, 17);
            this.lable56.TabIndex = 119;
            this.lable56.Text = "Dėstytojo ID";
            // 
            // Pav1
            // 
            this.Pav1.BackColor = System.Drawing.SystemColors.Window;
            this.Pav1.Location = new System.Drawing.Point(220, 36);
            this.Pav1.Name = "Pav1";
            this.Pav1.Size = new System.Drawing.Size(138, 22);
            this.Pav1.TabIndex = 118;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel5.Location = new System.Drawing.Point(6, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1297, 10);
            this.panel5.TabIndex = 103;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Location = new System.Drawing.Point(11, 589);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1297, 10);
            this.panel4.TabIndex = 101;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 602);
            this.panel2.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 117;
            this.label1.Text = "Fakulteto ID";
            // 
            // FakCB
            // 
            this.FakCB.FormattingEnabled = true;
            this.FakCB.Location = new System.Drawing.Point(220, 87);
            this.FakCB.Name = "FakCB";
            this.FakCB.Size = new System.Drawing.Size(138, 24);
            this.FakCB.TabIndex = 116;
            this.FakCB.SelectedIndexChanged += new System.EventHandler(this.FakCB_SelectedIndexChanged);
            this.FakCB.SelectionChangeCommitted += new System.EventHandler(this.FakCB_SelectionChangeCommitted);
            // 
            // Fak
            // 
            this.Fak.BackColor = System.Drawing.SystemColors.Info;
            this.Fak.Enabled = false;
            this.Fak.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Fak.Location = new System.Drawing.Point(384, 89);
            this.Fak.Name = "Fak";
            this.Fak.Size = new System.Drawing.Size(138, 22);
            this.Fak.TabIndex = 115;
            this.Fak.TextChanged += new System.EventHandler(this.Fak_TextChanged);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.Font = new System.Drawing.Font("Nominee Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button6.Location = new System.Drawing.Point(23, 289);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 23);
            this.button6.TabIndex = 114;
            this.button6.Text = "FAKULTETAS";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("Nominee Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(893, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 29);
            this.label5.TabIndex = 113;
            this.label5.Text = "KURSAI";
            // 
            // Prideti
            // 
            this.Prideti.Location = new System.Drawing.Point(384, 142);
            this.Prideti.Name = "Prideti";
            this.Prideti.Size = new System.Drawing.Size(138, 23);
            this.Prideti.TabIndex = 112;
            this.Prideti.Text = "Prideti";
            this.Prideti.UseVisualStyleBackColor = true;
            this.Prideti.Click += new System.EventHandler(this.Prideti_Click);
            // 
            // KurDVG
            // 
            this.KurDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KurDVG.Location = new System.Drawing.Point(205, 235);
            this.KurDVG.Name = "KurDVG";
            this.KurDVG.RowHeadersWidth = 51;
            this.KurDVG.RowTemplate.Height = 24;
            this.KurDVG.Size = new System.Drawing.Size(784, 344);
            this.KurDVG.TabIndex = 111;
            // 
            // Tru
            // 
            this.Tru.AutoSize = true;
            this.Tru.Location = new System.Drawing.Point(381, 16);
            this.Tru.Name = "Tru";
            this.Tru.Size = new System.Drawing.Size(131, 17);
            this.Tru.TabIndex = 110;
            this.Tru.Text = "Trukmė (valandom)";
            // 
            // Pav
            // 
            this.Pav.AutoSize = true;
            this.Pav.Location = new System.Drawing.Point(220, 16);
            this.Pav.Name = "Pav";
            this.Pav.Size = new System.Drawing.Size(135, 17);
            this.Pav.TabIndex = 109;
            this.Pav.Text = "Dalyko Pavadinimas";
            // 
            // Vardas
            // 
            this.Vardas.BackColor = System.Drawing.SystemColors.Info;
            this.Vardas.Enabled = false;
            this.Vardas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Vardas.Location = new System.Drawing.Point(692, 34);
            this.Vardas.Name = "Vardas";
            this.Vardas.Size = new System.Drawing.Size(138, 22);
            this.Vardas.TabIndex = 108;
            // 
            // Pavarde
            // 
            this.Pavarde.BackColor = System.Drawing.SystemColors.Info;
            this.Pavarde.Enabled = false;
            this.Pavarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Pavarde.Location = new System.Drawing.Point(692, 62);
            this.Pavarde.Name = "Pavarde";
            this.Pavarde.Size = new System.Drawing.Size(138, 22);
            this.Pavarde.TabIndex = 107;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.Font = new System.Drawing.Font("Nominee Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button5.Location = new System.Drawing.Point(23, 358);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 23);
            this.button5.TabIndex = 106;
            this.button5.Text = "ATSIJUNGTI";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Nominee Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button4.Location = new System.Drawing.Point(23, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 23);
            this.button4.TabIndex = 105;
            this.button4.Text = "KURSAI";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Font = new System.Drawing.Font("Nominee Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button3.Location = new System.Drawing.Point(23, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 23);
            this.button3.TabIndex = 104;
            this.button3.Text = "DĖSTYTOJAI";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Nominee Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button2.Location = new System.Drawing.Point(23, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 23);
            this.button2.TabIndex = 100;
            this.button2.Text = "STUDENTAI";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Nominee Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button1.Location = new System.Drawing.Point(23, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 98;
            this.button1.Text = "PAGRINDINIS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(180, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 602);
            this.panel1.TabIndex = 97;
            // 
            // Kursai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 598);
            this.Controls.Add(this.Kursas);
            this.Controls.Add(this.KurID);
            this.Controls.Add(this.Redaguoti);
            this.Controls.Add(this.Istrinti);
            this.Controls.Add(this.DesCB);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Tru1);
            this.Controls.Add(this.lable56);
            this.Controls.Add(this.Pav1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FakCB);
            this.Controls.Add(this.Fak);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Prideti);
            this.Controls.Add(this.KurDVG);
            this.Controls.Add(this.Tru);
            this.Controls.Add(this.Pav);
            this.Controls.Add(this.Vardas);
            this.Controls.Add(this.Pavarde);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kursai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kursai";
            ((System.ComponentModel.ISupportInitialize)(this.KurDVG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Kursas;
        private System.Windows.Forms.TextBox KurID;
        private System.Windows.Forms.Button Redaguoti;
        private System.Windows.Forms.Button Istrinti;
        private System.Windows.Forms.ComboBox DesCB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Tru1;
        private System.Windows.Forms.Label lable56;
        private System.Windows.Forms.TextBox Pav1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FakCB;
        private System.Windows.Forms.TextBox Fak;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Prideti;
        private System.Windows.Forms.DataGridView KurDVG;
        private System.Windows.Forms.Label Tru;
        private System.Windows.Forms.Label Pav;
        private System.Windows.Forms.TextBox Vardas;
        private System.Windows.Forms.TextBox Pavarde;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}