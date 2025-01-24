using System;
using TPCalculatrice;
using TPCalculatrice.Operations;

class program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Bienvenue sur ma calculatrice");

        while (true)
        {
            Console.WriteLine("Saissisez l'opérateur 'q' pour quitter");
            string operateur = Console.ReadLine();

            if (operateur == "q")
            {
                break;
            }

            Console.WriteLine("Saisissez le premier nombre");
            var Operation1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Saisissez le deuxieme nombre");
            var Operation2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Saisissez l operateur");
            string Operateur = Console.ReadLine();

            IOperation operation;

            if (Operateur == "+")
            {
                operation = new Addition(Operation1, Operation2);
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

            Console.WriteLine("Le resultat de votre operation est:" + Calcul.Resultat);
        }

        Console.WriteLine("----------------------");
        Console.WriteLine("Historique:");
        foreach (var ope in Historique.Operations)
        {
            Console.WriteLine(ope.ToString());
        }
    }
}