using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess;
using ProjLibraryClassReq;
using System.Data;
using les3belges;


namespace ClassLibraryL3B
{
    public class Passerelle
    {
        public static int DAOAutre(string requeteAutre)
        {
            int resultat;
            if (ClassReq.RetConnOk() == true)
            {
                ClassReq maClassReq = new ClassReq(requeteAutre);
                resultat = maClassReq.ExecuteIUD();
            }
            else
            {
                resultat = -1;
            }
            return resultat;
        }
        /// <summary>
        ///  Connection à la base, positionnement sur la base de données
        /// </summary>
        /// <returns>retourne true si bien passé</returns>
        public static bool connectBase()
        { 
            bool ok ;
            ClassReq.Connecter();
            ok = ClassReq.RetConnOk();
            return ok;
        }
        /// <summary>
        /// Insère une ligne dans ligneCommandeClient
        /// </summary>
        /// <param name="uneLigne">objet Ligne</param>
        /// <returns>retourne 1 si ok, 0 sinon</returns>
        public static int creerLigneCommande(LigneCommandeClient uneLigne)
        {
            int num = uneLigne.getLaCommande().getNumCommande();
            string reference=uneLigne.getLeProduit().getReference();
            int qte=uneLigne.getLaQuantité();
            double prixv = uneLigne.getLeProduit().getPrixUHTProduit();
            // remplacement virgule décimale par point décimal ...............à améliorer
            string prixP = prixv.ToString().Replace(",", ".");
            string requete = "INSERT INTO ligneCommandeClient VALUES( " + num + ",'"+ reference + "'," +  qte+","+ prixP +", 0, ' ')";
            ClassReq reqInsLig = new ClassReq(requete);
            int resultat = reqInsLig.ExecuteIUD();
            return resultat;
        }
        /// <summary>
        /// Retourne le plus grand numéro de commande
        /// </summary>
        /// <returns>le plus grand numéro ou 0 sil ny aps de ligne dans Commande</returns>
        public static int getMaxNumCde()
        {
            int maxNum;
            string req = "select max(numcommande) from commande";
            DataTable resultat =new DataTable();
            ClassReq reqMax = new ClassReq(req);
            resultat=reqMax.ExecuteSelect();
            if (resultat.Rows.Count==0)
                { maxNum = 0; }
            else
                { maxNum =Int32.Parse( resultat.Rows[0][0].ToString());}
            return maxNum;
        }
        /// <summary>
        /// Retourne le Client dont le numéro de téléphone est passé en paramètre n
        /// </summary>
        /// <param name="unTelephone">string le numéro de téléphone</param>
        /// <returns>objet Client</returns>
        public static Client getLeClientByTel(string unTelephone)
        {
            ClassReq.Connecter();
            Client unObjClient = null;
            if (ClassReq.RetConnOk() == true)
            {
                ClassReq afficherClasse = new ClassReq("select * from client where telephone='unTelephone'"); // creer une nouvelle requete
                DataTable res = new DataTable();
                res = afficherClasse.ExecuteSelect(); // recupere le resultat de la requete
                foreach (DataRow resLigne in res.Rows)
                {
                    int numClient = Int32.Parse(resLigne["numClient"].ToString()); // recuperer idClasse
                    string nomClient = resLigne["nomClient"].ToString();
                    string prenomClient = resLigne["prenomClient"].ToString();
                    string adresseClient = resLigne["adresse"].ToString();
                    string cpClient = resLigne["cp"].ToString();
                    string villeClient = resLigne["ville"].ToString();
                    string telClient = resLigne["telephone"].ToString();
                    string emailClient = resLigne["email"].ToString();

                    unObjClient = new Client(numClient, nomClient, prenomClient, adresseClient, cpClient, villeClient, telClient, emailClient);
                }
            }

            return unObjClient;
        }
        /// <summary>
        /// Retourne les Inventoristes non assigner à un inventaire
        /// </summary>
        /// 
        /// <returns>List Objet Inventoriste</returns>
        public static List<Inventoriste> getInventoristesDispo()
        {
            List<Inventoriste> lesInventoristes = new List<Inventoriste>();

            Inventoriste unObjInventoriste = null;
            if (ClassReq.RetConnOk() == true)
            {
                ClassReq afficherClasse = new ClassReq("select * from INVENTORISTE,PARTICIPER WHERE INVENTORISTE.IDINVENTORISTE NOT IN (SELECT INVENTORISTE.IDINVENTORISTE FROM INVENTORISTE,PARTICIPER WHERE INVENTORISTE.IDINVENTORISTE = PARTICIPER.IDINVENTORISTE) "); // creer une nouvelle requete
                DataTable res = new DataTable();
                res = afficherClasse.ExecuteSelect(); // recupere le resultat de la requete
                foreach (DataRow resLigne in res.Rows)
                {
                    int id = Int32.Parse(resLigne["IDINVENTORISTE"].ToString()); // recuperer idClasse
                    string nom = resLigne["NOMINVENTORISTE"].ToString();
                    string prenom = resLigne["PRENOMINVENTORISTE"].ToString();
                    string adresse = resLigne["ADRESSEINVENTORISTE"].ToString();
                    string complement = resLigne["COMPLEMENTADRESSEINVENTORISTE"].ToString();
                    string numTel = resLigne["NUMEROTELEPHONEINVENTORISTE"].ToString();
                    string numFixe = resLigne["NUMEROTELEFIXEINVENTORISTE"].ToString();
                    string email = resLigne["MAILINVENTORISTE"].ToString();
                    int IdVille = 1;
                    unObjInventoriste = new Inventoriste(id, nom, prenom, adresse, complement, numTel, numFixe, email, IdVille);
                    lesInventoristes.Add(unObjInventoriste);
                }
            }

            return lesInventoristes;
        }
        /// <summary>
        /// Retourne le produit dont la référence est passée en paramètre
        /// </summary>
        /// <param name="uneReference">string une référence produit</param>
        /// <returns>objet Produit</returns>
        public static Produit getProduit(string uneReference)
        {
            Produit res = null;
            ClassReq.Connecter();
            if (ClassReq.RetConnOk() == true)
            {
                string req = "SELECT * FROM PRODUIT WHERE REFERENCEPROD = '" + uneReference + "'";
                ClassReq leProduit = new ClassReq(req);
                DataTable resultat = leProduit.ExecuteSelect();
                if (resultat.Rows.Count == 1)
                {
                    string REFERENCEPRODPERSO = resultat.Rows[0]["REFERENCEPROD"].ToString();
                    string libelleProduit = resultat.Rows[0]["libelleProduit"].ToString();
                    double prixUHT = Double.Parse(resultat.Rows[0]["prixUHT"].ToString());
                    double tauxTVA = Double.Parse(resultat.Rows[0]["tauxTVA"].ToString());
                    int seuilReapro = Int32.Parse(resultat.Rows[0]["seuilReapro"].ToString());
                    int delaiReapro = Int32.Parse(resultat.Rows[0]["delaiReapro"].ToString());
                    int stockTemp = Int32.Parse(resultat.Rows[0]["stockTemp"].ToString());
                    string origineProduit = resultat.Rows[0]["origineProduit"].ToString();
                    string couleurProduit = resultat.Rows[0]["couleurProduit"].ToString();
                    string tailleProduit = resultat.Rows[0]["tailleProduit"].ToString();
                    int stockTheorique = Int32.Parse(resultat.Rows[0]["stockTheorique"].ToString());
                    int numFournisseur = Int32.Parse(resultat.Rows[0]["numFournisseur"].ToString());
                    int numCategorie = Int32.Parse(resultat.Rows[0]["numCategorie"].ToString());
                    string numReduction = resultat.Rows[0]["numReduction"].ToString();
                    res = new Produit(REFERENCEPRODPERSO, libelleProduit, prixUHT, stockTheorique, tauxTVA, stockTemp, couleurProduit, tailleProduit, origineProduit, delaiReapro, seuilReapro);

                }

            }

            return res;
        }
        /// <summary>
        /// Retourne le produit dont le nom est passée en paramètre
        /// </summary>
        /// <param name="uneReference">string une référence produit</param>
        /// <returns>objet Produit</returns>
        public static Produit getProduitParNom(string nomProduit)
        {
            Produit res = null;
            ClassReq.Connecter();
            if (ClassReq.RetConnOk() == true)
            {
                string req = "SELECT * FROM PRODUIT WHERE LIBELLEPRODUIT = '" + nomProduit + "'";
                ClassReq leProduit = new ClassReq(req);
                DataTable resultat = leProduit.ExecuteSelect();
                if (resultat.Rows.Count == 1)
                {
                    string REFERENCEPRODPERSO = resultat.Rows[0]["REFERENCEPROD"].ToString();
                    string libelleProduit = resultat.Rows[0]["libelleProduit"].ToString();
                    double prixUHT = Double.Parse(resultat.Rows[0]["prixUHT"].ToString());
                    double tauxTVA = Double.Parse(resultat.Rows[0]["tauxTVA"].ToString());
                    int seuilReapro = Int32.Parse(resultat.Rows[0]["seuilReapro"].ToString());
                    int delaiReapro = Int32.Parse(resultat.Rows[0]["delaiReapro"].ToString());
                    int stockTemp = Int32.Parse(resultat.Rows[0]["stockTemp"].ToString());
                    string origineProduit = resultat.Rows[0]["origineProduit"].ToString();
                    string couleurProduit = resultat.Rows[0]["couleurProduit"].ToString();
                    string tailleProduit = resultat.Rows[0]["tailleProduit"].ToString();
                    int stockTheorique = Int32.Parse(resultat.Rows[0]["stockTheorique"].ToString());
                    int numFournisseur = Int32.Parse(resultat.Rows[0]["numFournisseur"].ToString());
                    int numCategorie = Int32.Parse(resultat.Rows[0]["numCategorie"].ToString());
                    string numReduction = resultat.Rows[0]["numReduction"].ToString();
                    res = new Produit(REFERENCEPRODPERSO, libelleProduit, prixUHT, stockTheorique, tauxTVA, stockTemp, couleurProduit, tailleProduit, origineProduit, delaiReapro, seuilReapro);

                }

            }

            return res;
        }
        /// <summary>
        /// Retourne la référence du produit dont le nom est passée en paramètre
        /// </summary>
        /// <param name="uneReference">string une référence produit</param>
        /// <returns>string referenceProd</returns>
        public static string getRefProduitParNom(string nomProduit)
        {
            string REFERENCEPROD = null;
            ClassReq.Connecter();
            if (ClassReq.RetConnOk() == true)
            {
                string req = "SELECT PRODUIT.REFERENCEPROD FROM PRODUIT WHERE LIBELLEPRODUIT = '" + nomProduit + "'";
                ClassReq leProduit = new ClassReq(req);
                DataTable resultat = leProduit.ExecuteSelect();
                if (resultat.Rows.Count == 1)
                {
                    REFERENCEPROD = resultat.Rows[0]["REFERENCEPROD"].ToString();
                    

                }

            }

            return REFERENCEPROD;
        }
        /// Retourne le Client dont le numéro est passé en paramètre n
        /// </summary>
        /// <param name="unTelephone">in le numéro de client</param>
        /// <returns>objet Client</returns>
        public static Client getLeClientByNum(int unNum)
        {
            Client unObjClient = null;
            if (ClassReq.RetConnOk() == true)
            {   // récupération des infos client dans la base
                string req = "select * from client where numClient=" + unNum.ToString();
                ClassReq ReqCli = new ClassReq(req); 
                DataTable res = new DataTable();
                res = ReqCli.ExecuteSelect(); 
                if (res.Rows.Count != 0)
                { 
                    // intanciation de l'objet client
                    int numClient = Int32.Parse(res.Rows[0]["numClient"].ToString());
                    string nomClient = res.Rows[0]["nomClient"].ToString();
                    string prenomClient = res.Rows[0]["prenomClient"].ToString();
                    string adresseClient = res.Rows[0]["adresse"].ToString();
                    string cpClient = res.Rows[0]["cp"].ToString();
                    string villeClient = res.Rows[0]["ville"].ToString();
                    string telClient = res.Rows[0]["telephone"].ToString();
                    string emailClient = res.Rows[0]["email"].ToString();
                    unObjClient = new Client(numClient, nomClient, prenomClient, adresseClient, cpClient, villeClient, telClient, emailClient);
                } 
            }
            return unObjClient;
        }
  
