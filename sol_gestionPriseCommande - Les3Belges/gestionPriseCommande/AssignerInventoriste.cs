using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using les3belges;
using ClassLibraryL3B;
namespace les3belges
{
    public partial class AssignerInventoriste : Form
    {
        int choixInventaire;
        int laLigne;
        List<Inventoriste> lesInventoristes;
        List<Produit> lesProduits;
        List<Inventaire> lesInventaires;
        Participer uneParticipation;
        Produit leProduit;
        string reference;
        string nomProduit;
        public AssignerInventoriste()
        {
            InitializeComponent();
        }

        private void AssignerInventoriste_Load(object sender, EventArgs e)
        {
            txtMessage.ForeColor = System.Drawing.Color.Green;
            txtMessage.Text = "Retirer les inventoristes non concernés";
            txtMessage.Visible = true;
            panelChoixProduit.Visible = false;
            panelChoixInventaire.Visible = false;
            lesInventoristes = Passerelle.getInventoristesDispo();
            foreach (Inventoriste ligneInventoriste in lesInventoristes)
            {
                string[] lignesInventoristes = { ligneInventoriste.getIdInventoriste().ToString() ,ligneInventoriste.getNomInventoriste(), ligneInventoriste.getPrenomInventoriste(), ligneInventoriste.getAdresseInventoriste(), ligneInventoriste.getComplementAdresseInventoriste(), ligneInventoriste.getNumTelInventoriste(), ligneInventoriste.getNumFixeInventoriste(), ligneInventoriste.getMailInventoriste() };
                dataGridViewInventoriste.Rows.Add(lignesInventoristes);
            }

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            txtMessageI.ForeColor = System.Drawing.Color.Green;
            txtMessageI.Text = "Choisir l'inventaire concerné";
            txtMessageI.Visible = true;
            panelChoixInventaire.Visible = true;

                lesInventaires = Passerelle.getLesInventaires();
                foreach (Inventaire unInventaire in lesInventaires)
                {
                   
                    comboBoxInventaire.Items.Add("date:"+ boiteOutil.dateEnDateTime(Int32.Parse(unInventaire.getDateInventaire())));
                }

            

        }

        private void dataGridViewInventoriste_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {

                laLigne = e.RowIndex;
                dataGridViewInventoriste.Rows.RemoveAt(laLigne);
                lesInventoristes.RemoveAt(laLigne);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtMessageI.ForeColor = System.Drawing.Color.Green;
            txtMessageI.Text = "Choisir le produit concerné";
            txtMessageI.Visible = true;
            choixInventaire =comboBoxInventaire.SelectedIndex;
            panelChoixProduit.Visible = true;
            if(lesProduits != null)
            {
                foreach (Produit unProd in lesProduits) {
                    int i = 0;
                    comboBoxProduit.Items.RemoveAt(i);
                    i += 1;
                }
                comboBoxProduit.ResetText();
                
            }
            lesProduits = Passerelle.getLesProduitsParInventaire(choixInventaire);

            foreach (Produit unProduit in lesProduits)
            {
                reference = unProduit.getReference();
                comboBoxProduit.Items.Add(unProduit.getLibelleProduit());
            }

        }

        private void comboBoxProduit_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            nomProduit = comboBoxProduit.SelectedItem.ToString();
            leProduit = Passerelle.getProduitParNom(nomProduit);
            textBoxStockTheo.Text = leProduit.getStockTheorique().ToString();
        }

        private void textBoxStockTheo_TextChanged_1(object sender, EventArgs e)
        {
            nomProduit = comboBoxProduit.SelectedItem.ToString();
            leProduit = Passerelle.getProduitParNom(nomProduit);
            textBoxStockTheo.Text = leProduit.getStockTheorique().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uneReferenceProduit = Passerelle.getRefProduitParNom(comboBoxProduit.SelectedItem.ToString());

            // int idInventaire = Pase

            DialogResult reponse = MessageBox.Show(this, "Êtes-vous sûr de vouloir enregistrer cet inventaire ?", "Enregistrer Inventaire", MessageBoxButtons.OKCancel);
            if (reponse == DialogResult.OK)
            {   //création de la commande dans la BDD
                foreach (DataGridViewRow row in dataGridViewInventoriste.Rows)
                {

                    int idInventoriste = Convert.ToInt32(row.Cells["Idinventoriste"].Value);

                    if (idInventoriste != -1)
                    {

                       uneParticipation = new Participer(choixInventaire, idInventoriste, uneReferenceProduit);
                        int invOk1 = Passerelle.assignerInventoriste(uneParticipation);


                    }

                }


            }


        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < dataGridViewInventoriste.Rows.Count) { 
            dataGridViewInventoriste.Rows.RemoveAt(0) ;
            }
            lesInventoristes = Passerelle.getInventoristesDispo();
            foreach (Inventoriste ligneInventoriste in lesInventoristes)
            {
                string[] lignesInventoristes = { ligneInventoriste.getIdInventoriste().ToString(), ligneInventoriste.getNomInventoriste(), ligneInventoriste.getPrenomInventoriste(), ligneInventoriste.getAdresseInventoriste(), ligneInventoriste.getComplementAdresseInventoriste(), ligneInventoriste.getNumTelInventoriste(), ligneInventoriste.getNumFixeInventoriste(), ligneInventoriste.getMailInventoriste() };
                dataGridViewInventoriste.Rows.Add(lignesInventoristes);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
