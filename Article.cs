using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Exercice36_GestionStock
{
    public class Article 
    {
        public double prix {  get; set; }
        public string nom {  get; set; }
        public int NumRef { get; set; }


        public Article(double prix, string nom, int NumRef)
           
        {
            this.prix = prix;
            this.nom = nom;
            this.NumRef = NumRef;
        }


     


    }
}
