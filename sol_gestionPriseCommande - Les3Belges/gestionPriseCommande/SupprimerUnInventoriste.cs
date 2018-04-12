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
    public partial class SupprimerUnInventoriste : Form
    {
        private Inventoriste linventoriste; 
        public SupprimerUnInventoriste()
        {
            InitializeComponent();
        }
        private void SupprimerUnInventoriste_Load(object sender, EventArgs e)
        {
            List<Inventoriste> lesInventoriste;
            lesInventoriste = Passerelle.getLesInventoristes();
            foreach (Inventoriste unInv in lesInventoriste)
            {
                comboBoxSuppInventoriste.Items.Add(unInv.getNomInventoriste());
            }
        }
        private void comboBoxSuppInventoriste_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxSuppInventoriste.SelectedIndex;
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
            int index = comboBoxSuppInventoriste.SelectedIndex;
            int lIdInventosite = Passerelle.getLesInventoristes()[index].getIdInventoriste();
            DialogResult reponse = MessageBox.Show(this, "Êtes-vous sûr de vouloir enregistrer cet inventoriste ?", "Enregistrer Inventoriste", MessageBoxButtons.OKCancel);
            if (reponse == DialogResult.OK)
            {   //suppresion de l'inventoriste dans la BDD
                Passerelle.suppInventoriste(lIdInventosite);
                MessageBox.Show("L'inventoriste a été enregistrée avec succès !");
            }
            else
            {
                MessageBox.Show(" Souci sur l'insertion de l'invetoriste");
                comboBoxSuppInventoriste.Text = "";
                textBoxNom.Text = "";
                textBoxPrenom.Text = "";
                textBoxAdresse.Text = "";
                textBoxComplement.Text = "";
                textBoxNumTel.Text = "";
                textBoxNumFix.Text = "";
                textBoxMail.Text = "";
            } 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
