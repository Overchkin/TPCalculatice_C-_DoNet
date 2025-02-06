using System;
using TPCalculatrice;
using TPCalculatrice.Operations;

class program
{

    static int GetintValue(string valeur)
    {
        int? resultat = null; // Déclare `resultat` en dehors de la boucle

        while (!resultat.HasValue)
        {
            Console.WriteLine($"Saisissez la {valeur} valeur entière");
            string saisie = Console.ReadLine();

            if (!string.IsNullOrEmpty(saisie))
            {
                try
                {
                    resultat = int.Parse(saisie); // Essaie de convertir la saisie en entier
                }
                catch
                {
                    Console.WriteLine("Entrée invalide. Veuillez saisir un entier valide.");
                }
            }
            else
            {
                Console.WriteLine("Entrée vide. Veuillez saisir un entier.");
            }
        }

        return resultat.Value; // Retourne la valeur de `resultat`
    }

    static void Main(string[] args)
    {


        Console.WriteLine("Bienvenue sur ma calculatrice");

        while (true)
        {
            Console.WriteLine("Saissisez l'opérateur 'q' pour quitter ou sur entrer pour commencer");
            string operateur = Console.ReadLine()?.ToLower();

            if (operateur == "q")
            {
                Console.WriteLine("Merci d'avoir utilisé la calculatrice !");
                break;
            }

            var Operation1 = GetintValue("première");
            var Operation2 = GetintValue("seconde");

            Console.WriteLine("Saisissez l'opérateur (+, -, *, /, %) :");
            string Operateur = Console.ReadLine();

            IOperation operation;
            Operation SecondOperation;

            if (Operateur == "+")
            {
                operation = new Addition(Operation1, Operation2);
                SecondOperation = new Addition(Operation1, Operation2);
                Console.WriteLine($"Additions égales ? {Operation.Equals(SecondOperation)}");
            }
            else if (Operateur == "-")
            {
                operation = new Soustraction(Operation1, Operation2);
            }
            else if (Operateur == "*")
            {
                operation = new Multiplication(Operation1, Operation2);
            }
            else if (Operateur == "/")
            {
                operation = new Division(Operation1, Operation2);
            }
            else if (Operateur == "%")
            {
                operation = new Modulo(Operation1, Operation2);
            }
            else
            {
                Console.WriteLine("Operateur non reconnu");
                return;
            }

            Calculatrice Calcul = new Calculatrice(operation);
            Calcul.Executer();

            Console.WriteLine($"{Calcul.Operation.ToString()} = {Calcul.Operation.Resultat}");
        }

        Console.WriteLine("----------------------");
        Console.WriteLine("Historique:");
        foreach (var ope in Historique.Operations)
        {
            Console.WriteLine($"{ ope.ToString()} = {ope.Resultat}");
        }
    }
}