        /// <summary>
        ///  insère une ligne de la classe Commande dans la BDD  
        /// </summary>
        /// <param name="uneCommande">objet Commande</param>
        /// <returns>booléen 1 si bien inséré, 0 sinon</returns>
        public static int creerCommande(Commande uneCommande)
        {
            int insertCdeOK;
            int numCommande = uneCommande.getNumCommande();
            int dateCommande = boiteOutil.dateEnNum(DateTime.Today);
            double montantCommande = uneCommande.getMontantCommandeTTC();
            // conversion de la virgule décimale en point...................à améliorer
            string montantcdeP = montantCommande.ToString().Replace(",", ".");
            string statut = "En attente";
            int numClient = uneCommande.getLeClient().getNumClient();
            string req = "INSERT INTO Commande VALUES( " + numCommande + ",'" + dateCommande + "'," + montantcdeP + ", '" + statut + "', " + numClient + ")";
            ClassReq reqCreerCommande = new ClassReq(req);
            insertCdeOK = reqCreerCommande.ExecuteIUD();
            return insertCdeOK;
        }
        /// <summary>
        ///  insère une ligne de la classe Participer dans la BDD  
        /// </summary>
        /// <param name="uneParticipation">objet Participer</param>
        /// <returns>booléen 1 si bien inséré, 0 sinon</returns>
        public static int assignerInventoriste(Participer uneParticipation)
        {

            int insertCdeOK;
            int idInventoriste = uneParticipation.getIdinventoriste();
            int idInventaire = uneParticipation.getIdInventaire();
            string refProd = uneParticipation.getReferenceProduit();
            string req = "INSERT INTO PARTICIPER VALUES( " + idInventaire + "," + idInventoriste + ",'" + refProd + "')";
            ClassReq reqAssignerInventoriste = new ClassReq(req);
            insertCdeOK = reqAssignerInventoriste.ExecuteIUD();
            return insertCdeOK;
        }
        /// <summary>
        /// renvoie une chaine de deux caractères avec 0 devant si necessaire
        /// </summary>
        /// <param name="unechaine">une chaine représentant un mois ou un jour</param>
        /// <returns>la chaine complétée</returns>

