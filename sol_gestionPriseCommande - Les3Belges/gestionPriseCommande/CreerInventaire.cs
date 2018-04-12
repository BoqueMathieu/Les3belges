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
    public partial class CreerInventaire : Form
    {
        int index;
        int laLigne;
        int maxIdInventaire;
        List<Produit> lesProduits;
        int invOk;
        int invOk1;
        string refProduit;
       // List<string>produitFinaux;

        public CreerInventaire()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            int index = comboBoxProduit.SelectedIndex;
            string refProd = Passerelle.getLesProduits()[index].getReference();
            string libelle = Passerelle.getLesProduits()[index].getLibelleProduit();
            double prix = Passerelle.getLesProduits()[index].getPrixUHTProduit();
            int stockTheo = Passerelle.getLesProduits()[index].getStockTheorique();
            double tauxTva = Passerelle.getLesProduits()[index].getTauxTVA();
            string[] lesProduitsSelect = { refProd,libelle, prix.ToString(),tauxTva.ToString(),stockTheo.ToString()};
            dataGridViewSelectProduit.Rows.Add(lesProduitsSelect);
            TxtMessageF.ForeColor = System.Drawing.Color.Green;
            TxtMessageF.Text = "Choisir la date de l'inventaire";
            TxtMessageF.Visible = true;
            labelDate.Visible = true;
            dateTimePicker1.Visible = true;
            
        }

        private void CreerInventaire_Load(object sender, EventArgs e)
        {
            maxIdInventaire = Passerelle.getMaxIdInventaire()+1;
            TxtMessage.ForeColor = System.Drawing.Color.Green;
            TxtMessage.Text = "Choisir les Produits concernés par l'inventaire";
            TxtMessage.Visible = true;
            lesProduits = Passerelle.getLesProduits();
            foreach (Produit unProd in lesProduits)
            {
                comboBoxProduit.Items.Add(unProd.getLibelleProduit());
            }

            labelDate.Visible = false;
            dateTimePicker1.Visible = false;
        }

        private void dataGridViewSelectProduit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {

                laLigne = e.RowIndex;
                dataGridViewSelectProduit.Rows.RemoveAt(laLigne);
                //lesLignes.Add(laLigne);
                

            }
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            // int idInventaire = Pase
            int nbrTotal = dataGridViewSelectProduit.RowCount;
            DialogResult reponse = MessageBox.Show(this, "Êtes-vous sûr de vouloir enregistrer cet inventaire ?", "Enregistrer Inventaire", MessageBoxButtons.OKCancel);
            if (reponse == DialogResult.OK)
            {   //création de la commande dans la BDD
                string dateReapro = boiteOutil.dateEnNum(dateTimePicker1.Value).ToString();
                invOk = Passerelle.creerNewInventaire(maxIdInventaire, dateReapro);
                foreach (DataGridViewRow row in dataGridViewSelectProduit.Rows)
                {

                        refProduit = row.Cells["refProduit"].Value.ToString();

                    if (refProduit != null)
                    {
                        invOk1 = Passerelle.creerNewInventaireSuite(maxIdInventaire, refProduit);
                        
                           
                    }

                }
                

            }

            maxIdInventaire = Passerelle.getMaxIdInventaire() + 1;

        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }






    }

