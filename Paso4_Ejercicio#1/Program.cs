//Nombre del estudiante:Daniela Guzman+
//Grupo: 213022_386
//Numero y texto del progrma: 1_En la empresa ICO LTD se requiere un programa que permita hallar la edad promedio de sus empleados así:Por teclado se debe solicitar la cantidad de usuarios a valorar.(ejemplo si digita 5 deberá repetir los pasos siguientes 5 veces)
//Se requiere captura por teclado de nombre y edad (siendo la edad un número entero).Se debe implementar una función que reciba como parámetro la edad de los empleados, calcule y retorne el valor de la edad promedio de los empleados.
//Codigo de fuente:

using System;

namespace ICO_LTD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de empleados: ");
            int cantidadEmpleados = int.Parse(Console.ReadLine());

            string[] nombres = new string[cantidadEmpleados];
            int[] edades = new int[cantidadEmpleados];

            for (int i = 0; i < cantidadEmpleados; i++)
            {
                Console.Write("Ingrese el nombre del empleado " + (i + 1) + ": ");
                nombres[i] = Console.ReadLine();

                Console.Write("Ingrese la edad del empleado " + (i + 1) + ": ");
                edades[i] = int.Parse(Console.ReadLine());
            }

            double promedio = CalcularPromedio(edades);
            Console.WriteLine("La edad promedio de los empleados es: " + promedio);

            string empleado1 = ObtenerEmpleadoCercano(edades, promedio);
            string empleado2 = ObtenerEmpleadoCercano(edades, promedio, empleado1);

            Console.WriteLine("Los empleados más cercanos al promedio son: " + empleado1 + " y " + empleado2);
        }

        static double CalcularPromedio(int[] edades)
        {
            int suma = 0;
            foreach (int edad in edades)
            {
                suma += edad;
            }
            return (double)suma / edades.Length;
        }

        static string ObtenerEmpleadoCercano(int[] edades, double promedio, string empleadoExcluido = "")
        {
            int empleadoCercano = edades[0];
            foreach (int edad in edades)
            {
                if (Math.Abs(edad - promedio) < Math.Abs(empleadoCercano - promedio) && !empleadoExcluido.Equals(edad.ToString()))
                {
                    empleadoCercano = edad;
                }
            }
            return Array.Find(edades, x => x == empleadoCercano).ToString();
        }
    }
}


