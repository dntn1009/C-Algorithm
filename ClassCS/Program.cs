using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCS
{
    // 클래스는 기본적으로 복합 데이터 형식이며, 기능을 포함하고 있다.
    // 클래스 기본 형식
    // 한정자 class 클래스 이름
    // {
    //      데이터들
    //      메소드들
    // }

    // 정적 멤버 변수는 멤버 변수를 전역화 하는 기능으로
    // 정적으로 지정한 멤버 변수를 어디에서 든지 쉽게 접근하여 사용할 수 있게 한다.
    // 정적 멤버 변수는 변수의 상수화와는 다른 내용이다.
    /*
     * 정적 멤버 함수는 멤버 함수를 전역 함수화 하는 것이다.
     * 보통 정적 멤버 함수는 범용적인 함수를 만들때 사용된다.
     */
    class Program
    {
        static Random rd = new Random();
        static void Main(string[] args)
        {
            {
              /*  bool check = false;
                ScoreInfo[] score = null;
                while(true)
                {
                    if (score == null)
                    {
                        Console.Write("몇명의 정보를 입력하시겠습니까? : ");
                        score = new ScoreInfo[int.Parse(Console.ReadLine())];
                    }
                    else 
                    {
                        if (!check)
                        {
                            for (int i = 0; i < score.Length; i++)
                            {

                                Console.Write("{0}번째 이름 : ", i + 1);
                                string name = Console.ReadLine();
                                Console.Write("1.남 2.여, {0}번째 성별을 고르세요 : ", i + 1);
                                string MGcheck = Console.ReadLine();
                                if (MGcheck == "1")
                                {
                                    score[i] = new ScoreInfo(name, "남", rd.Next(25, 101), rd.Next(25, 101), rd.Next(25, 101), rd.Next(25, 101));
                                }
                                else if (MGcheck == "2")
                                {
                                    score[i] = new ScoreInfo(name, "여", rd.Next(25, 101), rd.Next(25, 101), rd.Next(25, 101), rd.Next(25, 101));
                                }
                            }
                            for (int i = 0; i < score.Length; i++)
                            {
                                for (int j = 0; j < score.Length; j++)
                                {
                                    if (score[i]._aver < score[j]._aver)
                                    {
                                        score[i]._rank++;
                                    }
                                }
                            }
                        }
                        check = true;
                        ShowScoreExplain(score);
                    }
                }
                *//*Item rareItem = new Item();
                Item normalItem; // 변수 선언
                Item ArareItem = new Item();
                Item BrareItem = new Item();
                normalItem = new Item(); // 객체 생성
                normalItem.InitializeData("부러진 목검", 10, 3);
                rareItem.InitializeData("반짝이는 구두", 1000, 9);
                ArareItem.InitializeData("예리한 철검", 2000, 14);
                BrareItem.InitializeData("예리한 다이아검", 5000, 20);
                normalItem.ShowInfo();
                rareItem.ShowInfo();
                ArareItem.ShowInfo();
                BrareItem.ShowInfo();*/
            }

            {
                /*  Rectangle rect = new Rectangle();
                  rect.ShowShape(2, 4);
                  rect.ShowInfo();
                  rect.ShowShape(4, 4);
                  rect.ShowInfo();
                  rect.ShowShape(6, 4);
                  rect.ShowInfo();*/

                /*Item rareItem = new Item();
                Item normalItem; // 변수 선언
                normalItem = new Item(); // 객체 생성
                normalItem.InitializeData("부러진 목검", 10, 3);
                normalItem.ShowInfo();
                normalItem.useitem();
                normalItem.useitem();
                normalItem.ShowInfo();*/

                /*const int number = 12345;

                Console.WriteLine("number = {0}", number);
                number = 98760;
                */
                /*Console.WriteLine("Sample Count = {0}", SampleClass._playCount);
                SampleClass._playCount++;
                Console.WriteLine("Sample Count = {0}", SampleClass._playCount);*/

                /*Person rbase;
                Student boy = new Student("김철수", 18, eGender.남, "놀고싶고", 2);
                rbase = boy;
                boy.PrintShow();
                rbase.PrintShow();*/
                //boy.OutputStudentInfo();
                /*Time time = new Time("정수현", 19, eGender.남, "송내고", 3, 7, 9, 13, 14, 17, 18, 19, 21);
                time.OutputStudentInfo();*/

            }

            {
                /*Worker work = new Worker("정수현", 27, eGender.남, "오토비즈시스템즈", "차량진단정비시스템개발", "연구원", 1);
                work.OutputWorkInfo();

                while (true)
                {
                    Console.Write("시간을 입력하세요 (0 ~ 24) : ");
                    int number;
                    bool answer = int.TryParse(Console.ReadLine(), out number);
                    if(!answer) 
                    {
                        Console.WriteLine("숫자를 입력해 주세요");
                    }
                    else
                    {
                        if(number >=0 && number <= 24)
                        {
                            switch (number)
                            {
                                case 16 :
                                        break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("괄호 안의 숫자를 입력해 주세요");
                        }
                    }
                }*/
            }

            /*
             * Shapes 클래스를 만듭니다.
             * 이 클래스는 가로 길이, 세로 길이, 면적, 둘레의 정보를 가지고 있습니다.
             * 또한 가로 길이와 세로 길이를 함수로 받아오고, 면적과 둘레는 외부로 보낼 수 있도록 해주세요(함수로)
             * Shapes클래스는 기반 클래스 입니다.
             * Quadrilateral 클래스를 만듭니다.
             * 이 클래스는 도형 이름을 저장하고 있고, 
             * 면적을 계산하는 함수와 둘레를 계산하는 함수가 있습니다.
             * 도형의 이름은 초기화 생성자에서 가로, 세로의 값을 이용해 만들어 집니다.
             * Shapes클래스를 상속받습니다.
             * 
             * Circle 클래스를 만듭니다.
             * 이 클래스는 동형이름을 저장하고, 면적을 계산하는 함수와 둘레를 계산하는 함수가 있습니다.
             * * 또한 가로 길이와 세로 길이를 함수로 받아오고, 면적과 둘레는 외부로 보낼 수 있도록 해주세요(함수로)
             * 도형의 이름은 초기화 생성자에서 가로, 세로의 값을 이용해 만들어 집니다.
             * 타원이 아닐경우 반지름이란 이름으로 외부에 값을 반환하도록 해야 합니다.
             */

            /*float area;
            float around;
            Shapes shapes = new Shapes();
            shapes.InitBase(2, 2);
            area = shapes.area_deliver();
            around= shapes.around_deliver();
            Console.WriteLine("===[shapes]==================================");
            Console.WriteLine("shape의 면적 : {0} 둘레 : {1}", area, around);
            Console.WriteLine("===================================================");

            Quadrilateral quad = new Quadrilateral(4, 5);
            area = quad.area_deliver();
            around= quad.around_deliver();
            Console.WriteLine("===[Quadrilateral]==========================");
            Console.WriteLine("Quadrilateral의 이름 : {0} 면적 : {1} 둘레 : {2}", quad._MyName, area, around);
            Console.WriteLine("==================================================");

            Circle circle = new Circle(3, 3);
            area = circle.area_deliver();
            around = circle.around_deliver();
            Console.WriteLine("===[Circle]=================================");
            Console.WriteLine("Circle의 이름 : {0} 면적 : {1} 둘레 : {2}", circle._MyName, area, around);
            Console.WriteLine("==================================================");*/

            ILogger log = new LogClass();
            log.WriteLog("짜잔~~ 하고 나왔심다~");

            system("pause");
        }

        static void ShowScoreExplain(ScoreInfo[] score)
        {
            Console.WriteLine("1. 전체 정보");
            Console.WriteLine("2. 점수별 정보");
            Console.Write("번호를 입력하세요. : ");
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                for (int i = 0; i < score.Length; i++)
                {
                    score[i].all_ShowInfo();
                }
            }
            else if (x == 2)
            {
                Console.WriteLine("1. 국어");
                Console.WriteLine("2. 수학");
                Console.WriteLine("3. 영어");
                Console.WriteLine("4. 과학");
                Console.Write("확인할 과목을 고르세요 : ");
                int _subject = int.Parse(Console.ReadLine());
                for (int i = 0; i < score.Length; i++)
                {
                    score[i].part_ShowInfo(_subject);
                }
                Console.WriteLine("=====================================");
            }
        }
        static void ShowItemPrice(Item item)
        {
            Console.WriteLine("{0}의 가격은 {1}입니다.", item._myName, item._buyPrice);
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
