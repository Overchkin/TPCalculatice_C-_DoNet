using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCalculatrice.Operations;

namespace TPCalculatrice
{

    public class Calculatrice
    {
        public IOperation Operation
        {
            get;
        }

        public int Resultat => Operation.Resultat;

        //Création du constructeur
        public Calculatrice(IOperation operation)
        {
            Historique.Operations.Add(operation);
            Operation = operation;
        }

        public void Executer()
        {
            Operation.Executer();
        }
    }
}

