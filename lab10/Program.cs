using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            listaopciones();
            Console.ReadKey();



        }
        public static void listaopciones()
        {
            Console.WriteLine("" +
            "================================\n" +
            "Productos de mPhone\n" +
            "================================\n" +
            "1: Ventas de mPhone 3000\n" +
            "2: Ventas de mPad 3500\n" +
            "3: Ventas de MAPBrook 3800\n" +
            "4: Ventas de mWatch 8000\n" +
            "5: Salir\n" +
            "================================\n" +
            "Ingrese una opción:\n");

            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    venta2("mPhone 3000");

                    break;
                case 2:
                    Console.Clear();
                    venta2("mPad 3500");

                    break;
                case 3:
                    Console.Clear();
                    venta2("MAPBrook 3800");

                    break;
                case 4:
                    Console.Clear();
                    venta2("mWatch 8000");
                    break;
                case 5:

                    boletafinal("regreso");
                    break;


            }
        }
        public static void venta2(string textopantalla)
        {
            Console.WriteLine(" " +
            "================================\n" +
            "Registrar Venta de " + textopantalla + "\n" +
            "================================\n" +
            "1: Registrar Venta\n" +
            "2: Registrar Devolucion\n" +
            "3: Menu principal\n" +
            "================================\n" +
            "Ingrese una opcion\n");
            int opcion22 = int.Parse(Console.ReadLine());
            switch (opcion22)
            {
                case 1:
                    Console.Clear();
                    listaventas1(textopantalla);
                    break;
                case 2:
                    Console.Clear();
                    listadevolucion1(textopantalla);
                    break;
                case 3:
                    Console.Clear();
                    listaopciones();
                    break;


            }



        }
        public static void listaventas1(string textopantalla2)
        {
            Console.WriteLine("" +
            "================================\n" +
            "Registrar venta de:\n" +
            "================================\n" +
            "Se va a registrar la venta de un\n" +
            textopantalla2 + " Desea continuar??\n" +
            "1:SI\n" +
            "2:NO\n" +
            "================================\n" +
            "Ingrese una opcion:\n");
            int opcion3 = int.Parse(Console.ReadLine());
            switch (opcion3)
            {
                case 1:
                    Console.WriteLine("Ingrese cantidad");
                    int cantidadneta = int.Parse(Console.ReadLine());
                    Console.Clear();
                    listaopciones();
                    break;
                case 2:
                    listaopciones();
                    break;


            }
        }
        public static void listadevolucion1(string textopantalla3)
        {
            Console.WriteLine("================================\n" +
                              "Registrar devolucion de:\n" +
                              "================================\n" +
                              "Se va a registrar la devolucion de un\n" +
                               textopantalla3 + " Desea continuar??\n" +
                              "1:SI\n" +
                              "2:NO\n" +
                              "================================\n" +
                              "Ingrese una opcion:\n");
            int opcion3 = int.Parse(Console.ReadLine());

            switch (opcion3)
            {
                case 1:
                    Console.WriteLine("Ingrese cantidad");
                    int cantidadneta = int.Parse(Console.ReadLine());
                    Console.Clear();
                    listaopciones();

                    break;
                case 2:
                    listaopciones();
                    break;


            }

        }

        public static void boletafinal(string cantidadneta)
        {

            Console.WriteLine("" +
            "================================\n" +
            "Reporte Final\n" +
            "================================\n" +
            "Productos Vendidos | Cantidad\n" +
            "--------------------------------\n" +
            "mPhones   |\n" + cantidadneta +
            "mPads     |\n" + cantidadneta +
            "MAPBrooks |\n" + cantidadneta +
            "mWatches  |\n" + cantidadneta +
            "--------------------------------\n" +
            "Total     |\n" + cantidadneta +
            "================================\n" +
            "Hasta luego!!!");

        }
    }
}
