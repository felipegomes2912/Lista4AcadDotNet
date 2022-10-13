using System.Security.Cryptography;

namespace Lista4AcadDotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXERCÍCIO 1
            /*
            int[] vet = new int[10];
            int maior=0, contPar=0, contImpar=0;

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write("Digite o valor no espaço " + i + " do vetor: ");
                vet[i] = int.Parse(Console.ReadLine());

                if (maior<= vet[i])
                {
                    maior = vet[i];
                }

                if (vet[i] % 2 == 0)
                {
                    contPar++;
                }
                else
                {
                    contImpar++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("----------------Resultado----------------");
            Console.WriteLine("Números pares: " + contPar);
            Console.WriteLine("Números ímpares: " + contImpar);
            Console.WriteLine("Maior número: " + maior);
            */



            //EXERCÍCIO 2
            /*
            int[] vet1 = new int[20];
            int[] vet2 = new int[20];
            int[] vet3 = new int[20];

            for (int i = 0; i < vet1.Length; i++)
            {
                Console.Write("Digite o valor no espaço " + i + " do vetor 1: ");
                vet1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vet1.Length; i++)
            {
                Console.Write("Digite o valor no espaço " + i + " do vetor 2: ");
                vet2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("");

            for (int i = 0; i < vet1.Length; i++)
            {
                vet3[i] = vet1[i] + vet2[i];
                Console.WriteLine("Valores somados: " + vet1[i] + " + " + vet2[i] + ".");
                Console.WriteLine("Soma: " + vet3[i]);
            }
            */



            //EXERCÍCIO 3
            /*
            int[] vet = new int[20];


            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write("Digite o valor no espaço " + i + " do vetor: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vet.Length; i++)
            {
                int cont = 0;

                for (int j = 1; j <= vet[i]; j++)
                {
                    if (vet[i] % j == 0)
                    {
                        cont++;
                    }
                }
                if (cont == 2)
                {
                    Console.WriteLine("A posição do vetor é o "+i+" e o valor " + vet[i] + " é primo.");
                }
            }
            */



            //EXERCÍCIO 4
            /*
            int[] vet1 = new int[10];
            int[] vet2 = new int[10];
            int[] vet3 = new int[10];

            for (int i = 0; i < vet1.Length; i++)
            {
                Console.Write("Digite o valor no espaço " + i + " do vetor 1: ");
                vet1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vet1.Length; i++)
            {
                Console.Write("Digite o valor no espaço " + i + " do vetor 2: ");
                vet2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("");

            for (int i = 0; i < vet1.Length; i++)
            {
                vet3[i] = vet1[i] * vet2[i];
                Console.WriteLine("Valores multiplicados: " + vet1[i] + " * " + vet2[i] + ".");               
            }
            Console.WriteLine("-----------------RESULTADO-----------------");
            for (int i = 0; i < vet3.Length; i++)
            {
                Console.Write(vet3[i] + " ");
            }
            */



            //EXERCÍCIO 5
            /**/
            int menor = 0, pos = 0;
            int[] vet = new int[5];

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write("Digite o " + (i+1) + "º elemento do vetor: ");
                vet[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < vet.Length; i++)
            {
                if (menor < vet[i])
                {
                    menor = vet[i];
                    pos = i;
                }
            }



















        }
    }
}