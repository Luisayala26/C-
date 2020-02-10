using System;
using System.Collections.Generic;
using System.Text;
/*Se Crearon las clases Fugo, Agua y Hierba la cual hereda de la clase ITipo  
 * Se creo el meto que hereda de ITipo  el cual para cada clase es diferente */
namespace eje17
{
    class Fuego:ITipo
    {
        public string Tipo() { return "Fuego"; }
    }
    class Agua : ITipo
    {
        public string Tipo() { return "Agua"; }
    }
    class Hierba : ITipo
    {
        public string Tipo() { return "Hirba"; }
    }
}
