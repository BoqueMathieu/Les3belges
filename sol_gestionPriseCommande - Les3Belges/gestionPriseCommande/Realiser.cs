using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les3belges
{
    class Realiser
    {
        private int IDINVENTAIRE;
        private string REFERENCEPROD;
        private int QTEPRODUIT;

        public Realiser(int unIdVentaire, string uneRefProd, int uneQteProd)
        {
            IDINVENTAIRE = unIdVentaire;
            REFERENCEPROD = uneRefProd;
            QTEPRODUIT = uneQteProd;
        }
        public int getIdiNventaire()
        {
            return IDINVENTAIRE;
        }
        public string getReferenceProd()
        {
            return REFERENCEPROD;
        }
        public int getQteProduit()
        {
            return QTEPRODUIT;
        }
    }
}
