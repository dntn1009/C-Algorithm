using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;
using System.Net;

namespace FunctionCS
{
    internal class Program
    {
        public class ReverserClass : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                return new CaseInsensitiveComparer().Compare(x, y);
            }
        }
        static Random rd = new Random();
        // C#에서는 함수가 멤버 함수만 존재한다.
        // 함수는 반복적 작업을 피할 목적으로 만들어지며, 하나의 기능으로 활용된느 것이 좋다.
        // 함수는 표준함수와 사용자 정의 함수로 나누어 지며,
        // 일반적으로 사용자가 목적성을 가지고 만드는 경우를 사용자 정의 함수라고 한다.
        // 함수의 형식
        // 한정자 반환형 함수명(매개변수자료형 매개변수명, .....);
        // {
        //    명령들...
        //    return 값;(반환형이 void인 경우 생략 가능);
        // }

        // 한정자는 함수의 형식및 형식 멤버의 선언을 수정하는데 사용(여러가지를 사용해도 된다).
        // 접근지정 한정자는 함수를 만드는데 있어서 꼭 사용되는 한정자로 private, protected, public 세가지가 있다.
        // 함수는 사용될 때 메모리를 가지고 사용이 끝나면 메모리에서 해지된다.
        // 반환형은 함수가 종료 될 시 값을 남긴다면 해당하는 값의 자료형을 사용한다.(반환할 값이 없으면 void를 사용)
        // 함수명은 사용자가 원하는대로 이름을 정해도 된다. 단, 함수의 목적성에 맞게 이름을 정하는 걸 권장한다.
        // 매개변수 자료형, 매개변수 명 은 함수 내에 필요로하는 정보가 외부에서 받아올 수 밖에 없을때 만들어 사용한다.
        // 여러개를 사용해도 된다.

        static void Main(string[] args)
        {
            {
                /* Program prog = new Program();
                 prog.ProgramStart();*/ // 1. 메인문이 static이여서
                                        //ProgramEnd();                    // 2. 함수가 스태틱으로 만들면 가능
                /*int number = GetInputIntegar();
                Console.WriteLine("입력하신 숫자는 <{0}>입니다.", number);*/
                /*int[] arr1 = { 11, 22, 33, 44, 55 };
                OutputPrintArrayInt(arr1, "arr1");*/

                /*for(int i = 0; i < 5; i++)
                {
                    Console.WriteLine("val = {0}", RandomNext(24, 100));
                }*/
            }

            {
                /*string check;
                Console.Write("키를 입력하세요(cm) : ");
                float cm = float.Parse(Console.ReadLine());
                Console.Write("몸무게를 입력하세요(kg) : ");
                float kg = float.Parse(Console.ReadLine());

                float bmi = CalcBMI(cm, kg);
                if (bmi >= 18.5 && bmi < 23)
                {
                    check = "정상";
                }
                else
                {
                    check = "비정상";
                }
                Console.WriteLine("(정상 수치의 범위는 18.5이상 ~23미만입니다.");
                Console.WriteLine("당신의 BMI 수치는 {0}입니다.", bmi);
                Console.WriteLine("{0}입니다.", check);*/
            }
            {
                /*    Console.Write("구구단 중 화면에 출력할 단을 입력하세요(2~9) : ");
                    int x = int.Parse(Console.ReadLine());
                    bool check_dan = gugudan(x);
                    if (!check_dan)
                        Console.WriteLine("잘못 입력하셨습니다.");
                    else
                        Console.WriteLine("입력을 완료하였습니다.");*/
            }
            {
                /*
                            int number1 = 99, number2 = 1024;

                            Console.WriteLine("num1 = {0}, num2 = {1}", number1, number2);
                            DecupleNumber(ref number1, number2);
                            Console.WriteLine("num1 = {0}, num2 = {1}", number1, number2);*/
            }

            {
                /*           int[] numbers = { 53, 7, 8, 109, 31, 24, 22, 47, 1004 };
                           for (int i = 0; i < numbers.Length; i++)
                           {
                               Console.WriteLine("numbers[{0}] = {1}", i, numbers[i]);
                           }
                           Console.WriteLine("================================");

                           for(int n = 0; n < numbers.Length -1; n++)
                           {
                               for(int m = n + 1; m < numbers.Length; m++)
                               {
                                   if (numbers[n] < numbers[m])
                                       SwapXY(ref numbers[n], ref numbers[m]);
                               }
                           }
                           for (int i = 0; i < numbers.Length; i++)
                           {
                               Console.WriteLine("numbers[{0}] = {1}", i, numbers[i]);
                           }
                           Console.WriteLine("================================");
                           선택정렬*/
            }

            {
                /* int num1 = 10, num2 = 36;
                 Console.WriteLine("num1 = {0}, num2 = {1}", num1, num2);
                 TenFoldInteger(num1, out num2);
                 Console.WriteLine("num1 = {0}, num2 = {1}", num1, num2);*/


                /*int input;
                Console.Write("정수를 입력하세요 : ");
                if(int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("입력하신 정수 : [{0}]", input);
                }
                else
                {
                    Console.WriteLine("잘못 입력하셨습니다.");
                }*/

                /*int x = 0;
                x = Tryint("숫자를 입력하세요 : ");
                Console.WriteLine("입력하신 숫자는 [{0}] 입니다.", x);*/

                /*string stdEx = "Let's work hard on the programming language class";
                int[] stdNumber = { 23, 43, 125, 1, 3, 78, 9, 543, 231, 61, 38, 188, 16};

                Console.Write("찾고 싶은 (문자열/숫자)를 입력해 주세요 : ");
                string readstr = Console.ReadLine();
                int readnum = 0;
                bool check_str = int.TryParse(readstr, out readnum);
                if(!check_str)
                {
                    GetCountFind(readstr, stdEx);
                }
                else
                {
                    GetCountFind(readnum, stdNumber);
                }*/
            }

            {
                /*int[] arrayInt = new int[6] { 1, 25, 4, 85, 45, 7 };
                int[] fixarry;
                Console.WriteLine("<현재 배열 값>");
                for(int i = 0; i < arrayInt.Length; i++)
                {
                    if(i == arrayInt.Length - 1)
                        Console.Write("{0}", arrayInt[i]);
                    else
                        Console.Write("{0}, ", arrayInt[i]);
                }
                Console.WriteLine();
                Console.WriteLine("[오름차순 정렬]");
                fixarry = SortArrayValue(arrayInt);
                for (int i = 0; i < arrayInt.Length; i++)
                {
                    if (i == arrayInt.Length - 1)
                        Console.Write("{0}", fixarry[i]);
                    else
                        Console.Write("{0}, ", fixarry[i]);
                }
                Console.WriteLine();
                Console.WriteLine("[내림차순 정렬]");
                fixarry = SortArrayValue(arrayInt, false);
                for (int i = 0; i < arrayInt.Length; i++)
                {
                    if (i == arrayInt.Length - 1)
                        Console.Write("{0}", fixarry[i]);
                    else
                        Console.Write("{0}, ", fixarry[i]);
                }*/
            }

            /*int count = 0,high = 0;
            count = GetCountNHiNumToNums(out high, 34, 1, 23, 5, 7, 4, 32, 28);
            Console.WriteLine("입력한 {0}개의 매개변수 중 제인 큰값은{1}입니다.", count, high);
*/

            /*SampleRecursiveFunc(6);*/

            Console.Write("반복 횟수를 입력하세요 : ");
            PrintStar(int.Parse(Console.ReadLine()));
            //BasicStarFunc(int.Parse(Console.ReadLine()));
            system("pause");
        }

        /*
         * 재귀 호출 함수는 자신의 함수 내에서 자기 자신을 호출하는 함수를 말한다.
         * 이 함수는 알고리즘을 구현하는데 많이 사용되며 잘 못 사용 시 오버스택 에러를 불러온다.
         * 함수를 사용한 결과를 보면 반복문의 결과와 유사하다.
         */
        static void BasicStarFunc(int loopCnt)
        {
            int re_loop = loopCnt;
            if (loopCnt <= 0)
            {
                Console.WriteLine();
                return;
            }
            SampleRecursiveFunc2(loopCnt, re_loop);

        }

        static void SampleRecursiveFunc2(int loopCnt, int re_loop)
        {
            if (loopCnt <= 0)
            {
                Console.WriteLine();
                BasicStarFunc(re_loop - 1);
                return;
            }
            Console.Write("*");
            SampleRecursiveFunc2(loopCnt - 1, re_loop);
        }

        static void SampleRecursiveFunc(int loopCnt)
        {
            if (loopCnt <= 0)
            {
                Console.WriteLine();
                return;
            }
            Console.Write("*");
            SampleRecursiveFunc(loopCnt -1);
        }

        static void PrintStar(int loopCnt, int now = 0)
        {
            if (now >= loopCnt)
                return;
            SampleRecursiveFunc(now + 1);
            PrintStar(loopCnt, now + 1);
        }

        /*
         * 기분 배열을 외부에서 받아서 정렬을 하고 정렬이 된 배열을 반환하는 함수를 만들어 주세요.
         * 단 Origin배열은 바뀌어서는 안됩니다.
         * 그리고, 외부에서 플래그를 하나 받아 true면 오름차순 false면 내림차순으로 정렬되게 만들어 주세요.
         * 기본은 오름차순입니다. 배열은 정수 배열로 하겠습니다.
         */

        /*
        * 매개변수의 초기화를 사용하는 함수.
        * 매개변수의 초기화란 매개변수에 기본값을 지정함으로서
        * 함수 사용시 매개변수에 값을 넘기지 않고도 사용할 수 있게 하는 것이다.
        */

        static int GetCountNHiNumToNums(out int hiNum, params int[] numbers)
        {
            hiNum = numbers[0];
            for(int i = 1; i < numbers.Length; i++)
            {
                if(hiNum < numbers[i])
                    hiNum = numbers[i];
            }
            return numbers.Length;
        }
        /*
         * 가변길이 매개변수를 사용하는 함수
         * 매개변수의 개수를 다르게 받을 수 있는 함수이다.
         * 매개변수 키워드 : param
         * 단, 매개변수의 자료형이 같아야 한다.
         */

        static int[] SortArrayValue(int[] allnum,  bool ign = true)
        {
            int[] fixnum = new int[allnum.Length];
            Array.Copy(allnum, fixnum, allnum.Length);
            if(ign)
            {
                Array.Sort(fixnum);
            }
            else
            {
                Array.Sort(fixnum);
                Array.Reverse(fixnum);
            }
            return fixnum;
        }
        static void GetFindValue(string str, string allstd, bool ign = false)
        {
            int count = 0;
            int cnt = allstd.Length - str.Length;
            for (int i = 0; i < cnt; i++)
            {
                if (string.Compare(allstd, i, str, 0, str.Length) == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("{0}문자열은 {1}개 있습니다", str, count);
        }
        /*
         * static void func(int a = 0)
         * static void func(int a, int b = 0 )
         * static void func(int a = 0, int b = 0)
         * static void func(int a, int b, int c = 0)
         * static void func(int a , int b = 0, int c = 0)
         * static void func(int a = 0 , int b = 0, int c = 0)
         */
        static void GetCountFind(string str, string allstd)
        {
            int count = 0;
            int cnt = allstd.Length - str.Length;
            for (int i = 0; i < cnt; i++)
            {
                if (string.Compare(allstd, i, str, 0, str.Length) == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("{0}문자열은 {1}개 있습니다", str, count);
        }
        static void GetCountFind(int num, int[] all_nums)
        {
            bool check = false;
            for(int i = 0; i < all_nums.Length; i++)
            {
                if(num == all_nums[i])
                {
                    check = true;
                }
            }
            if(!check)
            {
                Console.WriteLine("{0}은 배열에 없습니다", num);
            }
            else
            {
                Console.WriteLine("{0}은 배열에 있습니다", num);
            }

        }

        /*
         * 함수의 오버로드
         * 함수의 오버로드란 하나의 이름으로 여러개의 함수를 구현하는 것을 말한다.
         * 함수의 오버로드에서 구분이 되는 것은 매개변수로서 매개변수의 자료형이 다르거나 매개변수의 개수가 다르면 만들 수 있다.
         */

        static int Tryint(string text)
        {
            int input;
            while (true)
            {
                Console.Write(text);
                if(int.TryParse(Console.ReadLine(), out input))
                {
                    return input;
                    break;
                }
                else
                {
                    Console.WriteLine("잘못 입력하셨습니다");
                }

            }
        }

        // 기본 함수의 4가지
        // 1.반환값과 매개변수가 없다.
        // 내부에서 정보를 생성하여 결과까지 도출하는 함수의 형태이다.
        // 2.반환값은 있고 매개변수는 없다.
        // 내부에서 생성된 결과를 외부로 반환 시키는 함수의 형태이다.
        // 3.반환값은 없고 매개변수는 있다.
        // 외부의 정보를 이용하여 함수내에서 결과를 내는 형태
        // 4.반환값과 매개변수가 있다.
        // 외부의 정보로 내부의 결과를 만들어 외부로 다시 반환하는 함수의 형태이다.

        /*
         구구단의 단을 외부에서 받으면
        해당 단을 화면에 출력하는 함수를 만들어 주세요.
        만약 2~9단이 아니라면 false 를 반환해 주세요
        2~9단이라면 True를 반환해주세요.

        구구단중 화면에 출력할 단을  입력하세요(2~9) :
        ㅌ*ㅌ = ㅌ ㅌ*ㅌ = ㅌ ㅌ*ㅌ = ㅌ

        flase = 잘못입력하셨습니다.

         */

        // 참조형 키워드를 매개변수로 사용하는 함수
        // 매개변수에서의 참조형 키워드 : ref
        // 사용 형식
        // 한정자 반환형 함수명(ref 매개변수 자료형 매개변수 명, ...)
        //{
        //      명령들;
        //}

        // 출력 전용 매개변수를 사용하는 함수.
        // 매개변수에서의 출력 전용 키워드 : out
        // 사용 형식
        // 한정자 반환형 함수명(out 매개변수자료형 매개변수명, .....)
        // {
        //    명령들;
        // }

        /*
         * 기준 문자열에 찾는 문자열을 검색해 몇개가 있는지 반환하는 함수를 만들어 주세요
         * 기준 배열에 찾는 값이 있는지 검색해서 있는지 없는지를 반환하는 함수름 만들어 주세요.
         * 이름은 GetCountFind 입니다.
         */

        static void TenFoldInteger(int num, out int result)
        {
            num *= 10;
            result = num;
        }

        static void SwapXY(ref int num1, ref int num2)
        {
            int x = num1;
            num1 = num2;
            num2 = x;
          
        }

        static void DecupleNumber(ref int num1, int num2)
        {
            Console.WriteLine("num1 = {0}, num2 = {1}", num1, num2);
            num1 *= 10;
            num2 *= 10;
            Console.WriteLine("num1 = {0}, num2 = {1}", num1, num2);
        }


        static void PrintArray(int[] arr, string name)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("배열[{0}] = {1}, {2}", i, arr[i], name);
            }
            Console.WriteLine("=========================================");
        }
        static void PrintArray(float[] arr, string name)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("배열[{0}] = {1}, {2}", i, arr[i], name);
            }
            Console.WriteLine("=========================================");
        }
        //ex
        static bool gugudan(int x)
        {
            if(x >=2 && x <= 9)
            {
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine("{0} * {1} = {2}", x, i, x * i);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        static float CalcBMI(float cm, float kg)
        {
            float bmi = kg / ((cm / 100) * (cm / 100));

            return bmi;
        }

        static int GetInputIntegar()
        {
            Console.Write("정수를 입력하세요 : ");
            return int.Parse(Console.ReadLine());
        }

        static void OutputPrintArrayInt(int[] arr, string name)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("배열[{0}] = {1}, {2}", i, arr[i], name);
            }
            Console.WriteLine("=========================================");
        }

        static float RandomNext(int mini, int maxi)
        {
            float val = rd.Next(mini * 1000, maxi * 1000);
            return val;
        }

        void ProgramStart()
        {
            Console.WriteLine("프로그램을 시작합니다.");
        }

        static void ProgramEnd()
        {
            Console.WriteLine("프로그램을 시작합니다.");
        }
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
