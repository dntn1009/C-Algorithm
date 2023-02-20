using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Algorithm
{
    class CIMatrix
    {
        float[,] mat  = new float[4, 4];

        public float this[int index]
        {
            get {
                int row = index / mat.GetLength(0);
                int col = index % mat.GetLength(0);
                return mat[row, col]; }
        }//index

        public CIMatrix()
        {
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(0); j++)
                {
                    if (i == j)
                        mat[i, j] = 1;
                    else
                            mat[i, j] = 0;
                }
            }

        }//단위 행렬

        public CIMatrix(float[,] mat)
        {
            if (mat.GetLength(0) == 4 && mat.GetLength(0) == 4)
            {
                Array.Copy(mat, this.mat, mat.GetLength(0));
            }
            else
                identity();
            this.mat = mat;
        }

        public CIMatrix(float _11, float _12, float _13, float _14, float _21, float _22, float _23, float _24
                        , float _31, float _32, float _33, float _34, float _41, float _42, float _43, float _44)
        {
            mat = new float[4, 4] { {_11, _12, _13, _14 }, { _21, _22, _23, _24 }, { _31, _32, _33, _34 }, { _41, _42, _43, _44 } };
        }

        
        public CIMatrix Identity
        {
            get {return new CIMatrix(1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f); }
        } // 단위행렬 프로퍼티

        public void identity()
        {
            mat = new float[4, 4] { { 1f, 0f, 0f, 0f }, { 0f, 1f, 0f, 0f }, { 0f, 0f, 1f, 0f }, { 0f, 0f, 0f, 1f } };
        } // 단위행렬 반환

        public float[,] ZeroMatrix
        {
            get { return new float[4, 4] { { 0f, 0f, 0f, 0f }, { 0f, 0f, 0f, 0f }, { 0f, 0f, 0f, 0f }, { 0f, 0f, 0f, 0f } }; }
        }
        public static CIMatrix zeroMatrix(CIMatrix ci1)
        {
            float[,] zero = new float[4, 4];
            for (int i = 0; i < zero.GetLength(0); i++)
            {
                for (int j = 0; j < zero.GetLength(0); j++)
                {
                    zero[i, j] = 0;
                }
            }
            return new CIMatrix(zero);
        }//영행렬로 만든다.
        

        public static CIMatrix operator +(CIMatrix ci1, CIMatrix ci2)
        {
            float[,] plus = new float[4, 4]; 
            for (int i = 0; i < plus.GetLength(0); i++)
            {
                for (int j = 0; j < plus.GetLength(0); j++)
                {
                    plus[i, j] = ci1.mat[i, j] + ci2.mat[i, j];
                }
            }
            return new CIMatrix(plus);
        }//행렬 합

        public static CIMatrix operator -(CIMatrix ci1, CIMatrix ci2)
        {
            float[,] minus = new float[4, 4];
            for (int i = 0; i < minus.GetLength(0); i++)
            {
                for (int j = 0; j < minus.GetLength(0); j++)
                {
                    minus[i, j] = ci1.mat[i, j] - ci2.mat[i, j];
                }
            }
            return new CIMatrix(minus);
        }// 행렬 차

        public static CIMatrix operator *(CIMatrix ci1, CIMatrix ci2)
        {
            float[,] mutilple = new float[4, 4];
            float a = 0;
            for (int i = 0; i < mutilple.GetLength(0); i++)
            {
                for (int j = 0; j < mutilple.GetLength(0); j++)
                {
                    for(int k = 0; k < mutilple.GetLength(0); k++)
                    {
                        a += ci1.mat[i, k] * ci2.mat[k, j];
                    }
                    mutilple[i, j] = a;
                    a = 0;
                }
            }
            return new CIMatrix(mutilple);
        }// 행렬 곱

        public static CIMatrix operator *(float a, CIMatrix ci)
        {
            float[,] skala = new float[4, 4];
            for (int i = 0; i < skala.GetLength(0); i++)
            {
                for (int j = 0; j < skala.GetLength(0); j++)
                {
                    skala[i, j] = ci.mat[i, j] * a;
                }
            }
            return new CIMatrix(skala);
        }

        public static CIMatrix operator *(CIMatrix ci, float a)
        {
            float[,] skala = new float[4, 4];
            for (int i = 0; i < skala.GetLength(0); i++)
            {
                for (int j = 0; j < skala.GetLength(0); j++)
                {
                    skala[i, j] = ci.mat[i, j] * a;
                }
            }
            return new CIMatrix(skala);
        }// 스칼라 곱

        public static CIMatrix transpose(CIMatrix ci)
        {
            float[,] transpose = new float[4, 4];
            for (int row = 0; row < transpose.GetLength(0); row++)
            {
                for (int col = 0; col < transpose.GetLength(0); col++)
                {
                    transpose[row,col] = ci.mat[col, row];
                }
            }
            return new CIMatrix(transpose);
        }

        public static CIMatrix inverse(CIMatrix ci)
        {
            float[,] origin = ci.mat;
            CIMatrix inverse = new CIMatrix();
            //단위 행렬로 초기화
            const float ERROR = 1.0e-10f;
            for (int row = 0; row < inverse.mat.GetLength(0); row++)
                if (-ERROR < origin[row, row] && origin[row, row] < ERROR)
                {
                    for (int col = 0; col < inverse.mat.GetLength(0); col++)
                    {
                        if (-ERROR < origin[col, row] && origin[col, row] < ERROR) continue;
                        for (int n = 0; n < inverse.mat.GetLength(0); n++)
                        {
                            origin[row, n] += origin[col, n];
                            inverse.mat[row, n] += inverse.mat[col, n];  // result[i*n+j] += result[k*n+j];
                        }
                        break;
                    }
                    if (-ERROR < origin[row, row] && origin[row, row] < ERROR) 
                        return new CIMatrix(inverse.mat);
                }

            for (int row = 0; row < inverse.mat.GetLength(0); row++)
            {
                // 대각 요소를 1로 만듦
                float constant = origin[row, row];      // 대각 요소의 값 저장
                for (int col = 0; col < inverse.mat.GetLength(0); col++)
                {
                    origin[row, col] /= constant;   // tmpWork[i][i] 를 1 로 만드는 작업
                    inverse.mat[row, col] /= constant; // result[i*n+j] /= constant;   // i 행 전체를 tmpWork[i][i] 로 나눔
                }
                // i 행을 제외한 k 행에서 tmpWork[k][i] 를 0 으로 만드는 단계
                for (int n = 0; n < inverse.mat.GetLength(0); n++)
                {
                    if (n == row) continue;      // 자기 자신의 행은 건너뜀
                    if (origin[n, row] == 0) continue;   // 이미 0 이 되어 있으면 건너뜀

                    // tmpWork[k][i] 행을 0 으로 만듦
                    constant = origin[n, row];
                    for (int j = 0; j < inverse.mat.GetLength(0); j++)
                    {
                        origin[n, j] = origin[n, j] - origin[row, j] * constant;
                        inverse.mat[n, j] = inverse.mat[n, j] - inverse.mat[row, j] * constant;  // result[k*n+j] = result[k*n+j] - result[i*n+j] * constant;
                    }
                }
            }
            return inverse;
        }
        public override string ToString()
        {
            string str = "";
            for(int i = 0; i < mat.GetLength(0); i++) 
            {
                for(int j = 0; j < mat.GetLength(0); j++)
                {
                    if (j == mat.GetLength(0))
                        str += mat[i, j] + "\n";
                    else
                       str += mat[i, j]+ ", ";
                }
            }
            return string.Format(str);
        }

    }
}