        public static DateTime convertDatIntDate(int uneDateInt)
        {
            DateTime dateRet;
            int year = Int32.Parse(uneDateInt.ToString().Substring(0, 3));
            int month = Int32.Parse(uneDateInt.ToString().Substring(4, 5));
            int day = Int32.Parse(uneDateInt.ToString().Substring(6, 7));
            dateRet = new DateTime(year, month, day);
            return dateRet;
        } 
        public static string checkMajuscule(string unNom)
        {
            string resultat;
            if (unNom.Length > 1)
                resultat = unNom.Substring(0, 1).ToUpper() + unNom.Substring(1);
            else if (unNom.Length == 1)
                resultat = unNom.ToUpper();
            else
                resultat = unNom;
            return resultat;
        }
        // Boite à outils
         /// <summary>
        /// retourne vrai si la chaine passéé en paramètre est un entier
         /// </summary>
         /// <param name="uneChaine">string une chaine</param>
         /// <returns>vrai si entier, faux sinon</returns>

                public static void majStockTempProd(Produit unProd )
        { 
            string req = "UPDATE PRODUIT set stockTemp = " + unProd.getStockTemp() + " where referenceProd = '" + unProd.getReference() + "'";
            int majOk = Passerelle.DAOAutre(req);
        }
               
                /// <summary>
                /// </summary>
                /// <param name="linventaire">object Inventoriste</param>
                public static void majInfosInventoriste(Inventoriste linventoriste)
                {
                    string req = "UPDATE INVENTORISTE set ADRESSEINVENTORISTE = '" + linventoriste.getAdresseInventoriste() + "',COMPLEMENTADRESSEINVENTORISTE = '" + linventoriste.getComplementAdresseInventoriste() + "',NUMEROTELEPHONEINVENTORISTE = '" + linventoriste.getNumTelInventoriste() + "',NUMEROTELEFIXEINVENTORISTE = '" + linventoriste.getNumFixeInventoriste() + "',MAILINVENTORISTE = '" + linventoriste.getMailInventoriste() + "' where IDINVENTORISTE = " + linventoriste.getIdInventoriste();
                    int majOk1 = Passerelle.DAOAutre(req);
                }
              
