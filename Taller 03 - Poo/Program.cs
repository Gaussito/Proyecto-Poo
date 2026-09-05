    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño del rombo: ");
            int tamaño = int.Parse(Console.ReadLine());

            Rombo rombo = new Rombo(tamaño);

            rombo.Imprimir();
        }
    }

