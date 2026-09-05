namespace Taller33
{
    public class Matrices
    {
        private int m;
        private int n;
        private int p;

        private int[,] A;
        private int[,] B;
        private int[,] C;

        public Matrices(int m, int n, int p)
        {
            this.m = m;
            this.n = n;
            this.p = p;

            A = new int[m, n];
            B = new int[n, p];
            C = new int[m, p];
        }

        public void LlenarA()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = (i + 1) * j;
                }
            }
        }

        public void LlenarB()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    B[i, j] = (j + 1) * i;
                }
            }
        }

        public void Multiplicar()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    C[i, j] = 0;

                    for (int k = 0; k < n; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                }
            }
        }

        public void MostrarA()
        {
            Console.WriteLine("*** A ***");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        public void MostrarB()
        {
            Console.WriteLine("*** B ***");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    Console.Write(B[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        public void MostrarC()
        {
            Console.WriteLine("*** C ***");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    Console.Write(C[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}