namespace Taller33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor de m: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor de n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor de p: ");
            int p = int.Parse(Console.ReadLine());

            Matrices matrices = new Matrices(m, n, p);

            matrices.LlenarA();
            matrices.LlenarB();

            Console.WriteLine();
            matrices.MostrarA();

            Console.WriteLine();
            matrices.MostrarB();

            matrices.Multiplicar();

            Console.WriteLine();
            matrices.MostrarC();
        }
    }
}