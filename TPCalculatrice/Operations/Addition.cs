using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCalculatrice.Operations
{
    public class Addition : Operation
    {
        public Addition(int operandeGauche, int operandeDroite) : base(operandeGauche, operandeDroite)
        {

        }

        public override void Executer()
        {
            Resultat = OperandeGauche + OperandeDroite;
        }

        public override string ToString()
        {
            return $"{OperandeGauche} + {OperandeDroite} = {Resultat}";
        }
    }
}
