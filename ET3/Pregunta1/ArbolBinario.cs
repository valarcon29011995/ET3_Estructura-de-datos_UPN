using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta1
{
    internal class ArbolBinario
    {
        public Nodo raiz;
        public Nodo GetRaiz()
        {
            return raiz;
        }

        public void Inorden(Nodo raiz)
        {
            if (raiz != null)
            {
                Inorden(raiz.izquierdo);
                Console.WriteLine("{0}, valor {1}", raiz.valor, raiz.datos);
                Inorden(raiz.derecho);
            }
        }

        public void Preorden(Nodo raiz)
        {
            if (raiz != null)
            {
                Console.WriteLine("{0}, valor {1}", raiz.valor, raiz.datos);
                Preorden(raiz.izquierdo);
                Preorden(raiz.derecho);
            }
        }

        public void Postorden(Nodo raiz)
        {
            if (raiz != null)
            {
                Postorden(raiz.izquierdo);
                Postorden(raiz.derecho);
                Console.WriteLine("{0}, valor {1}", raiz.valor, raiz.datos);
            }
        }

        public void InsertarNodo(int valor, string datos)
        {
            Nodo puntero;
            Nodo padre;
            Nodo nodo = new Nodo
            {
                valor = valor,
                datos = datos,
            };
            if (raiz != null)
            {
                puntero = raiz;
                while (true)
                {
                    padre = puntero;
                    if (valor < puntero.valor)
                    {
                        puntero = puntero.izquierdo;
                        if (puntero == null)
                        {
                            padre.izquierdo = nodo;
                            break;
                        }
                    }
                    else
                    {
                        puntero = puntero.derecho;
                        if (puntero == null)
                        {
                            padre.derecho = nodo;
                            break;
                        }
                    }
                }
            }
            else
            {
                raiz = nodo;
            }
        }
        public void BuscarPorLlave(int llave)
        {
            Nodo puntero = raiz;
            while (puntero != null)
            {
                if (puntero.valor == llave)
                {
                    Console.WriteLine("Llave {0} encontrada", puntero.valor);
                    return;
                }
                else
                {
                    if (llave > puntero.valor)
                    {
                        puntero = puntero.derecho;
                    }
                    else
                    {
                        puntero = puntero.izquierdo;
                    }
                }
            }
            Console.WriteLine("No se encontró la llave");
        }
    }
}
