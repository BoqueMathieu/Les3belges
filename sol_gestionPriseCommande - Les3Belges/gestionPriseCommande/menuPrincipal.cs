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
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void saisirUneCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionCommande frmgestCom = new GestionCommande();
            frmgestCom.ShowDialog();
        }

        private void créerUnFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreerUnInventoriste frmgestFour = new CreerUnInventoriste();
            frmgestFour.ShowDialog();
        }

        private void modifiserUnFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierInformationsInventoriste frmgestFour = new ModifierInformationsInventoriste();
            frmgestFour.ShowDialog();
        }

        private void supprimerUnFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerUnInventoriste frmgestFour = new SupprimerUnInventoriste();
            frmgestFour.ShowDialog();
        }

        private void menuPrincipal_Load_1(object sender, EventArgs e)
        {
            if (Passerelle.connectBase() == false)
            {
                MessageBox.Show("Souci connexion BDD");
            }
         
        }



        private void assignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignerInventoriste frgAssignInvent = new AssignerInventoriste();
            frgAssignInvent.ShowDialog();
        }

        private void créerInventaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreerInventaire frgCreerInv = new CreerInventaire();
            frgCreerInv.ShowDialog();
        }

        private void primeInventoristeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrimeInventoriste frgPrimInv = new PrimeInventoriste();
            frgPrimInv.ShowDialog();
        }

        private void primeInventoristeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
    
        }
    }}