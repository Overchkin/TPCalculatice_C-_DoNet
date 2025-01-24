using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCalculatrice.Operations;

namespace TPCalculatrice
{
    public static class Historique
    {
        public static List<IOperation> Operations
        {
            get;
        }
        = new List<IOperation>();
    }
}
