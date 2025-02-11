using System;
using System.Collections.Generic;

namespace Oppgave_intermediate;

public class MyGenericClass<T> //this class can store an item of any type (int, string, DateTime etc.)
{
    private T _value; //T is like a "variable" for a type

    public MyGenericClass(T value) //the constructor is used to set the initial value
    // of _value when you create an object of this class
    {
        _value = value;
    }

    public T GetValue() //method to return the stored value
    {
        return _value;
    }

    public void SetValue(T newValue) //method to update the stored value
    {
        _value = newValue;
    }

}

public class MyItems<E> : IMyGenericInterface<E>
{
    private List<E> _items = new List<E>(); // Private list to store items
    public void Add(E item)
    {
        _items.Add(item);
    }

    // Get an item by index
    public E Get(int index)
    {
        return _items[index];
    }

    // Get the total number of items
    public int Count
    {
        get { return _items.Count; }
    }
}


class Program
{
    static void Main(string[] args)
    {
  
    }
}
