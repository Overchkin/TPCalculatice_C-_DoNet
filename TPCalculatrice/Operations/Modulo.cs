using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TPCalculatrice.Operations
{
    public class Modulo : Operation
    {
        public Modulo(int operandeGauche, int operandeDroite) : base(operandeGauche, operandeDroite)
        {

        }

        public override void Executer()
        {
            if (OperandeDroite != 0)
            {
                Resultat = OperandeGauche % OperandeDroite;
            }
        }

        public override string ToString()
        {
            return $"{OperandeGauche} % {OperandeDroite} = {Resultat}";
        }
    }
}
