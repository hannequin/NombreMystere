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
            bool trouve = false;
            Random rand = new Random();
            int nombreSecret = rand.Next(101);
            int nbrEssai = 0;
            string menu = "1";

            Console.WriteLine("Bienvenue dans le jeu du Plus ou Moins !");
            Console.WriteLine("Veuillez entrer un nombre compris entre 1 et 100 (inclus).");
            
            // Tant que le jeu n'est pas fini 
            while (!trouve) {

                // affichage du menu
                if (menu == "1")
                {
                    switch (menu)
                    {
                        case "Afficher la règles du jeu":
                            Console.WriteLine("C'est le printemps");
                            break;
                        case "Commencer une partie":
                            Console.WriteLine("C'est l'été");
                            break;
                        case "Quitter le jeu":
                            Console.WriteLine("C'est l'automne");
                            break;
                    }
                }

                string inputString = Console.ReadLine();
                int inputNumber;

                // Si la conversion a marché
                if (int.TryParse(inputString, out inputNumber)) {
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
