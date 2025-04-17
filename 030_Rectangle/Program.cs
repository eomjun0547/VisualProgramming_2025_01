namespace _030_Rectangle
{
    class Rectangle
    {
        private int width; int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public int GetArea()
        {
            return width * height;
        }
        public int GetPerimeter()
        {
            return width * 2 + height * 2;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(20, 20);
            Console.WriteLine("넓이 : {0}", r.GetArea());
            Console.WriteLine("둘레 : {0}", r.GetPerimeter());
        }
    }
}
