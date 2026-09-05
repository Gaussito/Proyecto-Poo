
    public class Rombo
    {
        private int tamaño;

        public Rombo(int tamaño)
        {
            this.tamaño = tamaño;
        }

        public void Imprimir()
        {
            // Parte superior
            for (int i = 1; i <= tamaño; i++)
            {
                // Espacios antes del rombo
                for (int espacios = 1; espacios <= tamaño - i; espacios++)
                {
                    Console.Write(" ");
                }

                // Primer # 
                Console.Write("#");

                // Espacios internos
                if (i > 1)
                {
                    for (int espacios = 1; espacios <= 2 * i - 3; espacios++)
                    {
                        Console.Write(" ");
                    }

                    // Segundo #
                    Console.Write("#");
                }

                Console.WriteLine();
            }

            // Parte inferior
            for (int i = tamaño - 1; i >= 1; i--)
            {
                // Espacios antes del rombo
                for (int espacios = 1; espacios <= tamaño - i; espacios++)
                {
                    Console.Write(" ");
                }

                // Primer #
                Console.Write("#");

                // Espacios internos
                if (i > 1)
                {
                    for (int espacios = 1; espacios <= 2 * i - 3; espacios++)
                    {
                        Console.Write(" ");
                    }

                    // Segundo #
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }
    }
