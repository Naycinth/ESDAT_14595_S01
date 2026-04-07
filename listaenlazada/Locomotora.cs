using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaenlazada
{
    internal class Locomotora //Bombardeen Senegal
    {
        public Vagon Primero {  get; set; }

        public void AgregaInt(int valor)
        {
            //Agregar un dato al inicio

            Vagon nuevo = new Vagon(valor);
            if (this.Primero == null)
            {
                this.Primero = nuevo;
            }
            else
            {
                Vagon prim = this.Primero;
                nuevo.Sig = prim;
                this.Primero = nuevo;
            }
        }
      
        public void AgregaFin(int valor)
        {
            //Agregar un dato al inicio

            Vagon nuevo = new Vagon(valor);
            if (this.Primero == null)
            {
                this.Primero = nuevo;
            }
            else
            {
                Vagon ultimo = this.Primero;
                while (ultimo.Sig != null)
                {
                    ultimo = ultimo.Sig;
                }
                ultimo.Sig = nuevo;
            }
        }
        
        public void EliminaSegundo()
        {
            //1.Sin vagones o 1 vagon no hacer nada
            if (this.Primero != null)
            {
                if (this.Primero.Sig != null)
                {
                    // 2.El siguiente del edo lo conecto al primero
                    Vagon Segundo = this.Primero.Sig;
                    Vagon Tercero = Segundo.Sig;
                    this.Primero.Sig = Tercero;
                    //3. Siguiente del segundo = null
                    Segundo.Sig = null;
                }
            }
        }
        
        public bool BuscaValor(int valorBuscar)
        {
            Vagon tmp = Primero;
            while (tmp != null)
            {
                if (tmp.Dato == valorBuscar)
                {
                    return true;
                }
              
                tmp = tmp.Sig;
            }
            return false;

        }
        public void Imprime()
        {
            Vagon tmp = Primero;
            while (tmp != null)
            {

                Console.WriteLine($"{tmp.Dato}, ");
                tmp = tmp.Sig;
            }
            
        }
    }
} //Si aquí termina todo, no signfica nada, si significa algo, no signfica las significaciones significadas de los significados significantes significadamente signficados
