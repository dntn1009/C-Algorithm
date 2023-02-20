using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Learn_DataStructure
{
    /* Linked List
     * 연속된 데이터의 묶음
     * Node, Link, Head, Tail로 구성
     * Singly => Link가 한쪽 방향으로만 연결되어 있는 형태
     * Doubly => 양쪽 방향으로 연결되어 있는 형태
     * Circularly => Tail 노드의 Link Head와 연결되어 있는 형태(위 두개는 Tail의 next link는 Null)
     * 실은 Head와 Tail의 구분이 없다.(편의를 위해 아무 Node하나를 Cursor로)
     */



    public class DL_node
    {
        public object _value;
        public DL_node _prev;
        public DL_node _next;


        public DL_node()
        {
            this._value = null;
            this._prev = null;
            this._next = null;
        }

    }
    class CILinkedList
    {
        DL_node _head;
        DL_node _tail;
        int _cnt;

        public object this[int index]
        {
            get 
            {
                if (index < 0 || index >= _cnt)
                    return null;
                else
                {
                    DL_node Search = _head;
                    for (int i = 0; i < index; i++)
                    {
                        Search = Search._next;
                    }
                    object t = Search._value;
                    return t;
                }
            }
            set
            {
                if (index < 0 || index >= _cnt)
                    return;
                else
                {
                    DL_node Search = _head;
                    for (int i = 0; i < index; i++)
                    {
                        Search = Search._next;
                    }
                    Search._value = value;
                }
            }
        }

        public int _count
        {
            get { return _cnt; }
        }
        public bool _isEmpty
        {
            get 
            { 
                if(_cnt == 0)
                    return false;
                return true;
            }
        }

        public CILinkedList()
        {
            _cnt = 0;
        }
        /// <summary>
        /// List 뒤에 값을 이용해 node를 만들어 추가한다.
        /// </summary>
        /// <param name="element">추가되는 값</param>
        public void Add(object element)
        {
            DL_node node = new DL_node();
            if (_cnt == 0)
            {
                node._prev = null;
                node._next = null;
                node._value = element;
                _head = node;
            }
            else if (_cnt == 1)
            {
                node._prev = _head;
                node._value = element;
                _tail = node;
                _head._next = _tail;
            }
            else
            {
                _tail._next = node;
                node._prev = _tail;
                node._value = element;
                _tail = node;
            }
            _cnt++;
            //맨 끝에 붙어야됌
        }
        /// <summary>
        /// 해당하는 값을 찾아 삭제한다. 값이 없으면 false 리턴
        /// </summary>
        /// <param name="element">삭제 할 값</param>
        /// <returns>삭제 성공시 true </returns>
        public bool Remove(object element) 
        {
            bool ret_check =false;
            DL_node search = _head;
            for(int i = 0; i < _cnt; i++)
            {
                DL_node t;
                if (search._value.Equals(element))
                {
                    search._next._prev = search._prev;
                    search._prev._next = search._next;
                    t = search._next;
                    search._next = null;
                    search._prev = null;
                    search._value = null;
                    search = null;
                    _cnt--;
                    search = t;
                    ret_check = true;
                }
                else
                    search = search._next;
               
            }
            return ret_check;
        }
        /// <summary>
        /// 해당하는 index를 삭제한다.해당하는 Index가 없으면 false 리턴
        /// </summary>
        /// <param name="index">삭제할 Index 번호</param>
        /// <returns>삭제 성공 시 true</returns>
        public bool RemoveAt(int index)
        {
            DL_node search = _head;
            if (_cnt <= index && _cnt > 0)
                return false;
            else
            {
                for (int i = 0; i < index; i++)
                {
                    search = search._next;
                }
                search._next._prev = search._prev;
                search._prev._next = search._next;
                search._value = null;
                search._prev = null;
                search._next=null;
                search = null;
                _cnt--;
                return true;
            }
        }
        /// <summary>
        /// 해당하는 위에 값을 삽입한다. index값이 범위에 없으면 list 맨뒤에 추가한다.
        /// </summary>
        /// <param name="index">삽입할 위치</param>
        /// <param name="element">삽입할 값</param>
        public void Insert(int index, object element)
        {
            DL_node node = new DL_node();
            if (_cnt <= index && _cnt > 0)
            { 
                _tail._next = node;
                node._prev = _tail;
                node._value = element;
                _tail = node;
                _cnt++;
            }
            else
            {
                DL_node search = _head;
                for(int i = 0; i < index - 1; i++) 
                {
                    search = search._next;
                }
                node._prev = search;
                node._next = search._next;
                search._next._prev = node;
                search._next = node;
                node._value = element;
                _cnt++;
            }
        }
        /// <summary>
        /// 순서를 거꾸로 한다.
        /// </summary>
        public void Reverse()
        {
            DL_node search = _tail;
            DL_node[] t = new DL_node[_cnt];
            for(int i = 0; i < _cnt; i++)
            {
                t[i] = search;
                search = search._prev;
            }
            _head = _tail;
            _tail = null;
            int num = _cnt;
            _cnt = 0;
            for(int i = 0; i < num; i++)
            {
                this.Add(t[i]._value);
            }

        }
    }

    public class SL_node
    {
        public object _value;
        public SL_node _next;

        public SL_node()
        {
            this._value = null;
            this._next = null;
        }
    }

    class SLLinkedList
    {
        SL_node _head;
        int _cnt;

        public object this[int index]
        {
            get
            {
                SL_node Search = _head;
                for (int i = 0; i < index; i++)
                {
                    Search = Search._next;
                }
                object t = Search._value;
                return t;
            }
            set
            {
                SL_node Search = _head;
                for (int i = 0; i < index; i++)
                {
                    Search = Search._next;
                }
                 Search._value = value;
            }
        }

        public int _count
        {
            get { return _cnt; }
        }
        public bool _isEmpty
        {
            get
            {
                if (_cnt == 0)
                    return false;
                return true;
            }
        }

        public SLLinkedList()
        {
            _cnt = 0;
        }
        /// <summary>
        /// List 뒤에 값을 이용해 node를 만들어 추가한다.
        /// </summary>
        /// <param name="element">추가되는 값</param>
        public void Add(object element)
        {
           SL_node node= new SL_node();
            node._value = element;
            if (_cnt == 0)
                _head = node;
            else
            {
                SL_node search = _head;
                for(int i = 0; i < _cnt; i++)
                    search = search._next;
                search._next = node;
            }
            _cnt++;
            //맨 끝에 붙어야됌
        }
        /// <summary>
        /// 해당하는 값을 찾아 삭제한다. 값이 없으면 false 리턴
        /// </summary>
        /// <param name="element">삭제 할 값</param>
        /// <returns>삭제 성공시 true </returns>
        public bool Remove(object element)
        {
            bool ret_check = false;
            SL_node search = _head;
            if(search._value == element)
            {
                _head = search._next;
                search._next = null;
                search._value= null;
                ret_check = true;
                _cnt--;
                return ret_check;
            }
            for(int i = 0; i < _cnt; i++)
            {
                if (search._next._value == element)
                {
                    search._next._value = null;
                    search._next = search._next._next;
                    search._next._next = null;
                    _cnt--;
                    ret_check = true;
                }
                else
                    search = search._next;
            }
            return ret_check;
        }
        /// <summary>
        /// 해당하는 index를 삭제한다.해당하는 Index가 없으면 false 리턴
        /// </summary>
        /// <param name="index">삭제할 Index 번호</param>
        /// <returns>삭제 성공 시 true</returns>
        public bool RemoveAt(int index)
        {
            if (_cnt > 0 && _cnt < index)
            {
                SL_node search = _head;
                for (int i = 0; i < _cnt; i++)
                    search = search._next;
                search._next._value = null;
                search._next = search._next._next;
                search._next._next = null;
                _cnt--;
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// 해당하는 위에 값을 삽입한다. index값이 범위에 없으면 list 맨뒤에 추가한다.
        /// </summary>
        /// <param name="index">삽입할 위치</param>
        /// <param name="element">삽입할 값</param>
        public void Insert(int index, object element)
        {
            SL_node node = new SL_node();
            node._value = element;
            if (_cnt > 0 && _cnt < index)
            {
                SL_node search = _head;
                for (int i = 0; i < _cnt; i++)
                    search = search._next;
                node._next = search._next._next;
                search._next = node;
            }
            else
            {
                if (_cnt == 0)
                    _head = node;
                else
                {
                    SL_node search = _head;
                    for (int i = 0; i < _cnt; i++)
                        search = search._next;
                    search._next = node;
                }
            }
            _cnt++;
        }
        /// <summary>
        /// 순서를 거꾸로 한다.
        /// </summary>
        public void Reverse()
        {
            SL_node search = _head;
            object[] value = new object[_cnt];
           for(int i = 0; i < _cnt; i++)
           {
                value[i] = search._value;
                search._value = null;
                SL_node t = search._next;
                search._next = null;
                search = t;
           }
           int cnt = _cnt;
            for (int i = 0; i < _cnt; i++)
            {
                if (i == 0)
                { 
                    search._value = value[cnt];
                    _head = search;
                }
                else
                    this.Add(value[cnt]);
                cnt--;
           }

        }
    }


}
