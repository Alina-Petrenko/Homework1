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
        }

        public void AddRange( T[] _newList)
        {
            foreach (T item in _newList)
            {
                Add(item);
            }
        }
        public void AddRange(IEnumerable<T> _newList)
        {
            foreach (T item in _newList)
            {
                Add(item);
            }
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