using System;
using System.Collections.Generic;
using System.Text;

namespace eje13
{
    //clase CarroBMW que hereda de Carro con contructor y un metodo que muestra la informacion del objeto 
    class CarroBMW:Carro
    {
        string modelo;
        public CarroBMW(double peso,double altura):base(peso,altura)
        {
            modelo = "BMW";
        }
        public override string ToString()
        {
            return "Modelo: " + modelo + "Peso: " +"Altura: " + altura;
        }
    }
    //clase CarroVW que hereda de Carro con contructor y un metodo que muestra la informacion del objeto
    class CarroVW : Carro
    {
        string modelo;
        public CarroVW(double peso, double altura) : base(peso, altura)
        {
            modelo = "VM";
        }
        public override string ToString()
        {
            return "Modelo: "+ modelo+"Peso: "+"Altura: "+altura;
        }
    }
}
