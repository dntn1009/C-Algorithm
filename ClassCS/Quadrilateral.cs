using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCS
{
    class Quadrilateral : Shapes
    {
        string _formname;

        public string _MyName
            {
                get {return _formname;}
            }
        

        public Quadrilateral(float vertical, float horizontal) : base(vertical, horizontal)
        {
            if(vertical == horizontal) 
            {
                _formname = "정사각형";
            }
            else
            {
                _formname = "직사각형";
            }
        }
    }
}
