using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================================");
            //연산자 
            //산술 연산자, 증감 연산자, 관계 연산자, 조건 연산자, 논리 연산자, 비트 연산자, 할당 연산자
            //[산술 연산자]
            //산술 연산자는 가감승제의 사칙연산을 기반으로 하는 연산자이다.
            //산술 연산자 키워드 : +, -, *, /, %
            //산술 연산자는 모두 이항 연산자이다.(좌항 연산자 우항).
            {
                //int burger = 0;
                //int friend = 0;
                //Console.WriteLine("햄버거의 갯수는 몇개인가요?");
                //burger = int.Parse(Console.ReadLine());  
                //Console.WriteLine("친구의 수는 몇명인가요?");
                //friend = int.Parse(Console.ReadLine());
                //Console.WriteLine("햄버거가 {0}개 있고 친구가 {1}명이 있습니다. 나누면 어떻게 될까요?", burger, friend);
                //Console.WriteLine("====> {0}개씩 나눠 먹고 {1}개가 남는다.", burger / friend, burger % friend);
            }

            //[증감 연산자]
            //증감 연산자는 해당하는 값을 1씩 증가 시키거나 감소 시키는 연산자이다. 
            //증감 연산자 키워드 : ++, --
            //증감 연산자는 모두 단항 연산자이다(연산자 우항 or 좌항 연산자).
            //증감 연산자에서 항은 변수여야 한다.
            //증감 연산자는 연산자의 위치에 따라 명령 우선 순위가 달라진다. 
            {
                //int number = 5;
                //Console.WriteLine("number[{0}]", number);
                //++number;
                //Console.WriteLine("number[{0}]", number);
                //number++;
                //Console.WriteLine("number[{0}]", number);
                //Console.WriteLine("number[{0}]", number);
                //Console.WriteLine("number[{0}]", ++number);
                //Console.WriteLine("number[{0}]", number++);
                //Console.WriteLine("number[{0}]", number);
            }

            //[관계 연산자]
            //관계 연산자는 수 끼리의 관계를 나타내는 연산자이다. 
            //관계 연산자 키워드 : <, <=, >, >=, !=, ==
            //관계 연산자는 모두 이항 연산자이다.
            //관계 연산자에서 결과는 true 또는 false가 된다.
            {
                //int su1 = 57;
                //int su2 = 66;
                //Console.WriteLine("su1[{0}] > su2[{1}]의 연산 결과는 {2} 이다.", su1, su2, su1 > su2);
            }

            //[조건 연산자]
            //조건 연산자는 조건식의 참, 거짓에 따라 결과 값을 다르게 도출하는 연산자이다.
            //조건 연산자 키워드 : ? :
            //조건 연산자는 삼항 연산자이다.(조건항 ? 참결과값 : 거짓결과값)
            {
                //int stdNum = 3;
                //int input = 0;
                //string word = string.Empty;
                //bool condition = false;

                //Console.Write("정수를 입력하세요 : ");
                //input = int.Parse(Console.ReadLine());

                //condition = input % stdNum == 0;
                //word = (condition) ? " 입니다." : "가 아닙니다.";
                //Console.WriteLine("입력한 정수[{0}]은(는) {1}의 배수{2}", input, stdNum, word);
            }

            //[논리 연산자]
            //논리 연산자는 논리값을 이용하여 결과를 내는 연산자이다.
            //논리 연산자 키워드 : &&(And), ||(Or), !(Not)
            //논리 연산자 !는 우단항 연산자이고 나머지는 이항 연산자이다.
            //    &&    좌     우     ||
            //    0     0       0     0
            //    0     0       1     1
            //    0     1       0     1
            //    1     1       1     1
            {
                //Console.WriteLine("!True = {0}", !true);
                //Console.WriteLine("!False = {0}", !false);
                //Console.WriteLine("==========================================");
                //Console.WriteLine("false && false == {0}", false && false);
                //Console.WriteLine("false && true  == {0}", false && true);
                //Console.WriteLine(" true && flase == {0}", true && false);
                //Console.WriteLine(" true && true  == {0}", true && true);
                //Console.WriteLine("false || false == {0}", false || false);
                //Console.WriteLine("false || true  == {0}", false || true);
                //Console.WriteLine(" true || false == {0}", true || false);
                //Console.WriteLine(" true || true  == {0}", true || true);
            }

            //[비트 연산자]
            //비트 연산자는 산술값의 비트를 이용하여 결과를 도출하는 연산자이다. 
            //비트 연산자 키워드 : <<, >>, &(And), |(Or), ^(Xor), ~(Not)
            // ~ 연산자는 우단항 연산자이고 나머지는 이항 연산자이다.
            // <<, >> 연산자는 따로 쉬프트 연산자라고 하며 비트의 이동 형식으로 연산을 한다.(기준값 연산자 이동값)
            //    좌   우      XOR
            //    0     0       0     
            //    0     1       1     
            //    1     0       1     
            //    1     1       0     
            {
                //Console.WriteLine("5 << 2 = {0}", 5 << 2);
                //Console.WriteLine("5 >> 2 = {0}", 5 >> 2);
            }
            {
                //Console.WriteLine("50 & 99 = {0}", 50 & 99);
                //Console.WriteLine("50 | 99 = {0}", 50 | 99);
                //Console.WriteLine("50 ^ 99 = {0}", 50 ^ 99);
                //Console.WriteLine("~50 = {0}", ~50);

                //Console.WriteLine("50 - 3 = {0}", 50 - 3);
                //Console.WriteLine("50 - 3 = {0}", 50 + (~3 + 1));
            }

            //[할당 연산자]
            //할당 연산자는 값을 변수에 할당하도록 하는 연산자이다.
            //할당 연산자 키워드 : =(순수할당연산자), +=, -=, *=, /=, %=, <<=, >>=, &=, |=, ^=
            //할당 연산자는 모두 이항 연산자이다. 단, 좌항은 꼭 변수여야 한다.
            {
                //int number = 50;
                //int add = 99;
                //Console.WriteLine("number = {0}, add = {1}", number, add);
                //Console.WriteLine("number[{2}] = number[{0}] + add[{1}]", number, add, number = number + add);
                //Console.WriteLine("number[{1}] += add[{1}]", add, number += add);
            }
            {
                //int date = 0, time = 0;
                //string word = string.Empty;

                //Console.Write("날짜를 입력하세요 : ");
                //date = int.Parse(Console.ReadLine());
                //word = date < 10 ? "분" : "시간";
                //time = date < 10 ? 1440 : 24;
                //Console.WriteLine("{0}일은 {2}{1} 입니다.", date, word, time * date);
            }
            {
                //int number = 0;
                //string word = string.Empty;

                //Console.Write("정수를 입력하세요 : ");
                //number = int.Parse(Console.ReadLine());
                //word = (number != 0 && number % 2 == 0 && number % 5 == 0) ? "True" : "False";

                //Console.WriteLine("입력하신 정수 [{0}]은(는) 2의 배수이면서 5의 배수이다({1}).", number, word);
            }






            Console.WriteLine("==========================================");
            system("pause");
        }

        // 수업용 함수
        static void system(string command)
        {
            if (command.CompareTo("pause") == 0)
            {
                Console.Write("계속하시려면 아무키나 누르세요...");
                Console.ReadKey();
            }
        }
    }
}

