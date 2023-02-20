using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace ControlCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            Console.WriteLine("==========================================");
            //제어문은 명령 처리 순서를 변화시켜주는 명령이다.
            //제어문에는 조건문, 분기문, 반복문이 있다.

            //[조건문]
            //조건식의 참 or 거짓 여부에 따라 실행 명령이 달라지도록 하는 명령문이다. 
            //조건식의 키워드 : if else
            //조건문 사용 형식
            //1)
            //if (조건식)
            //{
            //      명령문들;
            //}
            //2)
            //if (조건식)
            //{
            //      명령문들;
            //}
            //else
            //{
            //      명령문들;
            //}
            //3)
            //if (조건식)
            //{
            //      명령문들;
            //}
            //else if(조건식)
            //{
            //      명령문들;
            //}
            //.......(필요한 만큼)
            //else
            //{
            //      명령문들;
            //}

            
            //Console.WriteLine("val : {0}", rd.Next());              //<= 임의의 정수를 얻어온다.
            //Console.WriteLine("val : {0}", rd.Next(100));           //<= 0 ~ 지정한 수 미만 사이의 임의의 정수를 얻어온다.
            //Console.WriteLine("val : {0}", rd.Next(100, 150));      //<= 지정한 수 이상 지정한 수 미만 사이의 임의의 정수를 얻어온다.
            {
                //int su = 0;

                //su = rd.Next(0, 10001);
                //Console.WriteLine("저장수 : {0}은(는) ", su);

                //if (su % 2 == 1)
                //{
                //    Console.WriteLine("(홀수)");
                //}
                //else if (su == 0)
                //{
                //    Console.WriteLine();
                //}
                //else
                //{
                //    Console.WriteLine("(짝수)");
                //}
            }
            {
                //float Squaremeter = 0.0f, pyung = 0.0f;

                //Console.WriteLine("집의 공급 면적을 입력하세요(제곱미터) : ");
                //Squaremeter = float.Parse(Console.ReadLine());
                //pyung = Squaremeter / 3.306f;

                //Console.Write("{0:F3}제곱미터는 {1:F1}평입니다.", Squaremeter, pyung);

                //if (pyung >= 40)
                //{
                //    Console.WriteLine("(부자시네요~)");
                //}
                //else
                //{
                //    Console.WriteLine();
                //}
            }

            //[분기문]
            //분기문은 수식의 결과 값에 따라 처리할 명령들을 선별적으로 처리하게 하는 명령문
            //분기문 키워드 : switch case (break)
            //분기문 사용 형식
            //switch (수식)
            //{
            //      case 값:
            //          명령문들;
            //          break;
            //      case 값:
            //          명령문들;
            //          break;
            //      .....(원하는 만큼)
            //      default:(선택 사항)
            //          명령문들;
            //          break;
            //}
            {
                //int number = 0;
                //int movCount = 0;

                //Console.Write("이동 값을 입력하세요 (0~7): ");
                //movCount = int.Parse(Console.ReadLine());
                //if(movCount>0&&movCount<=7)
                //{
                //    switch (number << movCount)
                //    {
                //        case 1:
                //        case 2:
                //        case 3:
                //        case 4:
                //        case 5:
                //            Console.WriteLine("number를 {0}만큼 이동 시켜서 {1}이(가) 됐습니다.", movCount, number << movCount);
                //            break;
                //        default:
                //            Console.WriteLine("이동을 너무 많이 시켰습니다.");
                //            break;
                //    }
                //}
                //else
                //{
                //    Console.WriteLine("이동 값이 범위를 벗어 났습니다.");
                //}
            }
            {
                //int selectMenu = 0;
                //Console.WriteLine("길을 가고 있는데 지폐가 굴러가고 있는 것을 보았다!!");
                //Console.WriteLine("1.무시하고 가던 길을 간다.");
                //Console.WriteLine("2.언능 가서 줍는다.");
                //Console.WriteLine("3.빨리가서 지그시 발로 밟고 신발끈을 묶는 척 줍는다.");
                //Console.WriteLine("어떤 행동을 하시겠습니까 :");
                //selectMenu = int.Parse(Console.ReadLine());
                //switch (selectMenu)
                //{
                //    case 1:
                //        Console.WriteLine("무시하고 지나가는데 갑자기 강한 바람이 불어와 지폐가 내 뺨을 세차게 때렸다...ㄷㄷㄷ");
                //        break;
                //    case 2:
                //        Console.WriteLine("잽싸게 가서 줍자마자 갑자기 옆에서 주인이 등장해서 고맙다고 인사를 한다...ㅠㅠ");
                //        break;
                //    case 3:
                //        Console.WriteLine("은근슬쩍 발로 밟으려는 순간 누가 먼저 손으로 주워갔다....ㅠㅠ");
                //        break;
                //    default:
                //        Console.WriteLine("메뉴에 없는 번호를 선택했습니다.");
                //        break;
                //}
            }

            {
                //int choice = 0;
                //long memory = 0;
                //string unit = string.Empty;

                //Console.Write("메모리 크기를 입력하세요.(byte) : ");
                //memory = long.Parse(Console.ReadLine());
                //Console.WriteLine();
                //Console.WriteLine("1.kb");
                //Console.WriteLine("2.mb");
                //Console.WriteLine("3.gb");
                //Console.WriteLine("입력한 메모리의 크기를 어떤 단위로 확인하시겠습니까?");
                //choice = int.Parse(Console.ReadLine());
                //switch (choice)
                //{
                //    case 1:
                //        unit = "kb";
                //        Console.WriteLine("({0}) {1:#,###}b는 {2:#,###.###} {0}입니다.", unit, memory, (double)memory / 1024);

                //        break;
                //    case 2:
                //        unit = "mb";
                //        Console.WriteLine("({0}) {1:#,###}b는 {2:#,###.######} {0}입니다.", unit, memory, (double)memory / 1024 / 1024);

                //        break;
                //    case 3:
                //        unit = "gb";
                //        Console.WriteLine("({0}) {1:#,###}b는 {2:#,###.#########} {0}입니다.", unit, memory, (double)memory / 1024 / 1024 / 1024);

                //        break;
                //    default:
                //        Console.WriteLine("잘못입력하셨습니다.");
                //        break;
                //}
            }

            //[반복문]
            //조건식이 참일 동안 명령문들을 수행하도록 하는 제어문이다.
            //반복문 키워드 : while, do while, for, foreach(배열 or 컬렉션에서만 사용)
            //반복문 사용 형식
            //<while>
            //while(조건식)
            //{
            //      명령문들;
            //}
            {
                //int number = 0;
                //while (number == 0 || number % 5 == 0)
                //{
                //    Console.Write("5의 배수를 입력하세요 : ");
                //    number = int.Parse(Console.ReadLine());
                //    if (number % 5 == 0)
                //    {
                //        Console.WriteLine("{0}은(는) 5의 배수입니다.", number);
                //    }                
                //}
                //Console.WriteLine("{0}이(가) 5의 배수가 아니어서 종료합니다.", number);
            }

            //<do while>
            //do
            //{
            //      명령문들;
            //} while(조건식);
            {
                //int age = 0;
                //int year = 0;

                //Console.WriteLine("당신의 나이를 입력하세요 : ");
                //age = int.Parse(Console.ReadLine());

                //do
                //{
                //    year++;
                //} while (age > year);
                //Console.WriteLine("당신의 나이는 {0}세 로 태어난지 {1}년 되었습니다.", age, year);
            }

            //<for>
            //for (초기화식; 조건식; 증감식)
            //{
            //      명령문들;
            //}
            {
                //int count = 0;

                //Console.Write("임의의 수를 몇개 만들까요 : ");
                //count = int.Parse(Console.ReadLine());

                //for(int n=1;n<=count;n++)
                //{
                //    Console.WriteLine("{0}번째 임의의 수 : {1}",n,rd.Next());
                //}
            }




            /*Console.WriteLine("==========================================");
            system("pause");*/


            //break
            // 분기문 반복문에 쓰임 제어문 빠질때 사용
            //continue
            // 반복문에 쓰임 순서 건너뛰고 다음순서로 돌아갈때 사용

            /*int number = 0;
            while (number++ < 6)
            { 
                if (number == 4) // % 2 = 1 나머지가 1
                    break;
                Console.WriteLine("number[{0}]", number);
            }*/
            //1 2 3 4 5 6

        }

        // 수업용 함수
        /*static void system(string command)
        {
            if (command.CompareTo("pause") == 0)
            {
                Console.Write("계속하시려면 아무키나 누르세요...");
                Console.ReadKey();
            }
        }*/
    }
}
