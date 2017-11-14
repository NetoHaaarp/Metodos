using System;


namespace ClaseMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            int alumnos, nCal = 0;


            Console.WriteLine("inserte el numero de alumnos: ");
            alumnos = int.Parse(Console.ReadLine());

            int[] calificaciones = RegistrarCalificaciones(alumnos);
            Evaluar(calificaciones);
            Salon(calificaciones, alumnos);

            Console.ReadKey();

        }

        static int[] RegistrarCalificaciones(int numeroCalificaciones)
        {
            int[] cAlum = new int[numeroCalificaciones];
            int nCal = 0;
            do
            {
                Console.WriteLine("inserte calificaion del alumno {0}", (nCal + 1));
                cAlum[nCal] = int.Parse(Console.ReadLine());
                nCal++;
            } while (nCal < numeroCalificaciones);

            return cAlum;
        }

        static void Evaluar(int[] alumnos)
        {
            for (int i = 0; i < alumnos.Length; i++)
            {
                if (alumnos[i] >= 9)
                    Console.WriteLine(" el alumno" + (i + 1) + "es un excelente alumno");
                else if (alumnos[i] >= 7)
                    Console.WriteLine(" el alumno" + (i + 1) + "es un buen alumno");
                else
                    Console.WriteLine(" el alumno" + (i + 1) + "es un mal alumno");
            }
        }

        static void Salon(int[] calif, int alumnoss)
        {

            float res = 0;
            string grupo;

            foreach (int item in calif)
            {
                res += item;
            }
            res /= alumnoss;

            if (res >= 9)
                grupo = " excelente grupo";
            else if (res >= 7)
                grupo = " buen grupo";
            else
                grupo = " mal grupo";

            Console.WriteLine("\nel promedio total es: {0} considera un {1}", res, grupo);


        }

    }
}