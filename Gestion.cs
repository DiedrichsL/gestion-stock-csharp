using Exercice36_GestionStock;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercice36_GestionStock
{
    public class Gestion
    {
        Stock s = new Stock();

        public void LancerMenu()
        {
            int choix = -1;

            while (choix != 0)
            {
                

                AfficherMenu();

                Console.Write("Votre choix : ");
                choix = int.Parse(Console.ReadLine());

                switch (choix)
                {

                    case 1:
                        Console.WriteLine("Ajouter un article");

                        Console.Write("Numéro de référence : ");
                        int numRefAjout = int.Parse(Console.ReadLine());

                        Console.Write("Nom : ");
                        string nomAjout = Console.ReadLine();

                        Console.Write("Prix : ");
                        double prixAjout = double.Parse(Console.ReadLine());

                        Console.Write("Type (1=Tshirt, 2=Pantalon, 3=Chapeau, 4=Chaussette) : ");
                        int typeAjout = int.Parse(Console.ReadLine());

                        s.AjouterArticle(numRefAjout, nomAjout, prixAjout, typeAjout);
                        break;

                    case 2:
                        Console.WriteLine("Supprimer un article");

                        Console.Write("Numéro de référence à supprimer : ");
                        int numRefSupp = int.Parse(Console.ReadLine());

                        s.SupprimerArticle(numRefSupp);
                        break;

                    case 3:
                        Console.WriteLine("Modifier un article");

                        Console.Write("Numéro de référence de l'article à modifier : ");
                        int numRefModif = int.Parse(Console.ReadLine());

                        Console.Write("Nouveau nom : ");
                        string nouveauNom = Console.ReadLine();

                        Console.Write("Nouveau prix : ");
                        double nouveauPrix = double.Parse(Console.ReadLine());

                        Console.Write("Nouveau numéro de référence : ");
                        int nouveauNumRef = int.Parse(Console.ReadLine());

                        s.ModifierArticle(numRefModif, nouveauPrix, nouveauNom, nouveauNumRef);
                        break;

                    case 4:
                        Console.WriteLine("Rechercher par nom");

                        Console.Write("Nom recherché : ");
                        string nomRecherche = Console.ReadLine();

                        s.RechercherArticleNom(nomRecherche);
                        break;

                    case 5:
                        Console.WriteLine("Rechercher par prix");

                        Console.Write("Prix minimum : ");
                        double prixMin = double.Parse(Console.ReadLine());

                        Console.Write("Prix maximum : ");
                        double prixMax = double.Parse(Console.ReadLine());

                        s.RechercherArticleintervallePrix(prixMin, prixMax);
                        break;

                    case 6:
                        Console.WriteLine("Rechercher par type");
                        Console.Write("Type recherché (1=Tshirt, 2=Pantalon, 3=Chapeau, 4=Chaussette) : ");
                        int typeRecherche = int.Parse(Console.ReadLine());

                        s.RechercherArticleType(typeRecherche);
                        break;

                    case 7:
                        Console.WriteLine("Afficher tous les articles");
                        s.AfficherTousLesArticles();
                        break;

                    case 8:
                        Console.WriteLine("Au revoir");
                        break;

                    default:
                        Console.WriteLine("Choix invalide");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
        public void AfficherMenu()
        {
            
            {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Ajouter un article");
            Console.WriteLine("2. Supprimer un article");
            Console.WriteLine("3. Modifier un article");
            Console.WriteLine("4. Rechercher par nom");
            Console.WriteLine("5. Rechercher par prix");
            Console.WriteLine("6. Rechercher par type");
            Console.WriteLine("7. Afficher tous les articles");
            Console.WriteLine("8. Quitter");
         

            }
        }
     
    }
}



