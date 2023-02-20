using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_DataStructure
{
    public class B_node
    {
        public int _key;
        public object _value;
        public int _height;
        public B_node _left;
        public B_node _right;

        public B_node()
        {
            this._value = null;
            this._height = 0;
            this._left = null;
            this._right = null;
        }

        // public AVL_node(object value, int key, int height) { _value = value; _key = key; _height = height; }
    }

    class CISearchTree
    {
        //search insert delect
        B_node _Root;
        int _height;

        public CISearchTree()
        {
            _Root = null;
            _height = 0;
        }

        /*       public int _capacity { get { return _node.Length; } }
               public int _count { get { return _cnt; } }
       */
        public bool Insert(int key, object element)
        {
            bool check = true;
            if (_Root == null)
            {
                _Root = new B_node();
                _Root._value = element;
                _Root._key = key;
            }
            else
            {
                B_node search = _Root;

                while (search != null)
                {
                    if (key > search._key)
                        if (search._right != null)
                        {
                            search = search._right;
                        }
                        else
                        {
                            search._right = new B_node();
                            search._right._value = element;
                            search._right._key = key;
                            search._right._height = search._height + 1;
                            break;
                        }
                    else if (key < search._key)
                        if (search._left != null)
                        {
                            search = search._left;
                        }
                        else
                        {
                            search._left = new B_node();
                            search._left._value = element;
                            search._left._key = key;
                            search._left._height = search._height + 1;
                            break;
                        }
                    else
                    {
                        check = false;
                    }
                }
            }
            return check;
        }
        public bool Search(int key, ref object value)
        {
            B_node search = _Root;

            while (search != null)
            {
                if (search._key != key)
                {
                    if (key > search._key)
                        search = search._right;
                    else if (key < search._key)
                        search = search._left;
                }
                else
                {
                    value = search._value;
                    return true;
                }
            }
            return false;
        }


        public bool Delect(int key)
        {
            B_node search = _Root;
            B_node before = _Root;
            bool Left_Right = false; // false = 오른쪽, true = 왼쪽
            while (search != null)
            {
                if (search._key != key)
                {
                    if (key > search._key)
                    {
                        before = search;
                        search = search._right;
                        Left_Right = false;
                    }
                    else if (key < search._key)
                    {
                        before = search;
                        search = search._left;
                        Left_Right = true;
                    }
                }
                else
                {
                    if (search._left == null && search._right == null)
                    {
                        if (Left_Right)
                        {
                            before._left = null;
                            search = null;
                        }
                        else
                        {
                            before._right = null;
                            search = null;
                        }
                        return true;
                    }// case 3: 둘다 없는 경우
                    else if (search._left != null && search._right == null)
                    {
                        B_node par = search;
                        bool Left_Right2 = false;
                        while (search != null)
                        {
                            if (search._right != null)
                            {
                                par = search;
                                search = search._right;
                                Left_Right2 = false;
                            }
                            else if (search._left != null)
                            {
                                par = search;
                                search = search._left;
                                Left_Right2 = true;
                            }
                            else if (search._right == null && search._left == null)
                                break;
                        }
                        if (Left_Right2)
                        {
                            if (Left_Right)
                            {
                                search._left = before._left._left;
                                search._right = before._left._right;
                                before._left._left = null;
                                before._left._right = null;
                                before._left = search;

                            }
                            else
                            {
                                search._left = before._right._left;
                                search._right = before._right._right;
                                before._right._left = null;
                                before._right._right = null;
                                before._right = search;
                            }
                            par._left = null;
                        }//왼쪽
                        else
                        {
                            if (Left_Right)
                            {
                                search._left = before._left._left;
                                search._right = before._left._right;
                                before._left._left = null;
                                before._left._right = null;
                                before._left = search;

                            }
                            else
                            {
                                search._left = before._right._left;
                                search._right = before._right._right;
                                before._right._left = null;
                                before._right._right = null;
                                before._right = search;
                            }
                            par._right = null;
                        }//오른쪽
                    }// case2 : 왼쪽 자식만 있을 경우
                    else if (search._right != null)
                    {
                        B_node par = search;
                        bool Left_Right2 = false;
                        while (search != null)
                        {
                            if (search._left != null)
                            {
                                par = search;
                                search = search._left;
                                Left_Right2 = true;
                            }
                            else if (search._right != null && search._right._left != null)
                            {
                                par = search;
                                search = search._right;
                                Left_Right2 = false;
                            }
                            else if (search._right == null && search._left == null)
                                break;
                        }
                        if (Left_Right2)
                        {
                            if (Left_Right)
                            {
                                search._left = before._left._left;
                                search._right = before._left._right;
                                before._left._left = null;
                                before._left._right = null;
                                before._left = search;

                            }
                            else
                            {
                                search._left = before._right._left;
                                search._right = before._right._right;
                                before._right._left = null;
                                before._right._right = null;
                                before._right = search;
                            }
                            par._left = null;
                        }//왼쪽
                        else
                        {
                            if (Left_Right)
                            {
                                search._left = before._left._left;
                                search._right = before._left._right;
                                before._left._left = null;
                                before._left._right = null;
                                before._left = search;

                            }
                            else
                            {
                                search._left = before._right._left;
                                search._right = before._right._right;
                                before._right._left = null;
                                before._right._right = null;
                                before._right = search;
                            }
                            par._right = null;
                        }
                    }// case1 : 오른쪽 자식만 있을 경우 & 왼쪽, 오른쪽 자식만 있을 경우          
                    return true;
                }
            }
            return false;
        }
    }
}
