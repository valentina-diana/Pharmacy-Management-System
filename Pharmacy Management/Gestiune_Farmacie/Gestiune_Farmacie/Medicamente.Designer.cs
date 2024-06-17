namespace Gestiune_Farmacie
{
    partial class Medicamente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicamente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.IdMedicament = new System.Windows.Forms.Label();
            this.Denumire = new System.Windows.Forms.Label();
            this.Pret = new System.Windows.Forms.Label();
            this.Stoc = new System.Windows.Forms.Label();
            this.Producator = new System.Windows.Forms.Label();
            this.IdMedicamentTb = new System.Windows.Forms.TextBox();
            this.DenumireTb = new System.Windows.Forms.TextBox();
            this.PretTb = new System.Windows.Forms.TextBox();
            this.StocTb = new System.Windows.Forms.TextBox();
            this.ProducatorTb = new System.Windows.Forms.TextBox();
            this.MedicamenteGV = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicamenteGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 65);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicamente\r\n";
            // 
            // IdMedicament
            // 
            this.IdMedicament.AutoSize = true;
            this.IdMedicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdMedicament.Location = new System.Drawing.Point(27, 124);
            this.IdMedicament.Name = "IdMedicament";
            this.IdMedicament.Size = new System.Drawing.Size(118, 20);
            this.IdMedicament.TabIndex = 2;
            this.IdMedicament.Text = "IdMedicament:";
            // 
            // Denumire
            // 
            this.Denumire.AutoSize = true;
            this.Denumire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Denumire.Location = new System.Drawing.Point(27, 170);
            this.Denumire.Name = "Denumire";
            this.Denumire.Size = new System.Drawing.Size(87, 20);
            this.Denumire.TabIndex = 3;
            this.Denumire.Text = "Denumire:\r\n";
            // 
            // Pret
            // 
            this.Pret.AutoSize = true;
            this.Pret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pret.Location = new System.Drawing.Point(27, 212);
            this.Pret.Name = "Pret";
            this.Pret.Size = new System.Drawing.Size(45, 20);
            this.Pret.TabIndex = 4;
            this.Pret.Text = "Pret:";
            // 
            // Stoc
            // 
            this.Stoc.AutoSize = true;
            this.Stoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stoc.Location = new System.Drawing.Point(27, 258);
            this.Stoc.Name = "Stoc";
            this.Stoc.Size = new System.Drawing.Size(48, 20);
            this.Stoc.TabIndex = 5;
            this.Stoc.Text = "Stoc:";
            // 
            // Producator
            // 
            this.Producator.AutoSize = true;
            this.Producator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Producator.Location = new System.Drawing.Point(27, 303);
            this.Producator.Name = "Producator";
            this.Producator.Size = new System.Drawing.Size(96, 20);
            this.Producator.TabIndex = 6;
            this.Producator.Text = "Producator:";
            // 
            // IdMedicamentTb
            // 
            this.IdMedicamentTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdMedicamentTb.Location = new System.Drawing.Point(171, 117);
            this.IdMedicamentTb.Name = "IdMedicamentTb";
            this.IdMedicamentTb.Size = new System.Drawing.Size(225, 27);
            this.IdMedicamentTb.TabIndex = 7;
            // 
            // DenumireTb
            // 
            this.DenumireTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DenumireTb.Location = new System.Drawing.Point(171, 163);
            this.DenumireTb.Name = "DenumireTb";
            this.DenumireTb.Size = new System.Drawing.Size(225, 27);
            this.DenumireTb.TabIndex = 8;
            // 
            // PretTb
            // 
            this.PretTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PretTb.Location = new System.Drawing.Point(171, 205);
            this.PretTb.Name = "PretTb";
            this.PretTb.Size = new System.Drawing.Size(225, 27);
            this.PretTb.TabIndex = 9;
            // 
            // StocTb
            // 
            this.StocTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StocTb.Location = new System.Drawing.Point(171, 251);
            this.StocTb.Name = "StocTb";
            this.StocTb.Size = new System.Drawing.Size(225, 27);
            this.StocTb.TabIndex = 10;
            // 
            // ProducatorTb
            // 
            this.ProducatorTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProducatorTb.Location = new System.Drawing.Point(171, 296);
            this.ProducatorTb.Name = "ProducatorTb";
            this.ProducatorTb.Size = new System.Drawing.Size(225, 27);
            this.ProducatorTb.TabIndex = 11;
            // 
            // MedicamenteGV
            // 
            this.MedicamenteGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicamenteGV.Location = new System.Drawing.Point(442, 103);
            this.MedicamenteGV.Name = "MedicamenteGV";
            this.MedicamenteGV.RowHeadersWidth = 51;
            this.MedicamenteGV.RowTemplate.Height = 24;
            this.MedicamenteGV.Size = new System.Drawing.Size(783, 314);
            this.MedicamenteGV.TabIndex = 12;
            this.MedicamenteGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MedicamenteGV_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 461);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 148);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1095, 439);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(116, 32);
            this.button6.TabIndex = 16;
            this.button6.Text = "Imprimare";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(733, 439);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 230);
            this.panel2.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(27, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Medicamente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(51, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Gestiunea unei farmacii";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Proiect PAOO";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(31, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 37);
            this.button1.TabIndex = 18;
            this.button1.Text = "Reseteaza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(171, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 37);
            this.button2.TabIndex = 19;
            this.button2.Text = "Adauga";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(31, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 37);
            this.button3.TabIndex = 20;
            this.button3.Text = "Modifica";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(171, 408);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 37);
            this.button4.TabIndex = 21;
            this.button4.Text = "Sterge";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(31, 637);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 55);
            this.button5.TabIndex = 22;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(99, 637);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 55);
            this.button7.TabIndex = 23;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Medicamente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 727);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MedicamenteGV);
            this.Controls.Add(this.ProducatorTb);
            this.Controls.Add(this.StocTb);
            this.Controls.Add(this.PretTb);
            this.Controls.Add(this.DenumireTb);
            this.Controls.Add(this.IdMedicamentTb);
            this.Controls.Add(this.Producator);
            this.Controls.Add(this.Stoc);
            this.Controls.Add(this.Pret);
            this.Controls.Add(this.Denumire);
            this.Controls.Add(this.IdMedicament);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Medicamente";
            this.Text = "Medicamente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicamenteGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IdMedicament;
        private System.Windows.Forms.Label Denumire;
        private System.Windows.Forms.Label Pret;
        private System.Windows.Forms.Label Stoc;
        private System.Windows.Forms.Label Producator;
        private System.Windows.Forms.TextBox IdMedicamentTb;
        private System.Windows.Forms.TextBox DenumireTb;
        private System.Windows.Forms.TextBox PretTb;
        private System.Windows.Forms.TextBox StocTb;
        private System.Windows.Forms.TextBox ProducatorTb;
        private System.Windows.Forms.DataGridView MedicamenteGV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
    }
}