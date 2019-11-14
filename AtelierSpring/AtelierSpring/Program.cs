using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierSpring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, veuillez choisir une option de menu.");

            AfficherMenu();
            Console.ReadKey();
        }
        static void AfficherMenu()
        {




            Console.WriteLine("1. Afficher la longueur de la chaîne de caractère.");
            Console.WriteLine("2. Déterminer si la phrase contient «octopus».");
            Console.WriteLine("3. Connaître la position du premier ‘e'.");
            Console.WriteLine("4. Afficher une sous phrase.");
            Console.WriteLine("5. Transformer la chaîne en majuscule puis l’afficher.");
            Console.WriteLine("6. Transformer la chaîne en minuscule puis l’afficher.");
            Console.WriteLine("7. Fermer le programme.");




            int choixMenu = Convert.ToInt32(Console.ReadLine());



            switch (choixMenu)
            {

                case 1:
                    AfficherLongueurChaine();
                    break;
                case 2:
                    RechercherOctopus();
                    break;
                case 3:
                    AfficherPositionPremierE();
                    break;
                case 4:
                    AfficherSousPhrase();
                    break;
                case 5:
                    TransormerChaineMajuscule();
                    break;
                case 6:
                    TransormerChaineMinuscule();
                    break;
                case 7:
                    FermerProgramme();
                    break;
            }
        }

        //Afficher la longueur de la chaine de caractères
        static void AfficherLongueurChaine()
        {
            Console.WriteLine("Veuillez entrer une phrase.");
            string messageScrabble = Console.ReadLine();
            int longueurChaine = messageScrabble.Length;
            Console.WriteLine("" + longueurChaine + "");
        }
        static void RechercherOctopus()
        {
            Console.WriteLine("Veuillez entrer une phrase.");
            string messageScrabble = Console.ReadLine();
            if (messageScrabble.Contains("Octopus") == true)
                Console.WriteLine("Votre phrase contient 'Octopus'.");
            else
                Console.WriteLine("Votre phrase ne contient pas 'Octopus'.");
        }
        static void AfficherPositionPremierE()
        {
            Console.WriteLine("Veuillez entrer une phrase.");
            string messageScrabble = Console.ReadLine();
            int premierE = messageScrabble.IndexOf("e");
            Console.WriteLine("La position du premier e est" + premierE + "");
        }
        static void AfficherSousPhrase()
        {
            Console.WriteLine("Veuillez entrer une phrase.");
            string messageScrabble = Console.ReadLine();
            int positionDernierEspace = messageScrabble.IndexOf(' ');
            string dernierMot = messageScrabble.Substring(positionDernierEspace + 1);
            int premierEspace = messageScrabble.IndexOf(' ');
            string premierMot = messageScrabble.Substring(0, premierEspace);
            Console.WriteLine(premierMot);
            Console.WriteLine(dernierMot);
        }
        static void TransormerChaineMajuscule()
        {
            Console.WriteLine("Veuillez entrer une phrase.");
            string messageScrabble = Console.ReadLine();
            string messageEnMajuscule = messageScrabble.ToUpper();
            Console.WriteLine(messageEnMajuscule);
        }
        static void TransormerChaineMinuscule()
        {
            Console.WriteLine("Veuillez entrer une phrase.");
            string messageScrabble = Console.ReadLine();
            string messageEnMinuscule = messageScrabble.ToLower();
            Console.WriteLine(messageEnMinuscule);
        }
        static void FermerProgramme()
        {
            Console.WriteLine("Veuillez appuyer sur n'importe quelle touche.");
            Console.ReadKey();
        }




    }
}
        
    

