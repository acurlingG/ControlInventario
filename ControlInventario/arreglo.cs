using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario
{

    internal class arreglo
    {

        public void ejercicio()
        {
            int[] codigo = new int[10];   // arreglo de 10 posiciones codigos
            string[] producto = new string[10]; // arreglo de 10 posiciones producto
            float[] costo = new float[10];
            int[] cantidad = new int[10];
            costo[2] = 200;
            costo[9] = 500;
            codigo[2] = 50;
            producto[0] = "Teclado";
            producto[2] = "Mouse";
            producto[9] = "Pantalla";
            codigo[9] = 100;
            costo[3] = 600;
            costo[4] = 800;
            costo[5] = 300;
            // imprimir los valores de un arreglo

            for (int i = 0; i < 10; i++)
            {
                // and or not  &&   ||  !
                // Articulos con codigo = 0  y precio sea 200 entre 300
                if (codigo[i] == 0 && (costo[i] >= 200 && costo[i] <= 300))
                {
                    Console.WriteLine($"Codigo: {codigo[i]} Producto: {producto[i]} Precio: {costo[i]}");  //interpolacion
                }



            }

        }
     
    }
}
