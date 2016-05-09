namespace Calcolatrice_A_S_L
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxParole = new System.Windows.Forms.TextBox();
            this.textBoxNumeri = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonRadianti = new System.Windows.Forms.RadioButton();
            this.radioButtonGradi = new System.Windows.Forms.RadioButton();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxRisultatoParole = new System.Windows.Forms.TextBox();
            this.textBoxRisultatoNumeri = new System.Windows.Forms.TextBox();
            this.radioButtonTestoCifra = new System.Windows.Forms.RadioButton();
            this.radioButtonCifraTesto = new System.Windows.Forms.RadioButton();
            this.groupBoxAngoli = new System.Windows.Forms.GroupBox();
            this.groupBoxOpzioni = new System.Windows.Forms.GroupBox();
            this.labelParole = new System.Windows.Forms.Label();
            this.labelRisultatoParole = new System.Windows.Forms.Label();
            this.labelNumeri = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.ToolStripButtonInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxAngoli.SuspendLayout();
            this.groupBoxOpzioni.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxParole
            // 
            this.textBoxParole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxParole.Location = new System.Drawing.Point(8, 62);
            this.textBoxParole.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxParole.Name = "textBoxParole";
            this.textBoxParole.Size = new System.Drawing.Size(800, 20);
            this.textBoxParole.TabIndex = 0;
            // 
            // textBoxNumeri
            // 
            this.textBoxNumeri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNumeri.Location = new System.Drawing.Point(8, 212);
            this.textBoxNumeri.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumeri.Name = "textBoxNumeri";
            this.textBoxNumeri.ReadOnly = true;
            this.textBoxNumeri.Size = new System.Drawing.Size(800, 20);
            this.textBoxNumeri.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(8, 403);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(800, 135);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcola";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonRadianti
            // 
            this.radioButtonRadianti.AutoSize = true;
            this.radioButtonRadianti.Checked = true;
            this.radioButtonRadianti.Location = new System.Drawing.Point(15, 23);
            this.radioButtonRadianti.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonRadianti.Name = "radioButtonRadianti";
            this.radioButtonRadianti.Size = new System.Drawing.Size(85, 27);
            this.radioButtonRadianti.TabIndex = 3;
            this.radioButtonRadianti.TabStop = true;
            this.radioButtonRadianti.Text = "Radianti";
            this.radioButtonRadianti.UseVisualStyleBackColor = true;
            // 
            // radioButtonGradi
            // 
            this.radioButtonGradi.AutoSize = true;
            this.radioButtonGradi.Location = new System.Drawing.Point(136, 23);
            this.radioButtonGradi.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonGradi.Name = "radioButtonGradi";
            this.radioButtonGradi.Size = new System.Drawing.Size(66, 27);
            this.radioButtonGradi.TabIndex = 4;
            this.radioButtonGradi.Text = "Gradi";
            this.radioButtonGradi.UseVisualStyleBackColor = true;
            // 
            // labelX
            // 
            this.labelX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(520, 334);
            this.labelX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(285, 67);
            this.labelX.TabIndex = 5;
            // 
            // textBoxRisultatoParole
            // 
            this.textBoxRisultatoParole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRisultatoParole.Location = new System.Drawing.Point(8, 109);
            this.textBoxRisultatoParole.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRisultatoParole.Multiline = true;
            this.textBoxRisultatoParole.Name = "textBoxRisultatoParole";
            this.textBoxRisultatoParole.ReadOnly = true;
            this.textBoxRisultatoParole.Size = new System.Drawing.Size(800, 67);
            this.textBoxRisultatoParole.TabIndex = 6;
            // 
            // textBoxRisultatoNumeri
            // 
            this.textBoxRisultatoNumeri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRisultatoNumeri.Location = new System.Drawing.Point(8, 269);
            this.textBoxRisultatoNumeri.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRisultatoNumeri.Multiline = true;
            this.textBoxRisultatoNumeri.Name = "textBoxRisultatoNumeri";
            this.textBoxRisultatoNumeri.ReadOnly = true;
            this.textBoxRisultatoNumeri.Size = new System.Drawing.Size(800, 61);
            this.textBoxRisultatoNumeri.TabIndex = 7;
            // 
            // radioButtonTestoCifra
            // 
            this.radioButtonTestoCifra.AutoSize = true;
            this.radioButtonTestoCifra.Checked = true;
            this.radioButtonTestoCifra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonTestoCifra.Location = new System.Drawing.Point(15, 24);
            this.radioButtonTestoCifra.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonTestoCifra.Name = "radioButtonTestoCifra";
            this.radioButtonTestoCifra.Size = new System.Drawing.Size(129, 27);
            this.radioButtonTestoCifra.TabIndex = 8;
            this.radioButtonTestoCifra.TabStop = true;
            this.radioButtonTestoCifra.Text = "Testo --> Cifra";
            this.radioButtonTestoCifra.UseVisualStyleBackColor = true;
            this.radioButtonTestoCifra.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButtonCifraTesto
            // 
            this.radioButtonCifraTesto.AutoSize = true;
            this.radioButtonCifraTesto.Location = new System.Drawing.Point(144, 24);
            this.radioButtonCifraTesto.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonCifraTesto.Name = "radioButtonCifraTesto";
            this.radioButtonCifraTesto.Size = new System.Drawing.Size(129, 27);
            this.radioButtonCifraTesto.TabIndex = 9;
            this.radioButtonCifraTesto.Text = "Cifra --> Testo";
            this.radioButtonCifraTesto.UseVisualStyleBackColor = true;
            // 
            // groupBoxAngoli
            // 
            this.groupBoxAngoli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxAngoli.Controls.Add(this.radioButtonRadianti);
            this.groupBoxAngoli.Controls.Add(this.radioButtonGradi);
            this.groupBoxAngoli.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAngoli.Location = new System.Drawing.Point(8, 334);
            this.groupBoxAngoli.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAngoli.Name = "groupBoxAngoli";
            this.groupBoxAngoli.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAngoli.Size = new System.Drawing.Size(213, 65);
            this.groupBoxAngoli.TabIndex = 10;
            this.groupBoxAngoli.TabStop = false;
            this.groupBoxAngoli.Text = "Angoli";
            // 
            // groupBoxOpzioni
            // 
            this.groupBoxOpzioni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxOpzioni.Controls.Add(this.radioButtonCifraTesto);
            this.groupBoxOpzioni.Controls.Add(this.radioButtonTestoCifra);
            this.groupBoxOpzioni.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOpzioni.Location = new System.Drawing.Point(239, 334);
            this.groupBoxOpzioni.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxOpzioni.Name = "groupBoxOpzioni";
            this.groupBoxOpzioni.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxOpzioni.Size = new System.Drawing.Size(277, 65);
            this.groupBoxOpzioni.TabIndex = 11;
            this.groupBoxOpzioni.TabStop = false;
            this.groupBoxOpzioni.Text = "Opzioni";
            // 
            // labelParole
            // 
            this.labelParole.AutoSize = true;
            this.labelParole.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParole.Location = new System.Drawing.Point(4, 30);
            this.labelParole.Name = "labelParole";
            this.labelParole.Size = new System.Drawing.Size(120, 23);
            this.labelParole.TabIndex = 12;
            this.labelParole.Text = "Calcolo in parole";
            // 
            // labelRisultatoParole
            // 
            this.labelRisultatoParole.AutoSize = true;
            this.labelRisultatoParole.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRisultatoParole.Location = new System.Drawing.Point(4, 84);
            this.labelRisultatoParole.Name = "labelRisultatoParole";
            this.labelRisultatoParole.Size = new System.Drawing.Size(132, 23);
            this.labelRisultatoParole.TabIndex = 13;
            this.labelRisultatoParole.Text = "Risultato in parole";
            // 
            // labelNumeri
            // 
            this.labelNumeri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNumeri.AutoSize = true;
            this.labelNumeri.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeri.Location = new System.Drawing.Point(9, 178);
            this.labelNumeri.Name = "labelNumeri";
            this.labelNumeri.Size = new System.Drawing.Size(127, 23);
            this.labelNumeri.TabIndex = 14;
            this.labelNumeri.Text = "Calcolo in numeri";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Risultato in numeri";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.ToolStripButtonInfo});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(816, 25);
            this.toolStripMenu.TabIndex = 16;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // ToolStripButtonInfo
            // 
            this.ToolStripButtonInfo.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonInfo.Image")));
            this.ToolStripButtonInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonInfo.Name = "ToolStripButtonInfo";
            this.ToolStripButtonInfo.Size = new System.Drawing.Size(75, 22);
            this.ToolStripButtonInfo.Text = "Istruzioni";
            this.ToolStripButtonInfo.Click += new System.EventHandler(this.ToolStripButtonInfo_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(79, 22);
            this.toolStripButton1.Text = "Impostazioni";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 47);
            this.label2.TabIndex = 17;
            this.label2.Text = "Calcolatrice Testuale";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 546);
            this.Controls.Add(this.labelParole);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNumeri);
            this.Controls.Add(this.labelRisultatoParole);
            this.Controls.Add(this.groupBoxOpzioni);
            this.Controls.Add(this.groupBoxAngoli);
            this.Controls.Add(this.textBoxRisultatoNumeri);
            this.Controls.Add(this.textBoxRisultatoParole);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNumeri);
            this.Controls.Add(this.textBoxParole);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calcolatrice in lingua Italiana";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxAngoli.ResumeLayout(false);
            this.groupBoxAngoli.PerformLayout();
            this.groupBoxOpzioni.ResumeLayout(false);
            this.groupBoxOpzioni.PerformLayout();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxParole;
        private System.Windows.Forms.TextBox textBoxNumeri;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.RadioButton radioButtonGradi;
        public System.Windows.Forms.Label labelX;
        public System.Windows.Forms.RadioButton radioButtonRadianti;
        private System.Windows.Forms.TextBox textBoxRisultatoParole;
        private System.Windows.Forms.TextBox textBoxRisultatoNumeri;
        private System.Windows.Forms.RadioButton radioButtonTestoCifra;
        private System.Windows.Forms.RadioButton radioButtonCifraTesto;
        private System.Windows.Forms.GroupBox groupBoxAngoli;
        private System.Windows.Forms.GroupBox groupBoxOpzioni;
        private System.Windows.Forms.Label labelParole;
        private System.Windows.Forms.Label labelRisultatoParole;
        private System.Windows.Forms.Label labelNumeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton ToolStripButtonInfo;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label2;
    }
}

