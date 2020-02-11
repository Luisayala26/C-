using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones2
{
    class NegativeNumberException:Exception
    {
        public NegativeNumberException():base("Operacion invalida con numero negativo") {  }
        public NegativeNumberException(string Mensaje) : base(Mensaje) { }
    }
}
