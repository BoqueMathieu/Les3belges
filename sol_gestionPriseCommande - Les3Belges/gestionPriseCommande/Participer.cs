using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les3belges
{
    public class Participer
    {
        private int IDINVENTAIRE;
        private int IDINVENTORISTE;
        private string REFERENCEPROD;

        public Participer(int unIdInventaire, int unIdInventoriste,string uneReferenceProduit)
        {
           IDINVENTAIRE  = unIdInventaire;
           IDINVENTORISTE = unIdInventoriste;
            REFERENCEPROD = uneReferenceProduit;
        }
        public int getIdInventaire()
        {
            return IDINVENTAIRE;
        }
        public int getIdinventoriste()
        {
            return IDINVENTORISTE;
        }
        public string getReferenceProduit()
        {
            return REFERENCEPROD;
        }
    }
}
