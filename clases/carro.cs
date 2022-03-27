using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_carro.clases
{
    internal class carro

        {
        public string Marca { get; set; }
        public int Modelo { get; set; }
        public String Color { get; set; }

        private int Encendido = 0;
        private int apagado = 0; 
        private int va = 0;
        private const int MV = 200;

        public carro(string nombre, int modelo, string color)
        {
            Marca = nombre;
            Modelo = modelo;
            Color = color;
            Encendido = 0;
            this.va = 0;


        }
        public string vla()
        {
            return $"la velocidad es  {va} KPH";
        }

        public void EncenderMotor()
        {
            if (Encendido == 0)
            {
                Console.WriteLine("mummmmmm carro encendido");
                Encendido = 1;
            }
            else
            {
                Console.WriteLine("el carro ya estaba encendido");
            }
        }
        public string Acelerar()
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"el carro esta apagado";
                return mensaje;
            }



            va += 10;
           
            if (va <= MV)
            {
                mensaje = $" la velocidad es {va} KPH";
            }
            else
            {
                va = MV;
                mensaje = $"{va} KPH vas sobre el limite de velocidad desacelera";

                Bocina();
            }


            Console.WriteLine(mensaje);
            return mensaje;



        }
        public string Desacelerar()
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"el carro esta apagado";
                return mensaje;
            }



            va -= 10;
            if (va <= MV)
            {
                mensaje = $"desacelerando {va} KPH";
            }
            

            Console.WriteLine(mensaje);
            return mensaje;
        }
        public string FRENAR()
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"al carro esta apagado";
                return mensaje;
            }



            va -= 25;
            if ((va <= MV) && (va > 0))
            {
                mensaje = $"Vas frenando {va} KPH";
            }
            else
            {
                mensaje = "ya freno";
            }

            Console.WriteLine(mensaje);
            return mensaje;
        }

        public void ApagarMotor()
        {
            if (apagado == 0)
            {
                Console.WriteLine("carro apagado");
                apagado = 1;
            }
            else
            {
                Console.WriteLine("ya estaba apagado");
            }
        }
        public string Bocina()
        {
            string mensaje = "";
           
            {
                Console.Beep();
                Console.WriteLine("beep");
            }
           
            Console.WriteLine(mensaje);
            return mensaje;
        }

        }
}
