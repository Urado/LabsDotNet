using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListLab
{
    public class MyList<T> : IList<T>
    {
        private MyElement<T> _firstElement = null;

        private MyElement<T> getElementByNumber(int n)
        {
            MyElement<T> ret = _firstElement;
            for (int i = 0; i < n; i++)
            {
                if (ret == null)
                    break;
                ret = ret.Next;
            }
            return ret;
        }

        public T this[int index] { get { return getElementByNumber(index).Item; } set { getElementByNumber(index).Item = value; } }

        public int Count
        {
            get
            {
                int ret = 0;
                for (MyElement<T> i = _firstElement; i != null; i = i.Next)
                    ret++;
                return ret;
            }
        }

        public bool IsReadOnly{ get { return false; } }

        public void Add(T item)
        {
            if (_firstElement != null)
            {
                MyElement<T> i;
                for (i = _firstElement; i.Next != null; i = i.Next) ;
                i.Next = new MyElement<T>(item);
            }
            else
                _firstElement = new MyElement<T>(item);
        }

        public void Clear()
        {
            _firstElement = null;
        }

        public bool Contains(T item)
        {
            var i = _firstElement;
            for (; i != null && !i.Item.Equals(item); i = i.Next);
            return i != null;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            var Elem = _firstElement;
            for(int i=arrayIndex;Elem!=null;i++, Elem=Elem.Next)
            {
                array[i] = Elem.Item;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (MyElement<T> i = _firstElement; i != null; i = i.Next)
                yield return i.Item;
        }

        public int IndexOf(T item)
        {
            var i = _firstElement;
            int ret = 0;
            for (; i != null && !i.Item.Equals(item); i = i.Next)
                ret++;
            if (i == null)
                ret = -1;
            return ret;
        }

        public void Insert(int index, T item)
        {
            var inElem = new MyElement<T>(item);
            if (index == 0)
            {
                inElem.Next = _firstElement;
                _firstElement = inElem;
            }
            else
            {
                var before = getElementByNumber(index - 1);
                inElem.Next = before.Next;
                before.Next = inElem;
            }
        }

        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if(index!=-1)
                RemoveAt(IndexOf(item));
            return index != -1;
        }

        public void RemoveAt(int index)
        {
            if (index > 0)
            {
                var before = getElementByNumber(index - 1);
                if (before != null&&before.Next!=null)
                    before.Next = before.Next.Next;
            }
            else if(index==0)
                if (_firstElement != null)
                    _firstElement=_firstElement.Next;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (MyElement<T> i = _firstElement; i != null; i = i.Next)
                yield return i.Item;
        }

        public string ToCheckString()
        {
            string ret="";

            for (var iter = _firstElement; iter != null; iter = iter.Next)
                ret += iter.Item.ToString() + " ";

            return ret;
        }

        internal class MyElement<E>
        {
            internal MyElement(E item)
            {
                Item = item;
            }
            internal E Item { get; set; }
            internal MyElement<E> Next { get; set; }     

        }

    }
}
