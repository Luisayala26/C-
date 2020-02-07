using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesAbstractas
{
    class Carnivoro :Animal
    {
        public Carnivoro(string nombre) :base(nombre){ }
        public override string Come
        {
            get { return "Come otros animales"; }
        }

        public virtual void Cazar()
        {
            Console.WriteLine("El animal esta casando");
        }

    }

    class Herbivoro : Animal
    {
        public Herbivoro(string nombre):base(nombre) { }
        public override string Come
        {
            get { return "come plantas"; }
        }
        public void Recolecta() 
        {
            Console.WriteLine("EL animal recolecta su comida");
        }
    }

}
