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
    public partial class PrimeInventoriste : Form
    {
        List<Inventoriste> lesInventoristes;
        Ville laVille;
        public PrimeInventoriste()
        {
            InitializeComponent();
        }

        private void PrimeInventoriste_Load(object sender, EventArgs e)
        {
            lesInventoristes = Passerelle.getLesInventoristesPrimes();
            foreach (Inventoriste ligneInventoriste in lesInventoristes)
            {
                int id =ligneInventoriste.getIdVille();
                laVille = Passerelle.getLaVille(id);

                string[] lignesInventoristes = { ligneInventoriste.getIdInventoriste().ToString(), ligneInventoriste.getNomInventoriste(), ligneInventoriste.getPrenomInventoriste(), laVille.getNomVille() , laVille.getPrimeVille().ToString() };
                dataGridView1.Rows.Add(lignesInventoristes);
               
            }
        }
    }
}
