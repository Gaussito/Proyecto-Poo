namespace Taller3
{
    public class Rombo
    {
        private int tamaño;

        public Rombo(int tamaño)
        {
            this.tamaño = tamaño;
        }

        public void Imprimir()
        {
            int mitad = (tamaño + 1) / 2;

            // Parte superior
            for (int i = 1; i <= mitad; i++)
            {
                for (int espacios = 1; espacios <= mitad - i; espacios++)
                    Console.Write(" ");

                Console.Write("#");

                if (i > 1)
                {
                    for (int espacios = 1; espacios <= 2 * i - 3; espacios++)
                        Console.Write(" ");

                    Console.Write("#");
                }

                Console.WriteLine();
            }

            // Parte inferior
            for (int i = mitad - 1; i >= 1; i--)
            {
                for (int espacios = 1; espacios <= mitad - i; espacios++)
                    Console.Write(" ");

                Console.Write("#");

                if (i > 1)
                {
                    for (int espacios = 1; espacios <= 2 * i - 3; espacios++)
                        Console.Write(" ");

                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }
    }
}