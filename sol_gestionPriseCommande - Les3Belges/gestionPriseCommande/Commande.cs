using System;
using System.Collections.Generic;

namespace les3belges
{
    public class Commande
    {
        //Propriétées
        private int numCommande;
        private DateTime dateCommande;
        private double montantCommandeHT;
        private string statutCommande;
        private double montantCommandeTTC;
        private Client leClient;
        private List<LigneCommandeClient> lesLignes;
        //Méthodes
        public Commande(int unNumCommande, DateTime uneDateCommande, double unMontantCommandeHT, string unStatutCommande, double unmontantCommandeTTC, Client unClient)
        {
            numCommande = unNumCommande;
            dateCommande = uneDateCommande;
            montantCommandeHT = unMontantCommandeHT;
            statutCommande = unStatutCommande;
            montantCommandeTTC = unmontantCommandeTTC;
            leClient = unClient;
            lesLignes = new List<LigneCommandeClient>();
        }
        public Commande(Client unClient)
        {
            dateCommande = DateTime.Now;
            statutCommande = "attente";
            montantCommandeHT = 0;
            leClient = unClient;
            lesLignes = new List<LigneCommandeClient>();
        }
        public void ajouterUneLigneCommande(LigneCommandeClient uneLigne)
        {
            lesLignes.Add(uneLigne);
        }
        public void setNumCde(int unNum)
        { numCommande=unNum;}
        public List<LigneCommandeClient> getLesLignes()
        {   return lesLignes;         }
        public int getNumCommande()
        {   return numCommande;       }
        public DateTime getDateCommande()
        {   return dateCommande;      }
        public double getMontantCommandeHT()
        {
            return montantCommandeHT;
        }
        public string getStatutCommande()
        {
            return statutCommande;
        }
        public double getMontantCommandeTTC()
        {
            return montantCommandeTTC;
        }
        public void setMontantCommandeTTC(double unMontant)
        {
            montantCommandeTTC = unMontant;
        }
        public Client getLeClient()
        {
            return leClient;
        }
        public void setMontantHT(double unMontantHT)
        {
            this.montantCommandeHT = unMontantHT;
        }
    }
}
