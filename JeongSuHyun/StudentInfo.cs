using System;

namespace JeongSuHyun
{
    class StudentInfo
    {
        public string _name { get; set; }
        public int _group { get; set; }
        public int _number { get; set; }
        public int _blood  { get; set; }
        float _cm;
        float _kg;
        int _lang;
        int _eng;
        int _math;
        int _sci;
        public int _rank { get; set; }
        public float _aver { get; set; }

        public StudentInfo()
        {

        }
        public StudentInfo(string name, int group, int number, int blood, float cm, float kg, int lang, int math, int eng, int sci)
        {
            _rank = 1;
            _name = name;
            _group = group;
            _number = number;
            _blood = blood;
            _cm = cm;
            _kg = kg;
            _lang = lang;    
            _eng = eng;
            _math = math;
            _sci = sci;
            _aver = lang + eng + math + sci / 4;
        }

        public void score_ShowInfo()
        {
            Console.WriteLine("키 : {0}", _cm);
            Console.WriteLine("몸무게 : {0}", _kg);
            Console.WriteLine("국어 점수 : {0}", _lang);
            Console.WriteLine("수학 점수 : {0}", _math);
            Console.WriteLine("영어 점수 : {0}", _eng);
            Console.WriteLine("과학 점수 : {0}", _sci);
            Console.WriteLine("평균 점수 : {0}", _aver);
            Console.WriteLine("전체 석차 : {0}", _rank);
            Console.WriteLine("==========================");
        }
    }
}
