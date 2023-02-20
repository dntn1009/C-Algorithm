using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCS
{
    internal class Circle : Shapes
    {
        string _formname;
        float _vertical;
        float _horizontal;
        float _area;
        float _around;

        public string _MyName
        {
            get { return _formname; }
        }

        public Circle(float vertical, float horizontal) : base(vertical, horizontal)
        {
            _vertical = vertical;
            _horizontal = horizontal;

            if (vertical == horizontal)
            {
                _formname = "원";
            }
            else
            {
                _formname = "타원";
            }
        }

        public override float area_deliver()
        {
            _area = _vertical * _horizontal * 3.14f;

            return _area;
        }

        public override float around_deliver()
        {
            _around = (_vertical + _horizontal) * 2 * 3.14f;
            return _around;
        }

    }
}
