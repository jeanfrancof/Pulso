using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pulso
{
    class Program
    {
        static void Main(string[] args)
        {
            string id, nombre, sexo; int edad; decimal pulsacion;

            Console.WriteLine("******  Calculo de Pulsaciones     ******* ");
            Console.Write("Digite su  id: ");         id = Console.ReadLine();
            Console.Write("Digite su nombre: ");      nombre = Console.ReadLine();
            Console.WriteLine("F->Femenino o M-> Masculino): ");
            Console.Write("Digite su genero: ");      sexo = Console.ReadLine();
            Console.Write("Digite su edad: ");        edad = Int32.Parse(Console.ReadLine());

            if (sexo.ToUpper() == "F")
            {
                pulsacion = (220 - edad) / 10;
            }
            else if (sexo.ToUpper() == "M")
            {
                pulsacion = (210 - edad) / 10;
            }
            else
            {
                pulsacion = 0;
            }

            Console.WriteLine($"la persona {nombre} con id  {id} debe tener {pulsacion} pulsaciones por cada 10 segundos de entrenamiento fisico ");
            Console.ReadKey();
        }
    }
}
