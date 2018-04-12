using System;


namespace les3belges
{
    public class Inventoriste
    {
        private int idInventoriste;
        private string nomInventoriste;
        private string prenomInventoriste;
        private string adresseInventoriste;
        private string complementAdresseInventoriste;
        private string numTelInventoriste;
        private string numFixeInventoriste;
        private string mailInventoriste;
        private int idVille;
 
        public Inventoriste(int unIdInventoriste, string unNomInventoriste, string unPrenomInventoriste,string uneAdresseInventoriste,string unComplementAdresseInventoriste,string unNumtelInventoriste, string unNumFixeInventoriste,string unMailInventoriste,int unIdVille){
            idInventoriste = unIdInventoriste;

            nomInventoriste = unNomInventoriste;

            prenomInventoriste = unPrenomInventoriste;

            adresseInventoriste = uneAdresseInventoriste;

            complementAdresseInventoriste = unComplementAdresseInventoriste;

            numTelInventoriste = unNumtelInventoriste;

            numFixeInventoriste = unNumFixeInventoriste;

            mailInventoriste = unMailInventoriste;
            
            idVille = unIdVille;
    }
        public int getIdInventoriste()
        {
            return idInventoriste;
        }
        public string getNomInventoriste()
        {
            return nomInventoriste;
        }
        public string getPrenomInventoriste()
        {
            return prenomInventoriste;
        }
        public string getAdresseInventoriste()
        {
            return adresseInventoriste;
        }
        public string getComplementAdresseInventoriste()
        {
            return complementAdresseInventoriste;
        }
        public string getNumTelInventoriste()
        {
            if (numTelInventoriste.Length == 9)
            { numTelInventoriste = "0" + numTelInventoriste; }
            return numTelInventoriste;
        }
        public string getNumFixeInventoriste()
        {
            if (numFixeInventoriste.Length == 9)
            { numFixeInventoriste = "0" + numFixeInventoriste; }
            return numFixeInventoriste;
        }
        public string getMailInventoriste()
        {
            return mailInventoriste;
        }
        public int getIdVille()
        {
            return idVille;
        }
    }
}