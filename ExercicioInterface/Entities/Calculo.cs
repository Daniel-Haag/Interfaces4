using ExercicioInterface.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioInterface.Entities
{
    class Calculo : IPadrao
    {
        //public void somar (int n1, int n2)
        //{
        //    Console.WriteLine($"soma: {n1 + n2}");
        //}

        public void somar(int n1, int n2)
        {
            Console.WriteLine("soma: " + (n1 + n2));
        }

    }
}
