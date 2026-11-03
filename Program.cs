namespace Braquage_train;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consignes :
           - Utiliser une première boucle pour parcourir les quatre wagons.
           - Utiliser une deuxième boucle à l'intérieur pour parcourir les trois coffres de chaque wagon.
           - Afficher chaque coffre inspecté avec son numéro de wagon.
           - Compter le nombre total de coffres inspectés.
           
           Exemple :
               Inspection des 4 wagons du train
               Wagon 1 - Coffre 1 inspecté
               Wagon 1 - Coffre 2 inspecté
               Wagon 1 - Coffre 3 inspecté
               Wagon 2 - Coffre 1 inspecté
               ...
               Total : 12 coffres inspectés.
            
            BONUS 1 : permettre à l'utilisateur de choisir le nombre de wagons
            BONUS 2 : enregistrer l'ensemble du butin trouvé et l'afficher à la fin
         */

        int total = 0;

        // Liste pour enregistrer le butin
        List<string> butin = new List<string>();

        // Demander le nombre de wagons
        Console.Write("Combien de wagons contient le train ? ");
        int nombreWagons = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nInspection des " + nombreWagons + " wagons du train");

        // Parcourir les wagons
        for (int wagon = 1; wagon <= nombreWagons; wagon++)
        {
            // Parcourir les 3 coffres de chaque wagon
            for (int coffre = 1; coffre <= 3; coffre++)
            {
                Console.WriteLine("\nWagon " + wagon + " - Coffre " + coffre + " inspecté");

                total++;

                // Demander le butin trouvé
                Console.Write("Quel butin avez-vous trouvé ? ");
                string objet = Console.ReadLine();

                // Enregistrer le butin dans la liste
                butin.Add(objet);
            }
        }

        // Afficher le nombre total de coffres inspectés
        Console.WriteLine("\nTotal : " + total + " coffres inspectés.");

        // Afficher tout le butin trouvé
        Console.WriteLine("\nVoici la liste du butin trouvé :");

        for (int i = 0; i < butin.Count; i++)
        {
            Console.WriteLine("- " + butin[i]);
        }
    }
}