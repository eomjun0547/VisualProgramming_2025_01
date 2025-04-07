namespace _024_Clasee
{
    public class Program
    {
        class Date
        {
            private int year, month, day;
            public void SetYear(int year)
            {
                this.year = year;
            }
            public int GetYear()
            {
                return this.year;
            }
            public void PrintDate()
            {
                Console.WriteLine("{0}년 {1}월 {2}일", year, month, day);
            }
        }
        static void Main(string[] args)
        {
            Date a = new Date();
            a.SetYear(2025);
            Console.WriteLine(a.GetYear());
            a.PrintDate();
        }
    }
}
