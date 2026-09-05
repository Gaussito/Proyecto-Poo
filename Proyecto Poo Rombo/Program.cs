namespace Taller3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Ingrese el tamaño del rombo (0 para salir): ");
                int tamaño = int.Parse(Console.ReadLine());

                if (tamaño == 0)
                    break;

                Rombo rombo = new Rombo(tamaño);
                rombo.Imprimir();

                Console.WriteLine(); // Deja un espacio entre rombos
            }
        }
    }
}