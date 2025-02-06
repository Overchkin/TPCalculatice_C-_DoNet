using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCalculatrice.Operations
{
    public class Puissance : Operation
    {
        public Puissance(int operandeGauche, int operandeDroite) : base(operandeGauche, operandeDroite)
        {

        }

        public override void Executer()
        {
            Resultat = (int)Math.Pow(OperandeGauche, OperandeDroite);
        }

        public override string ToString()
        {
            return $"{OperandeGauche} Math.Pow {OperandeDroite}";
        }
    }
}
