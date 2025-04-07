namespace _023_Array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] a = new int[20];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(0, 100);
            }

            Console.WriteLine("배열 값: ");
            foreach (var i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(); 

            int min = a[0];
            int max = a[0];
            int sum = 0;

            foreach (var i in a)
            {
                if (i < min)
                    min = i;
                if (i > max)
                    max = i;
                sum += i;
            }

            Console.WriteLine("min = {0}, max = {1}, avg = {2:F2}", min, max, sum / 20.0);
        }
    }
}
