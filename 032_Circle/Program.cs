namespace _032_Circle
{
    internal class Program
    {
        class Circle
        {
            private double radius;

            public Circle(double radius)
            {
                this.radius = radius;
            }

            public double GetArea()
            {
                return radius * radius * 3.14;
            }
        }
        static void Main(string[] args)
        {
            Circle donut = new Circle(5);
            Console.WriteLine("도넛의 넓이 : {0}", donut.GetArea());
            Circle pie = new Circle(10);
            Console.WriteLine("파이의 넓이 : {0}", pie.GetArea());
            Circle pizza = new Circle(15);
            Console.WriteLine("피자의 넓이 : {0}", pizza.GetArea());

        }
    }
}
