using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCS
{
    /*
     * 직장이름과 부서명, 직급, 연차를 정보로 가지고 있습니다.
     * 출근, 퇴근, 회의, 티타임, 집중 근무시간, 야근, 회식, 야식, 자기 개발등의 행동
     * 일과표를 작성하여 시간별로 뭘 원하는 시간인지 알 수 있게 해주세요.
     */
    class Worker : Person
    {
        string _officename;
        string _officegroup;
        string _class;
        int _workyear;

        public Worker() : base("사람", 0, eGender.남)
        {
            _officename = "아카데미";
            _officegroup = "인디게임개발자양성";
            _class = "연구원";
            _workyear = 0;
        }

        public Worker(string n, int a, eGender g, string officename, string officegroup, string @class, int workyear) : base(n, a, g)
        {
            _officename = officename;
            _officegroup = officegroup;
            _class = @class;
            _workyear = workyear;
        }

        public void GoToOffice()
        {
            Console.WriteLine("{0}회사에 가고 있다.", _officename);
        }
        public void GoHome()
        {
            Console.WriteLine("집에 가고 있다.");
        }
        public void TeaTime()
        {
            Console.WriteLine("회사에서 휴식을 취하고 있다.");
        }
        public void Hard_work()
        {
            Console.WriteLine("집중 근무시간 중입니다.");
        }
        public void Night_Work()
        {
            Console.WriteLine("야근 중입니다.");
        }
        public void group_dinner()
        {
            Console.WriteLine("{0}부서원들과 회식 중입니다.", _officegroup);
        }

        public void OutputWorkInfo()
        {
            Console.WriteLine("내 이름은 {0}, {1}세 {2}자 회사원 입니다.", _MyName, _MyAge, _MyGender);
            Console.WriteLine("{0}부서에서 일하며, {1} 회사를 다니고 있습니다.", _officegroup, _officename);
            Console.WriteLine("회사를 다닌지 {0}연차 이며, {1} 직급입니다.", _workyear, _class);
        }
    }
}
