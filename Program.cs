namespace Aula02Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3) Escreva a seqüência de atribuições,
            // em forma de programa em C# e no Visual Studio, para trocar entre si os valores de duas variáveis A e B.

            int A = 10;
            int B = 20;

            Console.WriteLine("Antes da troca: A = {0}, B = {1}", A, B);

            // Troca dos valores das variáveis A e B
            int temp = A;
            A = B;
            B = temp;

            Console.WriteLine("Depois da troca: A = {0}, B = {1}", A, B);
        }
    }
}