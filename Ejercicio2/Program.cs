using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List

            /*SilvioList list = new SilvioList();
            list.InsertarAlFinal(10);
            list.InsertarAlFinal(45);
            list.InsertarAlFinal(15);
            list.InsertarPorPos(16,2);
            list.Mostrar();
            list.Borrar(15);
            list.InsertarPorPos(20, 2);
            list.Mostrar();
            list.BuscarPos(1);
            list.BuscarValor(16);
            list.OrdenarMay();
            list.Mostrar();
            Console.Read();*/

            //LinkedList

            SilvioLinkedList linkedList = new SilvioLinkedList();
            linkedList.InsertarPosFinal(15);
            linkedList.InsertarPosFinal(40);
            linkedList.InsertarPosFinal(4);
            linkedList.InsertarPorPos(1,20);
            linkedList.Imprimir();
            linkedList.Borrar(2);
            linkedList.Imprimir();
            linkedList.BuscarValor(40);
            linkedList.BuscarPos(1);
            linkedList.Ordenar();
            linkedList.Imprimir();
            Console.Read();
        }
    }
}
