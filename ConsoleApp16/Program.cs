using System;

namespace ConsoleApp16
{
    class Program
    {
        

        static void Main(string[] args)
        {
            float peso = 0;
            float altura = 0;

            //Console.WriteLine("Hello World!");

            Console.WriteLine("Peso: ");
            string pesoString = Console.ReadLine();

            Console.WriteLine("Altura");
            string alturaString = Console.ReadLine();

            peso = float.Parse(pesoString);
            altura = float.Parse(alturaString);

            float imc = CalcularIMC(altura, peso);

            ExibirIMC(imc);

            Console.ReadLine();

            /*
             40 - 35 = grau 2
             34 - 30 = grau 1
             29 - 25 = sobre peso
             24 - 18.5 = saudavel
             18.4 - 17 = magreza leve
             16 - 16 = magreza moderada
             */

        }

        private static float CalcularIMC( float altura, float peso) => peso / (altura* altura);
 
        private static void ExibirIMC(float imc)
        {
            Console.WriteLine("Seu IMC é: " + imc);

            if (imc < 16)
                Console.WriteLine("Magreza Moderada");
            else if (imc <= 18.5)
                Console.WriteLine("Magreza Leve");
            else if (imc <= 24)
                Console.WriteLine("Saudavel");
            else if (imc <= 29)
                Console.WriteLine("sobrepeso");
            else if (imc <= 34)
                Console.WriteLine("grau 1");
            else if (imc <= 40)
                Console.WriteLine("grau 2");
            else
                Console.WriteLine("grau 2");
        }

        
    }
}
