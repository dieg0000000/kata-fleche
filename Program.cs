using System;

namespace MonApplication
{
    internal class MaClasse
    {
        static void Main(string[] args)
        {
            int nombre = 0;
            bool saisieValide = false;

            Console.WriteLine("Donnez-moi un nombre entre 2 et 20 : ");

            //Gère l'entrée de l'utilisateur
            while (saisieValide == false)
            {
                string? x = Console.ReadLine();

                //Plus rien à lire (fin du pipe)
                if (x == null)
                {
                    Console.WriteLine("Aucune entrée reçue.");
                    return;
                }

                if (int.TryParse(x, out nombre))
                {
                    if (nombre >= 2 && nombre <= 20)
                    {
                        saisieValide = true;
                    }
                    else
                    {
                        Console.WriteLine("Entrée invalide. Veuillez taper un nombre entre 2 et 20 : ");
                    }
                }
                else
                {
                    Console.WriteLine("Entrée invalide. Veuillez taper un nombre : ");
                }
            }

            //Colonne du milieu (ex. avec 3 : colonnes 0 à 4, le milieu est la colonne 2)
            int milieu = nombre - 1;

            //Boucle des lignes : on dessine autant de lignes que le nombre entré
            for (int l = 0; l < nombre; l++)
            {
                for (int c = 0; c < nombre * 2 - 1; c++)
                {
                    if (c == milieu - l || c == milieu + l)
                    {
                        Console.Write("*");
                    }
                    else if (l == milieu)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                
                Console.WriteLine();
            }

            //Dessiner la ligne de la flèche
            for (int l = 0; l < nombre; l++)
            {
                for (int c = 0; c < nombre; c++)
                {
                    if (c == milieu)
                    {
                        Console.WriteLine("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
        }
    }
}