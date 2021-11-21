using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario arbolI = new ArbolBinario();
            arbolI.InsertarNodo(5, "Historia Clinica Paciente 5");
            arbolI.InsertarNodo(1, "Historia Clinica Paciente 1");
            arbolI.InsertarNodo(6, "Historia Clinica Paciente 6");
            arbolI.InsertarNodo(10, "Historia Clinica Paciente 10");
            arbolI.InsertarNodo(11, "Historia Clinica Paciente 11");
            arbolI.InsertarNodo(15, "Historia Clinica Paciente 15");

            Console.WriteLine("Inorden:");
            arbolI.Inorden(arbolI.GetRaiz());
            Console.WriteLine("");
            Console.WriteLine("Búsqueda de la historia clínica número: 15");
            arbolI.BuscarPorLlave(15);
            Console.WriteLine("");


            Console.WriteLine("*********Orden Eficiente*********\n");
            ArbolBinario arbolF = new ArbolBinario();

            arbolF.InsertarNodo(6, "Historia Clinica Paciente 6");
            arbolF.InsertarNodo(5, "Historia Clinica Paciente 5");
            arbolF.InsertarNodo(1, "Historia Clinica Paciente 1");
            arbolF.InsertarNodo(11, "Historia Clinica Paciente 11");
            arbolF.InsertarNodo(10, "Historia Clinica Paciente 10");
            arbolF.InsertarNodo(15, "Historia Clinica Paciente 15");

            Console.WriteLine("Inorden:");
            arbolF.Inorden(arbolF.GetRaiz());
            Console.WriteLine("");
            Console.WriteLine("Búsqueda de la historia clínica número: 15");
            arbolF.BuscarPorLlave(15);
            Console.WriteLine("");


            Console.Read();
        }
    }
}
