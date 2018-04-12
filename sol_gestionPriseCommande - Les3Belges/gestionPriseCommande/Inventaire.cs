using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les3belges
{
    public class Inventaire
    {
        private int IDINVENTAIRE;
        private string DATEINVENTAIRE;
        private string ETATINVENTAIRE;


        public Inventaire(int unIdInventaire ,string uneDateInventaire,string unEtatInventaire)
        {
           IDINVENTAIRE =unIdInventaire;
            DATEINVENTAIRE=uneDateInventaire;
           ETATINVENTAIRE =unEtatInventaire;

        }
        public int getIdInventaire(){
            return IDINVENTAIRE;
        }
        public string getDateInventaire()
        {
            return DATEINVENTAIRE;
        }
        public string getEtatInventaire()
        {
            return ETATINVENTAIRE;
        }

    }
}
