using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaBinaria
{
    class Vector
    {
        int[] vector;
        public int comparaciones { get; private set; }

        public Vector(int tamaño)
        {
            vector = new int[tamaño];
            comparaciones = 0;
        }

        public void llenar(int limite)
        {
            Random r = new Random();
            for (int i = 0; i < vector.Length; i++)
                vector[i] = r.Next(limite);
        }

        public string mostrar()
        {
            string s = "";
            for (int i = 0; i < vector.Length; i++)
                s += "[" + i.ToString() + "] = " + vector[i].ToString();
            return s;
        }

        public void ordenar()
        {
            Array.Sort(vector);
        }

        public int busquedaBin(int numero)
        {
            int limiteI = 0;
            int limiteS = vector.Length;
            int mitad = 0;
            while (mitad != 0 || mitad != vector.Length-1)
            {
                mitad = (limiteS + limiteI) / 2;
                if (vector[mitad] == numero)
                    return vector[mitad];
                if (numero > vector[mitad])
                    limiteI = mitad;
                else
                    limiteS = mitad;
                comparaciones++;
            }
            return -1;
        }

        public override string ToString()
        {
            string s = "";
            for(int i = 0; i < vector.Length; i++)
            {
                s += vector[i].ToString() + " ";
            }
            return s;
        }
    }
}
