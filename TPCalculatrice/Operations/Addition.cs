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
            return $"{OperandeGauche} + {OperandeDroite}";
        }

        public override bool Equals(object? obj)
        {
           if(obj is null)
            {
                return false;
            }
           if(obj is Addition add)
            {
                return add.OperandeDroite == OperandeDroite && add.OperandeGauche == OperandeGauche;
            }
           else
            {
                return false;
            }
        }
    }
}
