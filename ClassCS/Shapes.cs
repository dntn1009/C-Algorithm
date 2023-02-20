using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCS
{
    class Shapes
    {
        float _vertical;
        float _horizontal;
        float _area;
        float _around;

        public Shapes() 
        {
        }
        public Shapes(float vertical, float horzontal)
        {
            _vertical = vertical;
            _horizontal = horzontal;
        }

        public void InitBase(float x, float y)
        {
            _vertical = x;
            _horizontal = y;
            _area = x * y;
            _around = ( x + y) + 2;
        }

        public virtual float area_deliver()
        {
            _area = _vertical * _horizontal;
            return _area;
        }

        public virtual float around_deliver() 
        {
            _around = (_vertical + _horizontal) * 2;
            return _around;
        }

    }
}
