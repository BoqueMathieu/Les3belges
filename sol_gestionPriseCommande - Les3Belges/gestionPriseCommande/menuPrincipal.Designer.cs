namespace les3belges
{
    partial class menuPrincipal
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandesClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisirUneCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherUnClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierCoordonnéesClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerUnFournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifiserUnFournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnFournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerInventaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primeInventoristeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.commandesClientToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.produitToolStripMenuItem,
            this.fournisseurToolStripMenuItem,
            this.inventaireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(674, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(80, 28);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(135, 28);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // commandesClientToolStripMenuItem
            // 
            this.commandesClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saisirUneCommandeToolStripMenuItem});
            this.commandesClientToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandesClientToolStripMenuItem.Name = "commandesClientToolStripMenuItem";
            this.commandesClientToolStripMenuItem.Size = new System.Drawing.Size(182, 28);
            this.commandesClientToolStripMenuItem.Text = "Commandes Client";
            // 
            // saisirUneCommandeToolStripMenuItem
            // 
            this.saisirUneCommandeToolStripMenuItem.Name = "saisirUneCommandeToolStripMenuItem";
            this.saisirUneCommandeToolStripMenuItem.Size = new System.Drawing.Size(269, 28);
            this.saisirUneCommandeToolStripMenuItem.Text = "Saisir une commande ";
            this.saisirUneCommandeToolStripMenuItem.Click += new System.EventHandler(this.saisirUneCommandeToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechercherUnClientToolStripMenuItem,
            this.nouveauClientToolStripMenuItem,
            this.modifierCoordonnéesClientToolStripMenuItem});
            this.clientsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(78, 28);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // rechercherUnClientToolStripMenuItem
            // 
            this.rechercherUnClientToolStripMenuItem.Name = "rechercherUnClientToolStripMenuItem";
            this.rechercherUnClientToolStripMenuItem.Size = new System.Drawing.Size(314, 28);
            this.rechercherUnClientToolStripMenuItem.Text = "Rechercher un client";
            // 
            // nouveauClientToolStripMenuItem
            // 
            this.nouveauClientToolStripMenuItem.Name = "nouveauClientToolStripMenuItem";
            this.nouveauClientToolStripMenuItem.Size = new System.Drawing.Size(314, 28);
            this.nouveauClientToolStripMenuItem.Text = "Nouveau client";
            // 
            // modifierCoordonnéesClientToolStripMenuItem
            // 
            this.modifierCoordonnéesClientToolStripMenuItem.Name = "modifierCoordonnéesClientToolStripMenuItem";
            this.modifierCoordonnéesClientToolStripMenuItem.Size = new System.Drawing.Size(314, 28);
            this.modifierCoordonnéesClientToolStripMenuItem.Text = "Modifier coordonnées client";
            // 
            // produitToolStripMenuItem
            // 
            this.produitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechercherProduitToolStripMenuItem});
            this.produitToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produitToolStripMenuItem.Name = "produitToolStripMenuItem";
            this.produitToolStripMenuItem.Size = new System.Drawing.Size(81, 28);
            this.produitToolStripMenuItem.Text = "Produit";
            // 
            // rechercherProduitToolStripMenuItem
            // 
            this.rechercherProduitToolStripMenuItem.Name = "rechercherProduitToolStripMenuItem";
            this.rechercherProduitToolStripMenuItem.Size = new System.Drawing.Size(243, 28);
            this.rechercherProduitToolStripMenuItem.Text = "Rechercher produit";
            // 
            // fournisseurToolStripMenuItem
            // 
            this.fournisseurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerUnFournisseurToolStripMenuItem,
            this.modifiserUnFournisseurToolStripMenuItem,
            this.supprimerUnFournisseurToolStripMenuItem,
            this.primeInventoristeToolStripMenuItem});
            this.fournisseurToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.fournisseurToolStripMenuItem.Name = "fournisseurToolStripMenuItem";
            this.fournisseurToolStripMenuItem.Size = new System.Drawing.Size(117, 28);
            this.fournisseurToolStripMenuItem.Text = "Inventoriste";
            // 
            // créerUnFournisseurToolStripMenuItem
            // 
            this.créerUnFournisseurToolStripMenuItem.Name = "créerUnFournisseurToolStripMenuItem";
            this.créerUnFournisseurToolStripMenuItem.Size = new System.Drawing.Size(358, 28);
            this.créerUnFournisseurToolStripMenuItem.Text = "Créer un inventoriste";
            this.créerUnFournisseurToolStripMenuItem.Click += new System.EventHandler(this.créerUnFournisseurToolStripMenuItem_Click);
            // 
            // modifiserUnFournisseurToolStripMenuItem
            // 
            this.modifiserUnFournisseurToolStripMenuItem.Name = "modifiserUnFournisseurToolStripMenuItem";
            this.modifiserUnFournisseurToolStripMenuItem.Size = new System.Drawing.Size(358, 28);
            this.modifiserUnFournisseurToolStripMenuItem.Text = "Modifier informations inventoriste ";
            this.modifiserUnFournisseurToolStripMenuItem.Click += new System.EventHandler(this.modifiserUnFournisseurToolStripMenuItem_Click);
            // 
            // supprimerUnFournisseurToolStripMenuItem
            // 
            this.supprimerUnFournisseurToolStripMenuItem.Name = "supprimerUnFournisseurToolStripMenuItem";
            this.supprimerUnFournisseurToolStripMenuItem.Size = new System.Drawing.Size(358, 28);
            this.supprimerUnFournisseurToolStripMenuItem.Text = "Supprimer un inventoriste";
            this.supprimerUnFournisseurToolStripMenuItem.Click += new System.EventHandler(this.supprimerUnFournisseurToolStripMenuItem_Click);
            // 
            // inventaireToolStripMenuItem
            // 
            this.inventaireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerInventaireToolStripMenuItem,
            this.assignToolStripMenuItem});
            this.inventaireToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.inventaireToolStripMenuItem.Name = "inventaireToolStripMenuItem";
            this.inventaireToolStripMenuItem.Size = new System.Drawing.Size(103, 28);
            this.inventaireToolStripMenuItem.Text = "Inventaire";
            // 
            // créerInventaireToolStripMenuItem
            // 
            this.créerInventaireToolStripMenuItem.Name = "créerInventaireToolStripMenuItem";
            this.créerInventaireToolStripMenuItem.Size = new System.Drawing.Size(282, 28);
            this.créerInventaireToolStripMenuItem.Text = "Créer Inventaire";
            this.créerInventaireToolStripMenuItem.Click += new System.EventHandler(this.créerInventaireToolStripMenuItem_Click);
            // 
            // assignToolStripMenuItem
            // 
            this.assignToolStripMenuItem.Name = "assignToolStripMenuItem";
            this.assignToolStripMenuItem.Size = new System.Drawing.Size(282, 28);
            this.assignToolStripMenuItem.Text = "Assignation  Inventoriste";
            this.assignToolStripMenuItem.Click += new System.EventHandler(this.assignToolStripMenuItem_Click);
            // 
            // primeInventoristeToolStripMenuItem
            // 
            this.primeInventoristeToolStripMenuItem.Name = "primeInventoristeToolStripMenuItem";
            this.primeInventoristeToolStripMenuItem.Size = new System.Drawing.Size(358, 28);
            this.primeInventoristeToolStripMenuItem.Text = "Prime Inventoriste";
            this.primeInventoristeToolStripMenuItem.Click += new System.EventHandler(this.primeInventoristeToolStripMenuItem_Click);
            // 
            // menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 400);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "menuPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.menuPrincipal_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandesClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisirUneCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherUnClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierCoordonnéesClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerUnFournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnFournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifiserUnFournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerInventaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primeInventoristeToolStripMenuItem;
    }
}