namespace Calcolatrice_A_S_L
{
    partial class Calcolatrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calcolatrice));
            this.labelParole = new System.Windows.Forms.Label();
            this.labelRisultatoParole = new System.Windows.Forms.Label();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.ToolStripButtonInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.richTextBoxX = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxParole = new System.Windows.Forms.TextBox();
            this.textBoxNumeri = new System.Windows.Forms.TextBox();
            this.textBoxRisultatoParole = new System.Windows.Forms.TextBox();
            this.textBoxRisultatoNumeri = new System.Windows.Forms.TextBox();
            this.radioButtonGradi = new System.Windows.Forms.RadioButton();
            this.radioButtonRadianti = new System.Windows.Forms.RadioButton();
            this.groupBoxAngoli = new System.Windows.Forms.GroupBox();
            this.radioButtonTestoCifra = new System.Windows.Forms.RadioButton();
            this.radioButtonCifraTesto = new System.Windows.Forms.RadioButton();
            this.groupBoxOpzioni = new System.Windows.Forms.GroupBox();
            this.labelNumeri = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripMenu.SuspendLayout();
            this.groupBoxAngoli.SuspendLayout();
            this.groupBoxOpzioni.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelParole
            // 
            this.labelParole.AutoSize = true;
            this.labelParole.BackColor = System.Drawing.Color.Transparent;
            this.labelParole.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParole.Location = new System.Drawing.Point(12, 53);
            this.labelParole.Name = "labelParole";
            this.labelParole.Size = new System.Drawing.Size(175, 33);
            this.labelParole.TabIndex = 12;
            this.labelParole.Text = "Calcolo in parole";
            // 
            // labelRisultatoParole
            // 
            this.labelRisultatoParole.AutoSize = true;
            this.labelRisultatoParole.BackColor = System.Drawing.Color.Transparent;
            this.labelRisultatoParole.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRisultatoParole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelRisultatoParole.Location = new System.Drawing.Point(12, 154);
            this.labelRisultatoParole.Name = "labelRisultatoParole";
            this.labelRisultatoParole.Size = new System.Drawing.Size(194, 33);
            this.labelRisultatoParole.TabIndex = 13;
            this.labelRisultatoParole.Text = "Risultato in parole";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.Color.White;
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButtonInfo,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(816, 31);
            this.toolStripMenu.TabIndex = 16;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // ToolStripButtonInfo
            // 
            this.ToolStripButtonInfo.BackColor = System.Drawing.Color.Transparent;
            this.ToolStripButtonInfo.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonInfo.Image")));
            this.ToolStripButtonInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonInfo.Name = "ToolStripButtonInfo";
            this.ToolStripButtonInfo.Size = new System.Drawing.Size(83, 28);
            this.ToolStripButtonInfo.Text = "Istruzioni";
            this.ToolStripButtonInfo.Click += new System.EventHandler(this.ToolStripButtonInfo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = global::Calcolatrice_A_S_L.Properties.Resources.impostazioni1;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(79, 28);
            this.toolStripButton1.Text = "Impostazioni";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // richTextBoxX
            // 
            this.richTextBoxX.BackColor = System.Drawing.Color.White;
            this.richTextBoxX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxX.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxX.Location = new System.Drawing.Point(581, 314);
            this.richTextBoxX.Name = "richTextBoxX";
            this.richTextBoxX.ReadOnly = true;
            this.richTextBoxX.Size = new System.Drawing.Size(101, 61);
            this.richTextBoxX.TabIndex = 18;
            this.richTextBoxX.Text = "";
            this.richTextBoxX.TextChanged += new System.EventHandler(this.richTextBoxX_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Calcolatrice_A_S_L.Properties.Resources.papiro;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(595, 621);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 99);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcola";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxParole
            // 
            this.textBoxParole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxParole.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxParole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParole.Location = new System.Drawing.Point(11, 100);
            this.textBoxParole.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxParole.Name = "textBoxParole";
            this.textBoxParole.Size = new System.Drawing.Size(358, 29);
            this.textBoxParole.TabIndex = 0;
            this.textBoxParole.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxParole_KeyDown);
            // 
            // textBoxNumeri
            // 
            this.textBoxNumeri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNumeri.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNumeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeri.Location = new System.Drawing.Point(418, 100);
            this.textBoxNumeri.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumeri.Name = "textBoxNumeri";
            this.textBoxNumeri.ReadOnly = true;
            this.textBoxNumeri.Size = new System.Drawing.Size(358, 29);
            this.textBoxNumeri.TabIndex = 1;
            this.textBoxNumeri.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNumeri_KeyDown);
            // 
            // textBoxRisultatoParole
            // 
            this.textBoxRisultatoParole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRisultatoParole.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxRisultatoParole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRisultatoParole.Location = new System.Drawing.Point(11, 199);
            this.textBoxRisultatoParole.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRisultatoParole.Multiline = true;
            this.textBoxRisultatoParole.Name = "textBoxRisultatoParole";
            this.textBoxRisultatoParole.ReadOnly = true;
            this.textBoxRisultatoParole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRisultatoParole.Size = new System.Drawing.Size(358, 81);
            this.textBoxRisultatoParole.TabIndex = 6;
            // 
            // textBoxRisultatoNumeri
            // 
            this.textBoxRisultatoNumeri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRisultatoNumeri.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxRisultatoNumeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRisultatoNumeri.Location = new System.Drawing.Point(418, 199);
            this.textBoxRisultatoNumeri.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRisultatoNumeri.Multiline = true;
            this.textBoxRisultatoNumeri.Name = "textBoxRisultatoNumeri";
            this.textBoxRisultatoNumeri.ReadOnly = true;
            this.textBoxRisultatoNumeri.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRisultatoNumeri.Size = new System.Drawing.Size(358, 81);
            this.textBoxRisultatoNumeri.TabIndex = 7;
            // 
            // radioButtonGradi
            // 
            this.radioButtonGradi.AutoSize = true;
            this.radioButtonGradi.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGradi.ForeColor = System.Drawing.Color.Red;
            this.radioButtonGradi.Location = new System.Drawing.Point(129, 38);
            this.radioButtonGradi.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonGradi.Name = "radioButtonGradi";
            this.radioButtonGradi.Size = new System.Drawing.Size(75, 32);
            this.radioButtonGradi.TabIndex = 4;
            this.radioButtonGradi.Text = "Gradi";
            this.radioButtonGradi.UseVisualStyleBackColor = true;
            // 
            // radioButtonRadianti
            // 
            this.radioButtonRadianti.AutoSize = true;
            this.radioButtonRadianti.Checked = true;
            this.radioButtonRadianti.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRadianti.ForeColor = System.Drawing.Color.Red;
            this.radioButtonRadianti.Location = new System.Drawing.Point(15, 38);
            this.radioButtonRadianti.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonRadianti.Name = "radioButtonRadianti";
            this.radioButtonRadianti.Size = new System.Drawing.Size(99, 32);
            this.radioButtonRadianti.TabIndex = 3;
            this.radioButtonRadianti.TabStop = true;
            this.radioButtonRadianti.Text = "Radianti";
            this.radioButtonRadianti.UseVisualStyleBackColor = true;
            // 
            // groupBoxAngoli
            // 
            this.groupBoxAngoli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxAngoli.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAngoli.Controls.Add(this.radioButtonRadianti);
            this.groupBoxAngoli.Controls.Add(this.radioButtonGradi);
            this.groupBoxAngoli.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAngoli.Location = new System.Drawing.Point(11, 388);
            this.groupBoxAngoli.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAngoli.Name = "groupBoxAngoli";
            this.groupBoxAngoli.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAngoli.Size = new System.Drawing.Size(226, 80);
            this.groupBoxAngoli.TabIndex = 10;
            this.groupBoxAngoli.TabStop = false;
            this.groupBoxAngoli.Text = "Angoli";
            // 
            // radioButtonTestoCifra
            // 
            this.radioButtonTestoCifra.AutoSize = true;
            this.radioButtonTestoCifra.Checked = true;
            this.radioButtonTestoCifra.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTestoCifra.ForeColor = System.Drawing.Color.Red;
            this.radioButtonTestoCifra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonTestoCifra.Location = new System.Drawing.Point(13, 38);
            this.radioButtonTestoCifra.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonTestoCifra.Name = "radioButtonTestoCifra";
            this.radioButtonTestoCifra.Size = new System.Drawing.Size(152, 32);
            this.radioButtonTestoCifra.TabIndex = 8;
            this.radioButtonTestoCifra.TabStop = true;
            this.radioButtonTestoCifra.Text = "Testo --> Cifra";
            this.radioButtonTestoCifra.UseVisualStyleBackColor = true;
            this.radioButtonTestoCifra.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButtonCifraTesto
            // 
            this.radioButtonCifraTesto.AutoSize = true;
            this.radioButtonCifraTesto.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCifraTesto.ForeColor = System.Drawing.Color.Red;
            this.radioButtonCifraTesto.Location = new System.Drawing.Point(179, 38);
            this.radioButtonCifraTesto.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonCifraTesto.Name = "radioButtonCifraTesto";
            this.radioButtonCifraTesto.Size = new System.Drawing.Size(152, 32);
            this.radioButtonCifraTesto.TabIndex = 9;
            this.radioButtonCifraTesto.Text = "Cifra --> Testo";
            this.radioButtonCifraTesto.UseVisualStyleBackColor = true;
            // 
            // groupBoxOpzioni
            // 
            this.groupBoxOpzioni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxOpzioni.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxOpzioni.Controls.Add(this.radioButtonCifraTesto);
            this.groupBoxOpzioni.Controls.Add(this.radioButtonTestoCifra);
            this.groupBoxOpzioni.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOpzioni.Location = new System.Drawing.Point(11, 304);
            this.groupBoxOpzioni.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxOpzioni.Name = "groupBoxOpzioni";
            this.groupBoxOpzioni.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxOpzioni.Size = new System.Drawing.Size(338, 80);
            this.groupBoxOpzioni.TabIndex = 11;
            this.groupBoxOpzioni.TabStop = false;
            this.groupBoxOpzioni.Text = "Opzioni";
            // 
            // labelNumeri
            // 
            this.labelNumeri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNumeri.AutoSize = true;
            this.labelNumeri.BackColor = System.Drawing.Color.Transparent;
            this.labelNumeri.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeri.Location = new System.Drawing.Point(426, 53);
            this.labelNumeri.Name = "labelNumeri";
            this.labelNumeri.Size = new System.Drawing.Size(187, 33);
            this.labelNumeri.TabIndex = 14;
            this.labelNumeri.Text = "Calcolo in numeri";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(426, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "Risultato in numeri";
            // 
            // Calcolatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Calcolatrice_A_S_L.Properties.Resources.calc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 731);
            this.Controls.Add(this.richTextBoxX);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.labelParole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNumeri);
            this.Controls.Add(this.labelRisultatoParole);
            this.Controls.Add(this.groupBoxOpzioni);
            this.Controls.Add(this.groupBoxAngoli);
            this.Controls.Add(this.textBoxRisultatoNumeri);
            this.Controls.Add(this.textBoxRisultatoParole);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNumeri);
            this.Controls.Add(this.textBoxParole);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Calcolatrice";
            this.Text = "Calcolatrice in lingua Italiana";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.groupBoxAngoli.ResumeLayout(false);
            this.groupBoxAngoli.PerformLayout();
            this.groupBoxOpzioni.ResumeLayout(false);
            this.groupBoxOpzioni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelParole;
        private System.Windows.Forms.Label labelRisultatoParole;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton ToolStripButtonInfo;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.RichTextBox richTextBoxX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumeri;
        private System.Windows.Forms.GroupBox groupBoxOpzioni;
        private System.Windows.Forms.RadioButton radioButtonCifraTesto;
        private System.Windows.Forms.RadioButton radioButtonTestoCifra;
        private System.Windows.Forms.GroupBox groupBoxAngoli;
        public System.Windows.Forms.RadioButton radioButtonRadianti;
        public System.Windows.Forms.RadioButton radioButtonGradi;
        private System.Windows.Forms.TextBox textBoxRisultatoNumeri;
        private System.Windows.Forms.TextBox textBoxRisultatoParole;
        private System.Windows.Forms.TextBox textBoxNumeri;
        private System.Windows.Forms.TextBox textBoxParole;
        private System.Windows.Forms.Button button1;
    }
}

