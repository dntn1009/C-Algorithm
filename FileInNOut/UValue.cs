using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInNOut
{
    class UValue
    {
        //Operator ==> +, -, *, /, %, |, ^, <<, >> !, ~, ++, ==, !=, <, >, <=, >=
        int _number;

        public UValue(int v)
        {
            _number = v;
        }

        public override bool Equals(object obj)
        {
            return _number == ((UValue)obj)._number;
        }

        public override int GetHashCode()
        {
            return _number;
        }

        public void PrintShow()
        {
            Console.WriteLine("number = {0}", _number);
        }

        public static int operator +(UValue val, int num)
        {
            return val._number + num;
        }

        public static int operator +(int num, UValue val)
        {
            return num + val._number;
        }

        public static UValue operator +(UValue val1, UValue val2) 
        {
            return new UValue(val1._number + val2._number);
        }
        public static bool operator ==(UValue val1, UValue val2) 
        {
            return val1._number == val2._number;
        }
        public static bool operator !=(UValue val1, UValue val2)
        {
            return val1._number != val2._number;
        }// != 와 == 는 같이 만들어야되는듯?
    }
}
