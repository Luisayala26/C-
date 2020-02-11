using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesGenericas
{
    class Stack<T>
    {
        private int posicion=0;
        private T[] datos;

        public Stack()
        {
            datos = new T[10];
        }

        public Stack(int tam)
        {
            datos = new T[tam];
        }

        public void Push (T objeto)
        {
            datos[posicion++] = objeto;
        }

        public T pop()
        {
            return datos[--posicion];
        }

    }
}
