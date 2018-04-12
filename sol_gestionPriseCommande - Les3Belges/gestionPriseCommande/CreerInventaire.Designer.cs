namespace les3belges
{
    partial class CreerInventaire
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxProduit = new System.Windows.Forms.ComboBox();
            this.dataGridViewSelectProduit = new System.Windows.Forms.DataGridView();
            this.RefProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LIBELLEPRODUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIXUHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAUXTVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STOCKTHEORIQUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUPPRESSION = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.TxtMessage = new System.Windows.Forms.Label();
            this.TxtMessageF = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.label1.Location = new System.Drawing.Point(180, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Créer Inventaire";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(184, 380);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // comboBoxProduit
            // 
            this.comboBoxProduit.FormattingEnabled = true;
            this.comboBoxProduit.Location = new System.Drawing.Point(228, 123);
            this.comboBoxProduit.Name = "comboBoxProduit";
            this.comboBoxProduit.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProduit.TabIndex = 2;
            this.comboBoxProduit.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridViewSelectProduit
            // 
            this.dataGridViewSelectProduit.AllowUserToAddRows = false;
            this.dataGridViewSelectProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelectProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RefProduit,
            this.LIBELLEPRODUIT,
            this.PRIXUHT,
            this.TAUXTVA,
            this.STOCKTHEORIQUE,
            this.SUPPRESSION});
            this.dataGridViewSelectProduit.Location = new System.Drawing.Point(1, 177);
            this.dataGridViewSelectProduit.Name = "dataGridViewSelectProduit";
            this.dataGridViewSelectProduit.Size = new System.Drawing.Size(544, 150);
            this.dataGridViewSelectProduit.TabIndex = 3;
            this.dataGridViewSelectProduit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSelectProduit_CellClick);
            // 
            // RefProduit
            // 
            this.RefProduit.HeaderText = "Ref produit";
            this.RefProduit.Name = "RefProduit";
            // 
            // LIBELLEPRODUIT
            // 
            this.LIBELLEPRODUIT.HeaderText = "LIBELLE PRODUIT";
            this.LIBELLEPRODUIT.Name = "LIBELLEPRODUIT";
            // 
            // PRIXUHT
            // 
            this.PRIXUHT.HeaderText = "PRIX UHT";
            this.PRIXUHT.Name = "PRIXUHT";
            // 
            // TAUXTVA
            // 
            this.TAUXTVA.HeaderText = "TAUX TVA";
            this.TAUXTVA.Name = "TAUXTVA";
            // 
            // STOCKTHEORIQUE
            // 
            this.STOCKTHEORIQUE.HeaderText = "STOCK THEORIQUE";
            this.STOCKTHEORIQUE.Name = "STOCKTHEORIQUE";
            // 
            // SUPPRESSION
            // 
            this.SUPPRESSION.HeaderText = "SUPPRESSION";
            this.SUPPRESSION.Image = global::les3belges.Properties.Resources.Poubelle3;
            this.SUPPRESSION.Name = "SUPPRESSION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Produit :";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(142, 380);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(36, 13);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Date :";
            // 
            // TxtMessage
            // 
            this.TxtMessage.AutoSize = true;
            this.TxtMessage.Location = new System.Drawing.Point(225, 92);
            this.TxtMessage.Name = "TxtMessage";
            this.TxtMessage.Size = new System.Drawing.Size(0, 13);
            this.TxtMessage.TabIndex = 7;
            // 
            // TxtMessageF
            // 
            this.TxtMessageF.AutoSize = true;
            this.TxtMessageF.Location = new System.Drawing.Point(171, 349);
            this.TxtMessageF.Name = "TxtMessageF";
            this.TxtMessageF.Size = new System.Drawing.Size(0, 13);
            this.TxtMessageF.TabIndex = 8;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(213, 453);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 9;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(294, 453);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 10;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // CreerInventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 498);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.TxtMessageF);
            this.Controls.Add(this.TxtMessage);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewSelectProduit);
            this.Controls.Add(this.comboBoxProduit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "CreerInventaire";
            this.Text = "CreerInventaire";
            this.Load += new System.EventHandler(this.CreerInventaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxProduit;
        private System.Windows.Forms.DataGridView dataGridViewSelectProduit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label TxtMessage;
        private System.Windows.Forms.Label TxtMessageF;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIBELLEPRODUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIXUHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAUXTVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOCKTHEORIQUE;
        private System.Windows.Forms.DataGridViewImageColumn SUPPRESSION;
    }
}