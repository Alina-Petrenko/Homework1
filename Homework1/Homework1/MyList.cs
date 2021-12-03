using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class MyList<T> : IEnumerable<T>
    {
        private T[] _myList = new T[4];
        private int _count = 0;
        public int Count
        {
            get
            {
                return _count;
            }
        }

        public T this[int i]
        {
            get
            {
                if (i < 0 || i >= _count)
                    throw new IndexOutOfRangeException();
                return _myList[i];
            }

            set
            {
                if (i < 0 || i >= _count)
                    throw new IndexOutOfRangeException();
                _myList[i] = value;
            }
        }
        public void Add(T item)
        {
            if (_count >= _myList.Length)
            {
                T[] _newList = new T[_myList.Length * 2];
                for (int i = 0; i< _myList.Length; i++)
                {
                    _newList[i] = _myList[i];
                }
                _myList = _newList;
                    
            }
            _myList[_count] = item;
            _count++;
            CutArray();
        }

        public void AddRange( T[] _newList)
        {
            foreach (T item in _newList)
            {
                Add(item);
            }
            CutArray();
        }
        public void AddRange(IEnumerable<T> _newList)
        {
            foreach (T item in _newList)
            {
                Add(item);
            }
            CutArray();
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_myList[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
        public void Remove(T item)
        {
            RemoveAt(IndexOf(item));
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < _count - 1; i++)
            {
                _myList[i] = _myList[i + 1];
            }
            _count--;
            CutArray();
        }
        public void Sort()
        {
            Array.Sort(_myList);
        }
        private void CutArray()
        {
            T[] _newList = new T[_count];
            for (int i = 0; i<_newList.Length; i++)
            {
                _newList[i] = _myList[i];
            }
            _myList = _newList;
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i<_myList.Length; i++)
            {
                yield return _myList[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < _myList.Length; i++)
            {
                yield return _myList[i];
            }
        }
    }
}