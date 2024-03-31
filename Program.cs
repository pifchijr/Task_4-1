using System;

namespace Task_41;

class Program
{
    static void Main()
    {
        Array1D<int, string> array1Dint = new Array1D<int, string>();
        array1Dint.Add(1);
        array1Dint.Add(2);
        array1Dint.Add(1);
        array1Dint.Add(4);
        array1Dint.Add(77);
        array1Dint.Add(-125);
        array1Dint.Add(5656);
        array1Dint.Print();

        array1Dint.DeleteElement(1, (a, b) => a == b);
        array1Dint.Print();

        array1Dint.SortedArray();
        array1Dint.Print();

        Console.WriteLine(array1Dint.AmountOfElements());
        Console.WriteLine(array1Dint.AmountByCondition(item => item > 1));
        Console.WriteLine(array1Dint.Some(item => item > 1));
        Console.WriteLine(array1Dint.Some(item => item < -130));
        Console.WriteLine(array1Dint.All(item => item > -126));
        Console.WriteLine(array1Dint.All(item => item < 1000));




        Array1D<string, int> array1Dstring = new Array1D<string, int>();
        array1Dstring.Add("собака");
        array1Dstring.Add("собака");
        array1Dstring.Add("мышь");
        array1Dstring.Add("попугай");
        array1Dstring.Add("зебра");
        array1Dstring.Add("носорог");
        array1Dstring.Add("слон");
        array1Dstring.Print();

        array1Dstring.DeleteElement("собака", (a, b) => a == b);
        array1Dstring.Print();

        array1Dstring.SortedArray();
        array1Dstring.Print();

        Console.WriteLine(array1Dstring.AmountOfElements());
        Console.WriteLine(array1Dstring.AmountByCondition(item => item == "кошка"));
        Console.WriteLine(array1Dstring.Some(item => item == "мышь"));
        Console.WriteLine(array1Dstring.Some(item => item == "барсук"));
        Console.WriteLine(array1Dstring.All(item => item.Length > 3));
        Console.WriteLine(array1Dstring.All(item => item == "носорог"));
        Console.WriteLine(array1Dstring.FirstSuitable(item => item.Substring(0) == "з"));

        Array projection = array1Dstring.Projection(item => item == null ? -1 : item.Length);
        foreach (int item in projection)
        {
            Console.WriteLine(item);
        }


    }
}