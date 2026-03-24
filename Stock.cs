using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercice36_GestionStock
{
    public class Stock
    {
        private List<Article> stocks;

        public Stock()
        {
            stocks = new List<Article>();
        }

       
    

    public Article RechercherProduitNumRef(int numRef)

        {
            foreach (Article article in stocks)

            { 
                if (article.NumRef == numRef)
                {
                    return article;

                }
                     
            }

            return null;

        }

        public void AjouterArticle(int numRef, string nom, double prix, int type)
        {
            Article existant = RechercherProduitNumRef(numRef);

            if (existant != null)
            {
                Console.WriteLine("Un article avec ce numéro existe déjà.");
                return;
            }

            Article article = null;

            switch (type)
            {
                case 1:
                    article = new Tshirt(prix, nom, numRef);
                    break;

                case 2:
                    article = new Pentalon(prix, nom, numRef);
                    break;

                case 3:
                    article = new Chapeau(prix, nom, numRef);
                    break;

                case 4:
                    article = new Chausette(prix, nom, numRef);
                    break;

                default:
                    Console.WriteLine("Type invalide.");
                    return;
            }

            stocks.Add(article);
            Console.WriteLine("Article ajouté avec succès.");
        }


      
       public void SupprimerArticle(int numRef)
        {
            Article article = RechercherProduitNumRef(numRef);

            if (article == null)
            {
                Console.WriteLine("Article introuvable");
            }
            else
            {
                stocks.Remove(article);
            }
        }

        public void ModifierArticle(int numRef, double nouveauPrix,string nouveauNom, int nouveauNumRef)
        {
            Article article = RechercherProduitNumRef(numRef);
            if (article == null)
            {
                Console.WriteLine("Article introuvable");
            }
            else
            {
                article.prix = nouveauPrix;
                article.nom = nouveauNom;
                article.NumRef = nouveauNumRef;
            }
        }


        public void AfficherTousLesArticles()
        {
            if (stocks.Count == 0)
            {
                Console.WriteLine("Aucun article dans le stock.");

            }
            else
            { 
                foreach (Article article in stocks)
                {
                    Console.WriteLine($"{article.nom} - {article.prix} CHF - Ref : {article.NumRef}");
                }
            }
        }


        public void RechercherArticlePrix(int prix)
        {
            bool trouve = false;
            foreach (Article article in stocks)
             if(article.prix == prix)
                {
                    Console.WriteLine($"{article.nom}, {article.prix}, {article.NumRef}");
                    trouve = true;
                }
            if (!trouve)
            {

                Console.WriteLine("Aucun article trouvé avec ce prix");
            }


        }

        public void RechercherArticleType(int numRef)
        {
            bool trouve = false;
            foreach (Article article in stocks)
                if (article.NumRef == numRef)
                {
                    Console.WriteLine($"{article.nom}, {article.prix}, {article.NumRef}");
                    trouve = true;

                }
            
            if (!trouve)

            {
                Console.WriteLine("Aucun article trouvé avec ce numéro de référence");
            }
                        
        }

        public void RechercherArticleNom(string nom)
        {
            bool trouve = false;

            foreach (Article article in stocks)
               
                if (article.nom == nom)
                {
                    Console.WriteLine($"{article.nom}, {article.prix}, {article.NumRef}");
                   trouve = true;

                }
                if (!trouve)
                {

                Console.WriteLine("Aucun article trouvé avec ce nom");
                }

        }

        public void RechercherArticleintervallePrix(double prixMin, double prixMax)
        {
            bool trouve = false;

            foreach (Article article in stocks)
            {
                if (article.prix >= prixMin && article.prix <= prixMax)
                {
                    Console.WriteLine($"{article.nom} - {article.prix} CHF - Ref : {article.NumRef}");
                    trouve = true;
                }
            }

            if (!trouve)
            {
                Console.WriteLine("Aucun article trouvé dans cet intervalle de prix.");
            }
        }
    }

}
