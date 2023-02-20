using System;

namespace ClassCS
{
    /*이름, 성별, 국어, 영어, 수학, 과학 받아서 저장
     전체평균과 전체 석차의 정보가 있어 객체의 등수 알 수 있음
    초기화 생성자를 사용하며, 점수 정보를 한번에 확인할 수 있는 기능
    석차는 따로 외부에서 확인을 하거나 변경할 수 있도록 만들기
    이름도 외부에서 확인할 수 있도록 해주세요*/

    /*
     몇명의 정보를 입력하시겠습니까?

    1번째 이름:
    1남, 2여, n번쨰 성별을 고르세요:
    (점수는 임의로 등록)
    -- n번째 이름:

    1.전체 정보
    2.점수별 정보
    번호를 고르세요 :

    [OOO]님의 정보
    이름:
    성별:
    점수:
    평균 점수:
    전체 석차:

    (점수별일 경우)
    1.국어
    2.영어
    3.수학
    4.과학
    5.평균
    확인할 과목을 고르세요:
    OOO님의 OO점수 : OO점
     */
    class ScoreInfo
    {
        public string _name { get; set; }
        public string _sex { get; set; }
        //
        int _lang;
        int _math;
        int _eng;
        int _sci;
        public int _aver { get; set; }
        public int _rank { get; set; }
        //

        public ScoreInfo()
        {

        }

        public ScoreInfo(string name, string sex,int lang, int math, int eng, int sci)
        {
            _name = name;
            _sex = sex;
            _lang = lang;
            _math = math;
            _eng = eng;
            _sci = sci;
            _aver = (lang + math + eng + sci) / 4;
            _rank = 1;
        }

        public void all_ShowInfo()
        {
            Console.WriteLine("====[{0}]님의 정보 ======", _name);
            Console.WriteLine("이름 : {0}", _name);
            Console.WriteLine("성별 : {0}자", _sex);
            Console.WriteLine("국어 점수 : {0}", _lang);
            Console.WriteLine("수학 점수 : {0}", _math);
            Console.WriteLine("영어 점수 : {0}", _eng);
            Console.WriteLine("과학 점수 : {0}", _sci);
            Console.WriteLine("평균 점수 : {0}", _aver);
            Console.WriteLine("전체 석차 : {0}", _rank);
            Console.WriteLine("==========================");
        }
        public void part_ShowInfo(int subject)
        {
            Console.WriteLine("=====================================");
            if (subject == 1)
            {
                
                Console.WriteLine("{0}님의 국어점수 : {1}점", _name, _lang);
            }
            else if (subject == 2)
            {
                Console.WriteLine("{0}님의 수학점수 : {1}점", _name, _math);
            }
            else if (subject == 3)
            {
                Console.WriteLine("{0}님의 영어점수 : {1}점", _name, _eng);
            }
            else if (subject == 4)
            {
                Console.WriteLine("{0}님의 과학점수 : {1}점", _name, _sci);
            }
        }
    }
}
