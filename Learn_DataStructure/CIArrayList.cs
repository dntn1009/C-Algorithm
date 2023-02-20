using System;

namespace Learn_DataStructure
{
    class CIArrayList
    {
        /* ArrayList
         * 일차원적 자료구조
         * C++ = vector
         * 모든 자료구조의 기본형, 연속된 데이터의 묶음
         * 
        * 잘못된 index에는 에러를 던짐
        * TODO
        * get(index) = index위치의 element 반환
        * set(index, object) index의 object 값 수정
        * Add(index, object) index 위치의 object값 새로 삽입 삽입된 부분 뒤에 애들을 한칸씩 뒤로 밀어낸다. 추가는 오직 add에서만
        * Remove(index) 제거 후 나머지를 한칸 앞으로 당긴다.
        * Additional
        * Size() 현재 크기 확인
        * isEmpty() 비어있는지 확인 Bool
        * 크기는 고정되어있고 값이 추가된다. 그 이후에 고정된 크기의 범위를 넘어서면 크기를 늘린다.
        * add에서 n == n (크기와 마지막 값이 같으면) 크기를 늘려야 되며, add(i, o) i의 인덱스에 값을 추가하기 이전에, 마지막에서부터 i까지 뒤로 한칸씩 민 후에 값을 추가한다.
        * remove에서 삭제한 index의 앞에서 부터 마지막까지 한칸씩 당겨온다. 
        */
        object[] _datas;
        int _cnt;

        public CIArrayList()
        {
            _datas = new object[4];
            _cnt = 0;
        }// 0 2 4 8 16 32 64 128

        public object this[int index]
        {
            get
            {
                try
                {
                    if (_cnt == 0)
                        return null;
                    return _datas[index];
                }
                catch (IndexOutOfRangeException e)
                {
                    return null;
                }
            }
            set 
            {
                if (_cnt == 0)
                    return;
                if (index < 0 || index > _cnt)
                    return;
                _datas[index] = value; 
            }
        }

        public int _count// 들어간 값 size 확인
        {
            get { return _cnt; }
        }

        public int _capacity // 최대 크기
        {
            get { return _datas.Length; }
        }

        public bool _isEmpty
        {
            get
            {
                if (_datas == null)
                    return true;
                else
                    return false;
            }
        }
        /// <summary>
        /// ArrayList에 요소를 추가한다.
        /// </summary>
        /// <param name="element"> 추가할 요소 </param>
        public void Add(object element)
        {
            if (_cnt >= _datas.Length)
                Array.Resize(ref _datas, _datas.Length * 2);
            _datas[_cnt] = element;
            _cnt++;
        }
        /// <summary>
        /// 해당 Index 요소를 제거한다.
        /// </summary>
        /// <param name="index">제거할 요소가 있는 Index</param>
        /// <returns>Index가 잘못 되었을 시 false</returns>
        public bool Remove(int index)
        {
            try
            {
                object test = _datas[index];
                for (int i = index; i < _cnt; i++)
                {
                    _datas[i] = _datas[i + 1];
                }
                _cnt--;
                return true;
            }
            catch (IndexOutOfRangeException e)
            {
                return false;
            }
        }
        /// <summary>
        /// 해당 Index위치에 요소를 삽입한다.
        /// </summary>
        /// <param name="index">삽입할 위치 Index</param>
        /// <param name="element">삽입할 요소</param>
        /// <returns>삽입할 위치가 ArrayList범위를 벗어나면 false</returns>
        public bool Insert(int index, object element)
        {
            try
            {
                object test = _datas[index];
                if (_cnt == _datas.Length)
                    Array.Resize(ref _datas, _datas.Length * 2);
                for (int i = _cnt; i >= index; i--)
                {
                    _datas[i] = _datas[i - 1];
                }
                _datas[index] = element;
                _cnt++;
                return true;
            }
            catch (IndexOutOfRangeException e)
            {
                return false;
            }
        }

        public void sort()
        {
            int num = 0;
            int circulate = _cnt;
            for (int i = 0; i < _cnt; i++)
            {
                float flo_check;
                bool check = float.TryParse(_datas[i].ToString(), out flo_check);
                if (!check)
                {
                    object t = _datas[i];
                    _datas[i] = _datas[num];
                    _datas[num] = t;
                    num++;
                }
            }

            if (num != 0)
            {
                for (int i = 0; i < num; i++)
                {
                    for (int j = 0; j < num; j++)
                    {
                        string str_datas = _datas[i].ToString();
                        int str_check = str_datas.CompareTo(_datas[j].ToString());
                        if (str_check < 0)
                        {
                            object t = _datas[i];
                            _datas[i] = _datas[j];
                            _datas[j] = t;
                        }
                    }
                }
                while (circulate > num)
                {
                    for (int i = num + 1; i < circulate; i++)
                    {
                        string str1 = _datas[i].ToString();
                        string str2 = _datas[i-1].ToString();
                        if (float.Parse(str1) < float.Parse(str2))
                        {
                            object t = _datas[i];
                            _datas[i] = _datas[i - 1];
                            _datas[i - 1] = t;
                        }
                    }
                    circulate--;
                }
            }
            else
            {
                while (circulate > 1)
                {
                    for (int i = 1; i < circulate; i++)
                    {
                        if ((float)_datas[i] < (float)_datas[i - 1])
                        {
                            object t = _datas[i];
                            _datas[i] = _datas[i - 1];
                            _datas[i - 1] = t;
                        }
                    }
                    circulate--;
                }
            }
            //가나다, ABCabc, 
        }
        public void Reverse()
        {
            for(int i = 0; i < _cnt / 2; i++)
            {
                object t = _datas[i];
                _datas[i] = _datas[_cnt - i - 1];
                _datas[_cnt - i - 1] = t;
            }
        }
    }

    class CIList<T>
    {
        T[] _datas;
        int _cnt;

        public CIList() 
        {
            _datas = new T[4];
            _cnt = 0;
        }
        public object this[int index]
        {
            get
            {
                try
                {
                    if (_cnt == 0)
                        return null;
                    return _datas[index];
                }
                catch (IndexOutOfRangeException e)
                {
                    return null;
                }
            }
            set
            {
                if (_cnt == 0)
                    return;
                if (index < 0 || index > _cnt)
                    return;
                _datas[index] = (T)value;
            }
        } // 좀있다 한번더 체크

        public int _count// 들어간 값 size 확인
        {
            get { return _cnt; }
        }

        public int _capacity // 최대 크기
        {
            get { return _datas.Length; }
        }
        public bool _isEmpty
        {
            get
            {
                if (_datas == null || _cnt == 0)
                    return true;
                else
                    return false;
            }
        }

        public void Add(T element)
        {
            if (_cnt >= _datas.Length)
                Array.Resize(ref _datas, _datas.Length * 2);
            _datas[_cnt] = element;
            _cnt++;
        }

        public bool Remove(int index)
        {
            try
            {
                object test = _datas[index];
                for (int i = index; i < _cnt; i++)
                {
                    _datas[i] = _datas[i + 1];
                }
                _cnt--;
                return true;
            }
            catch (IndexOutOfRangeException e)
            {
                return false;
            }
        }

        public bool Insert(int index, T element)
        {
            try
            {
                object test = _datas[index];
                if (_cnt == _datas.Length)
                    Array.Resize(ref _datas, _datas.Length * 2);
                for (int i = _cnt; i >= index; i--)
                {
                    _datas[i] = _datas[i - 1];
                }
                _datas[index] = element;
                _cnt++;
                return true;
            }
            catch (IndexOutOfRangeException e)
            {
                return false;
            }
        }


    }

}
