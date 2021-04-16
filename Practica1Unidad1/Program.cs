using System;

namespace Practica1Unidad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Alumno = 0;
            Console.WriteLine("Ingresar la cantidad de alumnos");
            Alumno = Convert.ToInt32(Console.ReadLine());
            decimal[,] arreglocalif = new decimal[Alumno, 2];
            Console.WriteLine();

            for (int i = 0; i <= Alumno-1; i++)
            {
                Console.WriteLine("Calificacion del alumno N."+(i+1).ToString());
                arreglocalif[i, 0]=Convert.ToDecimal(Console.ReadLine());
                arreglocalif[i, 1] = (i + 1);//Alumno
                Console.WriteLine();
            }
            decimal calif = 0;
            decimal Alumno2 = 0;
            for (int i = 0; i <= Alumno - 1; i++)
            {
                if (arreglocalif[i,0]>calif)
                {
                    calif = arreglocalif[i, 0];
                    Alumno2 = arreglocalif[i, 1] = (i + 1);
                }
            }
            Console.WriteLine("El alumno con el mejor promedio es el alumno n. {0} con una calificacion de {1}",
            Alumno2.ToString(),
            calif.ToString());
            Console.WriteLine();

            calif = 10;
            Alumno2 = 0;
            for (int i = 0; i <= Alumno-1; i++)
            {
                if (arreglocalif[i,0] < calif)
                {
                    calif = arreglocalif[i, 0];
                    Alumno2 = arreglocalif[i, 1] = (i + 1);
                }
            }
            Console.WriteLine("El alumno con el peor promedio es el alumno n. {0} con una calificacion de {1}",
            Alumno2.ToString(),
            calif.ToString());

            Console.ReadKey();
        }
    }
}
