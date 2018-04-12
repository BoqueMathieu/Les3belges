namespace les3belges
{
    partial class AssignerInventoriste
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
            this.dataGridViewInventoriste = new System.Windows.Forms.DataGridView();
            this.Idinventoriste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomInventoriste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomInventoriste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseInventoriste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complementAdresseInventoriste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTelInventoriste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numFixeInventoriste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailInventoriste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supression = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.panelChoixInventoriste = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.Label();
            this.panelChoixProduit = new System.Windows.Forms.Panel();
            this.txtMessageP = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxStockTheo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxProduit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelChoixInventaire = new System.Windows.Forms.Panel();
            this.txtMessageI = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelInventaire = new System.Windows.Forms.Label();
            this.comboBoxInventaire = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventoriste)).BeginInit();
            this.panelChoixInventoriste.SuspendLayout();
            this.panelChoixProduit.SuspendLayout();
            this.panelChoixInventaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewInventoriste
            // 
            this.dataGridViewInventoriste.AllowUserToAddRows = false;
            this.dataGridViewInventoriste.AllowUserToOrderColumns = true;
            this.dataGridViewInventoriste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventoriste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idinventoriste,
            this.nomInventoriste,
            this.prenomInventoriste,
            this.adresseInventoriste,
            this.complementAdresseInventoriste,
            this.numTelInventoriste,
            this.numFixeInventoriste,
            this.mailInventoriste,
            this.Supression});
            this.dataGridViewInventoriste.Location = new System.Drawing.Point(3, 56);
            this.dataGridViewInventoriste.Name = "dataGridViewInventoriste";
            this.dataGridViewInventoriste.Size = new System.Drawing.Size(935, 114);
            this.dataGridViewInventoriste.TabIndex = 0;
            this.dataGridViewInventoriste.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInventoriste_CellClick);
            // 
            // Idinventoriste
            // 
            this.Idinventoriste.HeaderText = "Id Inventoriste";
            this.Idinventoriste.Name = "Idinventoriste";
            // 
            // nomInventoriste
            // 
            this.nomInventoriste.HeaderText = "Nom Inventoriste";
            this.nomInventoriste.Name = "nomInventoriste";
            // 
            // prenomInventoriste
            // 
            this.prenomInventoriste.HeaderText = "Prenom Inventoriste";
            this.prenomInventoriste.Name = "prenomInventoriste";
            // 
            // adresseInventoriste
            // 
            this.adresseInventoriste.HeaderText = "Adresse Inventoriste";
            this.adresseInventoriste.Name = "adresseInventoriste";
            // 
            // complementAdresseInventoriste
            // 
            this.complementAdresseInventoriste.HeaderText = "Complement Adresse";
            this.complementAdresseInventoriste.Name = "complementAdresseInventoriste";
            // 
            // numTelInventoriste
            // 
            this.numTelInventoriste.HeaderText = "Numero Telephone";
            this.numTelInventoriste.Name = "numTelInventoriste";
            // 
            // numFixeInventoriste
            // 
            this.numFixeInventoriste.HeaderText = "Numero fixe";
            this.numFixeInventoriste.Name = "numFixeInventoriste";
            // 
            // mailInventoriste
            // 
            this.mailInventoriste.HeaderText = "Mail Inventoriste";
            this.mailInventoriste.Name = "mailInventoriste";
            // 
            // Supression
            // 
            this.Supression.HeaderText = "Suppression";
            this.Supression.Image = global::les3belges.Properties.Resources.Poubelle3;
            this.Supression.Name = "Supression";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assignation d\'inventoriste";
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(775, 176);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 2;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(856, 176);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 3;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // panelChoixInventoriste
            // 
            this.panelChoixInventoriste.Controls.Add(this.txtMessage);
            this.panelChoixInventoriste.Controls.Add(this.buttonValider);
            this.panelChoixInventoriste.Controls.Add(this.buttonAnnuler);
            this.panelChoixInventoriste.Controls.Add(this.dataGridViewInventoriste);
            this.panelChoixInventoriste.Location = new System.Drawing.Point(-1, 115);
            this.panelChoixInventoriste.Name = "panelChoixInventoriste";
            this.panelChoixInventoriste.Size = new System.Drawing.Size(947, 213);
            this.panelChoixInventoriste.TabIndex = 4;
            // 
            // txtMessage
            // 
            this.txtMessage.AutoSize = true;
            this.txtMessage.Location = new System.Drawing.Point(322, 17);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(0, 13);
            this.txtMessage.TabIndex = 4;
            // 
            // panelChoixProduit
            // 
            this.panelChoixProduit.Controls.Add(this.txtMessageP);
            this.panelChoixProduit.Controls.Add(this.label5);
            this.panelChoixProduit.Controls.Add(this.textBoxStockTheo);
            this.panelChoixProduit.Controls.Add(this.label3);
            this.panelChoixProduit.Controls.Add(this.button1);
            this.panelChoixProduit.Controls.Add(this.button2);
            this.panelChoixProduit.Controls.Add(this.comboBoxProduit);
            this.panelChoixProduit.Controls.Add(this.label2);
            this.panelChoixProduit.Location = new System.Drawing.Point(502, 334);
            this.panelChoixProduit.Name = "panelChoixProduit";
            this.panelChoixProduit.Size = new System.Drawing.Size(434, 196);
            this.panelChoixProduit.TabIndex = 5;
            // 
            // txtMessageP
            // 
            this.txtMessageP.AutoSize = true;
            this.txtMessageP.Location = new System.Drawing.Point(156, 66);
            this.txtMessageP.Name = "txtMessageP";
            this.txtMessageP.Size = new System.Drawing.Size(0, 13);
            this.txtMessageP.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Choix Produit";
            // 
            // textBoxStockTheo
            // 
            this.textBoxStockTheo.Location = new System.Drawing.Point(307, 84);
            this.textBoxStockTheo.Name = "textBoxStockTheo";
            this.textBoxStockTheo.ReadOnly = true;
            this.textBoxStockTheo.Size = new System.Drawing.Size(100, 20);
            this.textBoxStockTheo.TabIndex = 7;
            this.textBoxStockTheo.TextChanged += new System.EventHandler(this.textBoxStockTheo_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stock Theorique :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Retour";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxProduit
            // 
            this.comboBoxProduit.FormattingEnabled = true;
            this.comboBoxProduit.Location = new System.Drawing.Point(82, 88);
            this.comboBoxProduit.Name = "comboBoxProduit";
            this.comboBoxProduit.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProduit.TabIndex = 1;
            this.comboBoxProduit.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduit_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Produit :";
            // 
            // panelChoixInventaire
            // 
            this.panelChoixInventaire.Controls.Add(this.txtMessageI);
            this.panelChoixInventaire.Controls.Add(this.label4);
            this.panelChoixInventaire.Controls.Add(this.labelInventaire);
            this.panelChoixInventaire.Controls.Add(this.comboBoxInventaire);
            this.panelChoixInventaire.Controls.Add(this.button3);
            this.panelChoixInventaire.Location = new System.Drawing.Point(64, 334);
            this.panelChoixInventaire.Name = "panelChoixInventaire";
            this.panelChoixInventaire.Size = new System.Drawing.Size(373, 196);
            this.panelChoixInventaire.TabIndex = 7;
            // 
            // txtMessageI
            // 
            this.txtMessageI.AutoSize = true;
            this.txtMessageI.Location = new System.Drawing.Point(103, 66);
            this.txtMessageI.Name = "txtMessageI";
            this.txtMessageI.Size = new System.Drawing.Size(0, 13);
            this.txtMessageI.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Choix Inventaire";
            // 
            // labelInventaire
            // 
            this.labelInventaire.AutoSize = true;
            this.labelInventaire.Location = new System.Drawing.Point(76, 95);
            this.labelInventaire.Name = "labelInventaire";
            this.labelInventaire.Size = new System.Drawing.Size(60, 13);
            this.labelInventaire.TabIndex = 9;
            this.labelInventaire.Text = "Inventaire :";
            // 
            // comboBoxInventaire
            // 
            this.comboBoxInventaire.FormattingEnabled = true;
            this.comboBoxInventaire.Location = new System.Drawing.Point(142, 92);
            this.comboBoxInventaire.Name = "comboBoxInventaire";
            this.comboBoxInventaire.Size = new System.Drawing.Size(156, 21);
            this.comboBoxInventaire.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(162, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Valider";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AssignerInventoriste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 555);
            this.Controls.Add(this.panelChoixInventaire);
            this.Controls.Add(this.panelChoixProduit);
            this.Controls.Add(this.panelChoixInventoriste);
            this.Controls.Add(this.label1);
            this.Name = "AssignerInventoriste";
            this.Text = "AssignerInventoriste";
            this.Load += new System.EventHandler(this.AssignerInventoriste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventoriste)).EndInit();
            this.panelChoixInventoriste.ResumeLayout(false);
            this.panelChoixInventoriste.PerformLayout();
            this.panelChoixProduit.ResumeLayout(false);
            this.panelChoixProduit.PerformLayout();
            this.panelChoixInventaire.ResumeLayout(false);
            this.panelChoixInventaire.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInventoriste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Panel panelChoixInventoriste;
        private System.Windows.Forms.Panel panelChoixProduit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxProduit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStockTheo;
        private System.Windows.Forms.Panel panelChoixInventaire;
        private System.Windows.Forms.Label labelInventaire;
        private System.Windows.Forms.ComboBox comboBoxInventaire;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idinventoriste;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomInventoriste;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomInventoriste;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseInventoriste;
        private System.Windows.Forms.DataGridViewTextBoxColumn complementAdresseInventoriste;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTelInventoriste;
        private System.Windows.Forms.DataGridViewTextBoxColumn numFixeInventoriste;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailInventoriste;
        private System.Windows.Forms.DataGridViewImageColumn Supression;
        private System.Windows.Forms.Label txtMessage;
        private System.Windows.Forms.Label txtMessageP;
        private System.Windows.Forms.Label txtMessageI;
    }
}