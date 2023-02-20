using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCS
{
    class MyList<T>
    {
        T[] _datas;

        public int _count
        {
            get; set;
        }

        public MyList()
        {
            _datas = new T[4];
        }

        public void Add(T val)
        {
            if(_count == _datas.Length)
            {
                Array.Resize<T>(ref _datas, _datas.Length * 2);
            }
            _datas[_count++] = val;
        }
        public bool GetValue(int index, out T val) 
        {
            if (index >= 0 && index < _count)
            {
                val = _datas[index];
                return true;
            }
            else
            {
                val = default(T);
                return false;
            }
        }
    }
}
