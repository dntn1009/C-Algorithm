using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCS
{
    enum eTribe
    { 
        인간,
        오크,
        엘프,
        고블린
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //출력문
            //Console.WriteLine(), Console.Write()
            //콘솔 화면에 내용을 출력하느 명령.
            {
                //Console.WriteLine("안녕하세요~");
                //Console.Write(12345);
                //Console.WriteLine("1번:{0}, 2번:{1}", 123456, "반갑습니다.");
                //Console.WriteLine("1번:{1}, 2번:{0}", 123456, "반갑습니다.");
                //Console.WriteLine("{0}, {1}, {1}, {0}", 123456, "반갑습니다.");
                //string write = string.Format("{0}, {1}, {1}, {0}", 123456, "반갑습니다.");
                //Console.WriteLine(write);
                //Console.WriteLine("{0}", 123456, "반갑습니다."); //Ok
                //Console.WriteLine("{0}, {1}", 123456);          // Error -> 가져오지 못하면 오류 발생

                //Console.WriteLine("[{0,15}]", 1234.567);
                //Console.WriteLine("[{0,-15:F1}]", 1234.567);
                //Console.WriteLine("{0:#,###}", 12345);
                //Console.WriteLine("{0:#,###.##}", 12345.789);
            }

            //입력문
            //Console.ReadLine(), Console.Read()
            //입력 버퍼에서 입력내용을 읽어와서 반환하는 명령.
            {
                //Console.WriteLine((char)Console.Read());
                //Console.WriteLine("입력내용 : {0}", Console.ReadLine());
            }

            //자료형
            //분류에 따라 : 정수, 실수, 논리, 문자, 문자열, 객체, 구조체, 열거
            //분류에 따른 키워드 
            //[정수]
            //byte(1), sbyte, short(2), ushort, int(4), unint, long(8), ulong
            //s가 붙으면 부호가 생김, u가 붙으면부호가 사라짐
            //[실수]
            //float(4, 7자리), double(8, 15~16자리), decimal(16, 28~29자리)
            //일반적으로 상수형태의 실수를 쓸 때(0.54)는 그 실수를 컴파일러는 double로 인지한다.
            //따로 컴파일러가 인지할 수 있도록 하기 위해서는 float은 0.0f, declimal은 0,0m으로 써야 한다.
            //Console.WriteLine("{0:F}, {0:F9}", 1.50f);
            //[논리]
            //bool
            //값으로 true, false 두가지를 가진다.
            //Console.WriteLine("{0}, {1}", true, false);
            //[문자]
            //char
            //2바이트 유니코드 값을 가진다.
            //[문자열]
            //string
            //string str = "안녕하세요~ 반갑습니다.";
            //Console.WriteLine("str[{0}], str's Length [{1}]", str, str.Length);
            //Console.WriteLine("str's firstChar = {0}", str[0]);
            //[객체]
            //object
            //어떤 자료형이던 저장할 수 있다.
            //object obj = "안녕!";
            //Console.WriteLine(obj);
            //obj = 123456;
            //Console.WriteLine(obj);
            //[열거]
            //enum
            //정수에 별명을 붙여서 사용하도록 하는 자료형이다. 
            //열거형은 namespace 안이나 class 안에서 선언해서 사용한다.
            //Console.WriteLine("{0} : {1}", eTribe.고블린, (int)eTribe.고블린);

            //자료형은 크게 상수와 변수로 나누어진다.
            //변수 : 값을 담아두기 위한 메모리상의 기억공간을 말한다.
            //상수 : 변수에 담아둘 값 또는 정보처리에 사용되는 값을 말한며 고유하다.
            //1. 자료형 변수명;           <- 지역 변수일 경우
            //2. 한정자 자료형 변수명;    <- 멤버 변수일 경우
            //int number = 0;         // 변수의 선언
            //int val = 10;           // 변수의 선언과 동시에 초기화

            //Console.WriteLine("number = {0}", number);
            //Console.WriteLine("val = {0}", val);

            //string input = string.Empty;
            //string famName = string.Empty, name = string.Empty;
            //Console.Write("이름을 입력하세요(성 이름) : ");
            //input = Console.ReadLine();
            //string[] datas = input.Split(' ');
            //famName = datas[0];
            //name = datas[1];
            ////Console.WriteLine("입력하신 이름은 [{0}]님 입니다.", input);
            //Console.WriteLine("입력하신 이름은 [{0}], 성은 [{1}] 입니다.", name, famName);


            //int su = 0;
            //float silsu = 0;
            //string buff = string.Empty;

            //su = 156;
            //silsu = su;
            //Console.WriteLine("su = {0}, silsu = {1}, silsu = {1:F}", su, silsu, silsu);
            //silsu = 9.81f;
            //su = (int)silsu;
            //Console.WriteLine("silsu = {0}, su = {1}", silsu, su);
            //buff = "하하하" + su;
            //Console.WriteLine(buff);
            //buff = su.ToString();
            //Console.WriteLine(buff+su);
            //su = int.Parse(buff) + 10;
            //Console.WriteLine("su = {0}", su);
            //buff = "1234";
            //Console.WriteLine("result = {0}", Convert.ToInt32(buff) + su);

            //string name = string.Empty;
            //float ki=0.0f;
            //int age = 0;

            //Console.Write("이름을 입력하세요 : ");
            //name = Console.ReadLine();
            //Console.Write("키를 입력하세요 : ");
            //ki = float.Parse(Console.ReadLine());
            //Console.Write("나이를 입력하세요 : ");
            //age = int.Parse(Console.ReadLine());

            //Console.WriteLine("[{0}님 정보]=======", name);
            //Console.WriteLine("키 : {0:F}", ki);
            //Console.WriteLine("나이 : {0}", age);
            //Console.WriteLine("======================");

            string name = string.Empty;
            int korean = 0, english = 0, math = 0;
            float avg = 0.0f;

            Console.WriteLine("이름을 입력하세요 : ");
            name = Console.ReadLine();
            Console.WriteLine("국어점수를 입력하세요 : ");
            korean = int.Parse(Console.ReadLine());
            Console.WriteLine("영어점수를 입력하세요 : ");
            english = int.Parse(Console.ReadLine());
            Console.WriteLine("수학점수를 입력하세요 : ");
            math = int.Parse(Console.ReadLine());

            avg = (float)(korean + english + math) / 3;
            Console.WriteLine("{0}님은 국어 {1}점, 영어 {2}점, 수학 {3}점 입니다.", name, korean, english, math);
            Console.WriteLine("{0}님의 세 과목 평균은 {1:F3}점 입니다.", name, avg);





            system("pause");
        }

        // 수업용 함수
        static void system(string command)
        {
            if(command.CompareTo("pause")==0)
            {
                Console.Write("계속하시려면 아무키나 누르세요...");
                Console.ReadKey();
            }
        }
    }
}
