using System;

namespace ClassCS
{
    class Rectangle
    {
        int _x;
        int _y;
        int _width;
        int _shape;

        public void ShowShape(int x, int y)
        {
            _x = x;
            _y = y;
            _width = x * y;
            _shape = (x + y) * 2;
            
        }
        public void ShowInfo()
        {
            Console.WriteLine("가로 : {0}\n세로 : {1}", _x, _y);
            Console.WriteLine("면적 : {0}\n둘레 : {1}", _width, _shape);
            if (_x == _y)
            {
                Console.WriteLine("정사각형 입니다.");
            }
            else if (_x > _y)
            {
                Console.WriteLine("가로가 긴 직사각형 입니다.");
            }
            else
            {
                Console.WriteLine("세로가 긴 직사각형 입니다.");
            }
        }
    }
}
