using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            int n, dentro, fora, x;

            Console.WriteLine("Digite um numero!");
            n = int.Parse(Console.ReadLine());

            dentro = 0;
            fora = 0;
            for (int i = 0; i < n; i++) {
                x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20) {
                    dentro++;
                }
                else {
                    fora++;
                }
                

            }

            Console.WriteLine(dentro + "Dentro");
            Console.WriteLine(fora + "Fora");
        }
    }
}