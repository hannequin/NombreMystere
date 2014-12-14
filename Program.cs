using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeuDuPlusOuMoins
{
    class Program {
        static void Main(string[] args) {   
            int i = 0;

            Console.Clear();    // efface l'affichage

            // La boucle est infini tant qu'on ne rentre pas une des valeurs attendu
            while(i == 0) {      
                Console.WriteLine("Bienvenue dans le jeu du Plus ou Moins !");
                Console.WriteLine("1 - Afficher la règles du jeu");
                Console.WriteLine("2 - Commencer une partie");
                Console.WriteLine("3 - Quitter le jeu");
                string input = Console.ReadLine();  // Lit l'option choisi
            
                // affichage du menu                          
                switch (input.ToLower()) {
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
            Console.WriteLine("Il y a 4 niveaux de difficulté :");
            Console.WriteLine("- Expert : 7 essais");
            Console.WriteLine("- Bon : 8 essais");
            Console.WriteLine("- Moyen : 9 essais");
            Console.WriteLine("- Débutant : 10 essais");
            Console.ReadLine();
            Main(args); // retour méthode main
        }

        static void partie(string[] args) {
            bool trouve = false;
            Random rand = new Random();
            int nombreSecret = rand.Next(101);
            int nbrEssai = 0;
            int i = 0;
            int niv = 0;
            int faute = 0;                

            while (i == 0) {
                Console.Clear();
                Console.WriteLine("Choississez votre niveau de difficulter (utilisez le numero correspondant a l'option !");
                Console.WriteLine("1 - Expert(7 essais)");
                Console.WriteLine("2 - Bon(8 essais)");
                Console.WriteLine("3 - moyen(9 essais)");
                Console.WriteLine("4 - Débutant(10 essais)");
                Console.WriteLine("5 - retour au menu précédant");
                string input = Console.ReadLine();  // Lit l'option choisi

                // affichage du menu                          
                switch (input.ToLower()) {
                    case "1":
                        i = 1;
                        niv = 1;
                        break;
                    case "2":
                        i = 1;
                        niv = 2;
                        break;
                    case "3":
                        i = 1;
                        niv = 3;
                        break;
                    case "4":
                        i = 1;
                        niv = 4;
                        break;
                    case "5":
                        i = 0;
                        Main(args); // retour méthode main
                        break;
                    default:
                        i = 0;
                        Console.WriteLine("Entrez le numero correspondant a l'option voulus (1/2/3/4/5)");
                        break;
                }
            }
             
            // niveau expert
            if(niv == 1) {
                Console.Clear();
                Console.WriteLine("Veuillez entrer un nombre compris entre 1 et 100 (inclus).");
            // Remes les compteur à 0
                faute = 0;
                nbrEssai = 0;
            // Tant que le jeu n'est pas fini 
                while (!trouve && nbrEssai < 7 && faute < 3) {

                    string inputString = Console.ReadLine();
                    int inputNumber;

                    // Si la conversion a marché
                    if (int.TryParse(inputString, out inputNumber)) {
                        // Si c'est en dehors des limites
                        if (inputNumber < 0 || inputNumber > 100) {
                            Console.WriteLine("Veuillez entrer un nombre compris entre 1 et 100 (inclus).");
                            faute++;
                        }

                        // Si c'est le bon
                        else if (inputNumber == nombreSecret) {
                            Console.WriteLine("Vous avez gagné ! Le nombre mystère était : {0}.", nombreSecret);
                            trouve = true;
                            niv = 0;
                        }

                        // Si c'est trop petit
                        else if (inputNumber < nombreSecret) {
                            Console.WriteLine("C'est plus.");
                        }

                        // Si c'est trop grand
                        else {
                            Console.WriteLine("C'est moins.");
                        }
                    }

                    // Si la conversion n'a pas réussi
                    else {
                        Console.WriteLine("Vous devez entrez les nombres en chiffres");
                        Console.WriteLine("Veuillez entrer un nombre compris entre 1 et 100 (inclus).");
                        faute++;
                    }

                    nbrEssai++; // Incrémente pour limité le nombre d'essai
                }

                // Marque une pause à la fin : le programme attend que vous appuyez sur Entrée et va récupérer ce que vous avez écrit.
                Console.ReadLine();
            }

            // niveau bon
            if (niv == 2)
            {
                Console.Clear();
                Console.WriteLine("Veuillez entrer un nombre compris entre 1 et 100 (inclus).");
                // Remes les compteur à 0
                faute = 0;
                nbrEssai = 0;
                // Tant que le jeu n'est pas fini 
                while (!trouve && nbrEssai < 8 && faute < 3)
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
                            faute++;
                        }

                        // Si c'est le bon
                        else if (inputNumber == nombreSecret)
                        {
                            Console.WriteLine("Vous avez gagné ! Le nombre mystère était : {0}.", nombreSecret);
                            trouve = true;
                            niv = 0;
                        }

                        // Si c'est trop petit
                        else if (inputNumber < nombreSecret)
                        {
                            Console.WriteLine("C'est plus.");
                        }

                        // Si c'est trop grand
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
                        faute++;
                    }

                    nbrEssai++; // Incrémente pour limité le nombre d'essai
                }

                // Marque une pause à la fin : le programme attend que vous appuyez sur Entrée et va récupérer ce que vous avez écrit.
                Console.ReadLine();
            }

            // niveau moyen
            if (niv == 3)
            {
                Console.Clear();
                Console.WriteLine("Veuillez entrer un nombre compris entre 1 et 100 (inclus).");
                // Remes les compteur à 0
                faute = 0;
                nbrEssai = 0;
                // Tant que le jeu n'est pas fini 
                while (!trouve && nbrEssai < 9 && faute < 3)
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
                            faute++;
                        }

                        // Si c'est le bon
                        else if (inputNumber == nombreSecret)
                        {
                            Console.WriteLine("Vous avez gagné ! Le nombre mystère était : {0}.", nombreSecret);
                            trouve = true;
                            niv = 0;
                        }

                        // Si c'est trop petit
                        else if (inputNumber < nombreSecret)
                        {
                            Console.WriteLine("C'est plus.");
                        }

                        // Si c'est trop grand
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
                        faute++;
                    }

                    nbrEssai++; // Incrémente pour limité le nombre d'essai
                }

                // Marque une pause à la fin : le programme attend que vous appuyez sur Entrée et va récupérer ce que vous avez écrit.
                Console.ReadLine();
            }

            // niveau debutant
            if (niv == 4)
            {
                Console.Clear();
                Console.WriteLine("Veuillez entrer un nombre compris entre 1 et 100 (inclus).");
                // Remes les compteur à 0
                faute = 0;
                nbrEssai = 0;
                // Tant que le jeu n'est pas fini 
                while (!trouve && nbrEssai < 10 && faute < 3)
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
                            faute++;
                        }

                        // Si c'est le bon
                        else if (inputNumber == nombreSecret)
                        {
                            Console.WriteLine("Vous avez gagné ! Le nombre mystère était : {0}.", nombreSecret);
                            trouve = true;
                            niv = 0;
                        }

                        // Si c'est trop petit
                        else if (inputNumber < nombreSecret)
                        {
                            Console.WriteLine("C'est plus.");
                        }

                        // Si c'est trop grand
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
                        faute++;
                    }

                    nbrEssai++; // Incrémente pour limité le nombre d'essai
                }

                // Marque une pause à la fin : le programme attend que vous appuyez sur Entrée et va récupérer ce que vous avez écrit.
                Console.ReadLine();
            }

            partie(args); // retour debut méthode partie
        }
    }
}
