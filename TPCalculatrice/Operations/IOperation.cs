using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCalculatrice.Operations
{


    public interface IOperation
    {
        void Executer();

        int Resultat
        {
            get;
        }
    }
}