                /// <summary>
                /// </summary>
                /// <param name="id">int un nombre</param>
                ///

                public static void suppInventoriste(int id)
                {
                    string req = "DELETE FROM INVENTORISTE WHERE IDINVENTORISTE=" + id;
                    int suppOk = Passerelle.DAOAutre(req);
                }
        // Boite à outils
         /// <summary>
        /// retourne vrai si la chaine passéé en paramètre est un entier
         /// </summary>
         /// <param name="uneChaine">string une chaine</param>
         /// <returns>vrai si entier, faux sinon</returns>
        public static bool convertNum(string uneChaine)
        {
            bool oknum;
            try
                {   int res = Int32.Parse(uneChaine);
                    oknum = true;
                }
            catch
                { oknum = false; }
            return oknum;
        }
        /// <summary>
        /// Retourne le max id d'inventoriste
        /// </summary>
        /// <returns>int res</returns>
        public static int getMaxIdInventoriste()
        {
            int res = 0;
            if (ClassReq.RetConnOk() == true)
            {
                string req = "SELECT MAX(IDINVENTORISTE) FROM INVENTORISTE";
                ClassReq lId = new ClassReq(req);
                DataTable resultat = lId.ExecuteSelect();

                if (resultat.Rows.Count == 0)
                { res = 0; }
                else
                {
                     res = Int32.Parse(resultat.Rows[0][0].ToString());
                }

            }
            return res;
        }
        /// <summary>
        /// Retourne le max id d'inventaire
        /// </summary>
        /// <returns>int l'id</returns>
        public static int getMaxIdInventaire()
        {
            int res = 0;
            if (ClassReq.RetConnOk() == true)
            {
                string req = "SELECT MAX(IDINVENTAIRE) FROM INVENTAIRE";
                ClassReq lId = new ClassReq(req);
                DataTable resultat = lId.ExecuteSelect();

                if (resultat.Rows.Count == 0)
                { res = 0; }
                else
                {
                    res = Int32.Parse(resultat.Rows[0][0].ToString());
                }

            }
            return res;
        }
        /// <summary>
        ///  insère une ligne de la classe Inventoriste dans la BDD  
        /// </summary>
        /// <param name="unInventoriste">objet Inventoriste</param>
        /// <returns>booléen 1 si bien inséré, 0 sinon</returns>
        public static int creerNewInventoriste(Inventoriste lInventoriste)
        {
            int insertCdeOK1;
            int lIdInventoriste = Passerelle.getMaxIdInventoriste()+1;

            string nom = lInventoriste.getNomInventoriste();
            string prenom = lInventoriste.getPrenomInventoriste();
            string adresse = lInventoriste.getAdresseInventoriste();
            string complement = lInventoriste.getComplementAdresseInventoriste();
            string numTel = lInventoriste.getNumTelInventoriste();
            string numFixe = lInventoriste.getNumFixeInventoriste();
            string mail = lInventoriste.getMailInventoriste();
            string req = "INSERT INTO INVENTORISTE VALUES( " + lIdInventoriste + ",'" + nom + "','" + prenom + "', '" + adresse + "', '" + complement + "','" + numTel + "','" + numFixe + "','" + mail + "')";
            //ClassReq reqCreerInventoriste = new ClassReq();
            //reqCreerInventoriste.ExecuteIUD();
            insertCdeOK1 = Passerelle.DAOAutre(req);
            return insertCdeOK1;
        }
        /// <summary>
        ///  insère une ligne de la classe Inventaire dans la BDD  
        /// </summary>
        /// <param name="unIdInventaire">int un nombre</param>
        /// <param name="uneDateReapro">date une date</param>
        public static int creerNewInventaire(int unIdInventaire,string uneDateReapro)
        {
            int insertCdeOKProduit;
            string etatInventaire = "En_cours";
            string req = "INSERT INTO INVENTAIRE VALUES( " + unIdInventaire + "," + uneDateReapro +",'" + etatInventaire + "')";


            //ClassReq reqCreerInventoriste = new ClassReq();
            //reqCreerInventoriste.ExecuteIUD();
            insertCdeOKProduit = Passerelle.DAOAutre(req);
            return insertCdeOKProduit;
        }
        /// <summary>
        ///  insère une ligne de la classe Realiser dans la BDD  
        /// </summary>
        /// <param name="unIdInventaire">int un nombre</param>
        /// <param name="uneRefProduit">string une chaîne</param>
        public static int creerNewInventaireSuite(int unIdInventaire, string uneRefProduit)
        {
            int insertCdeOKRealiser;
            int qteProduit = 0;
            string req = "INSERT INTO REALISER VALUES( " + unIdInventaire + ",'" + uneRefProduit + "'," + qteProduit + ")";


            //ClassReq reqCreerInventoriste = new ClassReq();
            //reqCreerInventoriste.ExecuteIUD();
            insertCdeOKRealiser = Passerelle.DAOAutre(req);
            return insertCdeOKRealiser;
        }
        /// <summary>
        /// Retourne tous les inventoristes
        /// </summary>
        /// <returns>List<Inventoriste></returns>
        public static List<Inventoriste> getLesInventoristes()
        {
            List<Inventoriste> maList = new List<Inventoriste>();
            if (ClassReq.RetConnOk() == true)
            {
                ClassReq afficherInventoriste = new ClassReq("SELECT * FROM INVENTORISTE");
                DataTable res = new DataTable();
                res = afficherInventoriste.ExecuteSelect();
                foreach (DataRow resLigne in res.Rows)
                {
                    int idInventoriste = Int32.Parse(resLigne["IDINVENTORISTE"].ToString());
                    string nomInventoriste = resLigne["NOMINVENTORISTE"].ToString();
                    string prenomInventoriste =resLigne["PRENOMINVENTORISTE"].ToString();
                    string adresseInventoriste = resLigne["ADRESSEINVENTORISTE"].ToString();
                    string complementInventoriste = resLigne["COMPLEMENTADRESSEINVENTORISTE"].ToString();
                    string numTelInventoriste = resLigne["NUMEROTELEPHONEINVENTORISTE"].ToString();
                    string numFixInventoriste = resLigne["NUMEROTELEFIXEINVENTORISTE"].ToString();
                    string mailInventoriste = resLigne["MAILINVENTORISTE"].ToString();
                    int IdVille = 1;
                    Inventoriste objInventoriste = new Inventoriste(idInventoriste, nomInventoriste, prenomInventoriste, adresseInventoriste, complementInventoriste, numTelInventoriste, numFixInventoriste, mailInventoriste, IdVille);
                    maList.Add(objInventoriste);
                }
            }
            return maList;
        }
        /// <summary>
        /// Retourne tous les Inventaires
        /// </summary>
        /// <returns>list<Inventaire></returns>
        public static List<Inventaire> getLesInventaires()
        {
            List<Inventaire> maList = new List<Inventaire>();
            if (ClassReq.RetConnOk() == true)
            {
                ClassReq afficherInventaire = new ClassReq("SELECT * FROM INVENTAIRE");
                DataTable res = new DataTable();
                res = afficherInventaire.ExecuteSelect();
                foreach (DataRow resLigne in res.Rows)
                {
                    int idInventaire = Int32.Parse(resLigne["IDINVENTAIRE"].ToString());
                    string dateInventaire = resLigne["DATEINVENTAIRE"].ToString();
                    string etatInventaire = resLigne["ETATINVENTAIRE"].ToString();
                    Inventaire objInventaire = new Inventaire(idInventaire, dateInventaire, etatInventaire);
                    maList.Add(objInventaire);
                }
            }
            return maList;
        }

