using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_12
{
    internal class Estudiantes
    {
        byte[] edades = new byte[0];
        int posicion = 0;

        public void insertar()
        {
            byte ed;
            string seguir;
            do
            {
                Console.Write("Ingrese edad: ");

                while (!byte.TryParse(Console.ReadLine(), out ed) || ed < 14 || ed > 120)
                {
                    Console.WriteLine("Error: Ingrese edad: ");
                }
                Array.Resize(ref edades, edades.Length + 1);
                edades[posicion] = ed;
                posicion++;
                Console.WriteLine("\nEdad registrada correctamente");
                Console.WriteLine("\nDesea seguir registrando? [si]: ");
                seguir = Console.ReadLine();
            } while (seguir == "si");
            
        }
        public void mostrar()
        {
            Console.SetCursorPosition(10, 12);
            Console.Write("POSICIÓN");
            Console.SetCursorPosition(30, 12);
            Console.Write("EDADES");
            for(int i = 0; i < edades.Length; i++)
            {
                Console.SetCursorPosition(10, 13+i);
                Console.Write(i);
                Console.SetCursorPosition(30, 13 + i);
                Console.Write(edades[i]);
            }
        }

        public void eliminar(byte ed)
        {
            int indice = Array.IndexOf(edades, ed);

            if(indice == -1)
            {
                for(int i = indice; i < edades.Length; i++)
                {
                    edades [i] = edades [i+1];
                }
                Array.Resize(ref edades, edades.Length - 1);
                posicion--;
                Console.WriteLine("\n Eliminado correctamente.");
            } else
            {
                Console.WriteLine("\nNo se puede eliminar porque no existe");
            }
        }
    }
}
