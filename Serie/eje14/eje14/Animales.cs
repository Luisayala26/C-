using System;
using System.Collections.Generic;
using System.Text;

namespace eje14
{
    //clases que heredan de IRespiracion
    class Insecto:IRespiracion
    {
        public void Modo() { Console.WriteLine("Tiene Respiracion Traqueal"); }
    }
    class Pez:IRespiracion
    {
        public void Modo() { Console.WriteLine("Tiene Respiracion Branquial"); }
    }
    class Mamifero:IRespiracion
    {
        public void Modo() { Console.WriteLine("Tiene Respiracion Pulmunar"); }
    }
}