        /// <summary>
        /// Retourne le produit dont la référence est passée en paramètre
        /// </summary>
        /// <param name="uneReference">string une référence produit</param>
        /// <returns>objet Produit</returns>
        public static List<Produit> getLesProduitsParInventaire(int unIdInventaire)
        {
            List<Produit> maList = new List<Produit>();
            if (ClassReq.RetConnOk() == true)
            {
                ClassReq afficherProduit = new ClassReq("SELECT  PRODUIT.REFERENCEPROD,PRODUIT.LIBELLEPRODUIT,PRODUIT.PRIXUHT,PRODUIT.TAUXTVA,PRODUIT.SEUILREAPRO,PRODUIT.DELAIREAPRO,PRODUIT.STOCKTEMP,PRODUIT.ORIGINEPRODUIT,PRODUIT.COULEURPRODUIT,PRODUIT.TAILLEPRODUIT,PRODUIT.STOCKTHEORIQUE,PRODUIT.NUMFOURNISSEUR,PRODUIT.NUMCATEGORIE,PRODUIT.NUMREDUCTION FROM INVENTAIRE, PRODUIT, REALISER WHERE INVENTAIRE.IDINVENTAIRE = REALISER.IDINVENTAIRE AND PRODUIT.REFERENCEPROD = REALISER.REFERENCEPROD AND INVENTAIRE.IDINVENTAIRE = " + unIdInventaire + " GROUP BY PRODUIT.REFERENCEPROD,PRODUIT.LIBELLEPRODUIT,PRODUIT.PRIXUHT,PRODUIT.TAUXTVA,PRODUIT.SEUILREAPRO,PRODUIT.DELAIREAPRO,PRODUIT.STOCKTEMP,PRODUIT.ORIGINEPRODUIT,PRODUIT.COULEURPRODUIT,PRODUIT.TAILLEPRODUIT,PRODUIT.STOCKTHEORIQUE,PRODUIT.NUMFOURNISSEUR,PRODUIT.NUMCATEGORIE,PRODUIT.NUMREDUCTION ");
                DataTable res = new DataTable();
                res = afficherProduit.ExecuteSelect();
                foreach (DataRow resLigne in res.Rows)
                {
                    string idProduit = resLigne["REFERENCEPROD"].ToString();
                    string libelleProduit = resLigne["LIBELLEPRODUIT"].ToString();
                    double prixUHT = Double.Parse(resLigne["PRIXUHT"].ToString());
                    double tauxTVA = Double.Parse(resLigne["TAUXTVA"].ToString());
                    int seuilReapro = Int32.Parse(resLigne["SEUILREAPRO"].ToString());
                    int delaiReapro = Int32.Parse(resLigne["DELAIREAPRO"].ToString());
                    int stockTemp = Int32.Parse(resLigne["STOCKTEMP"].ToString());
                    string origineProduit = resLigne["ORIGINEPRODUIT"].ToString();
                    string couleurProduit = resLigne["COULEURPRODUIT"].ToString();
                    string tailleProduit = resLigne["TAILLEPRODUIT"].ToString();
                    int stockTheorique = Int32.Parse(resLigne["STOCKTHEORIQUE"].ToString());
                    int numFournisseur = Int32.Parse(resLigne["NUMFOURNISSEUR"].ToString());
                    int numCategorie = Int32.Parse(resLigne["NUMCATEGORIE"].ToString());
                    Produit objProduit = new Produit(idProduit, libelleProduit, prixUHT, stockTheorique, tauxTVA, stockTemp, couleurProduit, tailleProduit, origineProduit, delaiReapro, seuilReapro);
                    
                    maList.Add(objProduit);
                }
            }
            return maList;
    
        }
        /// <summary>
        /// Retourne tous les Produits
        /// </summary>
        /// <returns>list<Produit></returns>
        public static List<Produit> getLesProduits()
        {
            List<Produit> lesProduits = new List<Produit>();
            if (ClassReq.RetConnOk() == true)
            {
                ClassReq afficherClasse = new ClassReq("select * from PRODUIT "); // creer une nouvelle requete
                DataTable res = new DataTable();
                res = afficherClasse.ExecuteSelect(); // recupere le resultat de la requete
                foreach (DataRow resLigne in res.Rows)
                {
                    string id = resLigne["REFERENCEPROD"].ToString(); // recuperer idClasse
                    string libelle = resLigne["LIBELLEPRODUIT"].ToString();
                    double prixUHT = Double.Parse(resLigne["PRIXUHT"].ToString());
                    double tauxTva = Double.Parse(resLigne["TAUXTVA"].ToString());
                    int seuilR = Int32.Parse(resLigne["SEUILREAPRO"].ToString());
                    int delaiR = Int32.Parse(resLigne["DELAIREAPRO"].ToString());
                    int stockTemp = Int32.Parse(resLigne["STOCKTEMP"].ToString());
                    string origineProd = resLigne["ORIGINEPRODUIT"].ToString();
                    string couleurProd = resLigne["COULEURPRODUIT"].ToString();
                    string tailleProd = resLigne["TAILLEPRODUIT"].ToString();
                    int stockTheo = Int32.Parse(resLigne["STOCKTHEORIQUE"].ToString());


                    Produit unObjProduit = new Produit(id, libelle, prixUHT, stockTheo, tauxTva, stockTemp, couleurProd, tailleProd, origineProd, delaiR, seuilR);
                    lesProduits.Add(unObjProduit);
                }
            }

            return lesProduits;
        }
        public static Ville getLaVille(int idVille)
        {

            Ville unObjVille = null;
            if (ClassReq.RetConnOk() == true)
            {
                ClassReq afficherClasse = new ClassReq("select * from VILLE WHERE " + idVille + "=IDVILLE "); // creer une nouvelle requete
                DataTable res = new DataTable();
                res = afficherClasse.ExecuteSelect(); // recupere le resultat de la requete
                foreach (DataRow resLigne in res.Rows)
                {
                    int id = Int32.Parse(res.Rows[0]["IDVILLE"].ToString());
                    string libelle = res.Rows[0]["NOMVILLE"].ToString();
                    int prime = Int32.Parse(res.Rows[0]["PRIMEVILLE"].ToString());
                    


                    unObjVille = new Ville(id, libelle, prime);
                }
            }

            return unObjVille;
        }
        /// <summary>
        /// Retourne tous les Produits
        /// </summary>
        /// <returns>list<Produit></returns>
        public static List<Inventoriste> getLesInventoristesPrimes()
        {
            List<Inventoriste> lesInventoristes = new List<Inventoriste>();
            if (ClassReq.RetConnOk() == true)
            {
                ClassReq afficherClasse = new ClassReq("SELECT * FROM INVENTORISTE"); // creer une nouvelle requete
                DataTable res = new DataTable();
                res = afficherClasse.ExecuteSelect(); // recupere le resultat de la requete
                foreach (DataRow resLigne in res.Rows)
                {
                
                    int idInventoriste = Int32.Parse(resLigne["IDINVENTORISTE"].ToString());
                    string nomInventoriste = resLigne["NOMINVENTORISTE"].ToString();
                    string prenomInventoriste = resLigne["PRENOMINVENTORISTE"].ToString();
                    string adresseInventoriste = resLigne["ADRESSEINVENTORISTE"].ToString();
                    string complementInventoriste = resLigne["COMPLEMENTADRESSEINVENTORISTE"].ToString();
                    string numTelInventoriste = resLigne["NUMEROTELEPHONEINVENTORISTE"].ToString();
                    string numFixInventoriste = resLigne["NUMEROTELEFIXEINVENTORISTE"].ToString();
                    string mailInventoriste = resLigne["MAILINVENTORISTE"].ToString();
                    int idVille = Int32.Parse(resLigne["IDVILLE"].ToString());
                    Inventoriste unObjInventoriste = new Inventoriste(idInventoriste, nomInventoriste, prenomInventoriste, adresseInventoriste, complementInventoriste, numTelInventoriste, numFixInventoriste, mailInventoriste, idVille);
                    lesInventoristes.Add(unObjInventoriste);                    
                }
            }

            return lesInventoristes;
        }

                
    }
}
