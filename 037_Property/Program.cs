using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _037_Property
{
    class Rect
    {
        public int width { get; set; } // 간단한 속성
        private int height;

        public int Height
        {
            get { return height; }
            set { if (value >= 0) height = value; }
        }

    }
    class Rectangle
    {
        private int width, height;

        public void SetWidth(int w) { width = w; }
        public int GetWidth() { return width; }
        public void SetHeight(int h) { height = h; }
        public int GetHeight() { return height; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Rect r2 = new Rect();
        }
    }
}
