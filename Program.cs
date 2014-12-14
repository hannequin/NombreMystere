using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeuDuPlusOuMoins
{
    class Program
    {
        static void Main(string[] args)
        {   
            int i = 0;
            // La boucle est infini tant qu'on ne rentre pas une des valeurs attendu
            while(i == 0){      
                Console.WriteLine("Bienvenue dans le jeu du Plus ou Moins !");
                Console.WriteLine("1 - Afficher la règles du jeu");
                Console.WriteLine("2 - Commencer une partie");
                Console.WriteLine("3 - Quitter le jeu");
                string input = Console.ReadLine();  // Lit l'option choisi
            
                // affichage du menu                          
                switch (input.ToLower())
                {
                    case "1":
                        i = 1;
                        regleJeu(args);
                        break;
                    case "2":
                        i = 1;
                        partie(args);
                        break;
                    case "3":
                        i = 0;
                        Environment.Exit(1);    // Permet de quitter la console
                        break;
                    default:
                        i = 0;
                        Console.WriteLine("Entrez le numero correspondant a l'option voulus (1/2/3)");                                               
                        break;                
                }
            }
        }

        static void regleJeu(string[] args) {
            Console.WriteLine("Il faut entrer un nombre compris entre 1 et 100, en chiffre pour trouver le nombre mystere");
            Console.ReadLine();            
        }

        static void partie(string[] args)
        {
            bool trouve = false;
            Random rand = new Random();
            int nombreSecret = rand.Next(101);

            Console.WriteLine("Veuillez entrer un nombre compris entre 1 et 100 (inclus).");

            // Tant que le jeu n'est pas fini 
            while (!trouve)
            {

                string inputString = Console.ReadLine();
                int inputNumber;

                // Si la conversion a marché
                if (int.TryParse(inputString, out inputNumber))
                {
                    // Si c'est en dehors des limites
                    if (inputNumber < 0 || inputNumber > 100)
                    {
                        Console.WriteLine("Veuillez entrer un nombre compris entre 1 et 100 (inclus).");
                    }

                    // Si c'est le bon
                    else if (inputNumber == nombreSecret)
                    {
                        Console.WriteLine("Vous avez gagné ! Le nombre mystère était : {0}.", nombreSecret);
                        trouve = true;
                    }

                    // Si c'est trop petit
                    else if (inputNumber < nombreSecret)
                    {
                        Console.WriteLine("C'est plus.");
                    }

                    // Si c'est trop grand...
                    else
                    {
                        Console.WriteLine("C'est moins.");
                    }
                }

        // Si la conversion n'a pas réussi
                else
                {
                    Console.WriteLine("Vous devez entrez les nombres en chiffres");
                    Console.WriteLine("Veuillez entrer un nombre compris entre 1 et 100 (inclus).");
                }
            }

            // Marque une pause à la fin : le programme attend que vous appuyez sur Entrée et va récupérer ce que vous avez écrit.
            Console.ReadLine();
        }
}
    }
