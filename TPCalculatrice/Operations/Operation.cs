using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCalculatrice.Operations
{
    public abstract class Operation : IOperation
    {
        protected int OperandeGauche
        {
            get;
        }
        protected int OperandeDroite
        {
            get;
        }
        public int Resultat
        {
            get;
            protected set;
        }


        //Création du constructeur
        protected Operation(int operandeGauche, int operandeDroite)
        {
            OperandeGauche = operandeGauche;
            OperandeDroite = operandeDroite;
        }
        public abstract void Executer();
    }
}
