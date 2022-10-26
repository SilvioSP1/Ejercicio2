using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class SilvioList
    {
        public int[] dato = new int[1];
        public int contador = 0;
        public int tamaño;

        public SilvioList()
        {

        }

        public bool ListaVacia() { return dato == null; }

        public void InsertarAlFinal(int item)
        {
            if (ListaVacia()) 
            {

                dato[contador] = item;
                contador++;
                tamaño = dato.Length;
            }
            else
            {
                tamaño++;
                Array.Resize(ref dato, tamaño);
                dato[contador] = item;
                contador++;
                tamaño = dato.Length;
            }

        }


        public void InsertarPorPos(int item, int pos)
        {
            int aux = 0;
            if (ListaVacia())
            {
                Console.WriteLine("La lista esté vacia, por lo tanto se va a insertar en la posicién 0");
                dato[0] = item;
                contador++;
            }
            else
            {
                if (pos <= tamaño )
                {
                    for (int i = 0; i <= pos; i++)
                    {
                        if (i == pos && pos <= tamaño) 
                        {
                            Array.Resize(ref dato, ++tamaño);
                            aux = dato[i];
                            dato[i] = item;
                            dato[i + 1] = aux;
                            contador++;
                        }
                    }
                }
                else if (pos > tamaño)
                {
                    Console.WriteLine("No se puede agreagar nada a esa poscion");
                }

            }

        }

        public void Borrar(int v)
        {
            int[] aux = new int[tamaño];
            int cont = 0,dif = 0;
            if (ListaVacia())
            {
                Console.WriteLine("No se puede eliminar nada poeque la lista esta vacia");
            }
            else if(Existe(v))
            {
                for (int i = 0; i < tamaño; i++)
                {
                    if (dato[i] != v) 
                    {
                        aux[cont] = dato[i];
                        cont++;
                    }
                    else if (dato[i] == v)
                    {
                        contador--;
                    }
                }
                tamaño = cont;
                Array.Resize(ref dato, tamaño);
                for (int i = 0; i < tamaño; i++)
                {
                    dato[i] = aux[i];
                    
                }
                
            }
            else
            {
                Console.WriteLine("El valor no existe");
            }
            
        }

        public void BuscarPos(int pos)
        {
            Console.WriteLine($"El valor de la posicion {pos} es {dato[pos]}");
        }

        public void BuscarValor(int v)
        {
            for (int i = 0; i < tamaño; i++)
            {
                if (dato[i] == v)
                {
                    Console.WriteLine($"La posicion del valor {v} es {i}");
                }
            }
        }

        public void OrdenarMay()
        {
            if (!ListaVacia())
            {
                for (int x = 0; x < tamaño; x++)
                {
                    for (int i = 0; i < tamaño -x- 1; i++)
                    {
                        if (dato[i] > dato[i + 1])
                        {
                            int tmp = dato[i + 1];
                            dato[i + 1] = dato[i];
                            dato[i] = tmp;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Lista vacia");
            }
        }

        public bool Existe(int v)
        {
            for (int i = 0; i < tamaño; i++)
            {
                if (dato[i] == v)
                {
                    return true;
                }
            }
            return false;
        }

        public void Mostrar()
        {
            if (ListaVacia())
            {
                Console.WriteLine("Lista vacia");
            }
            else
            {
                for (int i = 0; i < tamaño; i++)
                {
                    Console.WriteLine($"Dato {i}: {dato[i]}");
                }
            }
            Console.WriteLine();
        }
    }
}
