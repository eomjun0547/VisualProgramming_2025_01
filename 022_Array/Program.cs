namespace _022_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] i = new int[20];

            for (int a = 0; a < 20; a++)
            {
                i[a] = r.Next(0, 100);
            }

            int max = i[0];
            for (int a = 1; a<i.Length; a++)
            {
                if (i[a] > max)
                    max = i[a];
            }
            Console.WriteLine("최대값 : {0} ", max);
            
            int min = i[0];
            for (int a = 1; a < i.Length; a++)
            {
                if (i[a] < min)
                    min = i[a];
            }
            Console.WriteLine("최솟값 : {0} ", min);

            int sum = 0;
            for (int a = 0; a< i.Length; a++)
            {
                sum += i[a];
            }
            Console.WriteLine("평균 : {0:F2} ", (double)sum / i.Length);
        }
    }
}
