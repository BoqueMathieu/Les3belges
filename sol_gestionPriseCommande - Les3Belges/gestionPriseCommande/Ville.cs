using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les3belges
{
    public class Ville
    {
        private int idVille;
        private string nomVille;
        private int primeVille;
        
        //constructeur
        public Ville(int unIdVille, string unNomVille, int unePrimeVille)
        {
            idVille = unIdVille;
            nomVille = unNomVille;
            primeVille = unePrimeVille;
        }
        //guetteurs
        public int getIdVille()
        {
            return idVille;
        }
        public string getNomVille()
        {
            return nomVille;
        }
        public int getPrimeVille()
        {
            return primeVille;
        }

    }
}
