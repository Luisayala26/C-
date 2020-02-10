using System;
/*
9. Haz una pequeña investigación sobre los métodos que se encuentran en la clase Math y para
qué sirven. Crea una clase llamada Cículo y otra con el nombre de la gura geométrica de tu
preferencia. Cada clase deberá tener sus respectivos atributos y métodos de tal manera que
ocupes mínimo tres métodos de la clase Math.
Nota: la investigación se puede incluir como comentario en su archivo.
     */
namespace eje9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objeto y Metodos de la CLase circulo y cuadrado
            Circulo c = new Circulo();
            c.r = -5;
            Console.WriteLine(c.Area());

            Cuadrado c1 = new Cuadrado();
            c1.l = 10;
            Console.WriteLine(c1.Area());
            Console.ReadKey();
        }
    }
}

/*
 Métodos 
Abs (doble)
Devuelve el valor absoluto de un número decimal .

Acos (doble)
Devuelve el ángulo cuyo coseno es el número especificado.

Asin (doble)
Devuelve el ángulo cuyo seno es el número especificado.

Atan (doble)
Devuelve el ángulo cuya tangente es el número especificado.

BigMul (Int32, Int32)
Produce el producto completo de dos números de 32 bits.

Ceiling (doble)
Devuelve el valor integral más pequeño que es mayor o igual que el número de punto flotante de precisión doble especificado.

Cos (doble)
Devuelve el coseno del ángulo especificado.

Cosh (doble)
Devuelve el coseno hiperbólico del ángulo especificado.

Exp (doble)
Retornos eelevados a la potencia especificada.

Floor (doble)
Devuelve el valor integral más grande menor o igual que el número de punto flotante de precisión doble especificado.

IEEERemainder (Doble, Doble)
Devuelve el resto resultante de la división de un número especificado por otro número especificado.

Log (doble)
Devuelve el elogaritmo natural (base ) de un número especificado.

Max (doble, doble)
Devuelve el mayor de dos números de punto flotante de doble precisión.

Min (doble, doble)
Devuelve el menor de dos números de punto flotante de doble precisión.

Pow (doble, doble)
Devuelve un número especificado elevado a la potencia especificada.

Round (decimal)
Redondea un valor decimal al valor integral más cercano y redondea los valores del punto medio al número par más cercano.

Sign (decimal)
Devuelve un número entero que indica el signo de un número decimal.

Sin (doble)
Devuelve el seno del ángulo especificado.

Sqrt (Doble)
Devuelve la raíz cuadrada de un número especificado.

Tan (Doble)
Devuelve la tangente del ángulo especificado.

Truncate (Decimal)
Calcula la parte integral de un número decimal especificado.
     */
