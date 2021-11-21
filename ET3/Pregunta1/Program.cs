using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta1
{
    internal class Program
    {
        static ArbolBinario Lpostulantes = new ArbolBinario();
        static void Main(string[] args)
        {
            ArbolBinario arbol = new ArbolBinario();
            arbol.InsertarNodo(10, "Victor Alarcon - Ingeniería de Sistemas");
            arbol.InsertarNodo(15, "Manuel Arroyo - Administración");
            arbol.InsertarNodo(13, "Pamela Castellanos - Ingeniería Industrial");
            arbol.InsertarNodo(12, "Miriam Curasma - Contabilidad");
            arbol.InsertarNodo(14, "Heidi Contreras - Administración");
            Console.WriteLine("Inorden:");
            arbol.Inorden(arbol.GetRaiz());
            Console.WriteLine("");

            Console.WriteLine("Preorden:");
            arbol.Preorden(arbol.GetRaiz());
            Console.WriteLine("");

            Console.WriteLine("Postorden:");
            arbol.Postorden(arbol.GetRaiz());
            Console.WriteLine("");

            Console.Read();
        }
    }
}
