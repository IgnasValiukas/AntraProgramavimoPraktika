
namespace KolegijosVertinimoSistema_admin_
{
    partial class Studentai
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
            this.Istrinti = new System.Windows.Forms.Button();
            this.Prideti = new System.Windows.Forms.Button();
            this.StuDVG = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Vardas = new System.Windows.Forms.TextBox();
            this.Pavarde = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.Faku = new System.Windows.Forms.TextBox();
            this.FakIDcb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TelNr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Redaguoti = new System.Windows.Forms.Button();
            this.StuID = new System.Windows.Forms.TextBox();
            this.SemeCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StuDVG)).BeginInit();
            this.SuspendLayout();
            // 
            // Istrinti
            // 
            this.Istrinti.Location = new System.Drawing.Point(851, 192);
            this.Istrinti.Name = "Istrinti";
            this.Istrinti.Size = new System.Drawing.Size(138, 27);
            this.Istrinti.TabIndex = 45;
            this.Istrinti.Text = "Ištrinti";
            this.Istrinti.UseVisualStyleBackColor = true;
            this.Istrinti.Click += new System.EventHandler(this.Istrinti_Click);
            // 
            // Prideti
            // 
            this.Prideti.Location = new System.Drawing.Point(384, 142);
            this.Prideti.Name = "Prideti";
            this.Prideti.Size = new System.Drawing.Size(138, 23);
            this.Prideti.TabIndex = 41;
            this.Prideti.Text = "Pridėti";
            this.Prideti.UseVisualStyleBackColor = true;
            this.Prideti.Click += new System.EventHandler(this.button12_Click);
            // 
            // StuDVG
            // 
            this.StuDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StuDVG.Location = new System.Drawing.Point(205, 235);
            this.StuDVG.Name = "StuDVG";
            this.StuDVG.RowHeadersWidth = 51;
            this.StuDVG.RowTemplate.Height = 24;
            this.StuDVG.Size = new System.Drawing.Size(784, 344);
            this.StuDVG.TabIndex = 39;
            this.StuDVG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StuDVG_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Pavardė";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Vardas";
            // 
            // Vardas
            // 
            this.Vardas.Location = new System.Drawing.Point(220, 36);
            this.Vardas.Name = "Vardas";
            this.Vardas.Size = new System.Drawing.Size(138, 22);
            this.Vardas.TabIndex = 35;
            // 
            // Pavarde
            // 
            this.Pavarde.Location = new System.Drawing.Point(384, 36);
            this.Pavarde.Name = "Pavarde";
            this.Pavarde.Size = new System.Drawing.Size(138, 22);
            this.Pavarde.TabIndex = 34;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.Font = new System.Drawing.Font("Nominee Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button5.Location = new System.Drawing.Point(23, 358);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 23);
            this.button5.TabIndex = 32;
            this.button5.Text = "ATSIJUNGTI";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Font = new System.Drawing.Font("Nominee Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button4.Location = new System.Drawing.Point(23, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "KURSAI";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Font = new System.Drawing.Font("Nominee Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button3.Location = new System.Drawing.Point(23, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "DĖSTYTOJAI";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Nominee Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button2.Location = new System.Drawing.Point(23, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "STUDENTAI";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Nominee Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button1.Location = new System.Drawing.Point(23, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 28;
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
            this.panel1.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("Nominee Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(837, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 28);
            this.label5.TabIndex = 46;
            this.label5.Text = "STUDENTAI";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.Font = new System.Drawing.Font("Nominee Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button6.Location = new System.Drawing.Point(23, 289);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 23);
            this.button6.TabIndex = 52;
            this.button6.Text = "FAKULTETAS";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Faku
            // 
            this.Faku.BackColor = System.Drawing.SystemColors.Info;
            this.Faku.Enabled = false;
            this.Faku.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Faku.Location = new System.Drawing.Point(384, 89);
            this.Faku.Name = "Faku";
            this.Faku.Size = new System.Drawing.Size(138, 22);
            this.Faku.TabIndex = 53;
            // 
            // FakIDcb
            // 
            this.FakIDcb.FormattingEnabled = true;
            this.FakIDcb.Location = new System.Drawing.Point(220, 87);
            this.FakIDcb.Name = "FakIDcb";
            this.FakIDcb.Size = new System.Drawing.Size(138, 24);
            this.FakIDcb.TabIndex = 54;
            this.FakIDcb.SelectionChangeCommitted += new System.EventHandler(this.FakIDcb_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Fakulteto ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 602);
            this.panel2.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Location = new System.Drawing.Point(1002, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 602);
            this.panel3.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Location = new System.Drawing.Point(11, 589);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1297, 10);
            this.panel4.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel5.Location = new System.Drawing.Point(6, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1297, 10);
            this.panel5.TabIndex = 30;
            // 
            // TelNr
            // 
            this.TelNr.Location = new System.Drawing.Point(548, 36);
            this.TelNr.Name = "TelNr";
            this.TelNr.Size = new System.Drawing.Size(138, 22);
            this.TelNr.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(545, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 57;
            this.label8.Text = "Tel. Numeris";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(545, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 59;
            this.label9.Text = "Semestras";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(381, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 60;
            this.label10.Text = "Fakultetas:";
            // 
            // Redaguoti
            // 
            this.Redaguoti.Location = new System.Drawing.Point(851, 159);
            this.Redaguoti.Name = "Redaguoti";
            this.Redaguoti.Size = new System.Drawing.Size(138, 27);
            this.Redaguoti.TabIndex = 61;
            this.Redaguoti.Text = "Redaguoti";
            this.Redaguoti.UseVisualStyleBackColor = true;
            this.Redaguoti.Click += new System.EventHandler(this.Redaguoti_Click);
            // 
            // StuID
            // 
            this.StuID.Location = new System.Drawing.Point(851, 131);
            this.StuID.Name = "StuID";
            this.StuID.Size = new System.Drawing.Size(138, 22);
            this.StuID.TabIndex = 62;
            // 
            // SemeCB
            // 
            this.SemeCB.FormattingEnabled = true;
            this.SemeCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.SemeCB.Location = new System.Drawing.Point(548, 89);
            this.SemeCB.Name = "SemeCB";
            this.SemeCB.Size = new System.Drawing.Size(138, 24);
            this.SemeCB.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(850, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 64;
            this.label4.Text = "Studneto ID";
            // 
            // Studentai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 598);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SemeCB);
            this.Controls.Add(this.StuID);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Redaguoti);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TelNr);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FakIDcb);
            this.Controls.Add(this.Faku);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Istrinti);
            this.Controls.Add(this.Prideti);
            this.Controls.Add(this.StuDVG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Vardas);
            this.Controls.Add(this.Pavarde);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Studentai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studentai";
            ((System.ComponentModel.ISupportInitialize)(this.StuDVG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Istrinti;
        private System.Windows.Forms.Button Prideti;
        private System.Windows.Forms.DataGridView StuDVG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Vardas;
        private System.Windows.Forms.TextBox Pavarde;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox Faku;
        private System.Windows.Forms.ComboBox FakIDcb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TelNr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Redaguoti;
        private System.Windows.Forms.TextBox StuID;
        private System.Windows.Forms.ComboBox SemeCB;
        private System.Windows.Forms.Label label4;
    }
}