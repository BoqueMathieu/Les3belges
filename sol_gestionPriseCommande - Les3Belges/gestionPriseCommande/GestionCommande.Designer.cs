namespace les3belges
{
    partial class GestionCommande
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labClient = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTaille = new System.Windows.Forms.Label();
            this.labelCouleur = new System.Windows.Forms.Label();
            this.labelReference = new System.Windows.Forms.Label();
            this.labelPUHT = new System.Windows.Forms.Label();
            this.textBoxReference = new System.Windows.Forms.TextBox();
            this.labelEtat = new System.Windows.Forms.Label();
            this.labelQuantite = new System.Windows.Forms.Label();
            this.buttonRAZ = new System.Windows.Forms.Button();
            this.labelNomProduit = new System.Windows.Forms.Label();
            this.dataGridViewListeProduit = new System.Windows.Forms.DataGridView();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Couleur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supprimer = new System.Windows.Forms.DataGridViewImageColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonValiderCommande = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.buttonValiderProduit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMessageP = new System.Windows.Forms.Label();
            this.textBoxCouleur = new System.Windows.Forms.TextBox();
            this.textBoxQuantite = new System.Windows.Forms.TextBox();
            this.textBoxNomProduit = new System.Windows.Forms.TextBox();
            this.textBoxEtat = new System.Windows.Forms.TextBox();
            this.textBoxTaille = new System.Windows.Forms.TextBox();
            this.textBoxPUHT = new System.Windows.Forms.TextBox();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.labNom = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumCli = new System.Windows.Forms.TextBox();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.textBoxCodePostal = new System.Windows.Forms.TextBox();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.labelCodePostal = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxTva = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTotCde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeProduit)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labClient
            // 
            this.labClient.AutoSize = true;
            this.labClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labClient.Location = new System.Drawing.Point(2, 0);
            this.labClient.Name = "labClient";
            this.labClient.Size = new System.Drawing.Size(57, 24);
            this.labClient.TabIndex = 0;
            this.labClient.Text = "Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Produit";
            // 
            // labelTaille
            // 
            this.labelTaille.AutoSize = true;
            this.labelTaille.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaille.Location = new System.Drawing.Point(326, 41);
            this.labelTaille.Name = "labelTaille";
            this.labelTaille.Size = new System.Drawing.Size(46, 17);
            this.labelTaille.TabIndex = 8;
            this.labelTaille.Text = "Taille ";
            // 
            // labelCouleur
            // 
            this.labelCouleur.AutoSize = true;
            this.labelCouleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCouleur.Location = new System.Drawing.Point(251, 41);
            this.labelCouleur.Name = "labelCouleur";
            this.labelCouleur.Size = new System.Drawing.Size(61, 17);
            this.labelCouleur.TabIndex = 9;
            this.labelCouleur.Text = "Couleur ";
            // 
            // labelReference
            // 
            this.labelReference.AutoSize = true;
            this.labelReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReference.Location = new System.Drawing.Point(32, 41);
            this.labelReference.Name = "labelReference";
            this.labelReference.Size = new System.Drawing.Size(78, 17);
            this.labelReference.TabIndex = 10;
            this.labelReference.Text = "Réference ";
            // 
            // labelPUHT
            // 
            this.labelPUHT.AutoSize = true;
            this.labelPUHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPUHT.Location = new System.Drawing.Point(374, 42);
            this.labelPUHT.Name = "labelPUHT";
            this.labelPUHT.Size = new System.Drawing.Size(35, 17);
            this.labelPUHT.TabIndex = 12;
            this.labelPUHT.Text = "Prix ";
            // 
            // textBoxReference
            // 
            this.textBoxReference.Location = new System.Drawing.Point(33, 64);
            this.textBoxReference.Name = "textBoxReference";
            this.textBoxReference.Size = new System.Drawing.Size(76, 20);
            this.textBoxReference.TabIndex = 14;
            this.textBoxReference.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxReference_KeyDown);
            // 
            // labelEtat
            // 
            this.labelEtat.AutoSize = true;
            this.labelEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEtat.Location = new System.Drawing.Point(516, 42);
            this.labelEtat.Name = "labelEtat";
            this.labelEtat.Size = new System.Drawing.Size(84, 17);
            this.labelEtat.TabIndex = 16;
            this.labelEtat.Text = "Disponibilité";
            // 
            // labelQuantite
            // 
            this.labelQuantite.AutoSize = true;
            this.labelQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantite.Location = new System.Drawing.Point(436, 42);
            this.labelQuantite.Name = "labelQuantite";
            this.labelQuantite.Size = new System.Drawing.Size(62, 17);
            this.labelQuantite.TabIndex = 19;
            this.labelQuantite.Text = "Quantité";
            // 
            // buttonRAZ
            // 
            this.buttonRAZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRAZ.Location = new System.Drawing.Point(892, 62);
            this.buttonRAZ.Name = "buttonRAZ";
            this.buttonRAZ.Size = new System.Drawing.Size(75, 23);
            this.buttonRAZ.TabIndex = 21;
            this.buttonRAZ.Text = "RAZ";
            this.buttonRAZ.UseVisualStyleBackColor = true;
            this.buttonRAZ.Click += new System.EventHandler(this.buttonRAZ_Click);
            // 
            // labelNomProduit
            // 
            this.labelNomProduit.AutoSize = true;
            this.labelNomProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomProduit.Location = new System.Drawing.Point(106, 41);
            this.labelNomProduit.Name = "labelNomProduit";
            this.labelNomProduit.Size = new System.Drawing.Size(87, 17);
            this.labelNomProduit.TabIndex = 24;
            this.labelNomProduit.Text = "Désignation ";
            // 
            // dataGridViewListeProduit
            // 
            this.dataGridViewListeProduit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListeProduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewListeProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListeProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reference,
            this.NomProduit,
            this.Couleur,
            this.taille,
            this.PUHT,
            this.Quantite,
            this.Etat,
            this.Total,
            this.supprimer});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListeProduit.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewListeProduit.Location = new System.Drawing.Point(34, 45);
            this.dataGridViewListeProduit.Name = "dataGridViewListeProduit";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListeProduit.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewListeProduit.Size = new System.Drawing.Size(898, 86);
            this.dataGridViewListeProduit.TabIndex = 28;
            // 
            // Reference
            // 
            this.Reference.HeaderText = "Réference";
            this.Reference.Name = "Reference";
            // 
            // NomProduit
            // 
            this.NomProduit.HeaderText = "Désignation";
            this.NomProduit.Name = "NomProduit";
            this.NomProduit.Width = 200;
            // 
            // Couleur
            // 
            this.Couleur.HeaderText = "Couleur";
            this.Couleur.Name = "Couleur";
            // 
            // taille
            // 
            this.taille.HeaderText = "Taille";
            this.taille.Name = "taille";
            this.taille.Width = 50;
            // 
            // PUHT
            // 
            this.PUHT.HeaderText = "Prix";
            this.PUHT.Name = "PUHT";
            // 
            // Quantite
            // 
            this.Quantite.HeaderText = "Quantité";
            this.Quantite.Name = "Quantite";
            // 
            // Etat
            // 
            this.Etat.HeaderText = "Disponiblité";
            this.Etat.Name = "Etat";
            this.Etat.Width = 150;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // supprimer
            // 
            this.supprimer.HeaderText = "Supprimer";
            this.supprimer.Name = "supprimer";
            this.supprimer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.supprimer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 24);
            this.label16.TabIndex = 29;
            this.label16.Text = "Panier";
            // 
            // buttonValiderCommande
            // 
            this.buttonValiderCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValiderCommande.Location = new System.Drawing.Point(844, 170);
            this.buttonValiderCommande.Name = "buttonValiderCommande";
            this.buttonValiderCommande.Size = new System.Drawing.Size(160, 23);
            this.buttonValiderCommande.TabIndex = 31;
            this.buttonValiderCommande.Text = "Valider Commande";
            this.buttonValiderCommande.UseVisualStyleBackColor = true;
            this.buttonValiderCommande.Click += new System.EventHandler(this.buttonValiderCommande_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitter.Location = new System.Drawing.Point(772, 633);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(239, 29);
            this.buttonQuitter.TabIndex = 32;
            this.buttonQuitter.Text = "Retour MenuPrincipal";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // buttonValiderProduit
            // 
            this.buttonValiderProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValiderProduit.Location = new System.Drawing.Point(768, 61);
            this.buttonValiderProduit.Name = "buttonValiderProduit";
            this.buttonValiderProduit.Size = new System.Drawing.Size(99, 23);
            this.buttonValiderProduit.TabIndex = 15;
            this.buttonValiderProduit.Text = "Valider produit";
            this.buttonValiderProduit.UseVisualStyleBackColor = true;
            this.buttonValiderProduit.Click += new System.EventHandler(this.buttonValiderProduit_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtMessageP);
            this.panel1.Controls.Add(this.textBoxCouleur);
            this.panel1.Controls.Add(this.textBoxQuantite);
            this.panel1.Controls.Add(this.textBoxNomProduit);
            this.panel1.Controls.Add(this.textBoxEtat);
            this.panel1.Controls.Add(this.textBoxTaille);
            this.panel1.Controls.Add(this.textBoxPUHT);
            this.panel1.Controls.Add(this.labelCouleur);
            this.panel1.Controls.Add(this.labelPUHT);
            this.panel1.Controls.Add(this.buttonRAZ);
            this.panel1.Controls.Add(this.labelQuantite);
            this.panel1.Controls.Add(this.buttonValiderProduit);
            this.panel1.Controls.Add(this.labelNomProduit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelEtat);
            this.panel1.Controls.Add(this.labelTaille);
            this.panel1.Controls.Add(this.textBoxReference);
            this.panel1.Controls.Add(this.labelReference);
            this.panel1.Location = new System.Drawing.Point(4, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 130);
            this.panel1.TabIndex = 36;
            // 
            // txtMessageP
            // 
            this.txtMessageP.AutoSize = true;
            this.txtMessageP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageP.Location = new System.Drawing.Point(155, 23);
            this.txtMessageP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtMessageP.Name = "txtMessageP";
            this.txtMessageP.Size = new System.Drawing.Size(12, 17);
            this.txtMessageP.TabIndex = 47;
            this.txtMessageP.Text = " ";
            // 
            // textBoxCouleur
            // 
            this.textBoxCouleur.Location = new System.Drawing.Point(254, 64);
            this.textBoxCouleur.Name = "textBoxCouleur";
            this.textBoxCouleur.ReadOnly = true;
            this.textBoxCouleur.Size = new System.Drawing.Size(76, 20);
            this.textBoxCouleur.TabIndex = 44;
            // 
            // textBoxQuantite
            // 
            this.textBoxQuantite.Location = new System.Drawing.Point(440, 64);
            this.textBoxQuantite.Name = "textBoxQuantite";
            this.textBoxQuantite.Size = new System.Drawing.Size(76, 20);
            this.textBoxQuantite.TabIndex = 41;
            this.textBoxQuantite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxQuantite_KeyDown);
            // 
            // textBoxNomProduit
            // 
            this.textBoxNomProduit.Location = new System.Drawing.Point(105, 64);
            this.textBoxNomProduit.Name = "textBoxNomProduit";
            this.textBoxNomProduit.ReadOnly = true;
            this.textBoxNomProduit.Size = new System.Drawing.Size(151, 20);
            this.textBoxNomProduit.TabIndex = 40;
            // 
            // textBoxEtat
            // 
            this.textBoxEtat.Location = new System.Drawing.Point(512, 64);
            this.textBoxEtat.Name = "textBoxEtat";
            this.textBoxEtat.ReadOnly = true;
            this.textBoxEtat.Size = new System.Drawing.Size(114, 20);
            this.textBoxEtat.TabIndex = 39;
            // 
            // textBoxTaille
            // 
            this.textBoxTaille.Location = new System.Drawing.Point(329, 64);
            this.textBoxTaille.Name = "textBoxTaille";
            this.textBoxTaille.ReadOnly = true;
            this.textBoxTaille.Size = new System.Drawing.Size(38, 20);
            this.textBoxTaille.TabIndex = 38;
            // 
            // textBoxPUHT
            // 
            this.textBoxPUHT.Location = new System.Drawing.Point(366, 64);
            this.textBoxPUHT.Name = "textBoxPUHT";
            this.textBoxPUHT.ReadOnly = true;
            this.textBoxPUHT.Size = new System.Drawing.Size(76, 20);
            this.textBoxPUHT.TabIndex = 37;
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.Location = new System.Drawing.Point(75, 100);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(65, 17);
            this.labelPrenom.TabIndex = 38;
            this.labelPrenom.Text = "Prenom :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Enabled = false;
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(164, 65);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 23);
            this.textBoxNom.TabIndex = 39;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Enabled = false;
            this.textBoxPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrenom.Location = new System.Drawing.Point(164, 98);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(100, 23);
            this.textBoxPrenom.TabIndex = 40;
            // 
            // labNom
            // 
            this.labNom.AutoSize = true;
            this.labNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNom.Location = new System.Drawing.Point(75, 67);
            this.labNom.Name = "labNom";
            this.labNom.Size = new System.Drawing.Size(45, 17);
            this.labNom.TabIndex = 41;
            this.labNom.Text = "Nom :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TxtMessage);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxNumCli);
            this.panel2.Controls.Add(this.textBoxTelephone);
            this.panel2.Controls.Add(this.textBoxCodePostal);
            this.panel2.Controls.Add(this.labelTelephone);
            this.panel2.Controls.Add(this.labelCodePostal);
            this.panel2.Controls.Add(this.labNom);
            this.panel2.Controls.Add(this.textBoxPrenom);
            this.panel2.Controls.Add(this.labelPrenom);
            this.panel2.Controls.Add(this.textBoxNom);
            this.panel2.Controls.Add(this.labClient);
            this.panel2.Location = new System.Drawing.Point(4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 212);
            this.panel2.TabIndex = 42;
            // 
            // TxtMessage
            // 
            this.TxtMessage.AutoSize = true;
            this.TxtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMessage.Location = new System.Drawing.Point(88, 10);
            this.TxtMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TxtMessage.Name = "TxtMessage";
            this.TxtMessage.Size = new System.Drawing.Size(12, 17);
            this.TxtMessage.TabIndex = 46;
            this.TxtMessage.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Numéro :";
            // 
            // textBoxNumCli
            // 
            this.textBoxNumCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumCli.Location = new System.Drawing.Point(164, 37);
            this.textBoxNumCli.Name = "textBoxNumCli";
            this.textBoxNumCli.Size = new System.Drawing.Size(100, 23);
            this.textBoxNumCli.TabIndex = 46;
            this.textBoxNumCli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNumCli_KeyDown);
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Enabled = false;
            this.textBoxTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelephone.Location = new System.Drawing.Point(164, 158);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(100, 23);
            this.textBoxTelephone.TabIndex = 45;
            // 
            // textBoxCodePostal
            // 
            this.textBoxCodePostal.Enabled = false;
            this.textBoxCodePostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodePostal.Location = new System.Drawing.Point(164, 128);
            this.textBoxCodePostal.Name = "textBoxCodePostal";
            this.textBoxCodePostal.Size = new System.Drawing.Size(100, 23);
            this.textBoxCodePostal.TabIndex = 44;
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelephone.Location = new System.Drawing.Point(75, 158);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(84, 17);
            this.labelTelephone.TabIndex = 43;
            this.labelTelephone.Text = "Telephone :";
            // 
            // labelCodePostal
            // 
            this.labelCodePostal.AutoSize = true;
            this.labelCodePostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodePostal.Location = new System.Drawing.Point(75, 131);
            this.labelCodePostal.Name = "labelCodePostal";
            this.labelCodePostal.Size = new System.Drawing.Size(92, 17);
            this.labelCodePostal.TabIndex = 42;
            this.labelCodePostal.Text = "Code Postal :";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBoxTva);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBoxTotCde);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dataGridViewListeProduit);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.buttonValiderCommande);
            this.panel3.Location = new System.Drawing.Point(3, 356);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1008, 247);
            this.panel3.TabIndex = 45;
            // 
            // textBoxTva
            // 
            this.textBoxTva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTva.Location = new System.Drawing.Point(634, 168);
            this.textBoxTva.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTva.Name = "textBoxTva";
            this.textBoxTva.Size = new System.Drawing.Size(72, 23);
            this.textBoxTva.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(564, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "dont TVA";
            // 
            // textBoxTotCde
            // 
            this.textBoxTotCde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotCde.Location = new System.Drawing.Point(634, 136);
            this.textBoxTotCde.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTotCde.Name = "textBoxTotCde";
            this.textBoxTotCde.Size = new System.Drawing.Size(72, 23);
            this.textBoxTotCde.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(556, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Total TTC";
            // 
            // GestionCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 673);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GestionCommande";
            this.Text = "Enregistrement commande client";
            this.Load += new System.EventHandler(this.GestionCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeProduit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTaille;
        private System.Windows.Forms.Label labelCouleur;
        private System.Windows.Forms.Label labelReference;
        private System.Windows.Forms.Label labelPUHT;
        private System.Windows.Forms.TextBox textBoxReference;
        private System.Windows.Forms.Label labelEtat;
        private System.Windows.Forms.Label labelQuantite;
        private System.Windows.Forms.Button buttonRAZ;
        private System.Windows.Forms.Label labelNomProduit;
        private System.Windows.Forms.DataGridView dataGridViewListeProduit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonValiderCommande;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Button buttonValiderProduit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label labNom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.TextBox textBoxCodePostal;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.Label labelCodePostal;
        private System.Windows.Forms.TextBox textBoxQuantite;
        private System.Windows.Forms.TextBox textBoxNomProduit;
        private System.Windows.Forms.TextBox textBoxEtat;
        private System.Windows.Forms.TextBox textBoxTaille;
        private System.Windows.Forms.TextBox textBoxPUHT;
        private System.Windows.Forms.TextBox textBoxCouleur;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumCli;
        private System.Windows.Forms.Label TxtMessage;
        private System.Windows.Forms.Label txtMessageP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Couleur;
        private System.Windows.Forms.DataGridViewTextBoxColumn taille;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewImageColumn supprimer;
        private System.Windows.Forms.TextBox textBoxTva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTotCde;
        private System.Windows.Forms.Label label2;
    }
}

