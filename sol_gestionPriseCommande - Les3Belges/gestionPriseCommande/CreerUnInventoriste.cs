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
    public partial class CreerUnInventoriste : Form
    {
        //variable global
        private Inventoriste linventoriste;
        public CreerUnInventoriste()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int lIdInventosite = Passerelle.getMaxIdInventoriste() + 1;
            string nomInventoriste = textBoxNom.Text;
            string prenomInventoriste = textBoxPrenom.Text;
            string adresseInventoriste = textBoxAdresse.Text;
            string complementInventoriste = textBoxComp.Text;
            string numTelInventoriste = textBoxNumTel.Text;
            string numFixeInventoriste = textBoxNumFixe.Text;
            string mailInventoriste = textBoxMail.Text;
            int IdVille = 1;
            //Inventoriste linventoriste ;
            if ((nomInventoriste != " ") && (prenomInventoriste != " ") && (adresseInventoriste != " ") && (complementInventoriste != " ") && (numTelInventoriste != " ") && (numFixeInventoriste != " ") && (mailInventoriste != " "))
            {

                linventoriste = new Inventoriste(lIdInventosite, nomInventoriste, prenomInventoriste, adresseInventoriste, complementInventoriste, numTelInventoriste, numFixeInventoriste, mailInventoriste,IdVille);



                DialogResult reponse = MessageBox.Show(this, "Êtes-vous sûr de vouloir enregistrer cet inventoriste ?", "Enregistrer Inventoriste", MessageBoxButtons.OKCancel);
                if (reponse == DialogResult.OK)
                {   //création de la commande dans la BDD
                    int InvOk = Passerelle.creerNewInventoriste(linventoriste);
                    if (InvOk == 0)
                    {
                        MessageBox.Show(" Souci sur l'insertion de l'invetoriste");
                    }
                    else
                    {

                    }

                    MessageBox.Show("L'inventoriste a été enregistrée avec succès !");
                    textBoxNom.Text = "";
                    textBoxPrenom.Text = "";
                    textBoxAdresse.Text = "";
                    textBoxComp.Text = "";
                    textBoxNumTel.Text = "";
                    textBoxNumFixe.Text = "";
                    textBoxMail.Text = "";
                }
            }
        }

        private void buttonRAZ_Click(object sender, EventArgs e)
        {
        Controls.Clear();
        InitializeComponent();
        }
    }

 

   

    }

