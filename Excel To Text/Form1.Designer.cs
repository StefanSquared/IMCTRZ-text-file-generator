using System;

namespace Excel_To_Text
{
    partial class Form1
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
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnZacuvaj = new System.Windows.Forms.Button();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnOdberiFile = new System.Windows.Forms.Button();
            this.tbTSNalogodavac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCelNaDoznaka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSledno = new System.Windows.Forms.Button();
            this.btnIzvrsiSite = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbImePrezime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmbg = new System.Windows.Forms.TextBox();
            this.tbTrezorskaSmetka = new System.Windows.Forms.TextBox();
            this.tbPrimacSmetka = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbIznos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbFolioBroj = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbRashodnoKonto = new System.Windows.Forms.TextBox();
            this.labelPotpis = new System.Windows.Forms.Label();
            this.epIme = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTransakciska = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCelNaDoznaka = new System.Windows.Forms.ErrorProvider(this.components);
            this.epEmbg = new System.Windows.Forms.ErrorProvider(this.components);
            this.epIznos = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTrezorskaSemtka = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPrimacSmetka = new System.Windows.Forms.ErrorProvider(this.components);
            this.epFolio = new System.Windows.Forms.ErrorProvider(this.components);
            this.epKonto = new System.Windows.Forms.ErrorProvider(this.components);
            this.rbPP30 = new System.Windows.Forms.RadioButton();
            this.rbPP50 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbUplatnaSmetka1 = new System.Windows.Forms.TextBox();
            this.tbOpstina = new System.Windows.Forms.TextBox();
            this.tbUplatnaSmetka3 = new System.Windows.Forms.TextBox();
            this.tbDanocenBroj = new System.Windows.Forms.TextBox();
            this.epUplatnaSmetka = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDanocenBroj = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epIme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTransakciska)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCelNaDoznaka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmbg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIznos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTrezorskaSemtka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrimacSmetka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFolio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epKonto)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epUplatnaSmetka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDanocenBroj)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(30, 330);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbOutput.Size = new System.Drawing.Size(675, 175);
            this.tbOutput.TabIndex = 13;
            this.tbOutput.WordWrap = false;
            // 
            // btnZacuvaj
            // 
            this.btnZacuvaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZacuvaj.Location = new System.Drawing.Point(605, 510);
            this.btnZacuvaj.Name = "btnZacuvaj";
            this.btnZacuvaj.Size = new System.Drawing.Size(100, 35);
            this.btnZacuvaj.TabIndex = 12;
            this.btnZacuvaj.Text = "Зачувај";
            this.btnZacuvaj.UseVisualStyleBackColor = true;
            this.btnZacuvaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(180, 32);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.ReadOnly = true;
            this.tbFilePath.Size = new System.Drawing.Size(325, 20);
            this.tbFilePath.TabIndex = 14;
            this.tbFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOdberiFile
            // 
            this.btnOdberiFile.Location = new System.Drawing.Point(30, 30);
            this.btnOdberiFile.Name = "btnOdberiFile";
            this.btnOdberiFile.Size = new System.Drawing.Size(145, 25);
            this.btnOdberiFile.TabIndex = 0;
            this.btnOdberiFile.Text = "Одбери Документ(и)";
            this.btnOdberiFile.UseVisualStyleBackColor = true;
            this.btnOdberiFile.Click += new System.EventHandler(this.openFile);
            // 
            // tbTSNalogodavac
            // 
            this.tbTSNalogodavac.Location = new System.Drawing.Point(30, 135);
            this.tbTSNalogodavac.Name = "tbTSNalogodavac";
            this.tbTSNalogodavac.Size = new System.Drawing.Size(305, 20);
            this.tbTSNalogodavac.TabIndex = 2;
            this.tbTSNalogodavac.TextChanged += new System.EventHandler(this.tbTSNalogodavac_TextChanged);
            this.tbTSNalogodavac.Validating += new System.ComponentModel.CancelEventHandler(this.tbTSNalogodavac_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Трансакциска сметка на налогодавач";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Цел на дознака";
            // 
            // tbCelNaDoznaka
            // 
            this.tbCelNaDoznaka.Location = new System.Drawing.Point(30, 180);
            this.tbCelNaDoznaka.Name = "tbCelNaDoznaka";
            this.tbCelNaDoznaka.Size = new System.Drawing.Size(305, 20);
            this.tbCelNaDoznaka.TabIndex = 3;
            this.tbCelNaDoznaka.TextChanged += new System.EventHandler(this.tbCelNaDoznaka_TextChanged);
            this.tbCelNaDoznaka.Validating += new System.ComponentModel.CancelEventHandler(this.tbCelNaDoznaka_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Трезорска сметка";
            // 
            // btnSledno
            // 
            this.btnSledno.Location = new System.Drawing.Point(520, 30);
            this.btnSledno.Name = "btnSledno";
            this.btnSledno.Size = new System.Drawing.Size(75, 25);
            this.btnSledno.TabIndex = 10;
            this.btnSledno.Text = "Следно";
            this.btnSledno.UseVisualStyleBackColor = true;
            this.btnSledno.Click += new System.EventHandler(this.btnSledno_click);
            // 
            // btnIzvrsiSite
            // 
            this.btnIzvrsiSite.Location = new System.Drawing.Point(600, 30);
            this.btnIzvrsiSite.Name = "btnIzvrsiSite";
            this.btnIzvrsiSite.Size = new System.Drawing.Size(105, 25);
            this.btnIzvrsiSite.TabIndex = 11;
            this.btnIzvrsiSite.Text = "Испиши ги сите";
            this.btnIzvrsiSite.UseVisualStyleBackColor = true;
            this.btnIzvrsiSite.Click += new System.EventHandler(this.btnIzvrsiSite_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 12;
            // 
            // tbImePrezime
            // 
            this.tbImePrezime.Location = new System.Drawing.Point(30, 90);
            this.tbImePrezime.Name = "tbImePrezime";
            this.tbImePrezime.Size = new System.Drawing.Size(305, 20);
            this.tbImePrezime.TabIndex = 1;
            this.tbImePrezime.TextChanged += new System.EventHandler(this.tbImePrezime_TextChanged);
            this.tbImePrezime.Validating += new System.ComponentModel.CancelEventHandler(this.tbImePrezime_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Име и презиме";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "ЕМБГ";
            // 
            // tbEmbg
            // 
            this.tbEmbg.Location = new System.Drawing.Point(30, 225);
            this.tbEmbg.Name = "tbEmbg";
            this.tbEmbg.Size = new System.Drawing.Size(305, 20);
            this.tbEmbg.TabIndex = 4;
            this.tbEmbg.TextChanged += new System.EventHandler(this.tbEmbg_TextChanged);
            this.tbEmbg.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmbg_Validating);
            // 
            // tbTrezorskaSmetka
            // 
            this.tbTrezorskaSmetka.Location = new System.Drawing.Point(400, 90);
            this.tbTrezorskaSmetka.Name = "tbTrezorskaSmetka";
            this.tbTrezorskaSmetka.Size = new System.Drawing.Size(305, 20);
            this.tbTrezorskaSmetka.TabIndex = 5;
            this.tbTrezorskaSmetka.TextChanged += new System.EventHandler(this.tbTrezorskaSmetka_TextChanged);
            this.tbTrezorskaSmetka.Validating += new System.ComponentModel.CancelEventHandler(this.tbTrezorskaSmetka_Validating);
            // 
            // tbPrimacSmetka
            // 
            this.tbPrimacSmetka.Location = new System.Drawing.Point(400, 135);
            this.tbPrimacSmetka.Name = "tbPrimacSmetka";
            this.tbPrimacSmetka.Size = new System.Drawing.Size(305, 20);
            this.tbPrimacSmetka.TabIndex = 6;
            this.tbPrimacSmetka.TextChanged += new System.EventHandler(this.tbPrimacSmetka_TextChanged);
            this.tbPrimacSmetka.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrimacSmetka_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Трансакциска сметка на примач";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Износ";
            // 
            // tbIznos
            // 
            this.tbIznos.Location = new System.Drawing.Point(400, 180);
            this.tbIznos.Name = "tbIznos";
            this.tbIznos.Size = new System.Drawing.Size(305, 20);
            this.tbIznos.TabIndex = 7;
            this.tbIznos.TextChanged += new System.EventHandler(this.tbIznos_TextChanged);
            this.tbIznos.Validating += new System.ComponentModel.CancelEventHandler(this.tbIznos_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Фолио број";
            // 
            // tbFolioBroj
            // 
            this.tbFolioBroj.Location = new System.Drawing.Point(400, 225);
            this.tbFolioBroj.Name = "tbFolioBroj";
            this.tbFolioBroj.Size = new System.Drawing.Size(305, 20);
            this.tbFolioBroj.TabIndex = 8;
            this.tbFolioBroj.TextChanged += new System.EventHandler(this.tbFolioBroj_TextChanged);
            this.tbFolioBroj.Validating += new System.ComponentModel.CancelEventHandler(this.tbFolioBroj_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(400, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Расходно конто и програма";
            // 
            // tbRashodnoKonto
            // 
            this.tbRashodnoKonto.Location = new System.Drawing.Point(400, 270);
            this.tbRashodnoKonto.Name = "tbRashodnoKonto";
            this.tbRashodnoKonto.Size = new System.Drawing.Size(305, 20);
            this.tbRashodnoKonto.TabIndex = 9;
            this.tbRashodnoKonto.TextChanged += new System.EventHandler(this.tbRashodnoKonto_TextChanged);
            this.tbRashodnoKonto.Validating += new System.ComponentModel.CancelEventHandler(this.tbRashodnoKonto_Validating);
            // 
            // labelPotpis
            // 
            this.labelPotpis.AutoSize = true;
            this.labelPotpis.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPotpis.Location = new System.Drawing.Point(25, 519);
            this.labelPotpis.Name = "labelPotpis";
            this.labelPotpis.Size = new System.Drawing.Size(68, 26);
            this.labelPotpis.TabIndex = 26;
            this.labelPotpis.Text = "S^2 Soft";
            // 
            // epIme
            // 
            this.epIme.ContainerControl = this;
            // 
            // epTransakciska
            // 
            this.epTransakciska.ContainerControl = this;
            // 
            // epCelNaDoznaka
            // 
            this.epCelNaDoznaka.ContainerControl = this;
            // 
            // epEmbg
            // 
            this.epEmbg.ContainerControl = this;
            // 
            // epIznos
            // 
            this.epIznos.ContainerControl = this;
            // 
            // epTrezorskaSemtka
            // 
            this.epTrezorskaSemtka.ContainerControl = this;
            // 
            // epPrimacSmetka
            // 
            this.epPrimacSmetka.ContainerControl = this;
            // 
            // epFolio
            // 
            this.epFolio.ContainerControl = this;
            // 
            // epKonto
            // 
            this.epKonto.ContainerControl = this;
            // 
            // rbPP30
            // 
            this.rbPP30.AutoSize = true;
            this.rbPP30.Checked = true;
            this.rbPP30.Location = new System.Drawing.Point(10, 6);
            this.rbPP30.Name = "rbPP30";
            this.rbPP30.Size = new System.Drawing.Size(53, 17);
            this.rbPP30.TabIndex = 27;
            this.rbPP30.TabStop = true;
            this.rbPP30.Text = "ПП30";
            this.rbPP30.UseVisualStyleBackColor = true;
            this.rbPP30.CheckedChanged += new System.EventHandler(this.rbPP30_CheckedChanged);
            // 
            // rbPP50
            // 
            this.rbPP50.AutoSize = true;
            this.rbPP50.Location = new System.Drawing.Point(92, 6);
            this.rbPP50.Name = "rbPP50";
            this.rbPP50.Size = new System.Drawing.Size(53, 17);
            this.rbPP50.TabIndex = 28;
            this.rbPP50.Text = "ПП50";
            this.rbPP50.UseVisualStyleBackColor = true;
            this.rbPP50.CheckedChanged += new System.EventHandler(this.rbPP50_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbPP30);
            this.panel1.Controls.Add(this.rbPP50);
            this.panel1.Location = new System.Drawing.Point(30, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 30);
            this.panel1.TabIndex = 30;
            // 
            // tbUplatnaSmetka1
            // 
            this.tbUplatnaSmetka1.Location = new System.Drawing.Point(400, 225);
            this.tbUplatnaSmetka1.Name = "tbUplatnaSmetka1";
            this.tbUplatnaSmetka1.ReadOnly = true;
            this.tbUplatnaSmetka1.Size = new System.Drawing.Size(50, 20);
            this.tbUplatnaSmetka1.TabIndex = 31;
            this.tbUplatnaSmetka1.Text = "840";
            this.tbUplatnaSmetka1.Visible = false;
            // 
            // tbOpstina
            // 
            this.tbOpstina.Location = new System.Drawing.Point(456, 225);
            this.tbOpstina.Name = "tbOpstina";
            this.tbOpstina.Size = new System.Drawing.Size(50, 20);
            this.tbOpstina.TabIndex = 32;
            this.tbOpstina.Visible = false;
            this.tbOpstina.TextChanged += new System.EventHandler(this.tbOpstina_TextChanged);
            this.tbOpstina.Validating += new System.ComponentModel.CancelEventHandler(this.tbOpstina_Validating);
            // 
            // tbUplatnaSmetka3
            // 
            this.tbUplatnaSmetka3.Location = new System.Drawing.Point(512, 225);
            this.tbUplatnaSmetka3.Name = "tbUplatnaSmetka3";
            this.tbUplatnaSmetka3.ReadOnly = true;
            this.tbUplatnaSmetka3.Size = new System.Drawing.Size(63, 20);
            this.tbUplatnaSmetka3.TabIndex = 33;
            this.tbUplatnaSmetka3.Text = "01450";
            this.tbUplatnaSmetka3.Visible = false;
            // 
            // tbDanocenBroj
            // 
            this.tbDanocenBroj.Location = new System.Drawing.Point(400, 270);
            this.tbDanocenBroj.Name = "tbDanocenBroj";
            this.tbDanocenBroj.Size = new System.Drawing.Size(175, 20);
            this.tbDanocenBroj.TabIndex = 34;
            this.tbDanocenBroj.Text = "7034030974246709";
            this.tbDanocenBroj.Visible = false;
            this.tbDanocenBroj.TextChanged += new System.EventHandler(this.tbDanocenBroj_TextChanged);
            this.tbDanocenBroj.Validating += new System.ComponentModel.CancelEventHandler(this.tbDanocenBroj_Validating);
            // 
            // epUplatnaSmetka
            // 
            this.epUplatnaSmetka.ContainerControl = this;
            // 
            // epDanocenBroj
            // 
            this.epDanocenBroj.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(727, 552);
            this.Controls.Add(this.tbDanocenBroj);
            this.Controls.Add(this.tbUplatnaSmetka3);
            this.Controls.Add(this.tbOpstina);
            this.Controls.Add(this.tbUplatnaSmetka1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPotpis);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbRashodnoKonto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbFolioBroj);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbIznos);
            this.Controls.Add(this.tbPrimacSmetka);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTrezorskaSmetka);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbEmbg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbImePrezime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIzvrsiSite);
            this.Controls.Add(this.btnSledno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCelNaDoznaka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTSNalogodavac);
            this.Controls.Add(this.btnOdberiFile);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.btnZacuvaj);
            this.Controls.Add(this.tbOutput);
            this.Name = "Form1";
            this.Text = "IMCT програмче";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.epIme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTransakciska)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCelNaDoznaka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmbg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIznos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTrezorskaSemtka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrimacSmetka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFolio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epKonto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epUplatnaSmetka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDanocenBroj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btnZacuvaj;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btnOdberiFile;
        private System.Windows.Forms.TextBox tbTSNalogodavac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCelNaDoznaka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSledno;
        private System.Windows.Forms.Button btnIzvrsiSite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbImePrezime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEmbg;
        private System.Windows.Forms.TextBox tbTrezorskaSmetka;
        private System.Windows.Forms.TextBox tbPrimacSmetka;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbIznos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbFolioBroj;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbRashodnoKonto;
        private System.Windows.Forms.Label labelPotpis;
        private System.Windows.Forms.ErrorProvider epIme;
        private System.Windows.Forms.ErrorProvider epTransakciska;
        private System.Windows.Forms.ErrorProvider epCelNaDoznaka;
        private System.Windows.Forms.ErrorProvider epEmbg;
        private System.Windows.Forms.ErrorProvider epIznos;
        private System.Windows.Forms.ErrorProvider epTrezorskaSemtka;
        private System.Windows.Forms.ErrorProvider epPrimacSmetka;
        private System.Windows.Forms.ErrorProvider epFolio;
        private System.Windows.Forms.ErrorProvider epKonto;
        private System.Windows.Forms.RadioButton rbPP50;
        private System.Windows.Forms.RadioButton rbPP30;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbDanocenBroj;
        private System.Windows.Forms.TextBox tbUplatnaSmetka3;
        private System.Windows.Forms.TextBox tbOpstina;
        private System.Windows.Forms.TextBox tbUplatnaSmetka1;
        private System.Windows.Forms.ErrorProvider epUplatnaSmetka;
        private System.Windows.Forms.ErrorProvider epDanocenBroj;
    }
}

