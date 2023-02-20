using Microsoft.SqlServer.Server;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Learn_Algorithm
{

    public static class SortClass
    {
        /*선택 정렬
         * 현재 위치에 들어갈 값을 찾아 정렬하는 배열
         * 최소 선택 = 오름차순, 최대 선택 = 내림차순
         * 
         * 선택 정렬의 오름차순
         * 전부 다 찾아서 제일 작은놈을 맨 앞에 놓고,
         * 그다음에 제일 작은놈을 찾아서 두번째 앞에 놓고
         * 이런식으로 함.
         */

        /* 삽입 정렬
         * 
         * 오름차순
         * 두번째 인덱스 부터 시작
         * 현재 인덱스는 별도의 변수에 저장하고, 비교 인덱스 = 현재 인덱스 -1
         * 별도의 변수와 인덱스의 배열 값 비교
         * 별도의 변수가 더 작으면 현재 인덱스로 비교 인덱스의 값을 저장하고
         * 비교 인덱스를 -1하여 비교를 반복한다.
         * 만약 삽입 변수가 더 크면 비교 인덱스 + 1에 삽입 변수를 저장한다.
         */

        /*  버블 정렬
         * 두번째 인덱스 부터 시작
         * 현재 인덱스와 바로 전 인덱스를 비교한다.
         * 이전 인덱스가 더 크면 현재 인덱스와 바꿔준다.
         * 현재 인덱스가 더 크면, 교환하지 않고 다음 두 연속된 배열값을 비교한다.
         * 위의순서를 (전체 배열의 크기 - 현재까지 순환한 바퀴수) 만큼 반복
         */

        /* 분할 합병 정렬
         * 큰 문제를 반으로 쪼개 문제를 해결하는 방식
         * 배열을 반으로 쪼갠다 시작위치 + 종료위치 /2 후 그 위치를 기준으로 나눈다.
         * 쪼갠 배열의 크기가 0이거나 1일때 까지 반복한다.
         * 두 배열 A,B의 크기를 비교한다 각각의 배열의 현재 인덱스를 n, m으로 가정하자.
         * n에는 A배열의 시작 인덱스를 저장 하고, m에는 B배열의 시작 인덱스를 저장한다.
         * A[n]과 B[m]을 비교한다. 오름차순의 경우 이중에 작은값을 새 배열C에 저장한다.
         * B[m]이 더 크다면 A[n]의 값을 배열 C에 저장하고 n의 값을 하나 증가시켜준다.
         * 이를 n이나 m 둘 중 하나가 각자 배열의 끝에 도달할 때까지 반복
         * 끝까지 저장을 못한 배열의 값을 순서대로 전부 C에 저장한다.
         * C배열을 원래의 배열에 저장해 준다.
         */

        public static void SelectionSort(int[] datas, bool isAsending = true)
        {
            if (isAsending)
                for (int n = 0; n < datas.Length - 1; n++)
                {
                    for (int m = n + 1; m < datas.Length; m++)
                    {
                        if (datas[n] > datas[m])
                        {
                            int t = datas[n];
                            datas[n] = datas[m];
                            datas[m] = t;
                        }
                    }
                }
            else
                for (int n = 0; n < datas.Length - 1; n++)
                {
                    for (int m = n + 1; m < datas.Length; m++)
                    {
                        if (datas[n] < datas[m])
                        {
                            int t = datas[n];
                            datas[n] = datas[m];
                            datas[m] = t;
                        }
                    }
                }
        }

        public static void insertionSort(int[] datas, bool isAsending = true)
        {
            int re = 0;

            if (isAsending)
                for (int i = 1; i < datas.Length; i++)
                {
                    int t = datas[i];
                    int n = 0;
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (t < datas[j])
                        {
                            datas[i - n] = datas[j];
                            datas[j] = t;
                            n++;
                        }
                        if (t > datas[re] && j == re)
                            break;
                    }
                    re++;
                }
            else
                for (int i = 1; i < datas.Length; i++)
                {
                    int t = datas[i];
                    int n = 0;
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (t > datas[j])
                        {
                            datas[i - n] = datas[j];
                            datas[j] = t;
                            n++;
                        }
                        if (t > datas[re] && j == re)
                            break;
                    }
                    re++;
                }


        }

        public static void bubbleSort(int[] datas, bool isAsending = true)
        {
            int circulate = datas.Length;
            if (isAsending)
                while (circulate > 1)
                {
                    for (int i = 1; i < circulate; i++)
                    {
                        if (datas[i] < datas[i - 1])
                        {
                            int t = datas[i];
                            datas[i] = datas[i - 1];
                            datas[i - 1] = t;
                        }
                    }
                    circulate--;
                }
            else
                while (circulate > 1)
                {
                    for (int i = 1; i < circulate; i++)
                    {
                        if (datas[i] > datas[i - 1])
                        {
                            int t = datas[i];
                            datas[i] = datas[i - 1];
                            datas[i - 1] = t;
                        }
                    }
                    circulate--;
                }
        }

        public static void MergeSort(int[] datas, int nLeft, int nRight, bool isAsending = true)
        {
            divid(datas.Length, 0, datas.Length);
        }
        
        public static void divid(int Dtotal, int Lindex, int Rindex)
        {
            if(Dtotal == 0 || Dtotal == 1)
            {
                return;
            }
            int Mid = Dtotal / 2;
            divid(Mid, Lindex, Rindex);
        }
        //index로 나눈다고 생각



    }
}
