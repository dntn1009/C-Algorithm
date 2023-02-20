using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCS
{
    public enum 과목이름
    {
        국어   = 0,
        영어,
        수학,
        과학,
        
        과목수
    }
    internal class Program
    {
        static Random rd = new Random();
        static void Main(string[] args)
        {
            {
                // 배열은 같은 자료형 묶음
                // 일괄처리 목적
                // 메모리상에 연속적으로 자료를 기억
                // stack 값 = 가변 heap 주소 = 참조
                // 배열의 형식 -> 자료형[] 배열이름 = new 자료형[크기];

                /*int[] numbers;         // 선언
                  numbers = new int[5]; // 할당*/
                //int[] numbers = new int[5] { 11, 22, 33, 44, 55}; // 배열의 초기화 /1
                //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 ,7 }; // 배열의 초기화 /2
                /*  int[] numbers = { 10, 20, 30, 40, 50, 60, 70 }; // 배열의 초기화 /3

                  *//*for(int i = 0; i < numbers.Length; i++)
                  {
                      numbers[i] = rd.Next();
                  }*//*

                  for (int i = 0; i < numbers.Length; i++)
                  {
                      Console.WriteLine("numbers[{0}] = {1}", i, numbers[i]);
                  }*/


                /*Console.Write("학생 수를 입력 하세요 : ");
                int students = int.Parse(Console.ReadLine());

                Console.Write("최소 점수를 입력 하세요 : ");
                int low_score = int.Parse(Console.ReadLine());

                Console.Write("최대 점수를 입력 하세요 : ");
                int high_score = int.Parse(Console.ReadLine());

                int[] s_num = new int[students];

                for(int i = 0; i < students; i ++)
                {
                    s_num[i] = rd.Next(low_score, high_score);
                    Console.WriteLine("{0}번째 학생 점수 : {1}", i+1, s_num[i]);
                }*/
                //학생입력 최소최대점수입력 출력 

                /*Console.Write("입력하실 학생 수를 정하세요 : ");
                int students = int.Parse(Console.ReadLine()); //학생 총 수
                float[] s_num = new float[students]; // 학생 총 수 배열
                int high_s = 0, low_s = 0; // 최고 최저 학생 배열
                float high_k = 0, low_k = 0; // 최고 최저 학생 배열 값

                for (int i = 0; i< students; i++)
                {
                    Console.Write("{0}번째 학생의 키 : ", i+1);
                    s_num[i] = float.Parse(Console.ReadLine()); // 배열 안에 값넣기
                    if (i == 0)
                    {
                        high_s = i;
                        high_k = s_num[i];
                        low_s = i;
                        low_k = s_num[i];
                    }
                    if (high_k < s_num[i])
                    {
                        high_s = i;
                        high_k = s_num[i];
                    }
                    if (low_k > s_num[i])
                    {
                        low_s = i;
                        low_k = s_num[i];
                    }
                }// 값 비교하여 최고 최저 값 구하기

                Console.WriteLine("제일 큰 키의 학생은 {0}번째 학생으로 키가 {1}Cm 입니다.", high_s + 1, high_k);
                Console.WriteLine("제일 작은 키의 학생은 {0}번째 학생으로 키가 {1}Cm 입니다.", low_s + 1, low_k);
                // 결과 출력*/
            }
            {
                /*
                            Console.Write("입력하실 학생 수를 정하세요 : ");
                            int students = int.Parse(Console.ReadLine()); //학생 총 수
                            int[] s_num = new int[students]; // 학생 총 수 배열
                            int[] high_num = new int[students];
                            for (int i = 0; i<students; i++)
                            {
                                s_num[i] = rd.Next(55, 100);
                                high_num[i] = s_num[i];
                            }

                            Array.Sort(high_num);
                            Array.Reverse(high_num);

                            for (int i = 0; i < students; i++)
                            {
                                int index_a = Array.IndexOf(s_num ,high_num[i]);
                                Console.WriteLine("{0}번 학생 점수 : {1}", index_a, high_num[i]);

                            }*/
            }

            // 다차원 배열의 사용은 같은 자료형 들이 다른 쓰임으로 쓰여야 할때 만들어 사용된다.
            // 다차원 배열의 형식
            // 자료형[,] 배열이름  = new 자료형[행크기, 열크기] : (차원수가 늘어갈수록 대괄호의 ','가 늘어난다.)

            /*int[,] groupScore = new int[5, (int)과목이름.과목수];

            for(int i = 0; i < groupScore.GetLength(0); i++)
            {
                for (int j = 0; j < groupScore.GetLength(1); j++)
                {
                    groupScore[i, j] = rd.Next(30, 101);
                }
            }

            for (int i = 0; i < groupScore.GetLength(0); i++)
            {
                Console.Write("{0}번째 ", i + 1);
                for (int j = 0; j < groupScore.GetLength(1); j++)
                {
                    Console.Write("{0}과목 점수 : {1}점", (과목이름)j, groupScore[i, j]);
                    if (j < groupScore.GetLength(1) - 1)
                        Console.Write(", ");
                }
                Console.WriteLine();
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            }
            Console.WriteLine("=========================================================================================================");*/

            int[,] groupScore = new int[5, (int)과목이름.과목수];

            for (int i = 0; i < groupScore.GetLength(0); i++)
            {
                for (int j = 0; j < groupScore.GetLength(1); j++)
                {
                    groupScore[i, j] = rd.Next(30, 101);
                }
            }
            int stu_num = 0;
            
            Console.WriteLine("1. 국어점수 \n2. 영어점수\n3. 수학점수\n4. 과학점수");
            for (int i = 0; i < (int)과목이름.과목수; i++)
            {
                Console.WriteLine("{0}.{1}점수", i + 1, (과목이름)i);
            }
            Console.Write("번호를 입력 하세요.");
            stu_num = int.Parse(Console.ReadLine()) - 1;
            for (int i = 0; i < groupScore.GetLength(0); i++)
            {
                Console.Write("{0}번째 ", i + 1);
                Console.Write("{0}과목 점수 : {1}점", (과목이름)stu_num, groupScore[i, stu_num]);

                Console.WriteLine();
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            }
            Console.WriteLine("=========================================================================================================");

            system("pause");
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
