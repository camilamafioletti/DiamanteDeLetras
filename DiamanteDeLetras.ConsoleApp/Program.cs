namespace DiamanteDeLetras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Console.WriteLine("Informe uma letra do alfabeto: ");
            string letraInformada = Console.ReadLine().ToUpper();

            char[] alfabeto = letras.ToCharArray();

            int converteLetra = letras.IndexOf(letraInformada); 

            for (int i = 0; i <= converteLetra; i++) 
            {
                Console.WriteLine(" ");

                for (int j = 0; j < converteLetra - i; j++) 
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < 1; k++) 
                {
                    Console.Write(alfabeto[i]);

                    for (int l = 0; l <= 2 * i - 2; l++)
                    {
                        Console.Write(" ");
                    }
                    if (i != 0)
                    {
                        Console.Write(alfabeto[i]);
                    }
                }
            }

            for (int i = converteLetra - 1; i >= 0; i--)
            {
                Console.WriteLine(" ");


                for (int j = 0; j < converteLetra - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < 1; k++) 
                {
                    Console.Write(alfabeto[i]);

                    for (int l = 0; l <= 2 * i - 2; l++)
                    {
                        Console.Write(" ");
                    }
                    if (i != 0)
                    {
                        Console.Write(alfabeto[i]);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}