using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Linq;

namespace Task_41;

class Array1D<T, R>
{
    private T[] _array;

    private int _capacity;

    private const int defaultCapacity = 10;

    private int _size;

    // public Array1D(int capacity = defaultCapacity)
    // {
    //     _capacity = capacity;
    //     _array = new T[capacity];
    //     _size = 0;
    // }

    public Array1D(int capacity)
    {
        _capacity = capacity;
        _array = new T[capacity];
        _size = 0;
    }

    public Array1D() : this(defaultCapacity)
    {
    }

    public void Print()
    {
        Console.WriteLine(string.Join(", ", _array));
    }

    public void Add(T item)
    {
        if (_size >= _capacity)
        {
            _capacity = _capacity * 2 + 1;
            Array.Resize(ref _array, _capacity);
        }
        _array[_size] = item;
        _size++;
    }

    public void DeleteElement(T valueToRemove, Func<T, T, bool> areEqual)
    {
        List<T> list = [];
        foreach (T item in _array)
        {
            if (areEqual(item, valueToRemove))
            {
                _size--;
            }
            else
            {
                list.Add(item);
            }
        }
        _array = list.ToArray();
        Array.Resize(ref _array, _capacity);
    }

    public T[] SortedArray()
    {
        Array.Sort(_array);
        return _array;
    }

    public int AmountOfElements()
    {
        return _size;
    }

    public int AmountByCondition(Func<T, bool> predicate)
    {
        int counter = 0;
        foreach (T item in _array)
        {
            if (item != null && predicate(item))
            {
                counter++;
            }
        }
        return counter;
    }

    public bool Some(Func<T, bool> predicate)
    {
        foreach (T item in _array)
        {
            if (item != null && predicate(item))
            {
                return true;
            }
        }
        return false;
    }

    public bool All(Func<T, bool> predicate)
    {
        foreach (T item in _array)
        {
            if (item != null && !predicate(item))
            {
                return false;
            }
        }
        return true;
    }

    public bool Exist(T value, Func<T, T, bool> areEqual)
    {
        foreach (T item in _array)
        {
            if (areEqual(item, value))
            {
                return true;
            }
        }
        return false;
    }

    public T? FirstSuitable(Func<T, bool> predicate)
    {
        foreach (T item in _array)
        {
            if (item != null && predicate(item))
            {
                return item;
            }
        }
        return default;
    }

    public void Apply(Action<T> action)
    {
        foreach (T item in _array)
        {
            action(item);
        }
    }

    public T[] Flip()
    {
        Array.Reverse(_array);
        return _array;
    }

    public T? Minimum()
    {
        return _array.Min();
    }

    public T? Maximum()
    {
        return _array.Max();
    }

    public R[] Projection(Func<T, R> map)
    {
        return _array.Select(map).ToArray();
    }

    public T[] AmountFromIndex(int from, int len)
    {
        if (from < 0 || len < 0) return [];
        List<T> list = [];
        for (int index = from; index < from + len; index++)
        {
            if (_array[index] != null)
            {
                list.Add(_array[index]);
            }
        }
        return list.ToArray();
    }
}