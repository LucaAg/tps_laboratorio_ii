using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TP_02_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configuración de la pantalla
            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(Console.LargestWindowWidth / 2, Console.LargestWindowHeight - 2);

            // Nombre del Alumno
            Console.Title = "Taller de Agnoli Luca Nahuel";

            Taller taller = new Taller(6);

            Ciclomotor c1 = new Ciclomotor(Vehiculo.EMarca.BMW, "ASD012", ConsoleColor.Black);
            Ciclomotor c2 = new Ciclomotor(Vehiculo.EMarca.HarleyDavidson, "LEM666", ConsoleColor.Red);
            Sedan sedan1 = new Sedan(Vehiculo.EMarca.Toyota, "HJK789", ConsoleColor.White);
            Sedan sedan2 = new Sedan(Vehiculo.EMarca.Chevrolet, "IOP852", ConsoleColor.Blue, Sedan.ETipo.CincoPuertas);
            Suv suv1 = new Suv(Vehiculo.EMarca.Ford, "QWE968", ConsoleColor.Gray);
            Suv suv2 = new Suv(Vehiculo.EMarca.Renault, "TYU426", ConsoleColor.DarkBlue);
            Suv suv3 = new Suv(Vehiculo.EMarca.BMW, "IOP852", ConsoleColor.Green);
            Suv suv4 = new Suv(Vehiculo.EMarca.Honda, "ASD913", ConsoleColor.Green);

            // Agrego 8 ítems (los últimos 2 no deberían poder agregarse ni el m1 repetido) y muestro
            taller += c1;
            taller += c2;
            taller += sedan1;
            taller += sedan1;
            taller += sedan2;
            taller += suv1;
            taller += suv2;
            taller += suv3;
            taller += suv4;

            Console.WriteLine(taller.ToString());
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();

            // Quito 2 items y muestro
            taller -= c1;
            taller -= new Ciclomotor(Vehiculo.EMarca.Honda, "ASD913", ConsoleColor.Red);

            Console.WriteLine(taller.ToString());
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();

            // Vuelvo a agregar c2
            taller += c2;

            // Muestro solo Ciclomotor
            Console.WriteLine(Taller.Listar(taller, Taller.ETipo.Ciclomotor));
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();

            // Muestro solo Sedan
            Console.WriteLine(Taller.Listar(taller, Taller.ETipo.Sedan));
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();

            // Muestro solo Suv
            Console.WriteLine(Taller.Listar(taller, Taller.ETipo.Suv));
            Console.WriteLine("<-------------PRESIONE UNA TECLA PARA SALIR------------->");
            Console.ReadKey();
        }
    }
}
