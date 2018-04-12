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
    public partial class ModifierInformationsInventoriste : Form
    {
        private Inventoriste linventoriste;
        public ModifierInformationsInventoriste()
        {
            InitializeComponent();
        }

        private void ModifierInformationsInventoriste_Load(object sender, EventArgs e)
        {
            List<Inventoriste> lesInventoriste;
            lesInventoriste = Passerelle.getLesInventoristes();
            foreach (Inventoriste unInv in lesInventoriste)
            {
                comboBoxInventoristes.Items.Add(unInv.getNomInventoriste());
            }
        }



        private void comboBoxInventoristes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxInventoristes.SelectedIndex;
            textBoxNom.Text = Passerelle.getLesInventoristes()[index].getNomInventoriste();
            textBoxPrenom.Text = Passerelle.getLesInventoristes()[index].getPrenomInventoriste();
            textBoxAdresse.Text = Passerelle.getLesInventoristes()[index].getAdresseInventoriste();
            textBoxComplement.Text = Passerelle.getLesInventoristes()[index].getComplementAdresseInventoriste();
            textBoxNumTel.Text = Passerelle.getLesInventoristes()[index].getNumTelInventoriste();
            textBoxNumFix.Text = Passerelle.getLesInventoristes()[index].getNumFixeInventoriste();
            textBoxMail.Text = Passerelle.getLesInventoristes()[index].getMailInventoriste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = comboBoxInventoristes.SelectedIndex;
            int lIdInventosite = Passerelle.getLesInventoristes()[index].getIdInventoriste();
            string nomInventoriste = textBoxNom.Text;
            string prenomInventoriste = textBoxPrenom.Text;
            string adresseInventoriste = textBoxAdresse.Text;
            string complementInventoriste = textBoxComplement.Text;
            string numTelInventoriste = textBoxNumTel.Text;
            string numFixeInventoriste = textBoxNumFix.Text;
            string mailInventoriste = textBoxMail.Text;
            int IdVille = 1;
            linventoriste = new Inventoriste(lIdInventosite, nomInventoriste, prenomInventoriste, adresseInventoriste, complementInventoriste, numTelInventoriste, numFixeInventoriste, mailInventoriste,IdVille);
                DialogResult reponse = MessageBox.Show(this, "Êtes-vous sûr de vouloir enregistrer cet inventoriste ?", "Enregistrer Inventoriste", MessageBoxButtons.OKCancel);
                if (reponse == DialogResult.OK)
                {   //création de la commande dans la BDD
                    Passerelle.majInfosInventoriste(linventoriste);
                    MessageBox.Show("L'inventoriste a été enregistrée avec succès !");
                    comboBoxInventoristes.Text = "" ;
                    textBoxNom.Text = "";
                    textBoxPrenom.Text = "";
                    textBoxAdresse.Text = "";
                    textBoxComplement.Text = "";
                    textBoxNumTel.Text = "";
                    textBoxNumFix.Text = "";
                    textBoxMail.Text = "";
                }
                else{
                    MessageBox.Show(" Souci sur l'insertion de l'invetoriste");
                }   
                }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }





    }



