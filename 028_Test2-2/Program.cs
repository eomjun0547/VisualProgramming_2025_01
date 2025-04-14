namespace _028_Test2_2
{
    class Rectagle
    {
        private int width, height;
        //생성자 : return 값이 없고, 이름이 클래스와 같다.
        public Rectagle()
        {
            width = 0; height = 0;
        }
        public Rectagle(int w, int h)
        {
            width = w; height = h;
        }
        public int GetArea() { return width * height; }
        public int GetPerimeter() { return width * 2 + height * 2; }
        public void SetWidth(int w)
        {
            if(w > 0)
            {
                width = w;
            }
            else
            {
                height = 0;
                Console.WriteLine("0보다 큰 값을 사용하세요.");
            }
        }
        public void SetHeight(int h)
        {
            if (h > 0)
            {
                height = h;
            }
            else
            {
                width = 0;
                Console.WriteLine("0보다 큰 값을 사용하세요.");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectagle rect = new Rectagle();

            Console.Write("가로 : ");
            int w = int.Parse(Console.ReadLine());
            Console.Write("세로 : ");
            int h = int.Parse(Console.ReadLine());

            rect.SetWidth(w);
            rect.SetHeight(h);

            Console.WriteLine("넓이 : {0}", rect.GetArea());
            Console.WriteLine("둘레 : {0}", rect.GetPerimeter());
        }
    }
}
