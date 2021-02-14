using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<X,Y>
    {
        X[] _key;
        X[] _tempKey;
        Y[] _values;
        Y[] _tempValues;

        public MyDictionary()
        {
            _key = new X[0];
            _values = new Y[0];

        }

        public void Add(X key , Y value)
        {
            _tempKey = _key;
            _tempValues = _values;
            _key = new X[_key.Length + 1];
            _values = new Y[_values.Length + 1];
            for (int i = 0; i < _tempKey.Length; i++)
            {
                _key[i] = _tempKey[i];
                _values[i] = _tempValues[i];
            }
            _key[_key.Length - 1] = key;
            _values[_values.Length - 1] = value;
        }

        public int _KeyCount
        {
            get { return _key.Length; }
        }

        public int _ValueCount
        {
            get { return _values.Length; }
        }

        public void Clear()
        {
            _key = new X[0];
            _values = new Y[0];
        }

        public void _Print()
        {
            Console.WriteLine("Sözlük içeriği : "+ _key.Length + " adet çift bulundu.");
            Console.WriteLine("************");
            for (int i = 0; i < _key.Length; i++)
            {
                Console.WriteLine("Key   : " + _key[i]);
                Console.WriteLine("Value : " + _values[i]);
                Console.WriteLine("************");
            }
        }







    }
}
