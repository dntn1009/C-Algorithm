using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileInNOut
{

    [Serializable]
    internal class StudentInfo
    {
        string _name;
        int _age;
        double _cm;
        double _kg;

        public void InitDataSet(string n, int a, double c, double k)
        {
            _name = n;
            _age = a;
            _cm = c;
            _kg = k;
        }

        public void PrintShow()
        {
            Console.WriteLine("====[ {0} 학생 정보 ]==========", _name);
            Console.WriteLine("이름 : {0}", _name);
            Console.WriteLine("나이 : {0}세", _age);
            Console.WriteLine("신장 : {0}Cm", _cm);
            Console.WriteLine("몸무게 : {0}Kg", _kg);
            Console.WriteLine("=========================================");
        }
    }
}
