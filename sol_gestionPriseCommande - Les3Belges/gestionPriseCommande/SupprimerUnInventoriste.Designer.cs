namespace les3belges
{
    partial class SupprimerUnInventoriste
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
            this.comboBoxSuppInventoriste = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Nom = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxComplement = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxNumFix = new System.Windows.Forms.TextBox();
            this.textBoxNumTel = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxSuppInventoriste
            // 
            this.comboBoxSuppInventoriste.FormattingEnabled = true;
            this.comboBoxSuppInventoriste.Location = new System.Drawing.Point(203, 93);
            this.comboBoxSuppInventoriste.Name = "comboBoxSuppInventoriste";
            this.comboBoxSuppInventoriste.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSuppInventoriste.TabIndex = 0;
            this.comboBoxSuppInventoriste.SelectedIndexChanged += new System.EventHandler(this.comboBoxSuppInventoriste_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom Inventoriste :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.label2.Location = new System.Drawing.Point(140, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Suppresion Inventoriste ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(260, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(71, 139);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(35, 13);
            this.Nom.TabIndex = 36;
            this.Nom.Text = "Nom :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Prenom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Adresse :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Complement d\'adresse :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Numero telephone :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Mail :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Numero fixe :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(203, 136);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.ReadOnly = true;
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 43;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(203, 167);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.ReadOnly = true;
            this.textBoxPrenom.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenom.TabIndex = 44;
            // 
            // textBoxComplement
            // 
            this.textBoxComplement.Location = new System.Drawing.Point(203, 225);
            this.textBoxComplement.Name = "textBoxComplement";
            this.textBoxComplement.ReadOnly = true;
            this.textBoxComplement.Size = new System.Drawing.Size(100, 20);
            this.textBoxComplement.TabIndex = 45;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(203, 193);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.ReadOnly = true;
            this.textBoxAdresse.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdresse.TabIndex = 46;
            // 
            // textBoxNumFix
            // 
            this.textBoxNumFix.Location = new System.Drawing.Point(203, 289);
            this.textBoxNumFix.Name = "textBoxNumFix";
            this.textBoxNumFix.ReadOnly = true;
            this.textBoxNumFix.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumFix.TabIndex = 47;
            // 
            // textBoxNumTel
            // 
            this.textBoxNumTel.Location = new System.Drawing.Point(203, 258);
            this.textBoxNumTel.Name = "textBoxNumTel";
            this.textBoxNumTel.ReadOnly = true;
            this.textBoxNumTel.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumTel.TabIndex = 48;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(203, 321);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.ReadOnly = true;
            this.textBoxMail.Size = new System.Drawing.Size(100, 20);
            this.textBoxMail.TabIndex = 49;
            // 
            // SupprimerUnInventoriste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 449);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxNumTel);
            this.Controls.Add(this.textBoxNumFix);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.textBoxComplement);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSuppInventoriste);
            this.Name = "SupprimerUnInventoriste";
            this.Text = "SupprimerUnInventoriste";
            this.Load += new System.EventHandler(this.SupprimerUnInventoriste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSuppInventoriste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxComplement;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxNumFix;
        private System.Windows.Forms.TextBox textBoxNumTel;
        private System.Windows.Forms.TextBox textBoxMail;
    }
}